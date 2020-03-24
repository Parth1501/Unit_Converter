using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebService
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string CurrencyConverter(String from,String to,String value)
        {
            String result="";
            if(from=="Rupee" && to=="Dollar")
            {
                result = Convert.ToString((Convert.ToDouble(value)* 0.013));
            }
            else if (from == "Rupee" && to == "Euro")
            {
                result = Convert.ToString((Convert.ToDouble(value) * 0.012));
            }
            else if (from == "Dollar" && to == "Euro")
            {
                result = Convert.ToString((Convert.ToDouble(value) * 0.93));
            }
            else if (from == "Dollar" && to == "Rupee")
            {
                result = Convert.ToString((Convert.ToDouble(value) * 75.62));
            }
            else if (from == "Euro" && to == "Dollar")
            {
                result = Convert.ToString((Convert.ToDouble(value) * 1.08));
            }
            else
                result = Convert.ToString((Convert.ToDouble(value) * 81.40));
            return result;
        }
        [WebMethod]
        public string LengthConverter(String from, String to, String value)
        {
            String result = "";
            if (from == "Meter" && to == "Yard")
            {
                result = Convert.ToString((Convert.ToDouble(value) * 1.09361));
            }
            else if (from == "Meter" && to == "Foot")
            {
                result = Convert.ToString((Convert.ToDouble(value) * 3.28084));
            }
            else if (from == "Yard" && to == "Meter")
            {
                result = Convert.ToString((Convert.ToDouble(value) * 0.9144));
            }
            else if (from == "Yard" && to == "Foot")
            {
                result = Convert.ToString((Convert.ToDouble(value) * 3));
            }
            else if (from == "Foot" && to == "Meter")
            {
                result = Convert.ToString((Convert.ToDouble(value) * 0.3048));
            }
            else
                result = Convert.ToString((Convert.ToDouble(value) * 0.333333));
            return result;
        }
    }
}
