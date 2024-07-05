using BookRaiders.Earlybound;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;

namespace BookRaiders.Business
{
    public class LivroBO : BusinessBase
    {
        public LivroBO(IOrganizationService service, IOrganizationService serviceAdmin) : base(service, serviceAdmin)
        {
        }

        public void CancelarEmprestimos(bkrs_livro livro)
        {
            var emprestimoLivroBO = new EmprestimoLivroBO(service, serviceAdmin);
            List<bkrs_emprestimolivro> emprestimosLivro = emprestimoLivroBO.ObterEmprestimosPendentes(livro.Id);

            foreach (var emprestimo in emprestimosLivro)
            {
                var atualizarEmprestimo = new bkrs_emprestimolivro();
                atualizarEmprestimo.Id = emprestimo.Id;
                atualizarEmprestimo.StateCode = bkrs_emprestimolivro_statecode.Inactive;
                atualizarEmprestimo.StatusCode = bkrs_emprestimolivro_StatusCode.Cancelado;

                service.Update(atualizarEmprestimo);
            }
        }
    }
}
