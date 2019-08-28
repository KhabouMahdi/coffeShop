using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using metiers;
using System.Collections;

namespace DAO
{
    public class CategorieDAO
    {
        MySqlConnection cnx;
        int m;
        public void Add(Categorie m)
        {
            try
            {
                cnx = ConnexionCoffe.GetInstance();
                MySqlCommand cmd = new MySqlCommand("insert into tcategorie values(@id,  @nom,@desc, @img)", cnx);
                cmd.Parameters.Add("@id", m.IdCat);//
                cmd.Parameters.Add("@nom", m.Nom);
                cmd.Parameters.Add("@desc", m.Description);
                cmd.Parameters.Add("@img", m.Img);
                int n = cmd.ExecuteNonQuery();
                if (n != 0)
                    MessageBox.Show("Categorie ajouter avec succée \n ", "Attention");
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pb de la requete de l'ajout\n " + ex.Message, "Attention");
            }
        }
        public List<Categorie> FindAll()
        {
            List<Categorie> res = new List<Categorie>();
            ArrayList CategoriesList = new ArrayList();


            try
            {
                cnx = ConnexionCoffe.GetInstance();
                MySqlCommand cmd = new MySqlCommand("select * from tcategorie", cnx);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    Categorie m = new Categorie(reader.GetInt32("id"), reader.GetString(1), reader.GetString(2), (byte[])reader[3]);
                    res.Add(m);
                }
              //  reader.Close();
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Categorie : Pb de FindAll \n " + ex.Message, "Attention");
            }
            return res;

        }
        public int ReturnCategorieID(string CategorieName)
        {
            try
            {
                cnx = ConnexionCoffe.GetInstance();
                MySqlCommand cmd = new MySqlCommand("SELECT id FROM tcategorie where nom= '" + CategorieName + "';", cnx);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    m = reader.GetInt32(0);
                }
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Requete recherche idCat: Find  \n " + ex.Message, "Attention");
            }
            return m;
        }
    }
}