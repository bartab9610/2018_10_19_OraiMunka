namespace _2018_10_19_OraiMunka_Windows_form
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
            this.Label_nev = new System.Windows.Forms.Label();
            this.Label_szuletesi_datum = new System.Windows.Forms.Label();
            this.GroupBox_adatok = new System.Windows.Forms.GroupBox();
            this.Label_nem = new System.Windows.Forms.Label();
            this.TextBox_nev = new System.Windows.Forms.TextBox();
            this.DateTimePicker_szul_datum = new System.Windows.Forms.DateTimePicker();
            this.RadioButton_ferfi = new System.Windows.Forms.RadioButton();
            this.RadioButton_no = new System.Windows.Forms.RadioButton();
            this.GroupBox_hobbi = new System.Windows.Forms.GroupBox();
            this.Label_kedvenc_hobbi = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Label_uj_hobbi = new System.Windows.Forms.Label();
            this.TextBox_uj_hobbi = new System.Windows.Forms.TextBox();
            this.Button_hobbi_hozzaadas = new System.Windows.Forms.Button();
            this.Button_save = new System.Windows.Forms.Button();
            this.Button_open = new System.Windows.Forms.Button();
            this.GroupBox_adatok.SuspendLayout();
            this.GroupBox_hobbi.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_nev
            // 
            this.Label_nev.AutoSize = true;
            this.Label_nev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label_nev.Location = new System.Drawing.Point(16, 25);
            this.Label_nev.Name = "Label_nev";
            this.Label_nev.Size = new System.Drawing.Size(34, 13);
            this.Label_nev.TabIndex = 0;
            this.Label_nev.Text = "Név:";
            // 
            // Label_szuletesi_datum
            // 
            this.Label_szuletesi_datum.AutoSize = true;
            this.Label_szuletesi_datum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label_szuletesi_datum.Location = new System.Drawing.Point(16, 48);
            this.Label_szuletesi_datum.Name = "Label_szuletesi_datum";
            this.Label_szuletesi_datum.Size = new System.Drawing.Size(100, 13);
            this.Label_szuletesi_datum.TabIndex = 1;
            this.Label_szuletesi_datum.Text = "Születési dátum:";
            // 
            // GroupBox_adatok
            // 
            this.GroupBox_adatok.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_adatok.Controls.Add(this.RadioButton_no);
            this.GroupBox_adatok.Controls.Add(this.RadioButton_ferfi);
            this.GroupBox_adatok.Controls.Add(this.DateTimePicker_szul_datum);
            this.GroupBox_adatok.Controls.Add(this.TextBox_nev);
            this.GroupBox_adatok.Controls.Add(this.Label_nem);
            this.GroupBox_adatok.Controls.Add(this.Label_nev);
            this.GroupBox_adatok.Controls.Add(this.Label_szuletesi_datum);
            this.GroupBox_adatok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GroupBox_adatok.Location = new System.Drawing.Point(12, 12);
            this.GroupBox_adatok.Name = "GroupBox_adatok";
            this.GroupBox_adatok.Size = new System.Drawing.Size(317, 96);
            this.GroupBox_adatok.TabIndex = 2;
            this.GroupBox_adatok.TabStop = false;
            this.GroupBox_adatok.Text = "Adatok";
            // 
            // Label_nem
            // 
            this.Label_nem.AutoSize = true;
            this.Label_nem.Location = new System.Drawing.Point(16, 72);
            this.Label_nem.Name = "Label_nem";
            this.Label_nem.Size = new System.Drawing.Size(43, 13);
            this.Label_nem.TabIndex = 2;
            this.Label_nem.Text = "Neme:";
            // 
            // TextBox_nev
            // 
            this.TextBox_nev.Location = new System.Drawing.Point(127, 19);
            this.TextBox_nev.Name = "TextBox_nev";
            this.TextBox_nev.Size = new System.Drawing.Size(180, 20);
            this.TextBox_nev.TabIndex = 3;
            // 
            // DateTimePicker_szul_datum
            // 
            this.DateTimePicker_szul_datum.Location = new System.Drawing.Point(127, 44);
            this.DateTimePicker_szul_datum.Name = "DateTimePicker_szul_datum";
            this.DateTimePicker_szul_datum.Size = new System.Drawing.Size(180, 20);
            this.DateTimePicker_szul_datum.TabIndex = 4;
            // 
            // RadioButton_ferfi
            // 
            this.RadioButton_ferfi.AutoSize = true;
            this.RadioButton_ferfi.Location = new System.Drawing.Point(150, 70);
            this.RadioButton_ferfi.Name = "RadioButton_ferfi";
            this.RadioButton_ferfi.Size = new System.Drawing.Size(50, 17);
            this.RadioButton_ferfi.TabIndex = 5;
            this.RadioButton_ferfi.TabStop = true;
            this.RadioButton_ferfi.Text = "Férfi";
            this.RadioButton_ferfi.UseVisualStyleBackColor = true;
            // 
            // RadioButton_no
            // 
            this.RadioButton_no.AutoSize = true;
            this.RadioButton_no.Location = new System.Drawing.Point(241, 70);
            this.RadioButton_no.Name = "RadioButton_no";
            this.RadioButton_no.Size = new System.Drawing.Size(41, 17);
            this.RadioButton_no.TabIndex = 6;
            this.RadioButton_no.TabStop = true;
            this.RadioButton_no.Text = "Nő";
            this.RadioButton_no.UseVisualStyleBackColor = true;
            // 
            // GroupBox_hobbi
            // 
            this.GroupBox_hobbi.Controls.Add(this.Button_hobbi_hozzaadas);
            this.GroupBox_hobbi.Controls.Add(this.TextBox_uj_hobbi);
            this.GroupBox_hobbi.Controls.Add(this.Label_uj_hobbi);
            this.GroupBox_hobbi.Controls.Add(this.comboBox1);
            this.GroupBox_hobbi.Controls.Add(this.Label_kedvenc_hobbi);
            this.GroupBox_hobbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GroupBox_hobbi.Location = new System.Drawing.Point(12, 114);
            this.GroupBox_hobbi.Name = "GroupBox_hobbi";
            this.GroupBox_hobbi.Size = new System.Drawing.Size(200, 149);
            this.GroupBox_hobbi.TabIndex = 3;
            this.GroupBox_hobbi.TabStop = false;
            this.GroupBox_hobbi.Text = "Hobbi";
            // 
            // Label_kedvenc_hobbi
            // 
            this.Label_kedvenc_hobbi.AutoSize = true;
            this.Label_kedvenc_hobbi.Location = new System.Drawing.Point(16, 25);
            this.Label_kedvenc_hobbi.Name = "Label_kedvenc_hobbi";
            this.Label_kedvenc_hobbi.Size = new System.Drawing.Size(96, 13);
            this.Label_kedvenc_hobbi.TabIndex = 0;
            this.Label_kedvenc_hobbi.Text = "Kedvenc hobbi:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Úszás",
            "Bicikli",
            "Labdarúgás"});
            this.comboBox1.Location = new System.Drawing.Point(19, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(123, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // Label_uj_hobbi
            // 
            this.Label_uj_hobbi.Location = new System.Drawing.Point(19, 87);
            this.Label_uj_hobbi.Name = "Label_uj_hobbi";
            this.Label_uj_hobbi.Size = new System.Drawing.Size(58, 15);
            this.Label_uj_hobbi.TabIndex = 2;
            this.Label_uj_hobbi.Text = "Új hobbi:";
            // 
            // TextBox_uj_hobbi
            // 
            this.TextBox_uj_hobbi.Location = new System.Drawing.Point(83, 84);
            this.TextBox_uj_hobbi.Name = "TextBox_uj_hobbi";
            this.TextBox_uj_hobbi.Size = new System.Drawing.Size(111, 20);
            this.TextBox_uj_hobbi.TabIndex = 3;
            // 
            // Button_hobbi_hozzaadas
            // 
            this.Button_hobbi_hozzaadas.Location = new System.Drawing.Point(60, 115);
            this.Button_hobbi_hozzaadas.Name = "Button_hobbi_hozzaadas";
            this.Button_hobbi_hozzaadas.Size = new System.Drawing.Size(82, 23);
            this.Button_hobbi_hozzaadas.TabIndex = 4;
            this.Button_hobbi_hozzaadas.Text = "Hozzáadás";
            this.Button_hobbi_hozzaadas.UseVisualStyleBackColor = true;
            // 
            // Button_save
            // 
            this.Button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_save.Location = new System.Drawing.Point(244, 161);
            this.Button_save.Name = "Button_save";
            this.Button_save.Size = new System.Drawing.Size(75, 23);
            this.Button_save.TabIndex = 4;
            this.Button_save.Text = "Mentés";
            this.Button_save.UseVisualStyleBackColor = true;
            // 
            // Button_open
            // 
            this.Button_open.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_open.Location = new System.Drawing.Point(244, 201);
            this.Button_open.Name = "Button_open";
            this.Button_open.Size = new System.Drawing.Size(75, 23);
            this.Button_open.TabIndex = 5;
            this.Button_open.Text = "Betöltés";
            this.Button_open.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 275);
            this.Controls.Add(this.Button_open);
            this.Controls.Add(this.Button_save);
            this.Controls.Add(this.GroupBox_hobbi);
            this.Controls.Add(this.GroupBox_adatok);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(358, 314);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GroupBox_adatok.ResumeLayout(false);
            this.GroupBox_adatok.PerformLayout();
            this.GroupBox_hobbi.ResumeLayout(false);
            this.GroupBox_hobbi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label_nev;
        private System.Windows.Forms.Label Label_szuletesi_datum;
        private System.Windows.Forms.GroupBox GroupBox_adatok;
        private System.Windows.Forms.TextBox TextBox_nev;
        private System.Windows.Forms.Label Label_nem;
        private System.Windows.Forms.RadioButton RadioButton_no;
        private System.Windows.Forms.RadioButton RadioButton_ferfi;
        private System.Windows.Forms.DateTimePicker DateTimePicker_szul_datum;
        private System.Windows.Forms.GroupBox GroupBox_hobbi;
        private System.Windows.Forms.Label Label_kedvenc_hobbi;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Button_hobbi_hozzaadas;
        private System.Windows.Forms.TextBox TextBox_uj_hobbi;
        private System.Windows.Forms.Label Label_uj_hobbi;
        private System.Windows.Forms.Button Button_save;
        private System.Windows.Forms.Button Button_open;
    }
}

