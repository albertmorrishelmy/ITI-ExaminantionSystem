using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.Web.Http;
using System.Web.Http.Owin;
using System.Web.Http.Controllers;
using System.Web.Http.OData.Extensions;
using DataAccessLayer;
using System.Web.Http.OData.Batch;
using Microsoft.Data.Edm;
using System.Web.Http.OData.Builder;
using BusineesLayer.Map;
using DataAccessLayer.Models;
using Microsoft.Data.Edm.Library;
using System.Web.Hosting;
using Swashbuckle.Application;

[assembly: OwinStartup(typeof(API_OAuth.Startup))]

namespace API_OAuth
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();

            ConfigureAuth(app);

        }
    }
}