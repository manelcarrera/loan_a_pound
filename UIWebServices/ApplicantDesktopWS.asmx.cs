using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace UIWebServices
{
    /// <summary>
    /// Descripción breve de ApplicantDesktopWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    [System.Web.Script.Services.ScriptService]
    public class ApplicantDesktopWS : System.Web.Services.WebService
    {
        Logic.ApplicationHandler applicationHandler = new Logic.ApplicationHandler();

        [WebMethod]
        public Data.Application getApplication( int application_id )
        {
            return applicationHandler.getApplication(application_id);
        }

        [WebMethod]
        public void setApplication(Data.Application application )
        {
            applicationHandler.setApplication(application);
        }
    }
}
