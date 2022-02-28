namespace WFA_220228
{
    partial class FrmKereso
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.idopont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nyelv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CB_kereso = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idopont,
            this.nyelv,
            this.szint});
            this.dgv.Location = new System.Drawing.Point(23, 61);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.Size = new System.Drawing.Size(465, 176);
            this.dgv.TabIndex = 1;
            // 
            // idopont
            // 
            this.idopont.HeaderText = "Időpont";
            this.idopont.Name = "idopont";
            this.idopont.ReadOnly = true;
            // 
            // nyelv
            // 
            this.nyelv.HeaderText = "Nyelv";
            this.nyelv.Name = "nyelv";
            this.nyelv.ReadOnly = true;
            // 
            // szint
            // 
            this.szint.HeaderText = "Szint";
            this.szint.Name = "szint";
            this.szint.ReadOnly = true;
            // 
            // CB_kereso
            // 
            this.CB_kereso.FormattingEnabled = true;
            this.CB_kereso.Location = new System.Drawing.Point(23, 12);
            this.CB_kereso.Name = "CB_kereso";
            this.CB_kereso.Size = new System.Drawing.Size(465, 21);
            this.CB_kereso.TabIndex = 2;
            this.CB_kereso.SelectedIndexChanged += new System.EventHandler(this.CB_kereso_SelectedIndexChanged);
            this.CB_kereso.TextChanged += new System.EventHandler(this.CB_kereso_TextChanged);
            // 
            // FrmKereso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 261);
            this.Controls.Add(this.CB_kereso);
            this.Controls.Add(this.dgv);
            this.Name = "FrmKereso";
            this.Text = "FrmKereso";
            this.Load += new System.EventHandler(this.FrmKereso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn idopont;
        private System.Windows.Forms.DataGridViewTextBoxColumn nyelv;
        private System.Windows.Forms.DataGridViewTextBoxColumn szint;
        private System.Windows.Forms.ComboBox CB_kereso;
    }
}