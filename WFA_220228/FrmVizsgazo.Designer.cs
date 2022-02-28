namespace WFA_220228
{
    partial class FrmVizsgazo
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
            this.TB_id = new System.Windows.Forms.TextBox();
            this.TB_nev = new System.Windows.Forms.TextBox();
            this.TB_telefonszam = new System.Windows.Forms.TextBox();
            this.TB_szul = new System.Windows.Forms.TextBox();
            this.BT_torles = new System.Windows.Forms.Button();
            this.BT_modositas = new System.Windows.Forms.Button();
            this.BT_uj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_id
            // 
            this.TB_id.Location = new System.Drawing.Point(63, 78);
            this.TB_id.Name = "TB_id";
            this.TB_id.Size = new System.Drawing.Size(152, 20);
            this.TB_id.TabIndex = 0;
            // 
            // TB_nev
            // 
            this.TB_nev.Location = new System.Drawing.Point(63, 134);
            this.TB_nev.Name = "TB_nev";
            this.TB_nev.Size = new System.Drawing.Size(152, 20);
            this.TB_nev.TabIndex = 1;
            // 
            // TB_telefonszam
            // 
            this.TB_telefonszam.Location = new System.Drawing.Point(63, 196);
            this.TB_telefonszam.Name = "TB_telefonszam";
            this.TB_telefonszam.Size = new System.Drawing.Size(152, 20);
            this.TB_telefonszam.TabIndex = 2;
            // 
            // TB_szul
            // 
            this.TB_szul.Location = new System.Drawing.Point(63, 253);
            this.TB_szul.Name = "TB_szul";
            this.TB_szul.Size = new System.Drawing.Size(152, 20);
            this.TB_szul.TabIndex = 3;
            // 
            // BT_torles
            // 
            this.BT_torles.Location = new System.Drawing.Point(234, 55);
            this.BT_torles.Name = "BT_torles";
            this.BT_torles.Size = new System.Drawing.Size(75, 54);
            this.BT_torles.TabIndex = 4;
            this.BT_torles.Text = "Törlés";
            this.BT_torles.UseVisualStyleBackColor = true;
            this.BT_torles.Click += new System.EventHandler(this.BT_torles_Click);
            // 
            // BT_modositas
            // 
            this.BT_modositas.Location = new System.Drawing.Point(234, 137);
            this.BT_modositas.Name = "BT_modositas";
            this.BT_modositas.Size = new System.Drawing.Size(75, 54);
            this.BT_modositas.TabIndex = 5;
            this.BT_modositas.Text = "Módosítás";
            this.BT_modositas.UseVisualStyleBackColor = true;
            this.BT_modositas.Click += new System.EventHandler(this.BT_modositas_Click);
            // 
            // BT_uj
            // 
            this.BT_uj.Location = new System.Drawing.Point(234, 219);
            this.BT_uj.Name = "BT_uj";
            this.BT_uj.Size = new System.Drawing.Size(75, 54);
            this.BT_uj.TabIndex = 6;
            this.BT_uj.Text = "Új";
            this.BT_uj.UseVisualStyleBackColor = true;
            this.BT_uj.Click += new System.EventHandler(this.BT_uj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Név:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mobil:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Szül.év:";
            // 
            // FrmVizsgazo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 370);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_uj);
            this.Controls.Add(this.BT_modositas);
            this.Controls.Add(this.BT_torles);
            this.Controls.Add(this.TB_szul);
            this.Controls.Add(this.TB_telefonszam);
            this.Controls.Add(this.TB_nev);
            this.Controls.Add(this.TB_id);
            this.Name = "FrmVizsgazo";
            this.Text = "FrmVizsgazo";
            this.Load += new System.EventHandler(this.FrmVizsgazo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_id;
        private System.Windows.Forms.TextBox TB_nev;
        private System.Windows.Forms.TextBox TB_telefonszam;
        private System.Windows.Forms.TextBox TB_szul;
        private System.Windows.Forms.Button BT_torles;
        private System.Windows.Forms.Button BT_modositas;
        private System.Windows.Forms.Button BT_uj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}