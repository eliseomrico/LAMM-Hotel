using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace LAMM_PMS
{
    public partial class guest_edit_info_form: UserControl
    {

        private main_menu topMenu;

        public guest_edit_info_form(main_menu topMenu, string guest_id, string guest_fname, string guest_lname, string guest_phone_number, string guest_balance, string guest_credit_card_no) 
        {
            this.topMenu = topMenu;
            InitializeComponent();
            populateGuestInfo(guest_id, guest_fname, guest_lname, guest_phone_number, guest_balance, guest_credit_card_no);
        }


        private void populateGuestInfo(string guest_id, string guest_fname, string guest_lname, string guest_phone_number, string guest_balance, string guest_credit_card_no)
        {
            guest_edit_info_form_textbox_guest_id.Text = guest_id;
            guest_edit_info_form_textbox_first_name.Text = guest_fname;
            guest_edit_info_form_textbox_last_name.Text = guest_lname;
            guest_edit_info_form_textbox_phone_number.Text = guest_phone_number;
            guest_edit_info_form_textbox_account_balance.Text = guest_balance;
            guest_edit_info_form_textbox_credit_card_field1.Text = guest_credit_card_no.Substring(0,4);
            guest_edit_info_form_textbox_credit_card_field2.Text = guest_credit_card_no.Substring(4, 4);
            guest_edit_info_form_textbox_credit_card_field3.Text = guest_credit_card_no.Substring(8, 4);
            guest_edit_info_form_textbox_credit_card_field4.Text = guest_credit_card_no.Substring(12, 4);



        }

        private void guest_edit_info_form_btn_cancel_Click(object sender, EventArgs e)
        {
            Panel parent = (Panel)Parent;
            parent.Controls.Clear();
            parent.Controls.Add(new guest_search_form(topMenu));
        }

        private void guest_edit_info_form_btn_edit_Click(object sender, EventArgs e)
        {
            guest_edit_info_form_textbox_first_name.ReadOnly = false;
            guest_edit_info_form_textbox_last_name.ReadOnly = false;
            guest_edit_info_form_textbox_phone_number.ReadOnly = false;
            guest_edit_info_form_textbox_account_balance.ReadOnly = false;
            guest_edit_info_form_textbox_credit_card_field1.ReadOnly = false;
            guest_edit_info_form_textbox_credit_card_field2.ReadOnly = false;
            guest_edit_info_form_textbox_credit_card_field3.ReadOnly = false;
            guest_edit_info_form_textbox_credit_card_field4.ReadOnly = false;

        }

        private void guest_edit_info_form_textbox_credit_card_field1_TextChanged(object sender, EventArgs e)
        {
            if(guest_edit_info_form_textbox_credit_card_field1.ReadOnly == false && guest_edit_info_form_textbox_credit_card_field1.Text.Length > 3)
            {
                GetNextControl(guest_edit_info_form_textbox_credit_card_field1, true).Focus();
            }
        }

        private void guest_edit_info_form_textbox_credit_card_field2_TextChanged(object sender, EventArgs e)
        {
            if (guest_edit_info_form_textbox_credit_card_field2.ReadOnly == false && guest_edit_info_form_textbox_credit_card_field2.Text.Length > 3)
            {
                GetNextControl(guest_edit_info_form_textbox_credit_card_field2, true).Focus();
            }
        }

        private void guest_edit_info_form_textbox_credit_card_field3_TextChanged(object sender, EventArgs e)
        {
            if (guest_edit_info_form_textbox_credit_card_field3.ReadOnly == false && guest_edit_info_form_textbox_credit_card_field3.Text.Length > 3)
            {
                GetNextControl(guest_edit_info_form_textbox_credit_card_field3, true).Focus();
            }
        }

        private void guest_edit_info_form_textbox_credit_card_field4_TextChanged(object sender, EventArgs e)
        {
            if (guest_edit_info_form_textbox_credit_card_field4.ReadOnly == false && guest_edit_info_form_textbox_credit_card_field4.Text.Length > 3)
            {
                GetNextControl(guest_edit_info_form_textbox_credit_card_field4, true).Focus();
            }
        }
    }
}
