using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMultiRetorno
{
    public partial class exec03 : Form
    {
        public exec03()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void exec03_Load(object sender, EventArgs e)
        {

        }
        public static SqlConnection Connection { get; set; } = new SqlConnection("Data Source=BUE205D60;Initial" +
" Catalog=BDmanhã;Persist Security Info=True;User ID=guest01;Password=@Senac2021");

        /// <summary>
        /// This function returns all elements selected in the table, the table already inclube dbo.
        /// </summary>
        /// <param name="table"></param>
        /// <param name="element"></param>
        /// <returns>List(string) allSelectElements</returns>
        public static List<string> GenericUnitSelect(string element, string table)
        {
            List<string> returnElements = new List<string>();

            string select = $"SELECT {element} from dbo.{table}";
            SqlCommand cmd = new SqlCommand(select, Connection);
            Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                returnElements.Add(dr[0].ToString());
            }
            dr.Close();
            Connection.Close();
            return returnElements;
        }

        /// <summary>
        /// Select all values from all elements from given Table, already have dbo. before table
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public static List<string[]> GenericSelectAll(string table)
        {
            List<string[]> lista = new List<string[]>();
            string select = $"SELECT * from dbo.{table}";
            SqlCommand cmd = new SqlCommand(select,Connection);
            Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string[] vetor = new string[dr.FieldCount];
                for (int i = 0; i < vetor.Length; i++)
                {
                    vetor[i] = dr[i].ToString();
                }
                lista.Add(vetor);
            }
            dr.Close();
            Connection.Close();
            return lista;
        }
        private void AtualizaDG()
        {
            List<string[]> lista = DBFunction
        }
    }
}
