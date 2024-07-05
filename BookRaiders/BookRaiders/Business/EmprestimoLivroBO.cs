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
    public class EmprestimoLivroBO : BusinessBase
    {
        public EmprestimoLivroBO(IOrganizationService service, IOrganizationService serviceAdmin) : base(service, serviceAdmin)
        {
        }

        public void AlterarLivroIndisponivel(bkrs_emprestimolivro emprestimoLivro)
        {
            if (emprestimoLivro.StatusCode == bkrs_emprestimolivro_StatusCode.Aceito)
            {
                bkrs_livro atualizarLivro = new bkrs_livro();
                atualizarLivro.Id = emprestimoLivro.bkrs_livro.Id;
                atualizarLivro.StateCode = bkrs_livro_statecode.Inactive;
                atualizarLivro.StatusCode = bkrs_livro_StatusCode.Indisponvel;

                service.Update(atualizarLivro);
            }
        }

        public void CancelarOutrosEmprestimos(bkrs_emprestimolivro emprestimoLivro)
        {
            if (emprestimoLivro.StatusCode == bkrs_emprestimolivro_StatusCode.Aceito)
            {
                List<bkrs_emprestimolivro> emprestimosPendentes = ObterEmprestimosPendentes(emprestimoLivro.bkrs_livro.Id);

                if (emprestimosPendentes != null)
                {
                    foreach (var emprestimo in emprestimosPendentes)
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

        public void AlterarLivroDisponivel(bkrs_emprestimolivro emprestimoLivro)
        {
            if (emprestimoLivro.StatusCode == bkrs_emprestimolivro_StatusCode.Concluido)
            {
                bkrs_livro atualizarLivro = new bkrs_livro();
                atualizarLivro.Id = emprestimoLivro.bkrs_livro.Id;
                atualizarLivro.StateCode = bkrs_livro_statecode.Active;
                atualizarLivro.StatusCode = bkrs_livro_StatusCode.Disponvel;

                service.Update(atualizarLivro);
            }
        }

        public void LivroEntregueParaSolicitante(bkrs_emprestimolivro emprestimoLivro)
        {
            if (emprestimoLivro.bkrs_proprietariolivroentregue == true && emprestimoLivro.bkrs_solicitantelivrorecebido == true)
            {
                var atualizarEmprestimo = new bkrs_emprestimolivro();
                atualizarEmprestimo.Id = emprestimoLivro.Id;
                atualizarEmprestimo.StatusCode = bkrs_emprestimolivro_StatusCode.EmAndamento;

                service.Update(atualizarEmprestimo);
            }
        }

        public void LivroDevolvidoParaProprietario(bkrs_emprestimolivro emprestimoLivro)
        {
            if (emprestimoLivro.bkrs_proprietariolivrodevolvido == true && emprestimoLivro.bkrs_solicitantelivrodevolvido == true)
            {
                var atualizarEmprestimo = new bkrs_emprestimolivro();
                atualizarEmprestimo.Id = emprestimoLivro.Id;
                atualizarEmprestimo.StateCode = bkrs_emprestimolivro_statecode.Inactive;
                atualizarEmprestimo.StatusCode = bkrs_emprestimolivro_StatusCode.Concluido;

                service.Update(atualizarEmprestimo);
            }
        }

        public bkrs_emprestimolivro ObterEmprestimoLivro(Guid idEmprestimo)
        {
            if (idEmprestimo != null)
            {
                using (var orgContext = new CrmServiceContext(this.serviceAdmin))
                {
                    var emprestimo = orgContext.bkrs_emprestimolivroSet
                        .Where(w => w.Id == idEmprestimo)
                        .Select(s => new bkrs_emprestimolivro()
                        {
                            Id = s.Id,
                            StatusCode = s.StatusCode,
                            bkrs_livro = s.bkrs_livro,
                            bkrs_proprietariolivroentregue = s.bkrs_proprietariolivroentregue,
                            bkrs_solicitantelivrorecebido = s.bkrs_solicitantelivrorecebido,
                            bkrs_proprietariolivrodevolvido = s.bkrs_proprietariolivrodevolvido,
                            bkrs_solicitantelivrodevolvido = s.bkrs_solicitantelivrodevolvido,
                        }).FirstOrDefault();

                    return emprestimo;
                }
            }
            return null;
        }

        public List<bkrs_emprestimolivro> ObterEmprestimosPendentes(Guid idLivro)
        {
            if (idLivro != null)
            {
                using (var orgContext = new CrmServiceContext(this.serviceAdmin))
                {
                    var emprestimos = orgContext.bkrs_emprestimolivroSet
                        .Where(w => w.bkrs_livro.Id == idLivro && w.StatusCode == bkrs_emprestimolivro_StatusCode.Pendente)
                        .Select(s => new bkrs_emprestimolivro()
                        {
                            Id = s.Id,
                            StatusCode = s.StatusCode,
                            bkrs_livro = s.bkrs_livro
                        }).ToList();

                    return emprestimos;
                }
            }
            return null;
        }
    }
}
