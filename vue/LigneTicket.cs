using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metiers
{
    public class LigneTicket
    {
        int id;

        Produit idprod;
         Ticket idticket;
        string nomProd;
        int qteProd;
        decimal prixProd;
        decimal totalProd;

        public LigneTicket(int id, Produit idprod, Ticket idticket, string nomProd, int qteProd, decimal prixProd, decimal totalProd)
        {
            this.id = id;
            this.idprod = idprod;
            this.idticket = idticket;
            this.nomProd = nomProd;
            this.qteProd = qteProd;
            this.prixProd = prixProd;
            this.totalProd = totalProd;
        }

        public int Id { get => id; set => id = value; }
        public Produit Idprod { get => idprod; set => idprod = value; }
        public Ticket Idticket { get => idticket; set => idticket = value; }
        public string NomProd { get => nomProd; set => nomProd = value; }
        public int QteProd { get => qteProd; set => qteProd = value; }
        public decimal PrixProd { get => prixProd; set => prixProd = value; }
        public decimal TotalProd { get => totalProd; set => totalProd = value; }

        public override bool Equals(object obj)
        {
            var ticket = obj as LigneTicket;
            return ticket != null &&
                   id == ticket.id;
        }
    }
}
