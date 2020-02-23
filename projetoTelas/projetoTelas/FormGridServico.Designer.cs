namespace projetoTelas
{
    partial class FormGridServico
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
            this.GridServicos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridServicos)).BeginInit();
            this.SuspendLayout();
            // 
            // GridServicos
            // 
            this.GridServicos.AllowUserToAddRows = false;
            this.GridServicos.AllowUserToDeleteRows = false;
            this.GridServicos.AllowUserToOrderColumns = true;
            this.GridServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridServicos.Location = new System.Drawing.Point(426, 233);
            this.GridServicos.Name = "GridServicos";
            this.GridServicos.ReadOnly = true;
            this.GridServicos.Size = new System.Drawing.Size(240, 150);
            this.GridServicos.TabIndex = 0;
            // 
            // FormGridServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridServicos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGridServico";
            this.Text = "FormGridServico";
            ((System.ComponentModel.ISupportInitialize)(this.GridServicos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridServicos;
    }
}