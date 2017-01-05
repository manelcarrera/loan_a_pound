using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Logic
{
    public class UserHandler
    {
        Data.IDBAccess db = Data.DBAccessFactory.getDBAccess();

        public Data.User getUser(int usr_id)
        {
            return db.getUser(usr_id);
        }

        public void setUser(Data.User user)
        {
            db.setUser(user);
        }
    }
}