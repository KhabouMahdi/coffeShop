using metiers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
  public  class TicketDAO
    {
        MySqlConnection cnx;
        int m;

        public void Add(Ticket m)
        {
            try
            {
                cnx = ConnexionCoffe.GetInstance();
                MySqlCommand cmd = new MySqlCommand("insert into tticket values(@id,  @idemp,@total,@especes, @rendue,@dateCreation)", cnx);
                cmd.Parameters.Add("@id", m.Id);//
                cmd.Parameters.Add("@idemp", m.IdEmploye.Id);
                cmd.Parameters.Add("@total", m.Total);
                cmd.Parameters.Add("@especes", m.Especes);
                cmd.Parameters.Add("@rendue", m.Rendu);
                cmd.Parameters.Add("@dateCreation", m.DateTicket);


                int n = cmd.ExecuteNonQuery();
                if (n != 0)
                    MessageBox.Show("Ticket ajouter avec succée \n ", "Attention");
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pb de la requete de l'ajout\n " + ex.Message, "Attention");
            }

        }
        public void Add2(Ticket m)
        {
            try
            {
                cnx = ConnexionCoffe.GetInstance();
                MySqlCommand cmd = new MySqlCommand("insert into tticket values(@id,@idemp,@total,@especes, @rendue,@dateCreation)", cnx);
                cmd.Parameters.Add("@id", null);
                cmd.Parameters.Add("@idemp", m.IdEmploye.Id);
                cmd.Parameters.Add("@total", m.Total);
                cmd.Parameters.Add("@especes", m.Especes);
                cmd.Parameters.Add("@rendue", m.Rendu);
                cmd.Parameters.Add("@dateCreation", m.DateTicket);


                int n = cmd.ExecuteNonQuery();
                if (n != 0)
                    MessageBox.Show("Ticket ajouter avec succée \n ", "Attention");
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pb de la requete de l'ajout\n " + ex.Message, "Attention");
            }

        }
        public Ticket Find(int id)
        {
            EmployerDAO bdCat = new EmployerDAO();
            List<Employer> emps = bdCat.FindAll();

            Employer c = null;
            Ticket m = null;
            try
            {
                cnx = ConnexionCoffe.GetInstance();
                MySqlCommand cmd = new MySqlCommand("select * from tticket where id=@id", cnx);
                cmd.Parameters.Add("@id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    foreach (Employer emp in emps)
                        if (emp.Id.Equals(reader.GetInt32(3)))
                        { c = emp; break; }
                    m = new Ticket(reader.GetInt32("id"), c, reader.GetDecimal(2), reader.GetDecimal(3), reader.GetDecimal(4),reader.GetDateTime(5));

                }
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Requete recherche ticket : Find  \n " + ex.Message, "Attention");
            }
            return m;
        }
        public int lastVal()
        {
           
            try
            {
                cnx = ConnexionCoffe.GetInstance();
                MySqlCommand cmd = new MySqlCommand("SELECT MAX(id) FROM tticket", cnx);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    m = reader.GetInt32(0);
                }
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Requete recherche lastVal: Find  \n " + ex.Message, "Attention");
            }
            return m;
        }
        public List<Ticket> FindAll()
        {
            EmployerDAO bdCat = new EmployerDAO();
            List<Employer> categories = bdCat.FindAll();
            Employer c = null;

            List<Ticket> res = new List<Ticket>();
           // ArrayList ProduitList = new ArrayList();


            try
            {
                cnx = ConnexionCoffe.GetInstance();
                MySqlCommand cmd = new MySqlCommand("select * from tticket", cnx);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    foreach (Employer emp in categories)
                        if (emp.Id.Equals(reader.GetInt32(1)))
                        { c = emp; break; }

                    Ticket m = new Ticket(reader.GetInt32("id"), c, reader.GetDecimal(2), reader.GetDecimal(3), reader.GetDecimal(4), reader.GetDateTime(5));
                    res.Add(m);
                }
                // reader.Close();
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ticket : Pb de FindAll \n " + ex.Message, "Attention");
            }
            return res;

        }
    }
}
