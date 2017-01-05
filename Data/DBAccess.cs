using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;

namespace Data
{
    public interface IDBAccess
    {
        Loan getLoan( int loan_id );
        Application getApplication(int application_id);
        List<Application> getApplicationList();
        Applicant getApplicant(int applicant_id);
        User getUser(int usr_id);
        CreditScoreCompany getCreditScoreCompany(int credit_score_company_id);

        int setLoan( Loan loan );
        int setApplication(Application application);
        int setApplicant(Applicant applicant);
        int setUser(User user);
        int setCreditScoireCompany(CreditScoreCompany val);

    }

    public class DBAccessSQLite : IDBAccess
    {
        SQLiteConnection dbConnection;

        static string CONNECTION_STRING = "Data Source=c:\\LoanEngineService\\loanapound.db;Version=3;";

        public DBAccessSQLite()
        {
            dbConnection = new SQLiteConnection( CONNECTION_STRING );
        }

        public Loan getLoan(int loan_id) { return new Loan();  }

        public Application getApplication( int application_id )
        {
            string sql = "select * from Application where applicatioon_id=" + application_id;

            dbConnection.Open();
            SQLiteCommand command = new SQLiteCommand(sql, dbConnection);

            SQLiteDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                Application application = new Application(Int32.Parse(reader["id"].ToString()),
                                        Int32.Parse(reader["loan_id"].ToString()),
                                        Int32.Parse(reader["applicant_id"].ToString()),
                                        Int32.Parse(reader["score"].ToString()),
                                        Int32.Parse(reader["credit_score_company_id"].ToString()),
                                        Int32.Parse(reader["underwritter_decision"].ToString()),
                                        Convert.ToDouble(reader["amount"].ToString()));
                dbConnection.Close();
                return application;
            }
            else
            {
                dbConnection.Close();
                return new Application(); //FIXME
            }
            

        }

        public List<Application> getApplicationList()
        {
            string sql = "select * from application";

            dbConnection.Open();
            SQLiteCommand command = new SQLiteCommand(sql, dbConnection);

            SQLiteDataReader reader = command.ExecuteReader();

            List<Application>  applicationList = new List<Application>();

            while (reader.Read())
            {
                Application application = new Application(Int32.Parse(reader["id"].ToString()),
                                        Int32.Parse(reader["loan_id"].ToString()),
                                        Int32.Parse(reader["applicant_id"].ToString()),
                                        Int32.Parse(reader["score"].ToString()),
                                        Int32.Parse(reader["credit_score_company_id"].ToString()),
                                        Int32.Parse(reader["underwritter_decision"].ToString()),
                                        Convert.ToDouble(reader["amount"].ToString()));

                applicationList.Add( application );
            }
            dbConnection.Close();
            return applicationList;
        }

        public Applicant getApplicant(int applicant_id) { return new Applicant(); }
        public User getUser(int usr_id) { return new User(); }
        public CreditScoreCompany getCreditScoreCompany(int credit_score_company_id) { return new CreditScoreCompany(); }

        public int setLoan(Loan loan) { return 0; }

        public int setApplication(Application application)
        {
            string sql = "select * from application where id="+application.getId().ToString();
            dbConnection.Open();
            SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();

            if (reader.Read()) //FIXME
                sql = String.Format("update application set score={0}, credit_score_company_id={1}, underwritter_decision={2}, amount={3}  where id={4}", 
                                    application.getScore(),
                                    application.getCreditScoreCompanyId(),
                                    application.getUnderwritterDecision(),
                                    application.getAmount(),
                                    application.getId() );
            else
            {
                sql = String.Format("insert into application values( {0}, {1}, {2}, {4}, {5} )",
                                    application.getLoanId(),
                                    application.getApplicantId(),
                                    application.getScore(),
                                    application.getCreditScoreCompanyId(),
                                    application.getUnderwritterDecision(),
                                    application.getAmount() );
            }
            dbConnection.Close();

            dbConnection.Open();
            command = new SQLiteCommand(sql, dbConnection);
            command.ExecuteNonQuery();
            dbConnection.Close();
            return 0;
        }
        public int setApplicant(Applicant applicant) { return 0; }
        public int setUser(User user) { return 0; }
        public int setCreditScoireCompany(CreditScoreCompany val) { return 0; }

    }

    public class DBAccessFactory
    {
        public DBAccessFactory() { }

        static public IDBAccess getDBAccess()
        {
            return new DBAccessSQLite();
        }
    }
}


