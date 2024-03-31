namespace Location_Voiture
{
    partial class Voitures
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Voitures));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            label6 = new Label();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            numeroDeSerie_tb = new TextBox();
            label4 = new Label();
            marque_cb = new ComboBox();
            label5 = new Label();
            modele_tb = new TextBox();
            couleur_cb = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            supprimer_bt = new Button();
            modifier_bt = new Button();
            enregistrer_bt = new Button();
            label9 = new Label();
            pictureBox5 = new PictureBox();
            label10 = new Label();
            Voitures_list = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            label11 = new Label();
            descriptionFr_cb = new ComboBox();
            label12 = new Label();
            label13 = new Label();
            dateAchat_dtp = new Guna.UI2.WinForms.Guna2DateTimePicker();
            dateRevision_dtp = new Guna.UI2.WinForms.Guna2DateTimePicker();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Voitures_list).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1279, 30);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(374, 0);
            label6.Name = "label6";
            label6.Size = new Size(513, 26);
            label6.TabIndex = 5;
            label6.Text = "Application de Gestion de Location Automobile";
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(479, 46);
            label1.Name = "label1";
            label1.Size = new Size(272, 28);
            label1.TabIndex = 1;
            label1.Text = "Gestion Des Vehicules";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 876);
            panel2.Name = "panel2";
            panel2.Size = new Size(1279, 30);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(374, 0);
            label2.Name = "label2";
            label2.Size = new Size(221, 20);
            label2.TabIndex = 5;
            label2.Text = "Developed by Arlette and ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(12, 113);
            label3.Name = "label3";
            label3.Size = new Size(13, 20);
            label3.TabIndex = 9;
            label3.Text = " ";
            label3.Click += label3_Click;
            // 
            // numeroDeSerie_tb
            // 
            numeroDeSerie_tb.Location = new Point(12, 136);
            numeroDeSerie_tb.Name = "numeroDeSerie_tb";
            numeroDeSerie_tb.Size = new Size(163, 31);
            numeroDeSerie_tb.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(211, 113);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 10;
            label4.Text = "Marque";
            label4.Click += label4_Click;
            // 
            // marque_cb
            // 
            marque_cb.FormattingEnabled = true;
            marque_cb.Items.AddRange(new object[] { "Audi", "BMW", "Ford", "Honda", "Mercedes", "Nissan", "Toyota", "Volkswagen", "Volvo", "Tesla" });
            marque_cb.Location = new Point(211, 136);
            marque_cb.Name = "marque_cb";
            marque_cb.Size = new Size(151, 31);
            marque_cb.TabIndex = 11;
            marque_cb.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Crimson;
            label5.Location = new Point(397, 113);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 12;
            label5.Text = "Modele";
            // 
            // modele_tb
            // 
            modele_tb.Location = new Point(397, 136);
            modele_tb.Name = "modele_tb";
            modele_tb.Size = new Size(152, 31);
            modele_tb.TabIndex = 13;
            modele_tb.TextChanged += textBox2_TextChanged;
            // 
            // couleur_cb
            // 
            couleur_cb.FormattingEnabled = true;
            couleur_cb.Items.AddRange(new object[] { "Rouge", "Noire", "Blanche", "Blueue", "Jaune", "Grise" });
            couleur_cb.Location = new Point(581, 136);
            couleur_cb.Name = "couleur_cb";
            couleur_cb.Size = new Size(125, 31);
            couleur_cb.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Crimson;
            label7.Location = new Point(581, 113);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 16;
            label7.Text = "Couleur";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Crimson;
            label8.Location = new Point(740, 113);
            label8.Name = "label8";
            label8.Size = new Size(115, 20);
            label8.TabIndex = 18;
            label8.Text = "Date d'Achat";
            // 
            // supprimer_bt
            // 
            supprimer_bt.BackColor = Color.Teal;
            supprimer_bt.ForeColor = Color.White;
            supprimer_bt.Location = new Point(864, 201);
            supprimer_bt.Name = "supprimer_bt";
            supprimer_bt.Size = new Size(220, 42);
            supprimer_bt.TabIndex = 20;
            supprimer_bt.Text = "Supprimer";
            supprimer_bt.UseVisualStyleBackColor = false;
            supprimer_bt.Click += supprimer_bt_Click;
            // 
            // modifier_bt
            // 
            modifier_bt.BackColor = Color.Teal;
            modifier_bt.ForeColor = Color.White;
            modifier_bt.Location = new Point(581, 201);
            modifier_bt.Name = "modifier_bt";
            modifier_bt.Size = new Size(216, 42);
            modifier_bt.TabIndex = 21;
            modifier_bt.Text = "Modifier";
            modifier_bt.UseVisualStyleBackColor = false;
            modifier_bt.Click += modifier_bt_Click;
            // 
            // enregistrer_bt
            // 
            enregistrer_bt.BackColor = Color.Teal;
            enregistrer_bt.ForeColor = Color.White;
            enregistrer_bt.Location = new Point(248, 201);
            enregistrer_bt.Name = "enregistrer_bt";
            enregistrer_bt.Size = new Size(227, 42);
            enregistrer_bt.TabIndex = 22;
            enregistrer_bt.Text = "Enregistrer";
            enregistrer_bt.UseVisualStyleBackColor = false;
            enregistrer_bt.Click += enregistrer_bt_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Crimson;
            label9.Location = new Point(503, 269);
            label9.Name = "label9";
            label9.Size = new Size(223, 28);
            label9.TabIndex = 23;
            label9.Text = "Liste Des Voitures";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(1036, 842);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(38, 31);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 26;
            pictureBox5.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Crimson;
            label10.Location = new Point(1080, 842);
            label10.Name = "label10";
            label10.Size = new Size(154, 23);
            label10.TabIndex = 25;
            label10.Text = "Menu Principal";
            // 
            // Voitures_list
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            Voitures_list.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            Voitures_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            Voitures_list.ColumnHeadersHeight = 30;
            Voitures_list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            Voitures_list.DefaultCellStyle = dataGridViewCellStyle3;
            Voitures_list.GridColor = Color.FromArgb(231, 229, 255);
            Voitures_list.Location = new Point(12, 305);
            Voitures_list.Name = "Voitures_list";
            Voitures_list.RowHeadersVisible = false;
            Voitures_list.RowHeadersWidth = 51;
            Voitures_list.RowTemplate.Height = 29;
            Voitures_list.Size = new Size(1235, 531);
            Voitures_list.TabIndex = 27;
            Voitures_list.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            Voitures_list.ThemeStyle.AlternatingRowsStyle.Font = null;
            Voitures_list.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            Voitures_list.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            Voitures_list.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            Voitures_list.ThemeStyle.BackColor = Color.White;
            Voitures_list.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            Voitures_list.ThemeStyle.HeaderStyle.BackColor = Color.Teal;
            Voitures_list.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            Voitures_list.ThemeStyle.HeaderStyle.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Voitures_list.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            Voitures_list.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            Voitures_list.ThemeStyle.HeaderStyle.Height = 30;
            Voitures_list.ThemeStyle.ReadOnly = false;
            Voitures_list.ThemeStyle.RowsStyle.BackColor = Color.White;
            Voitures_list.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Voitures_list.ThemeStyle.RowsStyle.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Voitures_list.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            Voitures_list.ThemeStyle.RowsStyle.Height = 29;
            Voitures_list.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            Voitures_list.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.TargetControl = supprimer_bt;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Crimson;
            label11.ImageAlign = ContentAlignment.MiddleLeft;
            label11.Location = new Point(1107, 113);
            label11.Name = "label11";
            label11.Size = new Size(126, 20);
            label11.TabIndex = 28;
            label11.Text = "Description Fr";
            label11.Click += label11_Click;
            // 
            // descriptionFr_cb
            // 
            descriptionFr_cb.FormattingEnabled = true;
            descriptionFr_cb.Items.AddRange(new object[] { "Pris", "Dispo" });
            descriptionFr_cb.Location = new Point(1107, 136);
            descriptionFr_cb.Name = "descriptionFr_cb";
            descriptionFr_cb.Size = new Size(151, 31);
            descriptionFr_cb.TabIndex = 29;
            descriptionFr_cb.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.Crimson;
            label12.Location = new Point(13, 113);
            label12.Name = "label12";
            label12.Size = new Size(146, 20);
            label12.TabIndex = 30;
            label12.Text = "Numero de Serie";
            label12.Click += label12_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.Crimson;
            label13.Location = new Point(927, 113);
            label13.Name = "label13";
            label13.Size = new Size(147, 20);
            label13.TabIndex = 31;
            label13.Text = "Date de Revision";
            label13.Click += label13_Click;
            // 
            // dateAchat_dtp
            // 
            dateAchat_dtp.BackColor = Color.Teal;
            dateAchat_dtp.Checked = true;
            dateAchat_dtp.CustomizableEdges = customizableEdges3;
            dateAchat_dtp.FillColor = Color.Teal;
            dateAchat_dtp.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateAchat_dtp.Format = DateTimePickerFormat.Long;
            dateAchat_dtp.Location = new Point(740, 136);
            dateAchat_dtp.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dateAchat_dtp.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dateAchat_dtp.Name = "dateAchat_dtp";
            dateAchat_dtp.ShadowDecoration.CustomizableEdges = customizableEdges4;
            dateAchat_dtp.Size = new Size(147, 31);
            dateAchat_dtp.TabIndex = 59;
            dateAchat_dtp.Value = new DateTime(2024, 2, 7, 22, 35, 28, 930);
            // 
            // dateRevision_dtp
            // 
            dateRevision_dtp.BackColor = Color.Teal;
            dateRevision_dtp.Checked = true;
            dateRevision_dtp.CustomizableEdges = customizableEdges1;
            dateRevision_dtp.FillColor = Color.Teal;
            dateRevision_dtp.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateRevision_dtp.Format = DateTimePickerFormat.Long;
            dateRevision_dtp.Location = new Point(927, 136);
            dateRevision_dtp.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dateRevision_dtp.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dateRevision_dtp.Name = "dateRevision_dtp";
            dateRevision_dtp.ShadowDecoration.CustomizableEdges = customizableEdges2;
            dateRevision_dtp.Size = new Size(157, 31);
            dateRevision_dtp.TabIndex = 60;
            dateRevision_dtp.Value = new DateTime(2024, 2, 7, 22, 35, 28, 930);
            // 
            // Voitures
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1279, 906);
            Controls.Add(dateRevision_dtp);
            Controls.Add(dateAchat_dtp);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(descriptionFr_cb);
            Controls.Add(label11);
            Controls.Add(Voitures_list);
            Controls.Add(pictureBox5);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(enregistrer_bt);
            Controls.Add(modifier_bt);
            Controls.Add(supprimer_bt);
            Controls.Add(label8);
            Controls.Add(couleur_cb);
            Controls.Add(label7);
            Controls.Add(modele_tb);
            Controls.Add(label5);
            Controls.Add(marque_cb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(numeroDeSerie_tb);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Voitures";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Voitures";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)Voitures_list).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private TextBox numeroDeSerie_tb;
        private ComboBox marque_cb;
        private Label label4;
        private TextBox modele_tb;
        private Label label5;
        private Label label8;
        private ComboBox couleur_cb;
        private Label label7;
        private Label label6;
        private Button enregistrer_bt;
        private Button modifier_bt;
        private Button supprimer_bt;
        private Label label9;
        private Guna.UI2.WinForms.Guna2DataGridView Voitures_list;
        private PictureBox pictureBox5;
        private Label label10;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Label label11;
        private ComboBox descriptionFr_cb;
        private Label label12;
        private Label label13;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateAchat_dtp;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateRevision_dtp;
    }
}