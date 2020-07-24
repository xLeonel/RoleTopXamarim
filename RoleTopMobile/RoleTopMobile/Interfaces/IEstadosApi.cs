using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Refit;
using RoleTopMobile.Models;

namespace RoleTopMobile.Interfaces
{
    public interface IEstadosApi
    {
        [Get("/localidades/estados")]
        Task<EstadosApi> GetEstados();
    }
}
