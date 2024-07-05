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
    public class VerificarCredenciais : PluginBase
    {
        protected override void ExecutePlugin(IPluginExecutionContext context, IOrganizationServiceFactory serviceFactory, IOrganizationService service, IOrganizationService serviceAdmin, IPluginExecutionContext PluginExecutionContext)
        {
            string parametroCpf = (string)context.InputParameters["ParametroCpf"];
            string parametroEmail = (string)context.InputParameters["ParametroEmail"];
            string stringParametroIdUsuario = (string)context.InputParameters["ParametroIdUsuario"];
            Guid parametroIdUsuario = new Guid();
            
            if (stringParametroIdUsuario != "")
            {
                parametroIdUsuario = new Guid((string)context.InputParameters["ParametroIdUsuario"]);
            }

            var usuarioBO = new UsuarioBO(service, serviceAdmin);

            bool cpfExistente = false;
            bool emailExistente = false;

            if (parametroCpf != "" && parametroCpf != null)
            {
                cpfExistente = usuarioBO.VerificarCpfExistente(parametroCpf, parametroIdUsuario);
            }

            if (parametroEmail != "" && parametroEmail != null)
            {
                emailExistente = usuarioBO.VerificarEmailExistente(parametroEmail, parametroIdUsuario);
            }

            context.OutputParameters["RetornoCpf"] = cpfExistente;
            context.OutputParameters["RetornoEmail"] = emailExistente;
        } 
    }
}