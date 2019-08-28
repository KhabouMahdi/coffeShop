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
    public partial class TransactionDetaille : Form
    {
        int SaleID = 0;

        public TransactionDetaille(int SaleID)
        {
            InitializeComponent();
            this.SaleID = SaleID;

        }

        private void TransactionDetaille_Load(object sender, EventArgs e)
        {
            LigneTicketDAO lid = new LigneTicketDAO();

            foreach (LigneTicket SaleItemsDetails in lid.FindAllbyTicket(SaleID))
            {
                SaleItemsGridView.Rows.Add(SaleItemsDetails.NomProd, SaleItemsDetails.PrixProd, SaleItemsDetails.QteProd, SaleItemsDetails.TotalProd);
            }
        }
    }
}
