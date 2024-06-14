using BookRaiders.Earlybound;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;

namespace BookRaiders.Business
{
    public class UsuarioBO : BusinessBase
    {
        public UsuarioBO(IOrganizationService service, IOrganizationService serviceAdmin) : base(service, serviceAdmin)
        {
        }

        public void VerificarCpfExistente(bkrs_usuario usuario)
        {
            List<bkrs_usuario> listaUsuarios = ObterUsuariosCpfIguais(usuario);

            if (listaUsuarios.Count > 0)
            {
                throw new InvalidPluginExecutionException("Erro ao cadastrar usuário: CPF já registrado.");
            }
        }

        public List<bkrs_usuario> ObterUsuariosCpfIguais(bkrs_usuario usuario)
        {
            List<bkrs_usuario> listaUsuarios = new List<bkrs_usuario>();

            if (usuario != null)
            {
                using (var orgContext = new CrmServiceContext(this.serviceAdmin))
                {
                    listaUsuarios = orgContext.bkrs_usuarioSet
                        .Where(w => w.bkrs_cpf.Equals(usuario.bkrs_cpf) && w.Id != usuario.Id)
                        .Select(s => new bkrs_usuario()
                        {
                            Id = s.Id,
                            bkrs_cpf = s.bkrs_cpf,
                        }).ToList();

                    return listaUsuarios;
                }
            }

            return listaUsuarios;
        }
    }
}
