using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace UIWebServices
{
    /// <summary>
    /// Descripción breve de AdminDesktopWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    [System.Web.Script.Services.ScriptService]
    public class AdminDesktopWS : System.Web.Services.WebService
    {
        Logic.LoanHandler loanHandler = new Logic.LoanHandler();
        Logic.UserHandler userHandler = new Logic.UserHandler();

        [WebMethod]
        public Data.Loan getLoan( int loan_id )
        {
            return loanHandler.getLoan( loan_id );
        }

        [WebMethod]
        public void setLoan(Data.Loan loan)
        {
            loanHandler.setLoan(loan);
        }

        [WebMethod]
        public Data.User getUser(int usr_id)
        {
            return userHandler.getUser(usr_id);
        }

        [WebMethod]
        public void setUser(Data.User user)
        {
            userHandler.setUser(user);
        }

    }
}
