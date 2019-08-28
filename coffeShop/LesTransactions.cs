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
namespace coffeShop
{
    public partial class LesTransactions : Form
    {
        public LesTransactions()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Produit")
                {
                    int SaleID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);

                    TransactionDetaille _ViewSaleItems = new TransactionDetaille(SaleID);

                    _ViewSaleItems.ShowDialog();
                }
            }
        }

        private void LesTransactions_Load(object sender, EventArgs e)
        {
            TicketDAO td = new TicketDAO();
            foreach (metiers.Ticket SaleDetails in td.FindAll())
            {
                
                dataGridView1.Rows.Add(SaleDetails.Id, SaleDetails.DateTicket, SaleDetails.IdEmploye.NomUtilisateur, SaleDetails.Total, "View Products");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
