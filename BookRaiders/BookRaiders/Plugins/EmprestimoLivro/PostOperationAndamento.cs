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

namespace BookRaiders.Plugins.EmprestimoLivro
{
    public class PostOperationAndamento : PluginBase
    {
        protected override void ExecutePlugin(IPluginExecutionContext context, IOrganizationServiceFactory serviceFactory, IOrganizationService service, IOrganizationService serviceAdmin, IPluginExecutionContext PluginExecutionContext)
        {
            if (context.MessageName.ToLower() == "update")
            {
                var emprestimoLivro = GetTarget<bkrs_emprestimolivro>();
                var emprestimoLivroBO = new EmprestimoLivroBO(service, serviceAdmin);

                emprestimoLivro = emprestimoLivroBO.ObterEmprestimoLivro(emprestimoLivro.Id);

                emprestimoLivroBO.LivroEntregueParaSolicitante(emprestimoLivro);
                emprestimoLivroBO.LivroDevolvidoParaProprietario(emprestimoLivro);
            }
        } 
    }
}