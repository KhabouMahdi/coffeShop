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
using MySql.Data.MySqlClient;
using System.Globalization;





namespace coffeShop
{
    public partial class UserLogin : Form
    {
        public static string Separateur = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
        private bool mouseDown = false;
        private Point lastLocation;
        public UserLogin()
        {
            InitializeComponent();
            txtPw.AutoSize = false;
            this.txtPw.Size = new Size(160, 31);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void userLogin_Load(object sender, EventArgs e)
        {

        }

        private void lblClose_MouseEnter(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.White;
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.Black;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            /*MySqlConnection cnx;

            try
            {
                cnx = ConnexionCoffe.GetInstance();
                MySqlCommand cmd = new MySqlCommand("select * from tcompte where type=@type and nomUtilisateur='" + txtUserName.Text + "' and motPasse='" + txtPw.Text + "'", cnx);
                cmd.Parameters.Add("@type", "admin");//
                MySqlCommand cmd2 = new MySqlCommand("select * from tcompte where type=@type2 and nomUtilisateur='" + txtUserName.Text + "' and motPasse='" + txtPw.Text + "'", cnx);
                cmd2.Parameters.Add("@type2", "employer");//
                MySqlDataReader myReader;
                MySqlDataReader myReader2;

                myReader = cmd.ExecuteReader();
                //  myReader2 = cmd2.ExecuteReader();
                int count = 0;
                int count2 = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                }

                if (count == 1)
                {
                    myReader.Close();

                    //  MessageBox.Show("accepter \n ", "Attention");
                    //int user = Convert.ToInt32(txtUserName.Text);
                    EmployerDAO emee = new EmployerDAO();
                    Employer emp = emee.FindbyName(txtUserName.Text);
                //    this.Hide();
                    Administrateur f1 = new Administrateur(emp.Id);
                    f1.Show();
                  //  myReader.Close();

                }
                else
                {
                    lblverif.Visible = true;
                   myReader.Close();
                }
                myReader2 = cmd2.ExecuteReader();
                
              while (myReader2.Read())
                {
                    count2 = count2 + 1;
                }
                if (count2 == 1)
                {
                    lblverif.Visible = false;
                   // MessageBox.Show("accepter \n ", "Attention");
                    this.Hide();
                    Administrateur f1 = new Administrateur();
                    f1.Show();

                }
                else
                {
                    lblverif.Visible = true;
                }
                myReader2.Close();

                cnx.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Pb de la requete de l'ajout\n " + ex.Message, "Attention");
            }

            */

            EmployerDAO empd = new EmployerDAO() ;
            if (empd.Conadmin(txtUserName.Text, txtPw.Text) == true)
            {
                this.Hide();
                Administrateur emp = new Administrateur(empd.FindbyName(txtUserName.Text));
                emp.ShowDialog();
            }
            else
            {
                lblverif.Visible = true;            }





         /*   this.Hide();
            Administrateur f1 = new Administrateur();
            f1.Show();*/
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void pnlheader_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            pnlheader.Cursor = Cursors.Hand;
            lastLocation = e.Location;
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void pnlheader_MouseUp(object sender, MouseEventArgs e)
        {
           mouseDown = false;
            pnlheader.Cursor = Cursors.Default;
        }

        private void pnlheader_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                int newX = (this.Location.X - lastLocation.X) + e.X;
                int newY = (this.Location.Y - lastLocation.Y) + e.Y;
                this.Location = new Point(newX, newY);
            }
        }

        private void lblred_MouseEnter(object sender, EventArgs e)
        {
            lblred.ForeColor = Color.White;
        }

      

        private void lblred_MouseLeave(object sender, EventArgs e)
        {
            lblred.ForeColor = Color.Black;

        }

        private void pnlheader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
