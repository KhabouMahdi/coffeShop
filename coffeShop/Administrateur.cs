using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using metiers;
using DAO;
using System.IO;
namespace coffeShop
{
   
    public partial class Administrateur : Form
    {
        private bool mouseDown = false;
        private Point lastLocation;
        int user;
        int i;
        string nomUtilisateur;
        public Administrateur()
        {
            InitializeComponent();
           
        }
        public Administrateur(int usercon)
        {
            InitializeComponent();
            user = usercon;
            EmployerDAO T = new EmployerDAO();
            i = T.lastVal();
            txtIdUtil.Text = (i + 1).ToString();

        }
        List<Employer> employes = new List<Employer> ();
        private void Administrateur_Load(object sender, EventArgs e)
        {
            dgvEmp.Rows.Clear();
            EmployerDAO edao = new EmployerDAO();
            nomUtilisateur = edao.FindNameByid(user);
            //label2.Text = user.ToString();
            label2.Text = nomUtilisateur;

            timer1.Start();
            lblauj.Text = Convert.ToString(DateTime.Now.ToLongDateString());
            lbltemps.Text = Convert.ToString(DateTime.Now.ToLongTimeString());
            EmployerDAO pd = new EmployerDAO();
            employes = pd.FindAll();
            foreach (Employer mm in employes)
            {
                dgvEmp.Rows.Add(mm.Id, mm.Nom, mm.Prenom, mm.Sexe, mm.DateNaiss.ToShortDateString(), mm.Tel, mm.Email, mm.Type, mm.NomUtilisateur, mm.Password, mm.Adresse,mm.Img,mm.DateInscription);
            }
  
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            grpbox.Visible = false;
        }

   

        private void Close2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void lblclose2_MouseEnter(object sender, EventArgs e)
        {
            lblclose2.ForeColor = Color.White;
        }

        private void lblclose2_MouseLeave(object sender, EventArgs e)
        {
            lblclose2.ForeColor = Color.Black;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void grpbox_Enter(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnr_Click(object sender, EventArgs e)
        {
            grpmodUtil.Visible = false;

            grbEnr.Visible = true;
            grpbox.Visible = false;
        }

        private void btnTbdebor_Click(object sender, EventArgs e)
        {
            grpmodUtil.Visible = false;

            grbEnr.Visible = false;
            grpbox.Visible = true;

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void addProduit_Click(object sender, EventArgs e)
        {
           /* decimal prix;
            prix = Convert.ToDecimal(txtprix.Text);
            Produit m =new Produit(txtid.Text, txtnom.Text, prix);
            ProduitDAO bd = new ProduitDAO();
            bd.Add(m);*/
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void lblauj_Click(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltemps.Text = Convert.ToString(DateTime.Now.ToLongTimeString());
         
        }

        private void btnchoisir_Click(object sender, EventArgs e)
        {
           String imageLocation = "";
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                imageLocation = opf.FileName;
                pictureBoxUtilisateur.ImageLocation = imageLocation;
            }
        }

        private void btnEnrUtil_Click(object sender, EventArgs e)
        {
            DateTime dtinsc = DateTime.Now;
            string d = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            DateTime auj2 = DateTime.Parse(d);
            MemoryStream ms = new MemoryStream();
            pictureBoxUtilisateur.Image.Save(ms, pictureBoxUtilisateur.Image.RawFormat);
            byte[] img = ms.ToArray();



            Employer emp = new Employer(0,txtNomUtil.Text,txtPrenomutil.Text,cbxSexe.Text,txtTel.Text
                ,txtEmail.Text,txtadresse.Text,cbxType.Text,txtusername.Text,Eramake.eCryptography.Encrypt(txtpssword.Text),dtNaiss.Value, auj2,img);
            
           EmployerDAO bd= new EmployerDAO();
            bd.Add(emp);
            Administrateur_Load(sender, e);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtadresse.Text = "";
            txtconfpssw.Text = "";
            txtEmail.Text = "";
            txtIdUtil.Text = "";
            txtnom.Text = "";
            txtNomUtil.Text = "";
            txtPrenomutil.Text = "";
            txtprix.Text = "";
            txtusername.Text = "";



        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pbxUIEmp_Click(object sender, EventArgs e)
        {
            UIEmployer f1 = new UIEmployer(user);
            f1.Show();
        }

        private void pbxLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            UserLogin f1 = new UserLogin();
            f1.Show();
        }

        private void Administrateur_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            panel1.Cursor = Cursors.Hand;
            lastLocation = e.Location;
        }

        private void Administrateur_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            panel1.Cursor = Cursors.Default;
        }

        private void Administrateur_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                int newX = (this.Location.X - lastLocation.X) + e.X;
                int newY = (this.Location.Y - lastLocation.Y) + e.Y;
                this.Location = new Point(newX, newY);
            }
        }

