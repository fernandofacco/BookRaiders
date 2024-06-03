using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRaiders.Earlybound
{
    /// <summary>
    /// Status de TabelaTeste
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    public enum BKRZ_TabElatesTe_StateCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Ativo(a)", 0)]
        Active = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Inativo(a)", 1)]
        Inactive = 1,
    }

    /// <summary>
    /// Razão do status de TabelaTeste
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    public enum BKRZ_TabElatesTe_StatusCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Ativo(a)", 0)]
        Ativoa = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Inativo(a)", 1)]
        Inativoa = 2,
    }
}
