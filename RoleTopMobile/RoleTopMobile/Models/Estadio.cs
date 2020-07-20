using System;
using System.Collections.Generic;
using System.Text;

namespace RoleTopMobile.Models
{
    public class Estadio
    {
        public int id { get; set; }
        public int evento { get; set; }
        public string nome { get; set; }
        public string foto { get; set; }
        public int latitude { get; set; }
        public int longitude { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public object eventoNavigation { get; set; }
    }
}

