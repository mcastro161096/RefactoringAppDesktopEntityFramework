namespace projetoTelas
{
    partial class FormEditaOuExcluiServico
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbValorPago = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txbServicoPrestado = new System.Windows.Forms.TextBox();
            this.cmbxPago = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbValorTotal = new System.Windows.Forms.TextBox();
            this.botaoCancelar = new System.Windows.Forms.Button();
            this.botaoSalvar = new System.Windows.Forms.Button();
            this.botaoExcluirServico = new System.Windows.Forms.Button();
            this.botaoEditar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(87, 450);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(87, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(713, 24);
            this.panel2.TabIndex = 7;
            // 
            // txbValorPago
            // 
            this.txbValorPago.Location = new System.Drawing.Point(450, 79);
            this.txbValorPago.Multiline = true;
            this.txbValorPago.Name = "txbValorPago";
            this.txbValorPago.Size = new System.Drawing.Size(140, 25);
            this.txbValorPago.TabIndex = 37;
            this.txbValorPago.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbValorPago_KeyDown);
            this.txbValorPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbValorPago_KeyPress);
            this.txbValorPago.Leave += new System.EventHandler(this.txbValorPago_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label6.Location = new System.Drawing.Point(364, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "Data do Serviço";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(495, 131);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(133, 20);
            this.dateTimePicker1.TabIndex = 35;
            this.dateTimePicker1.Value = new System.DateTime(2020, 3, 7, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label5.Location = new System.Drawing.Point(134, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Descrição do serviço";
            // 
            // txbServicoPrestado
            // 
            this.txbServicoPrestado.Location = new System.Drawing.Point(123, 205);
            this.txbServicoPrestado.Multiline = true;
            this.txbServicoPrestado.Name = "txbServicoPrestado";
            this.txbServicoPrestado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbServicoPrestado.Size = new System.Drawing.Size(585, 179);
            this.txbServicoPrestado.TabIndex = 33;
            // 
            // cmbxPago
            // 
            this.cmbxPago.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxPago.FormattingEnabled = true;
            this.cmbxPago.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbxPago.Items.AddRange(new object[] {
            "Sim",
            "Não",
            "Parcial"});
            this.cmbxPago.Location = new System.Drawing.Point(171, 132);
            this.cmbxPago.Name = "cmbxPago";
            this.cmbxPago.Size = new System.Drawing.Size(121, 24);
            this.cmbxPago.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label2.Location = new System.Drawing.Point(101, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Pago";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label1.Location = new System.Drawing.Point(364, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Valor Pago";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label3.Location = new System.Drawing.Point(102, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Valor Total";
            // 
            // txbValorTotal
            // 
            this.txbValorTotal.Location = new System.Drawing.Point(186, 79);
            this.txbValorTotal.Multiline = true;
            this.txbValorTotal.Name = "txbValorTotal";
            this.txbValorTotal.Size = new System.Drawing.Size(140, 25);
            this.txbValorTotal.TabIndex = 28;
            this.txbValorTotal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbValorTotal_KeyDown);
            this.txbValorTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbValorTotal_KeyPress);
            this.txbValorTotal.Leave += new System.EventHandler(this.txbValorTotal_Leave);
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.botaoCancelar.FlatAppearance.BorderSize = 0;
            this.botaoCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoCancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoCancelar.ForeColor = System.Drawing.Color.White;
            this.botaoCancelar.Location = new System.Drawing.Point(539, 408);
            this.botaoCancelar.Name = "botaoCancelar";
            this.botaoCancelar.Size = new System.Drawing.Size(100, 30);
            this.botaoCancelar.TabIndex = 39;
            this.botaoCancelar.Text = "Cancelar";
            this.botaoCancelar.UseVisualStyleBackColor = false;
            this.botaoCancelar.Click += new System.EventHandler(this.botaoCancelar_Click);
            // 
            // botaoSalvar
            // 
            this.botaoSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.botaoSalvar.FlatAppearance.BorderSize = 0;
            this.botaoSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoSalvar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoSalvar.ForeColor = System.Drawing.Color.White;
            this.botaoSalvar.Location = new System.Drawing.Point(411, 408);
            this.botaoSalvar.Name = "botaoSalvar";
            this.botaoSalvar.Size = new System.Drawing.Size(100, 30);
            this.botaoSalvar.TabIndex = 38;
            this.botaoSalvar.Text = "Salvar";
            this.botaoSalvar.UseVisualStyleBackColor = false;
            this.botaoSalvar.Click += new System.EventHandler(this.botaoSalvar_Click);
            // 
            // botaoExcluirServico
            // 
            this.botaoExcluirServico.AutoSize = true;
            this.botaoExcluirServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.botaoExcluirServico.FlatAppearance.BorderSize = 0;
            this.botaoExcluirServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoExcluirServico.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoExcluirServico.ForeColor = System.Drawing.Color.White;
            this.botaoExcluirServico.Location = new System.Drawing.Point(666, 408);
            this.botaoExcluirServico.Name = "botaoExcluirServico";
            this.botaoExcluirServico.Size = new System.Drawing.Size(122, 30);
            this.botaoExcluirServico.TabIndex = 40;
            this.botaoExcluirServico.Text = "Excluir serviço";
            this.botaoExcluirServico.UseVisualStyleBackColor = false;
            this.botaoExcluirServico.Click += new System.EventHandler(this.botaoExcluirServico_Click);
            // 
            // botaoEditar
            // 
            this.botaoEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.botaoEditar.FlatAppearance.BorderSize = 0;
            this.botaoEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoEditar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoEditar.ForeColor = System.Drawing.Color.White;
            this.botaoEditar.Location = new System.Drawing.Point(688, 44);
            this.botaoEditar.Name = "botaoEditar";
            this.botaoEditar.Size = new System.Drawing.Size(100, 30);
            this.botaoEditar.TabIndex = 41;
            this.botaoEditar.Text = "Editar";
            this.botaoEditar.UseVisualStyleBackColor = false;
            this.botaoEditar.Click += new System.EventHandler(this.botaoEditar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label4.Location = new System.Drawing.Point(116, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 19);
            this.label4.TabIndex = 42;
            this.label4.Text = "Edição ou exclusão de serviço";
            // 
            // FormEditaOuExcluiServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.botaoEditar);
            this.Controls.Add(this.botaoExcluirServico);
            this.Controls.Add(this.botaoCancelar);
            this.Controls.Add(this.botaoSalvar);
            this.Controls.Add(this.txbValorPago);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbServicoPrestado);
            this.Controls.Add(this.cmbxPago);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbValorTotal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormEditaOuExcluiServico";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.FormEditaOuExcluiServico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbValorPago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbServicoPrestado;
        private System.Windows.Forms.ComboBox cmbxPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbValorTotal;
        private System.Windows.Forms.Button botaoCancelar;
        private System.Windows.Forms.Button botaoSalvar;
        private System.Windows.Forms.Button botaoExcluirServico;
        private System.Windows.Forms.Button botaoEditar;
        private System.Windows.Forms.Label label4;
    }
}