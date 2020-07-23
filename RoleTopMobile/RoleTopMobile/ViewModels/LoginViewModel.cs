using Newtonsoft.Json;
using RoleTopMobile.Models;
using RoleTopMobile.Services;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace RoleTopMobile.ViewModels
{
    public class LoginViewModel :BaseViewModel
    {
        public string Email { get; set; }
        public string Senha { get; set; }
        public ICommand btnLoginCommand { get; set; }

        public LoginViewModel()
        {
            btnLoginCommand = new Command(login);
        }

        public void login()
        {
            try
            {
                HttpClient client = Utils.getClient;

                Login login = new Login
                {
                    Email = this.Email,
                    Senha = this.Senha
                };

                string objectSerialized = JsonConvert.SerializeObject(login);

                StringContent content = new StringContent(objectSerialized, Encoding.UTF8, "application/json");

                HttpResponseMessage response = client.PostAsync("usuarios/login", content).Result;

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    string json = response.Content.ReadAsStringAsync().Result;

                    Token token = JsonConvert.DeserializeObject<Token>(json);
                    MessagingCenter.Send<string>("", "SucessoLogin");
                }
                else if (response.StatusCode == HttpStatusCode.NoContent)
                {
                    MessagingCenter.Send<String>("Usuário não encontrado", "ErroLogin");
                }
                else
                {
                    MessagingCenter.Send<String>($"Erro no servidor: StatusCode = {response.StatusCode.ToString()}", "ErroLogin");
                }
            }
            catch (Exception ex)
            {
                MessagingCenter.Send<String>("Erro", "ErroLogin");
            }
        }

        private bool verifyInputs()
        {
            if (!string.IsNullOrEmpty(Email) && Email.Trim().Length >= 3 &&
                !string.IsNullOrEmpty(Senha) && Senha.Trim().Length >= 3
                )
            {
                return true;
            }

            return false;
        }
        private bool ValidEmail()
        {

            if (Email.StartsWith("A/Z-a/z") && Email.Contains("@") && Email.EndsWith(".com"))
            {
                return true;
            }
            return Convert.ToBoolean(EmailBackgroundColor);
        }

        public Color emailBackgroundColor = Color.Red;

        public Color EmailBackgroundColor
        {
            get
            {
                return emailBackgroundColor;
            }

            set
            {
                emailBackgroundColor = value;
            }
        }

        private class Token
        {
            public string token { get; set; }
        }
    }
}
