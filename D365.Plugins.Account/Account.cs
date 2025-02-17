using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace D365.Plugins.Account
{
    public class Account : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            var context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            Entity target = ((Entity)context.InputParameters["Target"]);
            Entities.Account account = target.ToEntity<Entities.Account>();
            account.Name = $"{account.Name} Created with Early Bound";
        }
    }
}
