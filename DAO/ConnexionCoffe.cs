using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace DAO
{
   public class ConnexionCoffe
    {
        static String chaineCnx = "SERVER=127.0.0.1; DATABASE=bdsalondethe; uid=root; password=;";
        static MySqlConnection cnx = new MySqlConnection(chaineCnx);
        public static MySqlConnection GetInstance()
        {
            try
            {
                if (cnx.State != System.Data.ConnectionState.Open)
                    cnx.Open();
            }
            catch (Exception ex) { MessageBox.Show("salondethe : Pb de connexion\n " + ex.Message); }

            return cnx;
        }

        public void Close()
        {
            cnx.Close();

        }
    }
}
