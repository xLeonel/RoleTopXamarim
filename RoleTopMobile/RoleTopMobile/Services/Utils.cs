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
<<<<<<< HEAD
                    client.BaseAddress = new Uri("http://192.168.0.1:5000/api/");
=======
                    client.BaseAddress = new Uri("http://192.168.0.2:5000/api/");
>>>>>>> 82266b19e6aa1bb5da308e30d9b15ad33c923ecd
                }

                return client;
            }
        }
    }

}