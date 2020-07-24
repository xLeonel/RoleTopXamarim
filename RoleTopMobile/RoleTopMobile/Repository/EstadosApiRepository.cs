using RoleTopMobile.Interfaces;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using RoleTopMobile.Models;

namespace RoleTopMobile.Repository
{
    public class EstadosApiRepository : IEstadosApi
    {
        public async Task<EstadosApi> GetEstados()
        {
            var ufApi = RestService.For<IEstadosApi>("https://servicodados.ibge.gov.br/api/v1");
            var cidadesRetornado = await ufApi.GetEstados();

            return cidadesRetornado;
        }
    }
}
