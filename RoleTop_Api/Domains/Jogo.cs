using System;
using System.Collections.Generic;

namespace RoleTop_Api.Domains
{
    public partial class Jogo
    {
        public Jogo()
        {
            Evento = new HashSet<Evento>();
        }

        public int Id { get; set; }
        public int SelecaoCasa { get; set; }
        public int SelecaoVisitante { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }

        public virtual Selecao SelecaoCasaNavigation { get; set; }
        public virtual Selecao SelecaoVisitanteNavigation { get; set; }
        public virtual ICollection<Evento> Evento { get; set; }
    }
}
