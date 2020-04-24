namespace Management
{
    partial class ManageClientsForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.addclient = new System.Windows.Forms.Button();
            this.clearfields = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.addressrichtextbox = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.sexcombobox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dobdatepicker = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.email1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.phoneno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.firstname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.datagrid);
            this.panel1.Controls.Add(this.addclient);
            this.panel1.Controls.Add(this.clearfields);
            this.panel1.Controls.Add(this.edit);
            this.panel1.Controls.Add(this.remove);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.addressrichtextbox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.sexcombobox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dobdatepicker);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.email1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.phoneno);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lastname);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.firstname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.id);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-3, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1896, 802);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // datagrid
            // 
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(628, 130);
            this.datagrid.Margin = new System.Windows.Forms.Padding(4);
            this.datagrid.Name = "datagrid";
            this.datagrid.RowHeadersWidth = 51;
            this.datagrid.Size = new System.Drawing.Size(1264, 534);
            this.datagrid.TabIndex = 22;
            // 
            // addclient
            // 
            this.addclient.Location = new System.Drawing.Point(196, 743);
            this.addclient.Margin = new System.Windows.Forms.Padding(4);
            this.addclient.Name = "addclient";
            this.addclient.Size = new System.Drawing.Size(261, 36);
            this.addclient.TabIndex = 21;
            this.addclient.Text = "Add New Client";
            this.addclient.UseVisualStyleBackColor = true;
            this.addclient.Click += new System.EventHandler(this.addclient_Click);
            // 
            // clearfields
            // 
            this.clearfields.Location = new System.Drawing.Point(432, 687);
            this.clearfields.Margin = new System.Windows.Forms.Padding(4);
            this.clearfields.Name = "clearfields";
            this.clearfields.Size = new System.Drawing.Size(188, 36);
            this.clearfields.TabIndex = 20;
            this.clearfields.Text = "Clear Fields";
            this.clearfields.UseVisualStyleBackColor = true;
            this.clearfields.Click += new System.EventHandler(this.clearfields_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(237, 687);
            this.edit.Margin = new System.Windows.Forms.Padding(4);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(165, 36);
            this.edit.TabIndex = 19;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(19, 687);
            this.remove.Margin = new System.Windows.Forms.Padding(4);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(203, 36);
            this.remove.TabIndex = 18;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // addressrichtextbox
            // 
            this.addressrichtextbox.Location = new System.Drawing.Point(219, 546);
            this.addressrichtextbox.Margin = new System.Windows.Forms.Padding(4);
            this.addressrichtextbox.Name = "addressrichtextbox";
            this.addressrichtextbox.Size = new System.Drawing.Size(329, 117);
            this.addressrichtextbox.TabIndex = 16;
            this.addressrichtextbox.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(57, 550);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 31);
            this.label9.TabIndex = 15;
            this.label9.Text = "Address";
            // 
            // sexcombobox
            // 
            this.sexcombobox.FormattingEnabled = true;
            this.sexcombobox.Location = new System.Drawing.Point(219, 490);
            this.sexcombobox.Margin = new System.Windows.Forms.Padding(4);
            this.sexcombobox.Name = "sexcombobox";
            this.sexcombobox.Size = new System.Drawing.Size(331, 38);
            this.sexcombobox.TabIndex = 14;
            this.sexcombobox.SelectedIndexChanged += new System.EventHandler(this.sexcombobox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(57, 490);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 31);
            this.label8.TabIndex = 13;
            this.label8.Text = "Sex";
            // 
            // dobdatepicker
            // 
            this.dobdatepicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobdatepicker.Location = new System.Drawing.Point(219, 427);
            this.dobdatepicker.Margin = new System.Windows.Forms.Padding(4);
            this.dobdatepicker.Name = "dobdatepicker";
            this.dobdatepicker.Size = new System.Drawing.Size(329, 37);
            this.dobdatepicker.TabIndex = 12;
            this.dobdatepicker.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 0);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 37);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 433);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 31);
            this.label7.TabIndex = 10;
            this.label7.Text = "DOB";
            // 
            // email1
            // 
            this.email1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email1.Location = new System.Drawing.Point(220, 382);
            this.email1.Margin = new System.Windows.Forms.Padding(4);
            this.email1.Name = "email1";
            this.email1.Size = new System.Drawing.Size(329, 37);
            this.email1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 368);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 31);
            this.label6.TabIndex = 8;
            this.label6.Text = "Email";
            // 
            // phoneno
            // 
            this.phoneno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneno.Location = new System.Drawing.Point(219, 299);
            this.phoneno.Margin = new System.Windows.Forms.Padding(4);
            this.phoneno.Name = "phoneno";
            this.phoneno.Size = new System.Drawing.Size(329, 37);
            this.phoneno.TabIndex = 7;
            this.phoneno.TextChanged += new System.EventHandler(this.phoneno_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 303);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 31);
            this.label5.TabIndex = 6;
            this.label5.Text = "Phone #";
            // 
            // lastname
            // 
            this.lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname.Location = new System.Drawing.Point(220, 244);
            this.lastname.Margin = new System.Windows.Forms.Padding(4);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(329, 37);
            this.lastname.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "First Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // firstname
            // 
            this.firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname.Location = new System.Drawing.Point(219, 192);
            this.firstname.Margin = new System.Windows.Forms.Padding(4);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(329, 37);
            this.firstname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 244);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(220, 130);
            this.id.Margin = new System.Windows.Forms.Padding(4);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(329, 37);
            this.id.TabIndex = 1;
            this.id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1888, 123);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(645, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Clients";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ManageClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1896, 795);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageClientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Clients";
            this.Load += new System.EventHandler(this.ManageClientsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dobdatepicker;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox email1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox phoneno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox addressrichtextbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox sexcombobox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button addclient;
        private System.Windows.Forms.Button clearfields;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView datagrid;
    }
}