        private void txtpssword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvEmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if (e.RowIndex >= 0)
           {

                string EmpID = dgvEmp.Rows[e.RowIndex].Cells["id"].Value.ToString(); ;
                string nom = dgvEmp.Rows[e.RowIndex].Cells["nom"].Value.ToString();


                string prenom = dgvEmp.Rows[e.RowIndex].Cells["prenom"].Value.ToString();
                string sexe = dgvEmp.Rows[e.RowIndex].Cells["sexe"].Value.ToString();

                string type = dgvEmp.Rows[e.RowIndex].Cells["type"].Value.ToString();

                string tel = dgvEmp.Rows[e.RowIndex].Cells["telephone"].Value.ToString();

                string email = dgvEmp.Rows[e.RowIndex].Cells["email"].Value.ToString();
                string utilisateur = dgvEmp.Rows[e.RowIndex].Cells["utilisateur"].Value.ToString();
                string passe = dgvEmp.Rows[e.RowIndex].Cells["passe"].Value.ToString();
                string adresse = dgvEmp.Rows[e.RowIndex].Cells["adresse"].Value.ToString();
                string dateNaiss =dgvEmp.Rows[e.RowIndex].Cells["dateNaissance"].Value.ToString();
                byte[] image = (byte[])dgvEmp.Rows[e.RowIndex].Cells["img"].Value;
            dtmodDN.Value =Convert.ToDateTime( dgvEmp.Rows[e.RowIndex].Cells["dateNaissance"].Value);
            
            txtmodIdEmp.Text = EmpID;
                txtModEmail.Text =email;
                txtmodAdresse.Text =adresse;
                txtmodMp.Text =passe;
                txtmodNom.Text =nom;
                txtmodPrenom.Text =prenom;
                txtmodsexe.Text =sexe;
                txtmodTel.Text =tel;
                txtmodtype.Text =type;
                txtmodUtilisateur.Text =utilisateur;
                MemoryStream ms = new MemoryStream(image);
                pbmodImg.Image = Image.FromStream(ms);

            if (txtmodIdEmp.Text != "")
            {
                btnSupprimer.Enabled = true;
            }

              }
        }

        private void btnModifierUtil_Click(object sender, EventArgs e)
        {
            grbEnr.Visible = false;
            grpbox.Visible = false;
            grpmodUtil.Visible = true;
        }

        private void grpmodUtil_Enter(object sender, EventArgs e)
        {

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want to Delete this Product\nfrom Database", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int ProductID = Convert.ToInt32(txtmodIdEmp.Text);

                EmployerDAO pdo = new EmployerDAO();
                pdo.RemoveEmpbyId(ProductID) ;
                Administrateur_Load(sender, e);


            }
        }

        private void btnModImg_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                imageLocation = opf.FileName;
                pbmodImg.ImageLocation = imageLocation;
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want to Update this Emp\n", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int ProductID = Convert.ToInt32(txtmodIdEmp.Text);
                MemoryStream ms = new MemoryStream();
                pbmodImg.Image.Save(ms, pbmodImg.Image.RawFormat);
                byte[] img = ms.ToArray();

                DateTime dtinsc = DateTime.Now;
                string d = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                DateTime auj2 = DateTime.Parse(d);

                EmployerDAO pdo = new EmployerDAO();
                pdo.Update(ProductID, txtmodNom.Text, txtmodPrenom.Text, txtmodsexe.Text, dtmodDN.Value, txtmodTel.Text, txtModEmail.Text, txtmodtype.Text, txtmodUtilisateur.Text, txtmodMp.Text, txtmodAdresse.Text, img, auj2);
                Administrateur_Load(sender, e);


            }
        }

  
    }
}
