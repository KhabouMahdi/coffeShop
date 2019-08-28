using metiers;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
   public class LigneTicketDAO
    {
        MySqlConnection cnx;
        int m;
        public void Add(LigneTicket m)
        {
            try
            {
                cnx = ConnexionCoffe.GetInstance();
                MySqlCommand cmd = new MySqlCommand("insert into tligneticket values(@id,  @idprod,@idticket,@nomprod, @qteprod,@prixprod,@totalprod)", cnx);
                cmd.Parameters.Add("@id", m.Id);//
                cmd.Parameters.Add("@idprod", m.Idprod.Id);
                cmd.Parameters.Add("@idticket", m.Idticket.Id);
                cmd.Parameters.Add("@nomprod", m.NomProd);
                cmd.Parameters.Add("@qteprod", m.QteProd);
                cmd.Parameters.Add("@prixprod", m.PrixProd);
                cmd.Parameters.Add("@totalprod", m.TotalProd);


                int n = cmd.ExecuteNonQuery();
                if (n != 0)
                    MessageBox.Show("LigneTicket ajouter avec succée \n ", "Attention");
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pb de la requete de l'ajout\n " + ex.Message, "Attention");
            }

        }
        public List<LigneTicket> FindAllbyTicket(int idTick)
        {
            ProduitDAO bdProd = new ProduitDAO();
            List<Produit> produits = bdProd.FindAll();
            Produit p = null;

            TicketDAO bdtick = new TicketDAO();
            List<Ticket> tickets = bdtick.FindAll();
            Ticket t = null;


            List<LigneTicket> res = new List<LigneTicket>();

            try
            {
                cnx = ConnexionCoffe.GetInstance();
                MySqlCommand cmd = new MySqlCommand("select * from tligneticket where idticket=@idtick ", cnx);
                cmd.Parameters.Add("@idtick", idTick);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    foreach (Produit prod in produits)
                        if (prod.Id.Equals(reader.GetInt32(1)))
                        { p = prod; break; }

                    foreach (Ticket tick in tickets)
                        if (tick.Id.Equals(reader.GetInt32(2)))
                        { t = tick; break; }

                    LigneTicket m = new LigneTicket(reader.GetInt32("id"), p, t, reader.GetString(3), reader.GetInt32(4), reader.GetDecimal(5), reader.GetDecimal(6));
                    res.Add(m);
                }
                  reader.Close();
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ligne ticket : Pb de FindAll \n " + ex.Message, "Attention");
            }
            return res;

        }
       
    }
}
