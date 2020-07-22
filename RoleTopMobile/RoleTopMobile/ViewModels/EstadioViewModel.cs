using RoleTopMobile.Models;
using RoleTopMobile.Services;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using Xamarin.Forms;
using System.IO;

namespace RoleTopMobile.ViewModels
{
    public class EstadioViewModel : BaseViewModel
    {
        private List<Estadio> _estadios;

        public List<Estadio> Estadios
        {
            get { return _estadios; }
            set
            {
                _estadios = value;
                OnPropertyChanged();
            }
        }

        public EstadioViewModel()
        {
            Estadios = new List<Estadio>();

            getEstadios();
        }

        private void getEstadios()
        {
            try
            {
                HttpClient client = Utils.getClient;

                HttpResponseMessage response = client.GetAsync("Estadio").Result;

                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;

                    Estadios = JsonConvert.DeserializeObject<List<Estadio>>(json);

                    foreach (var item in Estadios)
                    {
                        item.fotoConvertida =  Utils.getImageSourceFromByteArray(item.foto);
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("======================================================================");
                Console.WriteLine("======================================================================");
                Console.WriteLine("======================================================================");
                Console.WriteLine(ex.Message);
                Console.WriteLine("======================================================================");
                Console.WriteLine("======================================================================");
            }
        }
    }
}
