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

namespace BookRaiders.Plugins.Usuario
{
    public class PreValidation : PluginBase
    {
        protected override void ExecutePlugin(IPluginExecutionContext context, IOrganizationServiceFactory serviceFactory, IOrganizationService service, IOrganizationService serviceAdmin)
        {
            if (context.MessageName.ToLower() == "create")
            {
                var usuario = GetTarget<bkrs_usuario>(context);
                var usuarioBO = new UsuarioBO(service, serviceAdmin); 

                usuarioBO.VerificarCpfExistente(usuario);
            }
            if (context.MessageName.ToLower() == "update")
            {
                var usuario = GetTarget<bkrs_usuario>(context);
                var usuarioImg = GetPreImage<bkrs_usuario>(context);

                var usuarioBO = new UsuarioBO(service, serviceAdmin);

                usuarioBO.VerificarCpfExistente(usuario);
            }
        } 
    }
}