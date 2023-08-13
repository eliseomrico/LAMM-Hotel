namespace LAMM_PMS
{
    partial class guest_search_form
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guest_search_form_panel_main = new System.Windows.Forms.Panel();
            this.guest_search_form_textbox_last_name = new System.Windows.Forms.TextBox();
            this.guest_search_form_btn_manage_guests = new System.Windows.Forms.Button();
            this.guest_search_form_data_gridview = new System.Windows.Forms.DataGridView();
            this.guest_search_form_label_last_name = new System.Windows.Forms.Label();
            this.guest_search_form_label_title = new System.Windows.Forms.Label();
            this.guest_search_form_panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guest_search_form_data_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // guest_search_form_panel_main
            // 
            this.guest_search_form_panel_main.BackColor = System.Drawing.Color.White;
            this.guest_search_form_panel_main.Controls.Add(this.guest_search_form_textbox_last_name);
            this.guest_search_form_panel_main.Controls.Add(this.guest_search_form_btn_manage_guests);
            this.guest_search_form_panel_main.Controls.Add(this.guest_search_form_data_gridview);
            this.guest_search_form_panel_main.Controls.Add(this.guest_search_form_label_last_name);
            this.guest_search_form_panel_main.Controls.Add(this.guest_search_form_label_title);
            this.guest_search_form_panel_main.Location = new System.Drawing.Point(0, 0);
            this.guest_search_form_panel_main.Margin = new System.Windows.Forms.Padding(4);
            this.guest_search_form_panel_main.Name = "guest_search_form_panel_main";
            this.guest_search_form_panel_main.Size = new System.Drawing.Size(1592, 1175);
            this.guest_search_form_panel_main.TabIndex = 24;
            // 
            // guest_search_form_textbox_last_name
            // 
            this.guest_search_form_textbox_last_name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guest_search_form_textbox_last_name.Location = new System.Drawing.Point(698, 133);
            this.guest_search_form_textbox_last_name.Margin = new System.Windows.Forms.Padding(4);
            this.guest_search_form_textbox_last_name.Name = "guest_search_form_textbox_last_name";
            this.guest_search_form_textbox_last_name.Size = new System.Drawing.Size(338, 39);
            this.guest_search_form_textbox_last_name.TabIndex = 27;
            this.guest_search_form_textbox_last_name.TextChanged += new System.EventHandler(this.guest_search_form_textbox_last_name_TextChanged);
            // 
            // guest_search_form_btn_manage_guests
            // 
            this.guest_search_form_btn_manage_guests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.guest_search_form_btn_manage_guests.FlatAppearance.BorderSize = 0;
            this.guest_search_form_btn_manage_guests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guest_search_form_btn_manage_guests.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guest_search_form_btn_manage_guests.ForeColor = System.Drawing.Color.White;
            this.guest_search_form_btn_manage_guests.Location = new System.Drawing.Point(570, 223);
            this.guest_search_form_btn_manage_guests.Margin = new System.Windows.Forms.Padding(4);
            this.guest_search_form_btn_manage_guests.Name = "guest_search_form_btn_manage_guests";
            this.guest_search_form_btn_manage_guests.Size = new System.Drawing.Size(520, 69);
            this.guest_search_form_btn_manage_guests.TabIndex = 26;
            this.guest_search_form_btn_manage_guests.Text = "Add a Guest";
            this.guest_search_form_btn_manage_guests.UseVisualStyleBackColor = false;
            this.guest_search_form_btn_manage_guests.Click += new System.EventHandler(this.guest_search_form_btn_manage_guests_Click);
            // 
            // guest_search_form_data_gridview
            // 
            this.guest_search_form_data_gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guest_search_form_data_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guest_search_form_data_gridview.Location = new System.Drawing.Point(0, 321);
            this.guest_search_form_data_gridview.Margin = new System.Windows.Forms.Padding(4);
            this.guest_search_form_data_gridview.MultiSelect = false;
            this.guest_search_form_data_gridview.Name = "guest_search_form_data_gridview";
            this.guest_search_form_data_gridview.ReadOnly = true;
            this.guest_search_form_data_gridview.RowHeadersWidth = 51;
            this.guest_search_form_data_gridview.RowTemplate.Height = 24;
            this.guest_search_form_data_gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guest_search_form_data_gridview.Size = new System.Drawing.Size(1592, 508);
            this.guest_search_form_data_gridview.TabIndex = 15;
            this.guest_search_form_data_gridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guest_search_form_data_gridview_CellContentClick);
            // 
            // guest_search_form_label_last_name
            // 
            this.guest_search_form_label_last_name.AutoSize = true;
            this.guest_search_form_label_last_name.BackColor = System.Drawing.Color.White;
            this.guest_search_form_label_last_name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guest_search_form_label_last_name.Location = new System.Drawing.Point(564, 138);
            this.guest_search_form_label_last_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.guest_search_form_label_last_name.Name = "guest_search_form_label_last_name";
            this.guest_search_form_label_last_name.Size = new System.Drawing.Size(126, 32);
            this.guest_search_form_label_last_name.TabIndex = 0;
            this.guest_search_form_label_last_name.Text = "Last Name";
            // 
            // guest_search_form_label_title
            // 
            this.guest_search_form_label_title.AutoSize = true;
            this.guest_search_form_label_title.BackColor = System.Drawing.Color.White;
            this.guest_search_form_label_title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guest_search_form_label_title.Location = new System.Drawing.Point(690, 56);
            this.guest_search_form_label_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.guest_search_form_label_title.Name = "guest_search_form_label_title";
            this.guest_search_form_label_title.Size = new System.Drawing.Size(205, 45);
            this.guest_search_form_label_title.TabIndex = 14;
            this.guest_search_form_label_title.Text = "Guest Search";
            // 
            // guest_search_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guest_search_form_panel_main);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "guest_search_form";
            this.Size = new System.Drawing.Size(1592, 1175);
            this.Load += new System.EventHandler(this.guest_search_form_Load);
            this.guest_search_form_panel_main.ResumeLayout(false);
            this.guest_search_form_panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guest_search_form_data_gridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel guest_search_form_panel_main;
        private System.Windows.Forms.Button guest_search_form_btn_manage_guests;
        private System.Windows.Forms.DataGridView guest_search_form_data_gridview;
        private System.Windows.Forms.Label guest_search_form_label_last_name;
        private System.Windows.Forms.Label guest_search_form_label_title;
        private System.Windows.Forms.TextBox guest_search_form_textbox_last_name;
    }
}
