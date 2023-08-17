using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EpicorRestAPI;
namespace RestExample
{
    class Program
    {
        static void Main(string[] args)
        {

            EpicorRest.AppPoolHost = "tldr.sever.com";
            EpicorRest.AppPoolInstance = "EpicorInstance";
            EpicorRest.UserName = "username";
            EpicorRest.Password = "password";
            EpicorRest.Company = "EPIC01";
            EpicorRest.APIKey = "APIkeyHere";  //API key created in API Key Maintenance in Epicor
            EpicorRest.APIVersion = EpicorRestVersion.V2; //Defaults to V2
            EpicorRest.License = EpicorLicenseType.Default;
            EpicorRest.IgnoreCertErrors = true;
            EpicorRest.Timeout = 5000;
            EpicorRest.MaxRequestLogLength = 1;

            if (EpicorRest.CreateBearerToken())
            {
                var x = EpicorRest.BaqGet("zCustomer01");
            }

        }
    }
}
