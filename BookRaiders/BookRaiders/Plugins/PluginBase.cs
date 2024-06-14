using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRaiders.Plugins
{
    public abstract class PluginBase : IPlugin
    {
        private IPluginExecutionContext context { get; set; }
        private IOrganizationServiceFactory serviceFactory { get; set; }
        private IOrganizationService service { get; set; }
        private IOrganizationService serviceAdmin { get; set; }

        public void Execute(IServiceProvider serviceProvider)
        {
            this.context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            this.serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
            this.service = serviceFactory.CreateOrganizationService(context.UserId);
            this.serviceAdmin = serviceFactory.CreateOrganizationService(null);

            ExecutePlugin(this.context, this.serviceFactory, this.service, this.serviceAdmin);
        }

        protected virtual void ExecutePlugin(IPluginExecutionContext context, IOrganizationServiceFactory serviceFactory, IOrganizationService service, IOrganizationService serviceAdmin)
        {

        }

        internal T GetTarget<T>(IPluginExecutionContext context) where T : Entity
        {
            var target = context.InputParameters["Target"] as Entity;

            return target.ToEntity<T>();
        }

        internal T GetPreImage<T>(IPluginExecutionContext context, string preImageName = "PreImage") where T : Entity
        {
            var entity = context.PreEntityImages[preImageName] as Entity;
            return entity.ToEntity<T>();
        }

        internal T GetPostImage<T>(IPluginExecutionContext context, string postImageName = "PostImage") where T : Entity
        {
            var image = context.PostEntityImages[postImageName] as Entity;

            return image.ToEntity<T>();
        }
    }
}
