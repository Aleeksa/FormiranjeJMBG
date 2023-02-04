namespace formiranje_JMBG
{
    partial class formJmbg
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDan = new System.Windows.Forms.TextBox();
            this.tbMesec = new System.Windows.Forms.TextBox();
            this.tbGodina = new System.Windows.Forms.TextBox();
            this.gbPol = new System.Windows.Forms.GroupBox();
            this.rbZ = new System.Windows.Forms.RadioButton();
            this.rbM = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.gbRegija = new System.Windows.Forms.GroupBox();
            this.rbKiM = new System.Windows.Forms.RadioButton();
            this.rbVojvodina = new System.Windows.Forms.RadioButton();
            this.rbCentSrb = new System.Windows.Forms.RadioButton();
            this.labJmbg = new System.Windows.Forms.Label();
            this.tbJmbg = new System.Windows.Forms.TextBox();
            this.btnIzracunaj = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gbPol.SuspendLayout();
            this.gbRegija.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dan:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mesec:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Godina:";
            // 
            // tbDan
            // 
            this.tbDan.Location = new System.Drawing.Point(95, 36);
            this.tbDan.Name = "tbDan";
            this.tbDan.Size = new System.Drawing.Size(100, 20);
            this.tbDan.TabIndex = 3;
            // 
            // tbMesec
            // 
            this.tbMesec.Location = new System.Drawing.Point(95, 67);
            this.tbMesec.Name = "tbMesec";
            this.tbMesec.Size = new System.Drawing.Size(100, 20);
            this.tbMesec.TabIndex = 4;
            // 
            // tbGodina
            // 
            this.tbGodina.Location = new System.Drawing.Point(95, 99);
            this.tbGodina.Name = "tbGodina";
            this.tbGodina.Size = new System.Drawing.Size(100, 20);
            this.tbGodina.TabIndex = 5;
            // 
            // gbPol
            // 
            this.gbPol.Controls.Add(this.rbZ);
            this.gbPol.Controls.Add(this.rbM);
            this.gbPol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPol.Location = new System.Drawing.Point(284, 36);
            this.gbPol.Name = "gbPol";
            this.gbPol.Size = new System.Drawing.Size(169, 83);
            this.gbPol.TabIndex = 6;
            this.gbPol.TabStop = false;
            this.gbPol.Text = "Pol";
            // 
            // rbZ
            // 
            this.rbZ.AutoSize = true;
            this.rbZ.Location = new System.Drawing.Point(83, 31);
            this.rbZ.Name = "rbZ";
            this.rbZ.Size = new System.Drawing.Size(37, 24);
            this.rbZ.TabIndex = 8;
            this.rbZ.TabStop = true;
            this.rbZ.Text = "Ž";
            this.rbZ.UseVisualStyleBackColor = true;
            // 
            // rbM
            // 
            this.rbM.AutoSize = true;
            this.rbM.Location = new System.Drawing.Point(18, 31);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(40, 24);
            this.rbM.TabIndex = 7;
            this.rbM.TabStop = true;
            this.rbM.Text = "M";
            this.rbM.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Region:";
            // 
            // cbRegion
            // 
            this.cbRegion.FormattingEnabled = true;
            this.cbRegion.Location = new System.Drawing.Point(111, 209);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(121, 21);
            this.cbRegion.TabIndex = 10;
            // 
            // gbRegija
            // 
            this.gbRegija.Controls.Add(this.rbKiM);
            this.gbRegija.Controls.Add(this.rbVojvodina);
            this.gbRegija.Controls.Add(this.rbCentSrb);
            this.gbRegija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegija.Location = new System.Drawing.Point(283, 148);
            this.gbRegija.Name = "gbRegija";
            this.gbRegija.Size = new System.Drawing.Size(247, 184);
            this.gbRegija.TabIndex = 11;
            this.gbRegija.TabStop = false;
            this.gbRegija.Text = "Politička regija";
            // 
            // rbKiM
            // 
            this.rbKiM.AutoSize = true;
            this.rbKiM.Location = new System.Drawing.Point(19, 122);
            this.rbKiM.Name = "rbKiM";
            this.rbKiM.Size = new System.Drawing.Size(175, 24);
            this.rbKiM.TabIndex = 2;
            this.rbKiM.TabStop = true;
            this.rbKiM.Text = "AP Kosovo i Metohija";
            this.rbKiM.UseVisualStyleBackColor = true;
            this.rbKiM.CheckedChanged += new System.EventHandler(this.rbKiM_CheckedChanged);
            // 
            // rbVojvodina
            // 
            this.rbVojvodina.AutoSize = true;
            this.rbVojvodina.Location = new System.Drawing.Point(19, 83);
            this.rbVojvodina.Name = "rbVojvodina";
            this.rbVojvodina.Size = new System.Drawing.Size(121, 24);
            this.rbVojvodina.TabIndex = 1;
            this.rbVojvodina.TabStop = true;
            this.rbVojvodina.Text = "AP Vojvodina";
            this.rbVojvodina.UseVisualStyleBackColor = true;
            this.rbVojvodina.CheckedChanged += new System.EventHandler(this.rbVojvodina_CheckedChanged);
            // 
            // rbCentSrb
            // 
            this.rbCentSrb.AutoSize = true;
            this.rbCentSrb.Location = new System.Drawing.Point(19, 41);
            this.rbCentSrb.Name = "rbCentSrb";
            this.rbCentSrb.Size = new System.Drawing.Size(140, 24);
            this.rbCentSrb.TabIndex = 0;
            this.rbCentSrb.TabStop = true;
            this.rbCentSrb.Text = "Centralna Srbija";
            this.rbCentSrb.UseVisualStyleBackColor = true;
            this.rbCentSrb.CheckedChanged += new System.EventHandler(this.rbCentSrb_CheckedChanged);
            // 
            // labJmbg
            // 
            this.labJmbg.AutoSize = true;
            this.labJmbg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labJmbg.Location = new System.Drawing.Point(123, 380);
            this.labJmbg.Name = "labJmbg";
            this.labJmbg.Size = new System.Drawing.Size(58, 20);
            this.labJmbg.TabIndex = 3;
            this.labJmbg.Text = "JMBG:";
            // 
            // tbJmbg
            // 
            this.tbJmbg.Location = new System.Drawing.Point(243, 380);
            this.tbJmbg.Name = "tbJmbg";
            this.tbJmbg.Size = new System.Drawing.Size(210, 20);
            this.tbJmbg.TabIndex = 13;
            // 
            // btnIzracunaj
            // 
            this.btnIzracunaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzracunaj.Location = new System.Drawing.Point(127, 461);
            this.btnIzracunaj.Name = "btnIzracunaj";
            this.btnIzracunaj.Size = new System.Drawing.Size(127, 44);
            this.btnIzracunaj.TabIndex = 14;
            this.btnIzracunaj.Text = "Generiši JMBG";
            this.btnIzracunaj.UseVisualStyleBackColor = true;
            this.btnIzracunaj.Click += new System.EventHandler(this.btnIzracunaj_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(326, 461);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(127, 44);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Resetuj";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(311, 508);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Dvoklik za potvrdu reset dugmeta";
            // 
            // formJmbg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 574);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnIzracunaj);
            this.Controls.Add(this.tbJmbg);
            this.Controls.Add(this.labJmbg);
            this.Controls.Add(this.gbRegija);
            this.Controls.Add(this.cbRegion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gbPol);
            this.Controls.Add(this.tbGodina);
            this.Controls.Add(this.tbMesec);
            this.Controls.Add(this.tbDan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formJmbg";
            this.Text = "Generisanje JMBG";
            this.Load += new System.EventHandler(this.formJmbg_Load);
            this.gbPol.ResumeLayout(false);
            this.gbPol.PerformLayout();
            this.gbRegija.ResumeLayout(false);
            this.gbRegija.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDan;
        private System.Windows.Forms.TextBox tbMesec;
        private System.Windows.Forms.TextBox tbGodina;
        private System.Windows.Forms.GroupBox gbPol;
        private System.Windows.Forms.RadioButton rbZ;
        private System.Windows.Forms.RadioButton rbM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbRegion;
        private System.Windows.Forms.GroupBox gbRegija;
        private System.Windows.Forms.RadioButton rbKiM;
        private System.Windows.Forms.RadioButton rbVojvodina;
        private System.Windows.Forms.RadioButton rbCentSrb;
        private System.Windows.Forms.Label labJmbg;
        private System.Windows.Forms.TextBox tbJmbg;
        private System.Windows.Forms.Button btnIzracunaj;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label4;
    }
}

