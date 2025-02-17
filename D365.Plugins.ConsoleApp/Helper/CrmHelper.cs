using D365.Plugins.Entities;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D365.Plugins.ConsoleApp.Helper
{
    public static class CrmHelper
    {
        public static void CreateAccount(IOrganizationService service)
        {
            Account account = new Account
            {
                Name = "Early Bound Account",
                IndustryCode = account_industrycode.Accounting,
                PreferredContactMethodCode = account_preferredcontactmethodcode.Email,
                FollowEmail=true
            };
            service.Create(account);
        }

        public static void UpdateAccount(IOrganizationService service)
        {
            Account account = new Account
            {
                Id = Guid.Parse("57fba79e-ffe9-ef11-be21-7c1e5228bfbc"),
                Name = $"Early Bound Account Update {DateTime.Now}"
            };
            service.Update(account);
        }

        public static void GetAllAccounts(IOrganizationService service)
        {
            OrgContext orgContext = new OrgContext(service);
            List<Account> accounts = orgContext.AccountSet.ToList();
            foreach (Account account in accounts) 
            {
                Console.WriteLine(account.Name);
            } 
        }

        public static void GetFilteredAccounds(IOrganizationService service)
        {
            OrgContext orgContext = new OrgContext(service);
            var accounts = orgContext.AccountSet.Where(s =>  s.Name.Contains("Early Bound")).ToList();
            foreach (var account in accounts) 
            {
               Console.WriteLine($"Name : {account.Name} , ID : {account.Id}");
            }
        }
    }
}
