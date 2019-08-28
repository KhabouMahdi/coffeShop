using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using metiers;
using System.IO;

namespace coffeShop
{
    public partial class AjouterProduit : Form
    {
        public AjouterProduit()
        {
            InitializeComponent();
        }

        private void btnchoisir_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                imageLocation = opf.FileName;
                imgprod.ImageLocation = imageLocation;
            }
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            Categorie c = (Categorie)cbxCategorie.SelectedItem;
            MemoryStream ms = new MemoryStream();
            imgprod.Image.Save(ms, imgprod.Image.RawFormat);
            byte[] img = ms.ToArray();

            decimal prix;
           prix = Convert.ToDecimal(txtprix.Text);
           Produit m =new Produit(0,txtnom.Text, txtdesc.Text,c, prix,img);
           ProduitDAO bd = new ProduitDAO();
           bd.Add(m);
        }
        static List<Categorie> Categories;

        private void ajouterProduit_Load(object sender, EventArgs e)
        {
            CategorieDAO bd = new CategorieDAO();
            Categories = bd.FindAll();
        /*    foreach (Categorie p in Categories)
            {

                cbxCategorie.Items.Add(p.ToString());


            }*/
             cbxCategorie.Items.AddRange(Categories.ToArray());
        }

        private void cbxCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
