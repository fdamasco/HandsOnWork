﻿
namespace HandsOnWork
{
    partial class Form_Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Clientes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Listar = new System.Windows.Forms.Button();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.txt_Conta = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Cpf = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.lbl_Conta = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_CPF = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.dgv_Clientes = new System.Windows.Forms.DataGridView();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Conta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btn_Listar);
            this.panel1.Controls.Add(this.txt_ID);
            this.panel1.Controls.Add(this.lbl_ID);
            this.panel1.Controls.Add(this.btn_Excluir);
            this.panel1.Controls.Add(this.btn_Editar);
            this.panel1.Controls.Add(this.btn_Novo);
            this.panel1.Controls.Add(this.txt_Conta);
            this.panel1.Controls.Add(this.txt_Email);
            this.panel1.Controls.Add(this.txt_Cpf);
            this.panel1.Controls.Add(this.txt_Nome);
            this.panel1.Controls.Add(this.lbl_Conta);
            this.panel1.Controls.Add(this.lbl_Email);
            this.panel1.Controls.Add(this.lbl_CPF);
            this.panel1.Controls.Add(this.lbl_Nome);
            this.panel1.Location = new System.Drawing.Point(39, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 167);
            this.panel1.TabIndex = 0;
            // 
            // btn_Listar
            // 
            this.btn_Listar.Location = new System.Drawing.Point(492, 122);
            this.btn_Listar.Name = "btn_Listar";
            this.btn_Listar.Size = new System.Drawing.Size(75, 26);
            this.btn_Listar.TabIndex = 12;
            this.btn_Listar.Text = "Listar";
            this.btn_Listar.UseVisualStyleBackColor = true;
            this.btn_Listar.Click += new System.EventHandler(this.btn_Listar_Click);
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(79, 24);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(46, 20);
            this.txt_ID.TabIndex = 1;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(21, 27);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(21, 13);
            this.lbl_ID.TabIndex = 11;
            this.lbl_ID.Text = "ID:";
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(492, 89);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Excluir.TabIndex = 10;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(492, 56);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(75, 23);
            this.btn_Editar.TabIndex = 9;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Novo
            // 
            this.btn_Novo.Location = new System.Drawing.Point(492, 20);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(75, 26);
            this.btn_Novo.TabIndex = 8;
            this.btn_Novo.Text = "Cadastrar";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // txt_Conta
            // 
            this.txt_Conta.Location = new System.Drawing.Point(79, 124);
            this.txt_Conta.Name = "txt_Conta";
            this.txt_Conta.Size = new System.Drawing.Size(363, 20);
            this.txt_Conta.TabIndex = 5;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(79, 99);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(363, 20);
            this.txt_Email.TabIndex = 4;
            // 
            // txt_Cpf
            // 
            this.txt_Cpf.Location = new System.Drawing.Point(79, 74);
            this.txt_Cpf.Name = "txt_Cpf";
            this.txt_Cpf.Size = new System.Drawing.Size(363, 20);
            this.txt_Cpf.TabIndex = 3;
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(79, 49);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(363, 20);
            this.txt_Nome.TabIndex = 2;
            // 
            // lbl_Conta
            // 
            this.lbl_Conta.AutoSize = true;
            this.lbl_Conta.Location = new System.Drawing.Point(21, 127);
            this.lbl_Conta.Name = "lbl_Conta";
            this.lbl_Conta.Size = new System.Drawing.Size(38, 13);
            this.lbl_Conta.TabIndex = 3;
            this.lbl_Conta.Text = "Conta:";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(21, 102);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(38, 13);
            this.lbl_Email.TabIndex = 2;
            this.lbl_Email.Text = "E-mail:";
            // 
            // lbl_CPF
            // 
            this.lbl_CPF.AutoSize = true;
            this.lbl_CPF.Location = new System.Drawing.Point(21, 77);
            this.lbl_CPF.Name = "lbl_CPF";
            this.lbl_CPF.Size = new System.Drawing.Size(30, 13);
            this.lbl_CPF.TabIndex = 1;
            this.lbl_CPF.Text = "CPF:";
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Location = new System.Drawing.Point(21, 52);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(38, 13);
            this.lbl_Nome.TabIndex = 0;
            this.lbl_Nome.Text = "Nome:";
            // 
            // dgv_Clientes
            // 
            this.dgv_Clientes.AllowUserToAddRows = false;
            this.dgv_Clientes.AllowUserToDeleteRows = false;
            this.dgv_Clientes.AllowUserToOrderColumns = true;
            this.dgv_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ID,
            this.cl_Nome,
            this.cl_CPF,
            this.cl_Email,
            this.cl_Conta});
            this.dgv_Clientes.Location = new System.Drawing.Point(39, 212);
            this.dgv_Clientes.MultiSelect = false;
            this.dgv_Clientes.Name = "dgv_Clientes";
            this.dgv_Clientes.ReadOnly = true;
            this.dgv_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Clientes.Size = new System.Drawing.Size(614, 216);
            this.dgv_Clientes.TabIndex = 1;
            this.dgv_Clientes.DoubleClick += new System.EventHandler(this.dgv_Clientes_DoubleClick);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(487, 445);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpar.TabIndex = 3;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Location = new System.Drawing.Point(406, 445);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(75, 23);
            this.btn_Fechar.TabIndex = 13;
            this.btn_Fechar.Text = "Fechar";
            this.btn_Fechar.UseVisualStyleBackColor = true;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click_1);
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.Location = new System.Drawing.Point(568, 445);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(75, 23);
            this.btn_Pesquisar.TabIndex = 14;
            this.btn_Pesquisar.Text = "Pesquisar";
            this.btn_Pesquisar.UseVisualStyleBackColor = true;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // col_ID
            // 
            this.col_ID.HeaderText = "Id";
            this.col_ID.Name = "col_ID";
            this.col_ID.ReadOnly = true;
            this.col_ID.Width = 40;
            // 
            // cl_Nome
            // 
            this.cl_Nome.HeaderText = "Nome";
            this.cl_Nome.Name = "cl_Nome";
            this.cl_Nome.ReadOnly = true;
            this.cl_Nome.Width = 180;
            // 
            // cl_CPF
            // 
            this.cl_CPF.HeaderText = "CPF";
            this.cl_CPF.Name = "cl_CPF";
            this.cl_CPF.ReadOnly = true;
            this.cl_CPF.Width = 135;
            // 
            // cl_Email
            // 
            this.cl_Email.HeaderText = "E-mail";
            this.cl_Email.Name = "cl_Email";
            this.cl_Email.ReadOnly = true;
            this.cl_Email.Width = 140;
            // 
            // cl_Conta
            // 
            this.cl_Conta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cl_Conta.HeaderText = "Conta";
            this.cl_Conta.Name = "cl_Conta";
            this.cl_Conta.ReadOnly = true;
            // 
            // Form_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 495);
            this.Controls.Add(this.btn_Pesquisar);
            this.Controls.Add(this.btn_Fechar);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.dgv_Clientes);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.TextBox txt_Conta;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Cpf;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label lbl_Conta;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_CPF;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.DataGridView dgv_Clientes;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_Listar;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.Button btn_Pesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Conta;
    }
}