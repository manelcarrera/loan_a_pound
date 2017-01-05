using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ScoreWebServices
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        //protected virtual int getScore()
        public int getScore()
        {
            return 100;
        }
    }

    /*public class WebServiceImpl1 : WebService1
    {

        [WebMethod]
        public int getScore()
        {
            return 101;
        }
    }
    public class WebServiceImpl2 : WebService1
    {

        [WebMethod]
        public int getScore()
        {
            return 102;
        }
    }
    public class WebServiceImpl3 : WebService1
    {

        [WebMethod]
        public int getScore()
        {
            return 103;
        }
    }*/

}
