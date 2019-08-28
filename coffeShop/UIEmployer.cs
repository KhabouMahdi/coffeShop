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
using metiers;
using DAO;
using System.Collections;

namespace coffeShop
{
    public partial class UIEmployer : Form
    {
        int idTick;

        int i;
        string nomUtilisateur;
        int user;
        private bool mouseDown = false;
        private Point lastLocation;
        public UIEmployer()
        {
            InitializeComponent();
        }
        public UIEmployer(int user)
        {
            InitializeComponent();
            this.user = user;
            EmployerDAO edao = new EmployerDAO();
            nomUtilisateur = edao.FindNameByid(user);
            // label4.Text = user.ToString();
            label4.Text = nomUtilisateur;
            TicketDAO T = new TicketDAO();
           i=T.lastVal();
            txtnumtick.Text = (i+1).ToString();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblRed_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void lblClose_MouseEnter(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.White;
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.Black;
        }

        private void lblRed_MouseEnter(object sender, EventArgs e)
        {
            lblRed.ForeColor = Color.White;

        }

        private void lblRed_MouseLeave(object sender, EventArgs e)
        {
            lblRed.ForeColor = Color.Black;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            panel1.Cursor = Cursors.Hand;
            lastLocation = e.Location;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            panel1.Cursor = Cursors.Default;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                int newX = (this.Location.X - lastLocation.X) + e.X;
                int newY = (this.Location.Y - lastLocation.Y) + e.Y;
                this.Location = new Point(newX, newY);
            }
        }

        private void btnajpro_Click(object sender, EventArgs e)
        {
            AjouterProduit f1 = new AjouterProduit();
            f1.Show();
        }

        private void btnajcat_Click(object sender, EventArgs e)
        {
            AjouterCategorie f1 = new AjouterCategorie(user);
            f1.Show();
        }

        private void btnprods_Click(object sender, EventArgs e)
        {
            LesProduits f1 = new LesProduits();
            f1.Show();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            LesTransactions tr = new LesTransactions();
            tr.Show();

        }
        static List<Categorie> AllCategories;

        private void UIEmployer_Load(object sender, EventArgs e)
        {
         

            CategorieDAO bd = new CategorieDAO();
            AllCategories = bd.FindAll();
            flpanelCat.Controls.Clear();
            

            foreach (Categorie cat in AllCategories)
            {
                Button btn = new Button();
                btn.Text = cat.Nom;
                btn.Size = new System.Drawing.Size(90, 90);
                btn.ForeColor = Color.White;
                btn.Cursor = Cursors.Hand;
                btn.Font=new System.Drawing.Font(btn.Font.Name, 10, FontStyle.Bold);


                MemoryStream ms = new MemoryStream(cat.Img);
                btn.Image = Image.FromStream(ms);
                btn.Image = new Bitmap(btn.Image, btn.Size);

                btn.Tag = cat.IdCat;
                flpanelCat.Controls.Add(btn);
               //  MessageBox.Show("accepter \n ", "Attention");


                 btn.Click += CategoryButtonClick;
            }
        }
        static List<Produit> AllProduit;

        void CategoryButtonClick(object sender, EventArgs e)
        {
            flPanelProd.Controls.Clear();

            Button btn = (Button)sender;

            int CategoryID = Convert.ToInt32(btn.Tag);

            ProduitDAO bd = new ProduitDAO();
            AllProduit = bd.FindToCat(CategoryID);



            foreach (Produit Product in AllProduit)
            {
                Button ProductButton = new Button();
                ProductButton.Text = Product.Nom;
                ProductButton.Size = new System.Drawing.Size(90, 90);
                ProductButton.ForeColor = Color.White;
                ProductButton.Cursor = Cursors.Hand;
                ProductButton.Font = new System.Drawing.Font(ProductButton.Font.Name, 10, FontStyle.Bold);

                MemoryStream ms = new MemoryStream(Product.Img);
                ProductButton.Image = Image.FromStream(ms);
                ProductButton.Image = new Bitmap(ProductButton.Image, ProductButton.Size);

                ProductButton.Tag = Product.Id;

                flPanelProd.Controls.Add(ProductButton);

                ProductButton.Click += ProductButton_Click;
                //ProductButton.MouseClick += ProductButton_MouseClick;


            }
        }
        void ProductButton_MouseClick(object sender, MouseEventArgs e)
        {
            //for loweing one quantity. do this.. <---------------------
            /*     switch (e.Button)
                 {
                     case MouseButtons.Right:

                         MessageBox.Show("Right Click");

                         break;
                     case MouseButtons.Left:
                         MessageBox.Show("Left Click");
                         break;
                 }*/
            if (e.Button == MouseButtons.Left)
            {
                MessageBox.Show("Left Click");
            }
            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Right Click");
            }
        }

        public int RowIndex = 0;

