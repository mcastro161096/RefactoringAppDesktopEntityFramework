namespace projetoTelas
{
    partial class FormCadastroServicos
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
            this.pessoasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxPlacaVeiculo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxTelefone = new System.Windows.Forms.TextBox();
            this.txtBoxNomePessoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.botaEditar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txbServicosPrestados = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.botaoExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label3.Location = new System.Drawing.Point(229, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Placa do Veículo";
            // 
            // txtBoxPlacaVeiculo
            // 
            this.txtBoxPlacaVeiculo.Enabled = false;
            this.txtBoxPlacaVeiculo.Location = new System.Drawing.Point(361, 223);
            this.txtBoxPlacaVeiculo.Multiline = true;
            this.txtBoxPlacaVeiculo.Name = "txtBoxPlacaVeiculo";
            this.txtBoxPlacaVeiculo.Size = new System.Drawing.Size(200, 25);
            this.txtBoxPlacaVeiculo.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label2.Location = new System.Drawing.Point(229, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Telefone";
            // 
            // txtBoxTelefone
            // 
            this.txtBoxTelefone.Enabled = false;
            this.txtBoxTelefone.Location = new System.Drawing.Point(361, 157);
            this.txtBoxTelefone.Multiline = true;
            this.txtBoxTelefone.Name = "txtBoxTelefone";
            this.txtBoxTelefone.Size = new System.Drawing.Size(200, 25);
            this.txtBoxTelefone.TabIndex = 8;
            // 
            // txtBoxNomePessoa
            // 
            this.txtBoxNomePessoa.Enabled = false;
            this.txtBoxNomePessoa.Location = new System.Drawing.Point(361, 89);
            this.txtBoxNomePessoa.Multiline = true;
            this.txtBoxNomePessoa.Name = "txtBoxNomePessoa";
            this.txtBoxNomePessoa.Size = new System.Drawing.Size(200, 25);
            this.txtBoxNomePessoa.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label1.Location = new System.Drawing.Point(229, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome completo";
            // 
            // botaEditar
            // 
            this.botaEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.botaEditar.FlatAppearance.BorderSize = 0;
            this.botaEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaEditar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaEditar.ForeColor = System.Drawing.Color.White;
            this.botaEditar.Location = new System.Drawing.Point(871, 91);
            this.botaEditar.Name = "botaEditar";
            this.botaEditar.Size = new System.Drawing.Size(75, 23);
            this.botaEditar.TabIndex = 12;
            this.botaEditar.Text = "Editar";
            this.botaEditar.UseVisualStyleBackColor = false;
            this.botaEditar.Click += new System.EventHandler(this.botaEditar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label4.Location = new System.Drawing.Point(229, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Dados do Cliente";
            // 
            // txbServicosPrestados
            // 
            this.txbServicosPrestados.Location = new System.Drawing.Point(228, 300);
            this.txbServicosPrestados.Multiline = true;
            this.txbServicosPrestados.Name = "txbServicosPrestados";
            this.txbServicosPrestados.Size = new System.Drawing.Size(566, 150);
            this.txbServicosPrestados.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label5.Location = new System.Drawing.Point(229, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Serviços Prestados";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(600, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 16;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.CliqueBotaoSalvar);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(728, 497);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 30);
            this.button4.TabIndex = 17;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.CliqueBotaoCancelar);
            // 
            // botaoExcluir
            // 
            this.botaoExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(45)))));
            this.botaoExcluir.FlatAppearance.BorderSize = 0;
            this.botaoExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoExcluir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoExcluir.ForeColor = System.Drawing.Color.White;
            this.botaoExcluir.Location = new System.Drawing.Point(871, 147);
            this.botaoExcluir.Name = "botaoExcluir";
            this.botaoExcluir.Size = new System.Drawing.Size(75, 23);
            this.botaoExcluir.TabIndex = 18;
            this.botaoExcluir.Text = "Excluir";
            this.botaoExcluir.UseVisualStyleBackColor = false;
            this.botaoExcluir.Click += new System.EventHandler(this.botaoExcluir_Click);
            //this.botaoExcluir.Click += new System.Windows.Forms.FormClosingEventArgs(this.botaoExcluir_Click);
            // 
            // FormCadastroServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 583);
            this.Controls.Add(this.botaoExcluir);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbServicosPrestados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.botaEditar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxPlacaVeiculo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxTelefone);
            this.Controls.Add(this.txtBoxNomePessoa);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FormCadastroServicos";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtBoxNomePessoa, 0);
            this.Controls.SetChildIndex(this.txtBoxTelefone, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtBoxPlacaVeiculo, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.botaEditar, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txbServicosPrestados, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.botaoExcluir, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource pessoasBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxPlacaVeiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxTelefone;
        private System.Windows.Forms.TextBox txtBoxNomePessoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botaEditar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbServicosPrestados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button botaoExcluir;
    }
}