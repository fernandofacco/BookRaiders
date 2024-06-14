﻿#pragma warning disable CS1591
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookRaiders.Earlybound
{
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("bkrs_emprestimolivro")]
    public partial class bkrs_emprestimolivro : Microsoft.Xrm.Sdk.Entity
    {

        /// <summary>
        /// Available fields, a the time of codegen, for the bkrs_emprestimolivro entity
        /// </summary>
        public partial class Fields
        {
            public const string bkrs_codigo = "bkrs_codigo";
            public const string bkrs_datadevolucao = "bkrs_datadevolucao";
            public const string bkrs_datadevolucaoestimada = "bkrs_datadevolucaoestimada";
            public const string bkrs_emprestimolivro_livro_bkrs_livro = "bkrs_emprestimolivro_livro_bkrs_livro";
            public const string bkrs_emprestimolivroId = "bkrs_emprestimolivroid";
            public const string Id = "bkrs_emprestimolivroid";
            public const string bkrs_livro = "bkrs_livro";
            public const string bkrs_livroName = "bkrs_livroname";
            public const string bkrs_proprietariolivro = "bkrs_proprietariolivro";
            public const string bkrs_proprietariolivroName = "bkrs_proprietariolivroname";
            public const string bkrs_quantdiasemprestimo = "bkrs_quantdiasemprestimo";
            public const string bkrs_solicitantelivro = "bkrs_solicitantelivro";
            public const string bkrs_solicitantelivroName = "bkrs_solicitantelivroname";
            public const string CreatedBy = "createdby";
            public const string CreatedByName = "createdbyname";
            public const string CreatedByYomiName = "createdbyyominame";
            public const string CreatedOn = "createdon";
            public const string CreatedOnBehalfBy = "createdonbehalfby";
            public const string CreatedOnBehalfByName = "createdonbehalfbyname";
            public const string CreatedOnBehalfByYomiName = "createdonbehalfbyyominame";
            public const string ImportSequenceNumber = "importsequencenumber";
            public const string ModifiedBy = "modifiedby";
            public const string ModifiedByName = "modifiedbyname";
            public const string ModifiedByYomiName = "modifiedbyyominame";
            public const string ModifiedOn = "modifiedon";
            public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
            public const string ModifiedOnBehalfByName = "modifiedonbehalfbyname";
            public const string ModifiedOnBehalfByYomiName = "modifiedonbehalfbyyominame";
            public const string OrganizationId = "organizationid";
            public const string OrganizationIdName = "organizationidname";
            public const string OverriddenCreatedOn = "overriddencreatedon";
            public const string StateCode = "statecode";
            public const string statecodeName = "statecodename";
            public const string StatusCode = "statuscode";
            public const string statuscodeName = "statuscodename";
            public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
            public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
            public const string VersionNumber = "versionnumber";
        }

        [System.Diagnostics.DebuggerNonUserCode()]
        public bkrs_emprestimolivro(System.Guid id) :
                base(EntityLogicalName, id)
        {
        }

        [System.Diagnostics.DebuggerNonUserCode()]
        public bkrs_emprestimolivro(string keyName, object keyValue) :
                base(EntityLogicalName, keyName, keyValue)
        {
        }

        [System.Diagnostics.DebuggerNonUserCode()]
        public bkrs_emprestimolivro(Microsoft.Xrm.Sdk.KeyAttributeCollection keyAttributes) :
                base(EntityLogicalName, keyAttributes)
        {
        }

        /// <summary>
        /// Default Constructor.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        public bkrs_emprestimolivro() :
                base(EntityLogicalName)
        {
        }

        public const string PrimaryIdAttribute = "bkrs_emprestimolivroid";

        public const string PrimaryNameAttribute = "bkrs_codigo";

        public const string EntitySchemaName = "bkrs_emprestimolivro";

        public const string EntityLogicalName = "bkrs_emprestimolivro";

        public const string EntityLogicalCollectionName = "bkrs_emprestimolivros";

        public const string EntitySetName = "bkrs_emprestimolivros";

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bkrs_codigo")]
        public string bkrs_codigo
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("bkrs_codigo");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.SetAttributeValue("bkrs_codigo", value);
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bkrs_datadevolucao")]
        public System.Nullable<System.DateTime> bkrs_datadevolucao
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("bkrs_datadevolucao");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.SetAttributeValue("bkrs_datadevolucao", value);
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bkrs_datadevolucaoestimada")]
        public System.Nullable<System.DateTime> bkrs_datadevolucaoestimada
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("bkrs_datadevolucaoestimada");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.SetAttributeValue("bkrs_datadevolucaoestimada", value);
            }
        }

        /// <summary>
        /// Identificador exclusivo de instâncias de entidade
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bkrs_emprestimolivroid")]
        public System.Nullable<System.Guid> bkrs_emprestimolivroId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("bkrs_emprestimolivroid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.SetAttributeValue("bkrs_emprestimolivroid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bkrs_emprestimolivroid")]
        public override System.Guid Id
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return base.Id;
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.bkrs_emprestimolivroId = value;
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bkrs_livro")]
        public Microsoft.Xrm.Sdk.EntityReference bkrs_livro
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("bkrs_livro");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.SetAttributeValue("bkrs_livro", value);
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bkrs_livroname")]
        public string bkrs_livroName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                if (this.FormattedValues.Contains("bkrs_livro"))
                {
                    return this.FormattedValues["bkrs_livro"];
                }
                else
                {
                    return default(string);
                }
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bkrs_proprietariolivro")]
        public Microsoft.Xrm.Sdk.EntityReference bkrs_proprietariolivro
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("bkrs_proprietariolivro");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.SetAttributeValue("bkrs_proprietariolivro", value);
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bkrs_proprietariolivroname")]
        public string bkrs_proprietariolivroName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                if (this.FormattedValues.Contains("bkrs_proprietariolivro"))
                {
                    return this.FormattedValues["bkrs_proprietariolivro"];
                }
                else
                {
                    return default(string);
                }
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bkrs_quantdiasemprestimo")]
        public System.Nullable<int> bkrs_quantdiasemprestimo
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("bkrs_quantdiasemprestimo");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.SetAttributeValue("bkrs_quantdiasemprestimo", value);
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bkrs_solicitantelivro")]
        public Microsoft.Xrm.Sdk.EntityReference bkrs_solicitantelivro
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("bkrs_solicitantelivro");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.SetAttributeValue("bkrs_solicitantelivro", value);
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bkrs_solicitantelivroname")]
        public string bkrs_solicitantelivroName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                if (this.FormattedValues.Contains("bkrs_solicitantelivro"))
                {
                    return this.FormattedValues["bkrs_solicitantelivro"];
                }
                else
                {
                    return default(string);
                }
            }
        }

        /// <summary>
        /// Identificador exclusivo do usuário que criou o registro.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdbyname")]
        public string CreatedByName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                if (this.FormattedValues.Contains("createdby"))
                {
                    return this.FormattedValues["createdby"];
                }
                else
                {
                    return default(string);
                }
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdbyyominame")]
        public string CreatedByYomiName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                if (this.FormattedValues.Contains("createdby"))
                {
                    return this.FormattedValues["createdby"];
                }
                else
                {
                    return default(string);
                }
            }
        }

        /// <summary>
        /// Data e hora de criação do registro.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
            }
        }

        /// <summary>
        /// Identificador exclusivo do usuário delegado que criou o registro.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.SetAttributeValue("createdonbehalfby", value);
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfbyname")]
        public string CreatedOnBehalfByName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                if (this.FormattedValues.Contains("createdonbehalfby"))
                {
                    return this.FormattedValues["createdonbehalfby"];
                }
                else
                {
                    return default(string);
                }
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfbyyominame")]
        public string CreatedOnBehalfByYomiName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                if (this.FormattedValues.Contains("createdonbehalfby"))
                {
                    return this.FormattedValues["createdonbehalfby"];
                }
                else
                {
                    return default(string);
                }
            }
        }

        /// <summary>
        /// Número de sequência da importação que criou este registro.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
        public System.Nullable<int> ImportSequenceNumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.SetAttributeValue("importsequencenumber", value);
            }
        }

        /// <summary>
        /// Identificador exclusivo do usuário que modificou o registro.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedbyname")]
        public string ModifiedByName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                if (this.FormattedValues.Contains("modifiedby"))
                {
                    return this.FormattedValues["modifiedby"];
                }
                else
                {
                    return default(string);
                }
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedbyyominame")]
        public string ModifiedByYomiName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                if (this.FormattedValues.Contains("modifiedby"))
                {
                    return this.FormattedValues["modifiedby"];
                }
                else
                {
                    return default(string);
                }
            }
        }

        /// <summary>
        /// Data e hora de modificação do registro.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
            }
        }

        /// <summary>
        /// Identificador exclusivo do usuário delegado que modificou o registro.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.SetAttributeValue("modifiedonbehalfby", value);
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfbyname")]
        public string ModifiedOnBehalfByName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                if (this.FormattedValues.Contains("modifiedonbehalfby"))
                {
                    return this.FormattedValues["modifiedonbehalfby"];
                }
                else
                {
                    return default(string);
                }
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfbyyominame")]
        public string ModifiedOnBehalfByYomiName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                if (this.FormattedValues.Contains("modifiedonbehalfby"))
                {
                    return this.FormattedValues["modifiedonbehalfby"];
                }
                else
                {
                    return default(string);
                }
            }
        }

        /// <summary>
        /// Identificador exclusivo da organização
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationidname")]
        public string OrganizationIdName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                if (this.FormattedValues.Contains("organizationid"))
                {
                    return this.FormattedValues["organizationid"];
                }
                else
                {
                    return default(string);
                }
            }
        }

        /// <summary>
        /// Data e hora da migração do registro.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
        public System.Nullable<System.DateTime> OverriddenCreatedOn
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.SetAttributeValue("overriddencreatedon", value);
            }
        }

        /// <summary>
        /// Status de Empréstimo de Livro
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public virtual bkrs_emprestimolivro_statecode? StateCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((bkrs_emprestimolivro_statecode?)(EntityOptionSetEnum.GetEnum(this, "statecode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.SetAttributeValue("statecode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecodename")]
        public string statecodeName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                if (this.FormattedValues.Contains("statecode"))
                {
                    return this.FormattedValues["statecode"];
                }
                else
                {
                    return default(string);
                }
            }
        }

        /// <summary>
        /// Razão do status de Empréstimo de Livro
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
        public virtual bkrs_emprestimolivro_StatusCode? StatusCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((bkrs_emprestimolivro_StatusCode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.SetAttributeValue("statuscode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscodename")]
        public string statuscodeName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                if (this.FormattedValues.Contains("statuscode"))
                {
                    return this.FormattedValues["statuscode"];
                }
                else
                {
                    return default(string);
                }
            }
        }

        /// <summary>
        /// Somente para uso interno.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
        public System.Nullable<int> TimeZoneRuleVersionNumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.SetAttributeValue("timezoneruleversionnumber", value);
            }
        }

        /// <summary>
        /// Código de fuso horário em uso quando o registro foi criado.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
        public System.Nullable<int> UTCConversionTimeZoneCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.SetAttributeValue("utcconversiontimezonecode", value);
            }
        }

        /// <summary>
        /// Número da Versão
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
            }
        }

        /// <summary>
        /// N:1 bkrs_emprestimolivro_livro_bkrs_livro
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bkrs_livro")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("bkrs_emprestimolivro_livro_bkrs_livro")]
        public BookRaiders.Earlybound.bkrs_livro bkrs_emprestimolivro_livro_bkrs_livro
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<BookRaiders.Earlybound.bkrs_livro>("bkrs_emprestimolivro_livro_bkrs_livro", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.SetRelatedEntity<BookRaiders.Earlybound.bkrs_livro>("bkrs_emprestimolivro_livro_bkrs_livro", null, value);
            }
        }

        /// <summary>
        /// Constructor for populating via LINQ queries given a LINQ anonymous type
        /// <param name="anonymousType">LINQ anonymous type.</param>
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        public bkrs_emprestimolivro(object anonymousType) :
                this()
        {
            foreach (var p in anonymousType.GetType().GetProperties())
            {
                var value = p.GetValue(anonymousType, null);
                var name = p.Name.ToLower();

                if (name.EndsWith("enum") && value.GetType().BaseType == typeof(System.Enum))
                {
                    value = new Microsoft.Xrm.Sdk.OptionSetValue((int)value);
                    name = name.Remove(name.Length - "enum".Length);
                }

                switch (name)
                {
                    case "id":
                        base.Id = (System.Guid)value;
                        Attributes["bkrs_emprestimolivroid"] = base.Id;
                        break;
                    case "bkrs_emprestimolivroid":
                        var id = (System.Nullable<System.Guid>)value;
                        if (id == null) { continue; }
                        base.Id = id.Value;
                        Attributes[name] = base.Id;
                        break;
                    case "formattedvalues":
                        // Add Support for FormattedValues
                        FormattedValues.AddRange((Microsoft.Xrm.Sdk.FormattedValueCollection)value);
                        break;
                    default:
                        Attributes[name] = value;
                        break;
                }
            }
        }
    }
}
#pragma warning restore CS1591