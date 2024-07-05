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
        private IPluginExecutionContext PluginExecutionContext { get; set; }

        public void Execute(IServiceProvider serviceProvider)
        {
            this.context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            this.serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
            this.service = serviceFactory.CreateOrganizationService(context.UserId);
            this.serviceAdmin = serviceFactory.CreateOrganizationService(null);
            this.PluginExecutionContext = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));

            ExecutePlugin(this.context, this.serviceFactory, this.service, this.serviceAdmin, this.PluginExecutionContext);
        }

        protected virtual void ExecutePlugin(IPluginExecutionContext context, IOrganizationServiceFactory serviceFactory, IOrganizationService service, IOrganizationService serviceAdmin, IPluginExecutionContext PluginExecutionContext)
        {

        }

        internal T GetTarget<T>() where T : Entity
        {
            var target = PluginExecutionContext.InputParameters["Target"] as Entity;

            return target.ToEntity<T>();
        }

        internal T GetPreImage<T>(string preImageName = "PreImage") where T : Entity
        {
            var entity = PluginExecutionContext.PreEntityImages[preImageName] as Entity;
            return entity.ToEntity<T>();
        }

        internal T GetPostImage<T>(string postImageName = "PostImage") where T : Entity
        {
            var image = PluginExecutionContext.PostEntityImages[postImageName] as Entity;
            return image.ToEntity<T>();
        }
    }
}
