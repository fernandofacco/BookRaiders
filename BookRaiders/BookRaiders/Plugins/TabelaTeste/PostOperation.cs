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

namespace BookRaiders.Plugins.TabelaTeste
{
    public class PostOperation : PluginBase
    {
        protected override void ExecutePlugin(IPluginExecutionContext context, IOrganizationServiceFactory serviceFactory, IOrganizationService service)
        {
            if (context.MessageName.ToLower() == "create")
            {
                var tabelaTeste = GetTarget<BKRZ_TabElatesTe>(context);
                var tabelaTesteBO = new TabelaTesteBO(service);

                tabelaTesteBO.AlterarCpf(tabelaTeste);
            }
        } 
    }
}