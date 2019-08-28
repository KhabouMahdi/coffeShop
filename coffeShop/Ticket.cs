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
using MySql.Data.MySqlClient;

namespace coffeShop
{
    public partial class Ticket : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adap;

        private string text;
        private string text2;
        private string text3;
        LigneTicketDAO l = new LigneTicketDAO();

        public Ticket()
        {
            InitializeComponent();

        }
        public Ticket(string text,string text2,string text3)
        {
            InitializeComponent();
            this.text = text;
            this.text2 = text2;

            this.text3 = text3;

          
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            //   List<LigneTicket> li = null;
            //  DataSet dst = null ;
            conn = ConnexionCoffe.GetInstance();
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from tligneticket where id=5";
            adap = new MySqlDataAdapter();
            adap.SelectCommand = cmd;
            DataSet custDB = new DataSet();
            custDB.Clear();
            adap.Fill(custDB, "cust");



           // CrystalReport1 myReport = new CrystalReport1();
          //  myReport.SetDataSource(custDB);
//crystalReportViewer1.ReportSource = myReport;
            CrystalReport1 op = new CrystalReport1();
           op.SetDataSource(custDB);
            op.SetParameterValue("ptotale", text);
            op.SetParameterValue("preg", text2);

            op.SetParameterValue("prendu", text3);

            crystalReportViewer1.ReportSource = op;
            crystalReportViewer1.Refresh();
        }

        private void CrystalReport11_InitReport(object sender, EventArgs e)
        {

        }

        
    }
}
