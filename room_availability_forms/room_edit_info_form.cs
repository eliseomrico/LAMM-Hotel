using LAMM_PMS.employee_forms;
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

namespace LAMM_PMS
{
    public partial class room_edit_info_form : UserControl
    {
        private main_menu topMenu;
        public room_edit_info_form(main_menu topMenu)
        {
            this.topMenu = topMenu;
            InitializeComponent();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Panel parent = (Panel)Parent;
            parent.Controls.Clear();
            parent.Controls.Add(new reservation_search_form(topMenu));
            this.Dispose();
        }
    }
}
