using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookRaiders.Earlybound;
using System.Runtime.Remoting.Contexts;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using BookRaiders.Business;
using System.Activities.Presentation.Validation;

namespace BookRaiders.Plugins.Livro
{
    public class PreOperation : PluginBase
    {
        protected override void ExecutePlugin(IPluginExecutionContext context, IOrganizationServiceFactory serviceFactory, IOrganizationService service, IOrganizationService serviceAdmin, IPluginExecutionContext PluginExecutionContext)
        {
            if (context.MessageName.ToLower() == "delete")
            {
                var livro = GetPreImage<bkrs_livro>();
                var livroBO = new LivroBO(service, serviceAdmin);

                livroBO.CancelarEmprestimos(livro);
            }
        } 
    }
}