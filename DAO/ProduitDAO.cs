using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using metiers;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Collections;

namespace DAO
{
    public class ProduitDAO
    {
        bool x;
        MySqlConnection cnx;
        public void Add(Produit m)
        {
            try
            {
                cnx = ConnexionCoffe.GetInstance();
                MySqlCommand cmd = new MySqlCommand("insert into tproduit values(@id,  @nom,@description,@cat, @prix,@img)", cnx);
                cmd.Parameters.Add("@id", m.Id);//
                cmd.Parameters.Add("@nom", m.Nom);
                cmd.Parameters.Add("@description", m.Description);
                cmd.Parameters.Add("@cat", m.IdCat.IdCat);
                cmd.Parameters.Add("@prix", m.Prix);
                cmd.Parameters.Add("@img", m.Img);


                int n = cmd.ExecuteNonQuery();
                if (n != 0)
                    MessageBox.Show("Produit ajouter avec succée \n ", "Attention");
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pb de la requete de l'ajout\n " + ex.Message, "Attention");
            }

        }
        public Produit Find(int id)
        {
            CategorieDAO bdCat = new CategorieDAO();
            List<Categorie> categories = bdCat.FindAll();

            Categorie c = null;
            Produit m = null;
            try
            {
                cnx = ConnexionCoffe.GetInstance();
                MySqlCommand cmd = new MySqlCommand("select * from tproduit where id=@id", cnx);
                cmd.Parameters.Add("@id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    foreach (Categorie med in categories)
                        if (med.IdCat.Equals(reader.GetInt32(3)))
                        { c = med; break; }
                    m = new Produit(reader.GetInt32("id"), reader.GetString(1), reader.GetString(2), c, reader.GetDecimal(4), (byte[])reader[5]);

                }
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Requete recherche Produit : Find  \n " + ex.Message, "Attention");
            }
            return m;
        }
        public List<Produit> FindAll()
        {
            CategorieDAO bdCat = new CategorieDAO();
            List<Categorie> categories = bdCat.FindAll();
            Categorie c = null;

            List<Produit> res = new List<Produit>();
            ArrayList ProduitList = new ArrayList();


            try
            {
                cnx = ConnexionCoffe.GetInstance();
                MySqlCommand cmd = new MySqlCommand("select * from tproduit", cnx);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    foreach (Categorie med in categories)
                        if (med.IdCat.Equals(reader.GetInt32(3)))
                        { c = med; break; }

                    Produit m = new Produit(reader.GetInt32("id"), reader.GetString(1), reader.GetString(2),c,reader.GetDecimal(4) ,(byte[])reader[5]);
                    res.Add(m);
                }
               // reader.Close();
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Produit : Pb de FindAll \n " + ex.Message, "Attention");
            }
            return res;

        }
        public List<Produit> FindToCat(int cat)
        {
            CategorieDAO bdCat = new CategorieDAO();
            List<Categorie> categories = bdCat.FindAll();
            Categorie c = null;

            List<Produit> res = new List<Produit>();
            try
            {
                cnx = ConnexionCoffe.GetInstance();
                MySqlCommand cmd = new MySqlCommand("select * from tproduit where idCateg=@idCateg", cnx);
                cmd.Parameters.Add("@idCateg", cat);//
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    foreach (Categorie med in categories)
                        if (med.IdCat.Equals(reader.GetInt32(3)))
                        { c = med; break; }
                    Produit m = new Produit(reader.GetInt32("id"), reader.GetString(1), reader.GetString(2), c, reader.GetDecimal(4), (byte[])reader[5]);
                    res.Add(m);
                }
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pb d'ouverture de la connexion \n " + ex.Message, "Attention");
            }
            return res;
        }

        public void Update(Produit s)
        {
            try
            {
                cnx = ConnexionCoffe.GetInstance();//ouvrir la connexion
                MySqlCommand cmd = new MySqlCommand("update tproduit set id=@id, nom=@nom, description=@description, idcateg=@idcateg,prix=@prix,image=@image where id=@id", cnx);

                cmd.Parameters.Add("@id", s.Id);//
                cmd.Parameters.Add("@nom", s.Nom);//
                cmd.Parameters.Add("@description", s.Description);//
                cmd.Parameters.Add("@idcateg", s.IdCat.IdCat);//
                cmd.Parameters.Add("@prix", s.Prix);//
                cmd.Parameters.Add("@image", s.Img);//


                int n = cmd.ExecuteNonQuery();
                if (n != 0)
                    MessageBox.Show("Produit est modifié avec succée \n ", "Attention");
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Produit : Update\n " + ex.Message, "Attention");
            }

        }
        public void Remove(Produit s)
        {
            try
            {
                cnx = ConnexionCoffe.GetInstance();//ouvrir la connexion
                MySqlCommand cmd = new MySqlCommand("delete from tproduit where id=@id", cnx);
                cmd.Parameters.Add("@id", s.Id);//
                int n = cmd.ExecuteNonQuery();
                if (n != 0)
                    MessageBox.Show("Produit supprimer avec succée \n ", "Attention");
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Produit : Remove \n " + ex.Message, "Attension");
            }

        }

        public bool RemoveProduitbyId(int id)
        {
            try
            {
                cnx = ConnexionCoffe.GetInstance();//ouvrir la connexion
                MySqlCommand cmd = new MySqlCommand("delete from tproduit where id=@id", cnx);
                cmd.Parameters.Add("@id", id);//
                int n = cmd.ExecuteNonQuery();
                if (n != 0)
                {
                    MessageBox.Show("Produit supprimer avec succée \n ", "Attention");
                    cnx.Close();
                    return true;
                }
                else
                    
                return false;                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Produit : RemoveByid \n " + ex.Message, "Attension");
                return false;

            }

        }

        public bool UpdateProduct(int ProductID, string ProductName, decimal ProductPrice, int ProductCategoryID, string ProductDescription, byte[] ProductPicture)
        {
            try
            {
                cnx = ConnexionCoffe.GetInstance();//ouvrir la connexion
                MySqlCommand cmd = new MySqlCommand("update tproduit set id=@id, nom=@nom, description=@description, idcateg=@idcateg,prix=@prix,image=@image where id=@id", cnx);

                cmd.Parameters.Add("@id", ProductID);//
                cmd.Parameters.Add("@nom", ProductName);//
                cmd.Parameters.Add("@description", ProductDescription);//
                cmd.Parameters.Add("@idcateg", ProductCategoryID);//
                cmd.Parameters.Add("@prix", ProductPrice);//
                cmd.Parameters.Add("@image", ProductPicture);//


                int n = cmd.ExecuteNonQuery();
                if (n != 0)
                    MessageBox.Show("Produit est modifié avec succée \n ", "Attention");
                cnx.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Produit : Update\n " + ex.Message, "Attention");
                return false;
            }
        }


    }
}
