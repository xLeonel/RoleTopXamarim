using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace RoleTopMobile.Services
{
    public static class Utils
    {
        private static HttpClient client;

        public static HttpClient getClient
        {
            get
            {
                if (client == null)
                {
                    client = new HttpClient();
                    client.BaseAddress = new Uri("http://192.168.0.2:5000/api/");
                }

                return client;
            }
        }
    }

}