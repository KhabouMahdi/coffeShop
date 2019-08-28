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
  public  class EmployerDAO
    {
        MySqlConnection cnx;
        private int a;
        bool bl;
        int m;

        public void Add(Employer m)
        {
            try
            {
                cnx = ConnexionCoffe.GetInstance();
                MySqlCommand cmd = new MySqlCommand("insert into tcompte values(@id,  @nom, @prenom,@sexe,@dateNaissance,@telephone,@email,@type,@nomUtilisateur,@motPasse,@adresse,@image,@dateInscription)", cnx);
                cmd.Parameters.Add("@id", m.Id);//
                cmd.Parameters.Add("@nom", m.Nom);
                cmd.Parameters.Add("@prenom", m.Prenom);
                cmd.Parameters.Add("@sexe", m.Sexe);
                cmd.Parameters.Add("@dateNaissance", m.DateNaiss);
                cmd.Parameters.Add("@telephone", m.Tel);
                cmd.Parameters.Add("@email", m.Email);
                cmd.Parameters.Add("@type", m.Type);
                cmd.Parameters.Add("@nomUtilisateur", m.NomUtilisateur);
                cmd.Parameters.Add("@motPasse", m.Password);
                cmd.Parameters.Add("@adresse", m.Adresse);
                cmd.Parameters.Add("@image", m.Img);
                cmd.Parameters.Add("@dateInscription", m.DateInscription);
          

                int n = cmd.ExecuteNonQuery();
                if (n != 0)
                    MessageBox.Show("Utilisateur ajouter avec succée \n ", "Attention");
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pb de la requete de l'ajout\n " + ex.Message, "Attention");
            }

        }
        public List<Employer> FindAll()
        {
            List<Employer> res = new List<Employer>();
            ArrayList EmployerList = new ArrayList();
            Employer m = null;


            try
            {
                cnx = ConnexionCoffe.GetInstance();
                MySqlCommand cmd = new MySqlCommand("select * from tcompte", cnx);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    m = new Employer(reader.GetInt32("id"), reader.GetString("nom"), reader.GetString("prenom"), reader.GetString("sexe"), reader.GetString("telephone"), reader.GetString("email"), reader.GetString("adresse"), reader.GetString("type"), reader.GetString("nomUtilisateur"), reader.GetString("motPasse"), reader.GetDateTime("dateNaissance"), reader.GetDateTime("dateInscription"), (byte[])reader["image"]);
                    res.Add(m);
                }
                //  reader.Close();
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Employe : Pb de FindAll \n " + ex.Message, "Attention");
            }
            return res;

        }
        public Employer Find(int id)
        {

            Employer m = null;
            try
            {
                cnx = ConnexionCoffe.GetInstance();
                MySqlCommand cmd = new MySqlCommand("select * from tcompte where id=@id", cnx);
                cmd.Parameters.Add("@id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                 
                    m = new Employer(reader.GetInt32("id"), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetDateTime(4), reader.GetDateTime(12), (byte[])reader[11]);

                }
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Requete recherche employeparid : Find  \n " + ex.Message, "Attention");
            }
            return m;
        }
        public string FindNameByid(int id)
        {

            string m = null;
            try
            {
                cnx = ConnexionCoffe.GetInstance();
                MySqlCommand cmd = new MySqlCommand("select * from tcompte where id=@id", cnx);
                cmd.Parameters.Add("@id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    m = reader.GetString("nomUtilisateur");

                }
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Requete recherche employeparid : Find  \n " + ex.Message, "Attention");
            }
            return m;
        }
        public int FindbyName(string user)
        {
            int userId = 0;

            //Employer m = null;
            try
            {
                cnx = ConnexionCoffe.GetInstance();
                MySqlCommand cmd = new MySqlCommand("select * from tcompte where nomUtilisateur=@user", cnx);
                cmd.Parameters.Add("@user",user);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    //  m = new Employer(reader.GetInt32("id"), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetDateTime(10), reader.GetDateTime(11), (byte[])reader[12]);
                    userId = reader.GetInt32(0);

                }
                //reader.Close();
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Requete recherche employerparnom : Find  \n " + ex.Message, "Attention");
            }
            return userId;
        }
        public bool Conadmin(string s1,string s2)
        {
            // Employer m = null;
            try
            {
                cnx = ConnexionCoffe.GetInstance();
                MySqlCommand cmd = new MySqlCommand("select * from tcompte where type=@type and nomUtilisateur=@ut and motPasse=@mPa", cnx);
                cmd.Parameters.Add("@type", "admin");
                cmd.Parameters.Add("@ut", s1);
                cmd.Parameters.Add("@mPa", s2);//                cmd.Parameters.Add("@id", id);
                MySqlDataReader myReader = cmd.ExecuteReader();
               // private int a;
                while (myReader.Read())
                {
                    a=a+1;
                }
                if (a == 1)
                {

                    bl = true;
                }
                else
                {
                    bl = false;
                }
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Requete cnx : Find  \n " + ex.Message, "Attention");
            }
            return bl;
        }

        public int lastVal()
        {

            try
            {
                cnx = ConnexionCoffe.GetInstance();
                MySqlCommand cmd = new MySqlCommand("SELECT MAX(id) FROM tcompte", cnx);
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
        public bool RemoveEmpbyId(int id)
        {
            try
            {
                cnx = ConnexionCoffe.GetInstance();//ouvrir la connexion
                MySqlCommand cmd = new MySqlCommand("delete from tcompte where id=@id", cnx);
                cmd.Parameters.Add("@id", id);//
                int n = cmd.ExecuteNonQuery();
                if (n != 0)
                {
                    MessageBox.Show("Employer supprimer avec succée \n ", "Attention");
                    cnx.Close();
                    return true;
                }
                else

                    return false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Employer : RemoveByid \n " + ex.Message, "Attension");
                return false;

            }

        }

        public void Update(int id,string n, string p, string se, DateTime dn, string tel, string email, string type, string ut, string mp, string adr,byte[] img,DateTime datIns)
        {
            try
            {
                cnx = ConnexionCoffe.GetInstance();//ouvrir la connexion
                MySqlCommand cmd = new MySqlCommand("update tcompte set id=@id, nom=@nom, prenom=@prenom, sexe=@sexe,dateNaissance=@dateNaissance,telephone=@telephone,email=@email,type=@type,nomUtilisateur=@nomUtilisateur,motPasse=@motPasse,adresse=@adresse,image=@image,dateInscription=@dateInscription where id=@id", cnx);

                cmd.Parameters.Add("@id", id);//
                cmd.Parameters.Add("@nom", n);//
                cmd.Parameters.Add("@prenom", p);//
                cmd.Parameters.Add("@sexe", se);//
                cmd.Parameters.Add("@dateNaissance", dn);//
                cmd.Parameters.Add("@telephone", tel);//
                cmd.Parameters.Add("@email", email);//
                cmd.Parameters.Add("@type", type);//
                cmd.Parameters.Add("@nomUtilisateur", ut);//
                cmd.Parameters.Add("@motPasse", mp);
                cmd.Parameters.Add("@adresse", adr);//
                cmd.Parameters.Add("@image", img);//
                cmd.Parameters.Add("@dateInscription", datIns);//


                int x = cmd.ExecuteNonQuery();
                if (x != 0)
                    MessageBox.Show("Employer est modifié avec succée \n ", "Attention");
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Employer : Update\n " + ex.Message, "Attention");
            }

        }



    }
}
