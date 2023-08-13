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
using Npgsql;
using System.Data;
using System.Configuration;

namespace LAMM_PMS
{
    public partial class guest_search_form : UserControl
    {

        // Variable to serve as reference to main menu
        private main_menu topMenu;
        private DataTable db_data;

        public guest_search_form(main_menu topMenu)
        {
            this.topMenu = topMenu;
            InitializeComponent();
        }

        private void guest_search_form_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
            guest_search_form_textbox_last_name.Focus();
            topMenu.changeMainMenuTitle("Guest Search");

        }

        private void PopulateDataGridView()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                // Create and execute an SQL query
                string sqlQuery = "SELECT * FROM Customer;";
                using (NpgsqlCommand command = new NpgsqlCommand(sqlQuery, connection))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        db_data = dataTable;

                        // Bind the DataTable to the DataGridView
                        guest_search_form_data_gridview.DataSource = dataTable;
                    }
                }

                connection.Close();
            }
        }
        private void guest_search_form_textbox_last_name_TextChanged(object sender, EventArgs e)
        {
            DataGridView dgv = guest_search_form_data_gridview;
            DataView dv = db_data.DefaultView;
            string last_name = guest_search_form_textbox_last_name.Text;


            if (!(last_name == " "))
            {
               
                dv.RowFilter = $"CUST_LNAME LIKE '{last_name}%'";
                dv.Sort = "CUST_ID ASC";
                dgv.DataSource = dv.ToTable();
            }
            else
            {
                dgv.DataSource = db_data;
            }

        }

        private void guest_search_form_btn_manage_guests_Click(object sender, EventArgs e)
        {
            // Fetch last customer id and add 1 to it to get new customer id.
            DataRow lastRow = db_data.Rows[db_data.Rows.Count - 1];
            int new_cust_id = ((int) lastRow["cust_id"]) + 1;

            Panel parent = (Panel)Parent;
            parent.Controls.Clear();
            parent.Controls.Add(new guest_add_form(topMenu,new_cust_id));


        }

        private void guest_search_form_data_gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = guest_search_form_data_gridview.CurrentRow;

            string guest_id = selectedRow.Cells["cust_id"].Value.ToString();
            string guest_fname = selectedRow.Cells["cust_fname"].Value.ToString();
            string guest_lname = selectedRow.Cells["cust_lname"].Value.ToString();
            string guest_phone_number = selectedRow.Cells["cust_phone"].Value.ToString();
            string guest_balance = selectedRow.Cells["cust_balance"].Value.ToString();
            string guest_credit_card_no = selectedRow.Cells["cust_credit_card_no"].Value.ToString();

            Panel parent = (Panel)Parent;
            parent.Controls.Clear();
            parent.Controls.Add(new guest_edit_info_form(topMenu,guest_id, guest_fname, guest_lname, guest_phone_number, guest_balance, guest_credit_card_no));
        }
    }
}