        void ProductButton_Click(object sender, EventArgs e)
        {
        

            Button ProductButton = sender as Button;
            int ProduitID = Convert.ToInt32(ProductButton.Tag);
            ProduitDAO bd = new ProduitDAO();
            Produit p = bd.Find(ProduitID);

            if (CheckProductAlreadyAdded(ProduitID))
            {
                // MessageBox.Show("Product Alraedy Exists in Datagrid view at Index : " + RowIndex);
                int Quantity = Convert.ToInt32(dgvProd.Rows[RowIndex].Cells["qte"].Value);
                decimal Price = Convert.ToInt32(dgvProd.Rows[RowIndex].Cells["prix"].Value);

                Quantity++;

                /////////////<Do thisssss...... Important.. Have decimal part in the total price>
                double TotalPrice = Convert.ToDouble(Quantity * Price);

                dgvProd.Rows[RowIndex].Cells["qte"].Value = Quantity;
                dgvProd.Rows[RowIndex].Cells["totalProduit"].Value = TotalPrice;

                txtTotal.Text = CalculateTotalBill(dgvProd).ToString();
            }
            else
            {
                dgvProd.Rows.Add(ProduitID, p.Nom, p.Prix, 1, p.Prix * 1);

                txtTotal.Text = CalculateTotalBill(dgvProd).ToString();
            }
        }

        public decimal CalculateTotalBill(DataGridView ProductsGridView)
        {
            decimal TotalBill = 0;

            foreach (DataGridViewRow Row in ProductsGridView.Rows)
            {
                decimal ProductTotal = Convert.ToDecimal(Row.Cells["totalProduit"].Value);

                TotalBill = TotalBill + ProductTotal;
            }

            return TotalBill;
        }

        public bool CheckProductAlreadyAdded(int ProductID)
        {
            foreach (DataGridViewRow Row in dgvProd.Rows)
            {
                if (Convert.ToInt32(Row.Cells["ID"].Value) == ProductID)
                {
                    RowIndex = Row.Index;
                    return true;
                }
            }
            return false;
        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            UIEmployer_Load(sender, e);

        }

        private void dgvProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvProd.Columns[e.ColumnIndex].Name == "delete")
                {
                    if (MessageBox.Show("Are You Sure You Want to Delete this Product", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        decimal DeletedProductTotal = Convert.ToDecimal(dgvProd.Rows[e.RowIndex].Cells["totalProduit"].Value);

                        decimal CurrentTotalBill = Convert.ToDecimal(txtTotal.Text);

                        CurrentTotalBill = CurrentTotalBill - DeletedProductTotal;

                        dgvProd.Rows.RemoveAt(e.RowIndex);
                        txtTotal.Text = CurrentTotalBill.ToString();
                    }
                }
            }
        }

        private void txtmtdonne_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtmtretourne.Text = (Convert.ToDecimal(txtmtdonne.Text) - Convert.ToDecimal(txtTotal.Text)).ToString();
            }
            catch
            {
                txtmtretourne.Text = string.Empty;
            }
        }

        private void btnConfirme_Click(object sender, EventArgs e)
        {
            EmployerDAO empd = new EmployerDAO();
            Employer emp2 =empd.Find(user);
            DateTime auj = DateTime.Now.Date;
            string d=DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            DateTime auj2 = DateTime.Parse(d);


            // Employer emp = new Employer(0,"","","","","","","","","", auj,auj,null);
            decimal total,don,ret;
            total = Convert.ToDecimal(txtTotal.Text);
            don = Convert.ToDecimal(txtmtdonne.Text);
            ret = Convert.ToDecimal(txtmtretourne.Text);
            metiers.Ticket m = new metiers.Ticket(idTick, emp2, total, don, ret, auj2);
            //metiers.Ticket m2 = new metiers.Ticket(emp2, total, don, ret, auj);

            TicketDAO bd = new TicketDAO();
           bd.Add(m);
          //  bd.Add2(m2);
          
           metiers.Ticket m2 = bd.Find(Convert.ToInt32(txtnumtick.Text));
            foreach (DataGridViewRow Row in dgvProd.Rows)
            {
                try
                {
                    LigneTicketDAO ltb = new LigneTicketDAO();
                    int ProductId = Convert.ToInt32(Row.Cells["id"].Value);
                    string ProductName = Row.Cells["Nomproduit"].Value.ToString();
                    decimal ProductPrice = Convert.ToDecimal(Row.Cells["prix"].Value);
                    int ProductQuantity = Convert.ToInt32(Row.Cells["qte"].Value);
                    decimal ProductTotal = Convert.ToDecimal(Row.Cells["totalProduit"].Value);
                    ProduitDAO pb = new ProduitDAO();
                    Produit p = pb.Find(ProductId);
                    LigneTicket l = new LigneTicket(0, p,m2, ProductName, ProductQuantity, ProductPrice, ProductTotal);
                    ltb.Add(l);
                }
                catch
                {
                    //means Rows are ended
                }
            }





            new Ticket(txtTotal.Text,txtmtdonne.Text,txtmtretourne.Text).ShowDialog();
            this.Hide();
            UIEmployer f1 = new UIEmployer(user);
            f1.Show();

        }

        private void txtnumtick_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
    }

