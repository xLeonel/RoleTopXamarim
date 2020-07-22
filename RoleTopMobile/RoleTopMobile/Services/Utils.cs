using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Text;
using Xamarin.Forms;

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
                    client.BaseAddress = new Uri("http://192.168.0.8:5000/api/");
=======
                    client.BaseAddress = new Uri("http://192.168.0.2:5000/api/");
>>>>>>> bf8885af6bb0b8e98591e4a1272498fa55c7ff9d
                }

                return client;
            }
        }

        public static ImageSource getImageSourceFromByteArray(byte[] imageArray)
        {
            try
            {
                MemoryStream ms = new MemoryStream(imageArray);
<<<<<<< HEAD
                ImageSource imgSource = ImageSource.FromStream(() => ms);
                return imgSource;
=======
                ImageSource imageSource = ImageSource.FromStream(() => ms);
                return imageSource;
>>>>>>> bf8885af6bb0b8e98591e4a1272498fa55c7ff9d
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

}