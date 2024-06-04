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
    public class TabelaTesteBO : BusinessBase
    {
        public TabelaTesteBO(IOrganizationService service) : base(service)
        {
        }

        public void AlterarCpf(BKRZ_TabElatesTe tabelaTeste)
        {
            BKRZ_TabElatesTe atualizarTabelaTeste = new BKRZ_TabElatesTe();
            atualizarTabelaTeste.Id = tabelaTeste.Id;
            // atualizarTabelaTeste.BKRZ_CPF = "TESTE";
            
            this.service.Update(atualizarTabelaTeste);
        }
    }
}
