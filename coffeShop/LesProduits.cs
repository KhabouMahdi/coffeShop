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

namespace coffeShop
{
    public partial class LesProduits : Form
    {
        public LesProduits()
        {
            InitializeComponent();
        }
        static List<Categorie> Categories;
        static List<Produit> produits;

        private void LesProduits_Load(object sender, EventArgs e)
        {
            cbxCat.Items.Add("All Categories");

            CategorieDAO bd = new CategorieDAO();
           Categories = bd.FindAll();
            cbxCat.Items.AddRange(Categories.ToArray());
            ProduitDAO pd = new ProduitDAO();
            produits = pd.FindAll();
            foreach (Produit mm in produits)
            {
                dataGridView1.Rows.Add(mm.Id, mm.Nom, mm.Prix, mm.IdCat, mm.Description,mm.Img);

            }
           cbxCat.SelectedIndex = 0;

        }

       private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "delete")
                {
                    if (MessageBox.Show("Are You Sure You Want to Delete this Product\nfrom Database", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int ProductID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);

         ProduitDAO pdo=new ProduitDAO();
                        if (pdo.RemoveProduitbyId(ProductID))
                        {
                            dataGridView1.Rows.RemoveAt(e.RowIndex);
                        }
                        else if (pdo.RemoveProduitbyId(ProductID))
                        {
                            MessageBox.Show("Product Not Deleted");
                        }
                    }
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "edit")
                {
                    int ProductID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);

                    string ProductName = dataGridView1.Rows[e.RowIndex].Cells["nom"].Value.ToString();

                    decimal ProductPrice = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["prix"].Value.ToString());

                    string ProductCategory = dataGridView1.Rows[e.RowIndex].Cells["categorie"].Value.ToString();

                    string ProductDescription = dataGridView1.Rows[e.RowIndex].Cells["description"].Value.ToString();

                    byte[] ProductPicture = (byte[])dataGridView1.Rows[e.RowIndex].Cells["image"].Value;

                    UpdateProduit UpdateProductForm = new UpdateProduit(ProductID, ProductName, ProductPrice, ProductCategory, ProductDescription, ProductPicture);

                    if (UpdateProductForm.ShowDialog() == DialogResult.OK)
                    {
                        ProduitDAO pdo = new ProduitDAO();

                        Produit UpdatedProductDetail = pdo.Find(ProductID);

                        dataGridView1.Rows[e.RowIndex].Cells["nom"].Value = UpdatedProductDetail.Nom;
                        dataGridView1.Rows[e.RowIndex].Cells["prix"].Value = UpdatedProductDetail.Prix;
                        dataGridView1.Rows[e.RowIndex].Cells["categorie"].Value = UpdatedProductDetail.IdCat.Nom;
                        dataGridView1.Rows[e.RowIndex].Cells["description"].Value = UpdatedProductDetail.Description;
                        dataGridView1.Rows[e.RowIndex].Cells["image"].Value = UpdatedProductDetail.Img;
                    }
                }
            }
        }

        private void cbxCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            ProduitDAO pd = new ProduitDAO();
            produits = pd.FindAll();

            if (cbxCat.SelectedIndex == 0)
            {

                foreach (Produit ProductDetail in produits)
                {
                    dataGridView1.Rows.Add(ProductDetail.Id, ProductDetail.Nom, ProductDetail.Prix, ProductDetail.IdCat, ProductDetail.Description, ProductDetail.Img);
                }
            }
            else if (cbxCat.SelectedIndex > 0)
            {
                string CategoryName = cbxCat.SelectedItem.ToString();
                CategorieDAO c = new CategorieDAO();
                int id = c.ReturnCategorieID(CategoryName);
                ProduitDAO pdao = new ProduitDAO();
                produits = pdao.FindToCat(id);

               // int CategoryID = _DataAccess.ReturnCategoryID(CategoryName);

                foreach (Produit ProductDetail in produits)
                {
                    dataGridView1.Rows.Add(ProductDetail.Id, ProductDetail.Nom, ProductDetail.Prix, ProductDetail.IdCat, ProductDetail.Description, ProductDetail.Img);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
