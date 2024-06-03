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
    public class TabelaTesteBO
    {
        private IOrganizationService service;
        private IOrganizationService serviceAdmin;
        private ITracingService tracingService;


        public TabelaTesteBO(IOrganizationService service)
        {
            this.service = service;
        }

        public void AlterarCpf(BKRZ_TabElatesTe tabelaTeste)
        {
            BKRZ_TabElatesTe atualizarTabelaTeste = new BKRZ_TabElatesTe();
            atualizarTabelaTeste.Id = tabelaTeste.Id;
            atualizarTabelaTeste.BKRZ_CPF = "TESTE";

            service.Update(atualizarTabelaTeste);
        }
    }
}
