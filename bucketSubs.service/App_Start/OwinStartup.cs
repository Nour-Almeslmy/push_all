﻿using DataAccessLayer.Data.Context;
using Microsoft.Owin;
using System.Web.Http;
using Owin;
using DataAccessLayer.Data;
using System.Linq;
using System.Net.Http.Formatting;
using Newtonsoft.Json.Serialization;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Security.OAuth;
using System;
using Unity.AspNet.WebApi;

[assembly: OwinStartup(typeof(bucketSubs.service.App_Start.OwinStartup))]
//using the OwinStartup Attribute to connect to the startup class with the hosting runtime.

namespace bucketSubs.service.App_Start
{
    public class OwinStartup
    {
        //specify components for the application pipeline
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration httpConfig = new HttpConfiguration();

            ConfigureOAuthTokenGeneration(app);

            //app.UseCors(CorsOptions.AllowAll);
            //ConfigureWebApi(httpConfig);
            WebApiConfig.Register(httpConfig);
            
            httpConfig.DependencyResolver = new UnityHierarchicalDependencyResolver(UnityConfig.Container);
            //Creates New Child Container with every begin request

            app.UseWebApi(httpConfig);


            #region Authentication-Authorization
            //UseOAuthAuthorizationServer extension method of OWIN is used to setup the authorization server.
            //app.UseOAuthAuthorizationServer(new OAuthAuthorizationServerOptions
            //{
            //    TokenEndpointPath = new PathString("/Login"),
            //    //Provider = new AuthorizationServerProvider(),
            //    //AccessTokenExpireTimeSpan = TimeSpan.FromMinutes(30),
            //    AllowInsecureHttp = true
            //});

            //app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
            #endregion
        }


        private void ConfigureOAuthTokenGeneration(IAppBuilder app)
        {
            /*
             - AppBuilderExtensions has the method "CreatePerOwinContext<T>" that registers a callback 
               that will be invoked to create an instance of type T and it will be stored in the OwinContext. 
             - we can retrieve it using the context.Get method => creates one instance of the given type per request.
             */

            //Db Instance
            app.CreatePerOwinContext(ApplicationDbContext.Create);

            //User Manager Instance
            app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);
        }

        private void ConfigureWebApi(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            //create Formatter for JSON
            var jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().First();

            jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        }
    }
}
