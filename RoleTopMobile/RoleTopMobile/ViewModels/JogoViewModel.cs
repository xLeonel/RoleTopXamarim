using Newtonsoft.Json;
using RoleTopMobile.Models;
using RoleTopMobile.Services;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace RoleTopMobile.ViewModels
{
    public class JogoViewModel : BaseViewModel
    {
        private List<Jogo> _jogos;
        private List<Selecao> _selecao;
        private List<Estadio> _estadio;

        public List<Jogo> Jogos
        {
            get { return _jogos; }
            set
            {
                _jogos = value;
                OnPropertyChanged();
            }
        }
        public List<Selecao> Selecaos
        {
            get { return _selecao; }
            set
            {
                _selecao = value;
                OnPropertyChanged();
            }
        }
        public List<Estadio> Estadios
        {
            get { return _estadio; }
            set
            {
                _estadio = value;
                OnPropertyChanged();
            }
        }

        public JogoViewModel()
        {
            Jogos = new List<Jogo>();
            Selecaos = new List<Selecao>();
            Estadios = new List<Estadio>();

            getJogos();
            getEstadios();
            getSelecaos();
        }

        private void getJogos()
        {
            try
            {
                HttpClient client = Utils.getClient;

                HttpResponseMessage response = client.GetAsync("Jogo").Result;

                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;

                    Jogos = JsonConvert.DeserializeObject<List<Jogo>>(json);
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
                        item.fotoConvertida = Utils.getImageSourceFromByteArray(item.foto);
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
        private void getSelecaos()
        {
            try
            {
                HttpClient client = Utils.getClient;

                HttpResponseMessage response = client.GetAsync("Selecao").Result;

                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;

                    Selecaos = JsonConvert.DeserializeObject<List<Selecao>>(json);
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
