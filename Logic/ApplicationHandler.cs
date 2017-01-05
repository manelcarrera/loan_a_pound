using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Logic
{
    public class ApplicationHandler
    {
        Data.IDBAccess db = Data.DBAccessFactory.getDBAccess();

        public Data.Application getApplication(int application_id )
        {
            return db.getApplication(application_id);
        }

        public List<Data.Application> getApplicationList()
        {
            return db.getApplicationList();
        }

        public void setApplication(Data.Application application)
        {
            db.setApplication(application);
        }
    }
}