using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRaiders.Business
{
    public abstract class BusinessBase
    {
        protected IOrganizationService service { get; set; }
        protected IOrganizationService serviceAdmin { get; set; }
        protected ITracingService tracingService { get; set; }

        public BusinessBase(IOrganizationService service)
        {
            this.service = service;
        }
    }
}
