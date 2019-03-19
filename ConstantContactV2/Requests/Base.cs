using System;
using System.Configuration;
using Aarvani.ConstantContactV2.Configurations;

namespace Aarvani.ConstantContactV2.Requests
{
    public abstract class Base
    {
        internal string BearToken  { get; }
        internal string ApiUrl { get; }
        internal string APIKey { get; }

        protected Base()
        {
            ApiUrl = Endpoints.api;
            if (ConfigurationManager.AppSettings["AccessToken"] != null)
            {
                BearToken = ConfigurationManager.AppSettings["AccessToken"];
            }
            else
            {
                throw new ArgumentException("Access Token Missing");
            }
            if (ConfigurationManager.AppSettings["APIKey"] != null)
            {
                APIKey = ConfigurationManager.AppSettings["APIKey"];
            }
            else
            {
                throw new ArgumentException("APIKey Missing");
            }
        }
    }
}
