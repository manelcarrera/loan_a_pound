using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;


using System.IO;

using System.Data.SQLite;

using System.Timers;

namespace LoanEngineService
{
    public partial class LoanEngineService : ServiceBase
    {
        Timer timer = new Timer();

        static refweb1.WebService1 ws1 = new refweb1.WebService1();
        static refweb2.WebService2 ws2 = new refweb2.WebService2();

        static string LOG_FILE = "c:\\LoanEngineService\\logging.txt";

        public LoanEngineService()
        {
            InitializeComponent();
        }

        private void OnElapsedTime(object source, ElapsedEventArgs e) //PollDB
        {
            List<Data.Application> applicationList = Data.DBAccessFactory.getDBAccess().getApplicationList();

            foreach (var application in applicationList)
            {
                if (application.getScore() == 0)
                {
                    File.AppendAllText( LOG_FILE, "Loan applications to score: Yes\n" );

                    int score = 0;
                    if (application.getAmount() < 100*1000) //CRITERIA
                        score = ws1.getScore();
                    else
                        score = ws2.getScore();
                    application.setScore(score);

                    Data.DBAccessFactory.getDBAccess().setApplication(application);
                }
                else
                {
                    File.AppendAllText(LOG_FILE, "Loan applications to score: No\n");
                }
            }
        }

        protected override void OnStart(string[] args)
        {
            timer.Elapsed += new ElapsedEventHandler(OnElapsedTime);
            timer.Interval = 5*1000; //miliseconds
            timer.Enabled = true;
        }

        protected override void OnStop()
        {
            timer.Enabled = false;
        }
    }
}
