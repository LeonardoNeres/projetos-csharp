﻿namespace SistemaDeCadastro
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.comboEC = new System.Windows.Forms.ComboBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.checkCasa = new System.Windows.Forms.CheckBox();
            this.checkVeiculo = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioO = new System.Windows.Forms.RadioButton();
            this.radioF = new System.Windows.Forms.RadioButton();
            this.radioM = new System.Windows.Forms.RadioButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.lista = new System.Windows.Forms.ListBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Nascimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estado Civil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(249, 7);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(517, 31);
            this.txtNome.TabIndex = 4;
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(249, 43);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(517, 31);
            this.txtData.TabIndex = 5;
            // 
            // comboEC
            // 
            this.comboEC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEC.FormattingEnabled = true;
            this.comboEC.Location = new System.Drawing.Point(249, 86);
            this.comboEC.Name = "comboEC";
            this.comboEC.Size = new System.Drawing.Size(405, 33);
            this.comboEC.TabIndex = 6;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(249, 122);
            this.txtTelefone.Mask = "(00) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(405, 31);
            this.txtTelefone.TabIndex = 7;
            // 
            // checkCasa
            // 
            this.checkCasa.AutoSize = true;
            this.checkCasa.Location = new System.Drawing.Point(297, 174);
            this.checkCasa.Name = "checkCasa";
            this.checkCasa.Size = new System.Drawing.Size(120, 17);
            this.checkCasa.TabIndex = 8;
            this.checkCasa.Text = "Possui Casa Própria";
            this.checkCasa.UseVisualStyleBackColor = true;
            // 
            // checkVeiculo
            // 
            this.checkVeiculo.AutoSize = true;
            this.checkVeiculo.Location = new System.Drawing.Point(297, 217);
            this.checkVeiculo.Name = "checkVeiculo";
            this.checkVeiculo.Size = new System.Drawing.Size(96, 17);
            this.checkVeiculo.TabIndex = 9;
            this.checkVeiculo.Text = "Possui veículo";
            this.checkVeiculo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioO);
            this.groupBox1.Controls.Add(this.radioF);
            this.groupBox1.Controls.Add(this.radioM);
            this.groupBox1.Location = new System.Drawing.Point(265, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 121);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // radioO
            // 
            this.radioO.AutoSize = true;
            this.radioO.Location = new System.Drawing.Point(7, 87);
            this.radioO.Name = "radioO";
            this.radioO.Size = new System.Drawing.Size(51, 17);
            this.radioO.TabIndex = 2;
            this.radioO.Text = "Outro";
            this.radioO.UseVisualStyleBackColor = true;
            // 
            // radioF
            // 
            this.radioF.AutoSize = true;
            this.radioF.Location = new System.Drawing.Point(7, 58);
            this.radioF.Name = "radioF";
            this.radioF.Size = new System.Drawing.Size(67, 17);
            this.radioF.TabIndex = 1;
            this.radioF.Text = "Feminino";
            this.radioF.UseVisualStyleBackColor = true;
            // 
            // radioM
            // 
            this.radioM.AutoSize = true;
            this.radioM.Checked = true;
            this.radioM.Location = new System.Drawing.Point(7, 29);
            this.radioM.Name = "radioM";
            this.radioM.Size = new System.Drawing.Size(73, 17);
            this.radioM.TabIndex = 0;
            this.radioM.TabStop = true;
            this.radioM.Text = "Masculino";
            this.radioM.UseVisualStyleBackColor = true;
            // 
            // lista
            // 
            this.lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 25;
            this.lista.Location = new System.Drawing.Point(80, 492);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(873, 204);
            this.lista.TabIndex = 11;
            this.lista.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lista_MouseDoubleClick);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(249, 423);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(177, 63);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Cadastrar / Alterar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(498, 423);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(168, 63);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(738, 423);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(168, 63);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 825);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkVeiculo);
            this.Controls.Add(this.checkCasa);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.comboEC);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DateTimePicker txtData;
        private System.Windows.Forms.ComboBox comboEC;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.CheckBox checkCasa;
        private System.Windows.Forms.CheckBox checkVeiculo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioF;
        private System.Windows.Forms.RadioButton radioM;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.RadioButton radioO;
    }
}

