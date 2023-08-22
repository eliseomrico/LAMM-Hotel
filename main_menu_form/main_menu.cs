using LAMM_PMS.employee_forms;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LAMM_PMS
{
    public partial class main_menu : Form
    {

        public main_menu main_menu_instance;

        // Initialize variable for the button that is currently selected
        private Button selectedButton;

        // Initialize back color variables for all buttons
        private Color originalColor = Color.FromArgb(23, 53, 53);
        private Color selectedColor = Color.FromName("OliveDrab");
        

        public main_menu()
        {
            InitializeComponent();
            selectedButton = main_menu_btn_home;
        }

        public void changeMainMenuTitle(string title)
        {
            this.Text = "LAAM PMS - " + title;
        }

        // Helper Methods
        private void resetButtonColor()
        {

            // Purpose: This method reverts the back color of the currently selected button stored in the selectedButton
            //          variable back to its original color. It is used when the selected button is changed via a user's click. 

            selectedButton.BackColor = originalColor;
        }
        private void clearMainPanelControls()
        {

            // Purpose: This method clears all of the controls of the main panel area in the main_menu_form.
            //          It is used to prepare the main panel area to receive a new set of controls (e.g. a new form)

            main_menu_panel_content_area.Controls.Clear();

        }
        private void setButtonColorToSelectedColor(Button button)
        {
            resetButtonColor();
            button.BackColor = selectedColor;
            selectedButton = button;
        }
        private void setMainContentAreaVisible(bool visible)
        {
            main_menu_panel_content_area.Visible = visible;
        }
        private void addFormToMainContentArea(UserControl form)
        {
            main_menu_panel_content_area.Controls.Add(form);
        }

        public void resetForm()
        {
            setButtonColorToSelectedColor((Button)main_menu_btn_home);
            setMainContentAreaVisible(false);
            clearMainPanelControls();
            changeMainMenuTitle("Main Menu");
        }

        // Button Methods
        private void main_menu_btn_home_Click(object sender, EventArgs e)
        {
            setButtonColorToSelectedColor((Button)sender);
            setMainContentAreaVisible(false);
            clearMainPanelControls();
            changeMainMenuTitle("Main Menu");
        }

        // Reservations Form
        private void main_menu_btn_reservations_Click(object sender, EventArgs e)
        {
            setButtonColorToSelectedColor((Button)sender);
            clearMainPanelControls();
            addFormToMainContentArea(new reservation_search_form(this));
            setMainContentAreaVisible(true);
        }

        // Rooms Form
        private void main_menu_btn_room_availability_Click(object sender, EventArgs e)
        {
            setButtonColorToSelectedColor((Button)sender);
            clearMainPanelControls();
            addFormToMainContentArea(new room_search_form(this));
            setMainContentAreaVisible(true);
        }

        // Guests Form
        private void main_menu_btn_guests_Click(object sender, EventArgs e)
        {
            setButtonColorToSelectedColor((Button)sender);
            clearMainPanelControls();
            addFormToMainContentArea(new guest_search_form(this));
            setMainContentAreaVisible(true);
        }

        // Check In Form
        private void main_menu_btn_check_in_Click(object sender, EventArgs e)
        {
            setButtonColorToSelectedColor((Button)sender);
            clearMainPanelControls();
            addFormToMainContentArea(new check_in_form(this));
            setMainContentAreaVisible(true);
        }

        // Check Out Form
        private void main_menu_btn_check_out_Click(object sender, EventArgs e)
        {
            setButtonColorToSelectedColor((Button)sender);
            clearMainPanelControls();
            addFormToMainContentArea(new check_out_form(this));
            setMainContentAreaVisible(true);
        }

        // Admin Dropdown (?)
        private void main_menu_btn_administrator_Click(object sender, EventArgs e)
        {
            setButtonColorToSelectedColor((Button)sender);
        }

        // Employees Form
        private void main_menu_btn_employees_Click(object sender, EventArgs e)
        {
            setButtonColorToSelectedColor((Button)sender);
            clearMainPanelControls();
            addFormToMainContentArea(new employee_search_form(this));
            setMainContentAreaVisible(true);
        }

        // Locations Form
        private void main_menu_button_locations_Click(object sender, EventArgs e)
        {
            setButtonColorToSelectedColor((Button)sender);
            clearMainPanelControls();
            addFormToMainContentArea(new location_search_form(this));
            setMainContentAreaVisible(true);
        }

        // Transactions Form
        private void main_menu_button_transactions_Click(object sender, EventArgs e)
        {
            setButtonColorToSelectedColor((Button)sender);
            clearMainPanelControls();
            addFormToMainContentArea(new transactions_form(this));
            setMainContentAreaVisible(true);
        }
    }
}