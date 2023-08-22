using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace LAMM_PMS
{
    public partial class guest_add_form: UserControl
    {

        private main_menu topMenu;

        public guest_add_form(main_menu topMenu, int new_guest_id)
        {
            this.topMenu = topMenu;

            InitializeComponent();
            guest_add_form_textbox_guest_id.Text = new_guest_id.ToString();
        }

        private void guest_add_form_Load(object sender, EventArgs e)
        {
            guest_add_form_textbox_first_name.Focus();
            topMenu.changeMainMenuTitle("Add a Guest");
        }

        private void guest_add_form_btn_cancel_Click(object sender, EventArgs e)
        {
            Panel parent = (Panel) Parent;
            parent.Controls.Clear();
            parent.Controls.Add(new guest_search_form(topMenu));
        }

        private void guest_add_form_textbox_credit_card_field1_TextChanged(object sender, EventArgs e)
        {
            if (this.guest_add_form_textbox_credit_card_field1.Text.Length > 3)
            {
                GetNextControl(this.guest_add_form_textbox_credit_card_field1, true).Focus();
            }
        }

        private void guest_add_form_textbox_credit_card_field2_TextChanged(object sender, EventArgs e)
        {
            if (this.guest_add_form_textbox_credit_card_field2.Text.Length > 3)
            {
                GetNextControl(this.guest_add_form_textbox_credit_card_field2, true).Focus();
            }
        }

        private void guest_add_form_textbox_credit_card_field3_TextChanged(object sender, EventArgs e)
        {
            if (this.guest_add_form_textbox_credit_card_field3.Text.Length > 3)
            {
                GetNextControl(this.guest_add_form_textbox_credit_card_field3, true).Focus();
            }
        }

        private void guest_add_form_textbox_credit_card_field4_TextChanged(object sender, EventArgs e)
        {
            if (this.guest_add_form_textbox_credit_card_field4.Text.Length > 3)
            {
                GetNextControl(this.guest_add_form_textbox_credit_card_field4, true).Focus();
            }
        }

        private void guest_add_form_btn_add_guest_Click(object sender, EventArgs e)
        {
            string guest_first_name = guest_add_form_textbox_first_name.Text;
            string guest_last_name = guest_add_form_textbox_last_name.Text;
            string guest_phone_number = guest_add_form_textbox_phone_number.Text;
            int guest_account_balance = Int32.Parse(guest_add_form_textbox_account_balance.Text);
            string guest_credit_card_no = guest_add_form_textbox_credit_card_field1.Text +
                                          guest_add_form_textbox_credit_card_field2.Text +
                                          guest_add_form_textbox_credit_card_field3.Text +
                                          guest_add_form_textbox_credit_card_field4.Text;


            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO CUSTOMER (cust_fname, cust_lname, cust_phone, cust_balance, cust_credit_card_no) VALUES (@first_name, @last_name,@phone_number,@account_balance,@credit_card_number)";
                    using (NpgsqlCommand command = new NpgsqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@first_name", guest_first_name);
                        command.Parameters.AddWithValue("@last_name", guest_last_name);
                        command.Parameters.AddWithValue("@phone_number", guest_phone_number);
                        command.Parameters.AddWithValue("@account_balance", guest_account_balance);
                        command.Parameters.AddWithValue("@credit_card_number", guest_credit_card_no);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data inserted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No rows were affected.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }

                Panel parent = (Panel)Parent;
                parent.Controls.Clear();
                parent.Controls.Add(new guest_search_form(topMenu));

            }

        }
       
        
        
        /*
        // Credit Card Auto-Tab Fields
        private void textBox_cc_part1_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void textBox_cc_part2_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox_cc_part2.Text.Length > 3)
            {
                GetNextControl(this.textBox_cc_part2, true).Focus();
            }
        }
        private void textBox_cc_part3_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox_cc_part3.Text.Length > 3)
            {
                GetNextControl(this.textBox_cc_part3, true).Focus();
            }
        }
        private void textBox_cc_part4_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox_cc_part4.Text.Length > 3)
            {
                GetNextControl(this.textBox_cc_part4, true).Focus();
            }
        }
        */
    }
}
