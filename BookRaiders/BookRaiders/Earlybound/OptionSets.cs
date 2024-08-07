﻿using System;
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
        Disponvel = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Indisponível", 1)]
        Indisponvel = 2,
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
        Aceito = 709060009,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Atrasado", 4)]
        Atrasado = 709060011,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Cancelado", 6)]
        Cancelado = 709060013,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Concluído", 5)]
        Concluido = 709060012,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Em Andamento", 3)]
        EmAndamento = 709060010,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Pendente", 0)]
        Pendente = 709060001,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Recusado", 1)]
        Recusado = 709060008,
    }
}
