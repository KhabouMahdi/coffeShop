using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metiers
{
    public class Ticket
    {
        int id;
        Employer idEmploye;
        decimal total, especes, rendu;
        DateTime dateTicket;

        public Ticket(Employer idEmploye, decimal total, decimal especes, decimal rendu, DateTime dateTicket)
        {
            this.idEmploye = idEmploye;
            this.total = total;
            this.especes = especes;
            this.rendu = rendu;
            this.dateTicket = dateTicket;
        }

        public Ticket(int id, Employer idEmploye, decimal total, decimal especes, decimal rendu, DateTime dateTicket)
        {
            this.id = id;
            this.idEmploye = idEmploye;
            this.total = total;
            this.especes = especes;
            this.rendu = rendu;
            this.dateTicket = dateTicket;
        }

        public int Id { get => id; set => id = value; }
        public Employer IdEmploye { get => idEmploye; set => idEmploye = value; }
        public decimal Total { get => total; set => total = value; }
        public decimal Especes { get => especes; set => especes = value; }
        public decimal Rendu { get => rendu; set => rendu = value; }
        public DateTime DateTicket { get => dateTicket; set => dateTicket = value; }

        public override bool Equals(object obj)
        {
            var ticket = obj as Ticket;
            return ticket != null &&
                   id == ticket.id;
        }
        
    }
}
