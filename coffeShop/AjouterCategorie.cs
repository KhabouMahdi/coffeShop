using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using metiers;
namespace coffeShop
{
    public partial class AjouterCategorie : Form
    {
        int user;
        public AjouterCategorie(int user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btnchoisir_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                imageLocation = opf.FileName;
                imagecat.ImageLocation = imageLocation;
            }
        }

        private void btnajouterCat_Click(object sender, EventArgs e)
        {

            MemoryStream ms = new MemoryStream();
            imagecat.Image.Save(ms, imagecat.Image.RawFormat);
            byte[] img = ms.ToArray();

           

            Categorie cate = new Categorie(0,txtnom.Text,txtDesc.Text,img);

            CategorieDAO bd = new CategorieDAO();
            bd.Add(cate);
            this.Hide();
        //    UIEmployer.ActiveForm.Hide();
            UIEmployer emp = new UIEmployer(user);
            emp.Show();
        }

        private void AjouterCategorie_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
