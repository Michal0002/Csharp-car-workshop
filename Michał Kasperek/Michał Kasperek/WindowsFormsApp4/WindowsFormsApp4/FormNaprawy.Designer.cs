namespace WindowsFormsApp4
{
    partial class FormNaprawy
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
            this.button_wyczyść = new System.Windows.Forms.Button();
            this.button_anuluj = new System.Windows.Forms.Button();
            this.button_dodajnaprawe = new System.Windows.Forms.Button();
            this.textBox_nr_rejestracyjny = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_czas_pracy = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_koszt_części = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_mechanik = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_czas_pracy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_koszt_części)).BeginInit();
            this.SuspendLayout();
            // 
            // button_wyczyść
            // 
            this.button_wyczyść.Location = new System.Drawing.Point(93, 199);
            this.button_wyczyść.Name = "button_wyczyść";
            this.button_wyczyść.Size = new System.Drawing.Size(66, 23);
            this.button_wyczyść.TabIndex = 21;
            this.button_wyczyść.Text = "Wyczyść";
            this.button_wyczyść.UseVisualStyleBackColor = true;
            this.button_wyczyść.Click += new System.EventHandler(this.button_wyczyść_Click);
            // 
            // button_anuluj
            // 
            this.button_anuluj.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_anuluj.Location = new System.Drawing.Point(165, 199);
            this.button_anuluj.Name = "button_anuluj";
            this.button_anuluj.Size = new System.Drawing.Size(64, 23);
            this.button_anuluj.TabIndex = 20;
            this.button_anuluj.Text = "Anuluj";
            this.button_anuluj.UseVisualStyleBackColor = true;
            // 
            // button_dodajnaprawe
            // 
            this.button_dodajnaprawe.Location = new System.Drawing.Point(12, 199);
            this.button_dodajnaprawe.Name = "button_dodajnaprawe";
            this.button_dodajnaprawe.Size = new System.Drawing.Size(75, 23);
            this.button_dodajnaprawe.TabIndex = 19;
            this.button_dodajnaprawe.Text = "Dodaj";
            this.button_dodajnaprawe.UseVisualStyleBackColor = true;
            this.button_dodajnaprawe.Click += new System.EventHandler(this.button_dodajnaprawe_Click);
            // 
            // textBox_nr_rejestracyjny
            // 
            this.textBox_nr_rejestracyjny.Location = new System.Drawing.Point(95, 27);
            this.textBox_nr_rejestracyjny.Name = "textBox_nr_rejestracyjny";
            this.textBox_nr_rejestracyjny.Size = new System.Drawing.Size(100, 20);
            this.textBox_nr_rejestracyjny.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nr. rejestracyny:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown_czas_pracy);
            this.groupBox1.Controls.Add(this.numericUpDown_koszt_części);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox_mechanik);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_nr_rejestracyjny);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 181);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANE POJAZDU DO NAPRAWY";
            // 
            // numericUpDown_czas_pracy
            // 
            this.numericUpDown_czas_pracy.DecimalPlaces = 1;
            this.numericUpDown_czas_pracy.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDown_czas_pracy.Location = new System.Drawing.Point(74, 145);
            this.numericUpDown_czas_pracy.Name = "numericUpDown_czas_pracy";
            this.numericUpDown_czas_pracy.Size = new System.Drawing.Size(111, 20);
            this.numericUpDown_czas_pracy.TabIndex = 12;
            this.numericUpDown_czas_pracy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_koszt_części
            // 
            this.numericUpDown_koszt_części.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_koszt_części.Location = new System.Drawing.Point(95, 111);
            this.numericUpDown_koszt_części.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_koszt_części.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_koszt_części.Name = "numericUpDown_koszt_części";
            this.numericUpDown_koszt_części.Size = new System.Drawing.Size(111, 20);
            this.numericUpDown_koszt_części.TabIndex = 11;
            this.numericUpDown_koszt_części.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Czas pracy:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Koszt części [zł]: ";
            // 
            // comboBox_mechanik
            // 
            this.comboBox_mechanik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_mechanik.FormattingEnabled = true;
            this.comboBox_mechanik.Location = new System.Drawing.Point(69, 79);
            this.comboBox_mechanik.Name = "comboBox_mechanik";
            this.comboBox_mechanik.Size = new System.Drawing.Size(121, 21);
            this.comboBox_mechanik.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mechanik:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(100, 53);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data wykonania:";
            // 
            // FormNaprawy
            // 
            this.AcceptButton = this.button_dodajnaprawe;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_anuluj;
            this.ClientSize = new System.Drawing.Size(242, 229);
            this.Controls.Add(this.button_wyczyść);
            this.Controls.Add(this.button_anuluj);
            this.Controls.Add(this.button_dodajnaprawe);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormNaprawy";
            this.Text = "FormNaprawy";
            this.Load += new System.EventHandler(this.FormNaprawy_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_czas_pracy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_koszt_części)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_wyczyść;
        private System.Windows.Forms.Button button_anuluj;
        private System.Windows.Forms.Button button_dodajnaprawe;
        private System.Windows.Forms.TextBox textBox_nr_rejestracyjny;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown_czas_pracy;
        private System.Windows.Forms.NumericUpDown numericUpDown_koszt_części;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_mechanik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
    }
}