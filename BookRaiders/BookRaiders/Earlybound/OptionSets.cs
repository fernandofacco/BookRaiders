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

    /// <summary>
    /// Status de Usuário
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    public enum bkrs_usuario_statecode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Ativo(a)", 0)]
        Active = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Inativo(a)", 1)]
        Inactive = 1,
    }

    /// <summary>
    /// Razão do status de Usuário
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    public enum bkrs_usuario_StatusCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Ativo(a)", 0)]
        Ativoa = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Inativo(a)", 1)]
        Inativoa = 2,
    }

    /// <summary>
    /// Status de Livro
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    public enum bkrs_livro_statecode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Ativo(a)", 0)]
        Active = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Inativo(a)", 1)]
        Inactive = 1,
    }

    /// <summary>
    /// Razão do status de Livro
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    public enum bkrs_livro_StatusCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Disponível", 0)]
        DisponVel = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Indisponível", 1)]
        IndisponVel = 2,
    }

    /// <summary>
    /// Status de Empréstimo de Livro
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    public enum bkrs_emprestimolivro_statecode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Ativo(a)", 0)]
        Active = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Inativo(a)", 1)]
        Inactive = 1,
    }

    /// <summary>
    /// Razão do status de Empréstimo de Livro
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    public enum bkrs_emprestimolivro_StatusCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Aceito", 2)]
        Aceito = 709060003,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Atrasado", 7)]
        Atrasado = 709060008,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Cancelado", 6)]
        Cancelado = 709060007,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Concluído", 5)]
        ConcluDo = 709060006,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Em Andamento", 4)]
        EmAndamento = 709060005,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Pendente", 1)]
        Pendente = 709060002,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Rascunho", 0)]
        Rascunho = 709060001,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Recusado", 3)]
        Recusado = 709060004,
    }
}
