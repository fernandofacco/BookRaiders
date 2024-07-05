using BookRaiders.Business;
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

        public bool VerificarCpfExistente(string cpf, Guid idUsuario)
        {
            List<bkrs_usuario> listaUsuarios = ObterUsuariosCpfIguais(cpf, idUsuario);

            if (listaUsuarios.Count > 0)
            {
                return true;
            }
            return false;
        }

        public List<bkrs_usuario> ObterUsuariosCpfIguais(string cpf, Guid idUsuario)
        {
            List<bkrs_usuario> listaUsuarios = new List<bkrs_usuario>();

            if (cpf != null)
            {
                using (var orgContext = new CrmServiceContext(this.serviceAdmin))
                {
                    listaUsuarios = orgContext.bkrs_usuarioSet
                        .Where(w => w.bkrs_cpf.Equals(cpf) && w.Id != idUsuario)
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

        public bool VerificarEmailExistente(string email, Guid idUsuario)
        {
            List<bkrs_usuario> listaUsuarios = ObterUsuariosEmailIguais(email, idUsuario);

            if (listaUsuarios.Count > 0)
            {
                return true;
            }
            return false;
        }

        public List<bkrs_usuario> ObterUsuariosEmailIguais(string email, Guid idUsuario)
        {
            List<bkrs_usuario> listaUsuarios = new List<bkrs_usuario>();

            if (email != null)
            {
                using (var orgContext = new CrmServiceContext(this.serviceAdmin))
                {
                    listaUsuarios = orgContext.bkrs_usuarioSet
                        .Where(w => w.bkrs_email.Equals(email) && w.Id != idUsuario)
                        .Select(s => new bkrs_usuario()
                        {
                            Id = s.Id,
                            bkrs_email = s.bkrs_email,
                        }).ToList();

                    return listaUsuarios;
                }
            }

            return listaUsuarios;
        }
    }
}