
namespace Senudin_app
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_cm = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_oil_paper = new System.Windows.Forms.Button();
            this.panel_cm = new System.Windows.Forms.Panel();
            this.button_print = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_save = new System.Windows.Forms.Button();
            this.dateTimePicker_expire = new System.Windows.Forms.DateTimePicker();
            this.textBox_quantity_product = new System.Windows.Forms.TextBox();
            this.textBox_name_product = new System.Windows.Forms.TextBox();
            this.textBox_EAN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_oil_paper = new System.Windows.Forms.Panel();
            this.button_display_data = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView_oil_paper = new System.Windows.Forms.DataGridView();
            this.textBox_oil_quantity = new System.Windows.Forms.TextBox();
            this.textBox_naylon_quantity = new System.Windows.Forms.TextBox();
            this.textBox_paper_quantity = new System.Windows.Forms.TextBox();
            this.dateTimePicker_oil_paper = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.senudinappDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.senudin_appDataSet = new Senudin_app.Senudin_appDataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_cm.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel_oil_paper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_oil_paper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.senudinappDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.senudin_appDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(779, 303);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 182);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(380, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to Senudin\'s app";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(85, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose your action:";
            // 
            // button_cm
            // 
            this.button_cm.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_cm.Location = new System.Drawing.Point(87, 191);
            this.button_cm.Name = "button_cm";
            this.button_cm.Size = new System.Drawing.Size(75, 23);
            this.button_cm.TabIndex = 3;
            this.button_cm.Text = "Submit";
            this.button_cm.UseVisualStyleBackColor = false;
            this.button_cm.Click += new System.EventHandler(this.button_cm_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter date for CM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Enter data for oil and paper";
            // 
            // button_oil_paper
            // 
            this.button_oil_paper.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_oil_paper.Location = new System.Drawing.Point(221, 191);
            this.button_oil_paper.Name = "button_oil_paper";
            this.button_oil_paper.Size = new System.Drawing.Size(75, 23);
            this.button_oil_paper.TabIndex = 6;
            this.button_oil_paper.Text = "Submit";
            this.button_oil_paper.UseVisualStyleBackColor = false;
            this.button_oil_paper.Click += new System.EventHandler(this.button_oil_paper_Click);
            // 
            // panel_cm
            // 
            this.panel_cm.AutoSize = true;
            this.panel_cm.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel_cm.Controls.Add(this.button_print);
            this.panel_cm.Controls.Add(this.listView1);
            this.panel_cm.Controls.Add(this.button_save);
            this.panel_cm.Controls.Add(this.dateTimePicker_expire);
            this.panel_cm.Controls.Add(this.textBox_quantity_product);
            this.panel_cm.Controls.Add(this.textBox_name_product);
            this.panel_cm.Controls.Add(this.textBox_EAN);
            this.panel_cm.Controls.Add(this.label8);
            this.panel_cm.Controls.Add(this.label7);
            this.panel_cm.Controls.Add(this.label6);
            this.panel_cm.Controls.Add(this.label5);
            this.panel_cm.Location = new System.Drawing.Point(87, 247);
            this.panel_cm.Name = "panel_cm";
            this.panel_cm.Size = new System.Drawing.Size(654, 312);
            this.panel_cm.TabIndex = 7;
            this.panel_cm.Visible = false;
            // 
            // button_print
            // 
            this.button_print.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_print.Location = new System.Drawing.Point(515, 273);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(75, 23);
            this.button_print.TabIndex = 10;
            this.button_print.Text = "Print";
            this.button_print.UseVisualStyleBackColor = false;
            this.button_print.Click += new System.EventHandler(this.button_print_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(38, 103);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(552, 159);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "EAN";
            this.columnHeader2.Width = 97;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name of product";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date of expire";
            this.columnHeader4.Width = 134;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Quantity of product";
            this.columnHeader5.Width = 228;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteItemToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 26);
            // 
            // deleteItemToolStripMenuItem
            // 
            this.deleteItemToolStripMenuItem.Name = "deleteItemToolStripMenuItem";
            this.deleteItemToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.deleteItemToolStripMenuItem.Text = "Delete item";
            this.deleteItemToolStripMenuItem.Click += new System.EventHandler(this.deleteItemToolStripMenuItem_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(515, 67);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 8;
            this.button_save.Text = "Submit";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // dateTimePicker_expire
            // 
            this.dateTimePicker_expire.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_expire.Location = new System.Drawing.Point(296, 66);
            this.dateTimePicker_expire.Name = "dateTimePicker_expire";
            this.dateTimePicker_expire.Size = new System.Drawing.Size(97, 20);
            this.dateTimePicker_expire.TabIndex = 7;
            this.dateTimePicker_expire.Value = new System.DateTime(2022, 6, 20, 0, 0, 0, 0);
            // 
            // textBox_quantity_product
            // 
            this.textBox_quantity_product.Location = new System.Drawing.Point(415, 67);
            this.textBox_quantity_product.Name = "textBox_quantity_product";
            this.textBox_quantity_product.Size = new System.Drawing.Size(94, 20);
            this.textBox_quantity_product.TabIndex = 6;
            // 
            // textBox_name_product
            // 
            this.textBox_name_product.Location = new System.Drawing.Point(162, 67);
            this.textBox_name_product.Name = "textBox_name_product";
            this.textBox_name_product.Size = new System.Drawing.Size(92, 20);
            this.textBox_name_product.TabIndex = 5;
            // 
            // textBox_EAN
            // 
            this.textBox_EAN.Location = new System.Drawing.Point(38, 67);
            this.textBox_EAN.Name = "textBox_EAN";
            this.textBox_EAN.Size = new System.Drawing.Size(92, 20);
            this.textBox_EAN.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(412, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Quantity of product";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Date of expire";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Name of product";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "EAN";
            // 
            // panel_oil_paper
            // 
            this.panel_oil_paper.AutoSize = true;
            this.panel_oil_paper.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel_oil_paper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_oil_paper.Controls.Add(this.button_display_data);
            this.panel_oil_paper.Controls.Add(this.button1);
            this.panel_oil_paper.Controls.Add(this.dataGridView_oil_paper);
            this.panel_oil_paper.Controls.Add(this.textBox_oil_quantity);
            this.panel_oil_paper.Controls.Add(this.textBox_naylon_quantity);
            this.panel_oil_paper.Controls.Add(this.textBox_paper_quantity);
            this.panel_oil_paper.Controls.Add(this.dateTimePicker_oil_paper);
            this.panel_oil_paper.Controls.Add(this.label12);
            this.panel_oil_paper.Controls.Add(this.label11);
            this.panel_oil_paper.Controls.Add(this.label10);
            this.panel_oil_paper.Controls.Add(this.label9);
            this.panel_oil_paper.Location = new System.Drawing.Point(87, 247);
            this.panel_oil_paper.Name = "panel_oil_paper";
            this.panel_oil_paper.Size = new System.Drawing.Size(654, 312);
            this.panel_oil_paper.TabIndex = 8;
            this.panel_oil_paper.Visible = false;
            // 
            // button_display_data
            // 
            this.button_display_data.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_display_data.Location = new System.Drawing.Point(539, 267);
            this.button_display_data.Name = "button_display_data";
            this.button_display_data.Size = new System.Drawing.Size(75, 23);
            this.button_display_data.TabIndex = 10;
            this.button_display_data.Text = "Display data";
            this.button_display_data.UseVisualStyleBackColor = false;
            this.button_display_data.Click += new System.EventHandler(this.button_display_data_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(539, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView_oil_paper
            // 
            this.dataGridView_oil_paper.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_oil_paper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_oil_paper.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView_oil_paper.Location = new System.Drawing.Point(45, 107);
            this.dataGridView_oil_paper.Name = "dataGridView_oil_paper";
            this.dataGridView_oil_paper.Size = new System.Drawing.Size(569, 141);
            this.dataGridView_oil_paper.TabIndex = 8;
            // 
            // textBox_oil_quantity
            // 
            this.textBox_oil_quantity.Location = new System.Drawing.Point(413, 65);
            this.textBox_oil_quantity.Name = "textBox_oil_quantity";
            this.textBox_oil_quantity.Size = new System.Drawing.Size(100, 20);
            this.textBox_oil_quantity.TabIndex = 7;
            // 
            // textBox_naylon_quantity
            // 
            this.textBox_naylon_quantity.Location = new System.Drawing.Point(295, 65);
            this.textBox_naylon_quantity.Name = "textBox_naylon_quantity";
            this.textBox_naylon_quantity.Size = new System.Drawing.Size(100, 20);
            this.textBox_naylon_quantity.TabIndex = 6;
            // 
            // textBox_paper_quantity
            // 
            this.textBox_paper_quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_paper_quantity.Location = new System.Drawing.Point(171, 66);
            this.textBox_paper_quantity.Name = "textBox_paper_quantity";
            this.textBox_paper_quantity.Size = new System.Drawing.Size(100, 20);
            this.textBox_paper_quantity.TabIndex = 5;
            // 
            // dateTimePicker_oil_paper
            // 
            this.dateTimePicker_oil_paper.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_oil_paper.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_oil_paper.Location = new System.Drawing.Point(45, 66);
            this.dateTimePicker_oil_paper.Name = "dateTimePicker_oil_paper";
            this.dateTimePicker_oil_paper.Size = new System.Drawing.Size(98, 20);
            this.dateTimePicker_oil_paper.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(168, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Paper quantity";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(292, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Naylon quantity";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(410, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Oil quantity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Date";
            // 
            // senudinappDataSetBindingSource
            // 
            this.senudinappDataSetBindingSource.DataSource = this.senudin_appDataSet;
            this.senudinappDataSetBindingSource.Position = 0;
            // 
            // senudin_appDataSet
            // 
            this.senudin_appDataSet.DataSetName = "Senudin_appDataSet";
            this.senudin_appDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.Items.AddRange(new object[] {
            "Monthly report on oil and paper",
            "Reports on CM"});
            this.comboBox1.Location = new System.Drawing.Point(398, 191);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(398, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Select data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(992, 578);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_oil_paper);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_cm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel_oil_paper);
            this.Controls.Add(this.panel_cm);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "+";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_cm.ResumeLayout(false);
            this.panel_cm.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel_oil_paper.ResumeLayout(false);
            this.panel_oil_paper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_oil_paper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.senudinappDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.senudin_appDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_cm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_oil_paper;
        private System.Windows.Forms.Panel panel_cm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker_expire;
        private System.Windows.Forms.TextBox textBox_quantity_product;
        private System.Windows.Forms.TextBox textBox_name_product;
        private System.Windows.Forms.TextBox textBox_EAN;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button_print;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteItemToolStripMenuItem;
        private System.Windows.Forms.Panel panel_oil_paper;
        private System.Windows.Forms.DataGridView dataGridView_oil_paper;
        private System.Windows.Forms.BindingSource senudinappDataSetBindingSource;
        private Senudin_appDataSet senudin_appDataSet;
        private System.Windows.Forms.TextBox textBox_oil_quantity;
        private System.Windows.Forms.TextBox textBox_naylon_quantity;
        private System.Windows.Forms.TextBox textBox_paper_quantity;
        private System.Windows.Forms.DateTimePicker dateTimePicker_oil_paper;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_display_data;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label13;
    }
}

