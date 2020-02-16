namespace projetoTelas
{
    partial class FormResultadoPesquisa
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cODPESSOADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEFONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLACAVEICULODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pESSOASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbProjetoDataSet = new projetoTelas.dbProjetoDataSet();
            this.dbProjetoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pESSOASTableAdapter = new projetoTelas.dbProjetoDataSetTableAdapters.PESSOASTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pESSOASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbProjetoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbProjetoDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODPESSOADataGridViewTextBoxColumn,
            this.nOMEDataGridViewTextBoxColumn,
            this.tELEFONEDataGridViewTextBoxColumn,
            this.pLACAVEICULODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pESSOASBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(222, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(578, 426);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // cODPESSOADataGridViewTextBoxColumn
            // 
            this.cODPESSOADataGridViewTextBoxColumn.DataPropertyName = "CODPESSOA";
            this.cODPESSOADataGridViewTextBoxColumn.HeaderText = "CODPESSOA";
            this.cODPESSOADataGridViewTextBoxColumn.Name = "cODPESSOADataGridViewTextBoxColumn";
            this.cODPESSOADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMEDataGridViewTextBoxColumn
            // 
            this.nOMEDataGridViewTextBoxColumn.DataPropertyName = "NOME";
            this.nOMEDataGridViewTextBoxColumn.HeaderText = "NOME";
            this.nOMEDataGridViewTextBoxColumn.Name = "nOMEDataGridViewTextBoxColumn";
            this.nOMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tELEFONEDataGridViewTextBoxColumn
            // 
            this.tELEFONEDataGridViewTextBoxColumn.DataPropertyName = "TELEFONE";
            this.tELEFONEDataGridViewTextBoxColumn.HeaderText = "TELEFONE";
            this.tELEFONEDataGridViewTextBoxColumn.Name = "tELEFONEDataGridViewTextBoxColumn";
            this.tELEFONEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pLACAVEICULODataGridViewTextBoxColumn
            // 
            this.pLACAVEICULODataGridViewTextBoxColumn.DataPropertyName = "PLACAVEICULO";
            this.pLACAVEICULODataGridViewTextBoxColumn.HeaderText = "PLACAVEICULO";
            this.pLACAVEICULODataGridViewTextBoxColumn.Name = "pLACAVEICULODataGridViewTextBoxColumn";
            this.pLACAVEICULODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pESSOASBindingSource
            // 
            this.pESSOASBindingSource.DataMember = "PESSOAS";
            this.pESSOASBindingSource.DataSource = this.dbProjetoDataSet;
            // 
            // dbProjetoDataSet
            // 
            this.dbProjetoDataSet.DataSetName = "dbProjetoDataSet";
            this.dbProjetoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbProjetoDataSetBindingSource
            // 
            this.dbProjetoDataSetBindingSource.DataSource = this.dbProjetoDataSet;
            this.dbProjetoDataSetBindingSource.Position = 0;
            // 
            // pESSOASTableAdapter
            // 
            this.pESSOASTableAdapter.ClearBeforeFill = true;
            // 
            // FormResultadoPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FormResultadoPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pESSOASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbProjetoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbProjetoDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dbProjetoDataSetBindingSource;
        private dbProjetoDataSet dbProjetoDataSet;
        private System.Windows.Forms.BindingSource pESSOASBindingSource;
        private dbProjetoDataSetTableAdapters.PESSOASTableAdapter pESSOASTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODPESSOADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEFONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLACAVEICULODataGridViewTextBoxColumn;
    }
}