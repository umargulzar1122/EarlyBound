using D365.Plugins.ConsoleApp.Helper;
using D365.Plugins.Entities;
using Microsoft.PowerPlatform.Dataverse.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D365.Plugins.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Dataverse"].ConnectionString;
            using (var service = new ServiceClient(connectionString))
            {
                if (service.IsReady)
                {
                    CrmHelper.CreateAccount(service);
                    CrmHelper.UpdateAccount(service);
                    CrmHelper.GetAllAccounts(service);
                    CrmHelper.GetFilteredAccounds(service);
                }
            }
        }
    }
}
