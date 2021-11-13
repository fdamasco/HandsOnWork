
namespace HandsOnWork
{
    partial class Form_PesquisarClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_PesquisarClientes));
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.lst_Pesquisa = new System.Windows.Forms.ListBox();
            this.btn_Selecionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Location = new System.Drawing.Point(231, 403);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(75, 23);
            this.btn_Fechar.TabIndex = 14;
            this.btn_Fechar.Text = "Fechar";
            this.btn_Fechar.UseVisualStyleBackColor = true;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // lst_Pesquisa
            // 
            this.lst_Pesquisa.FormattingEnabled = true;
            this.lst_Pesquisa.Location = new System.Drawing.Point(12, 12);
            this.lst_Pesquisa.Name = "lst_Pesquisa";
            this.lst_Pesquisa.Size = new System.Drawing.Size(387, 381);
            this.lst_Pesquisa.TabIndex = 15;
            // 
            // btn_Selecionar
            // 
            this.btn_Selecionar.Location = new System.Drawing.Point(312, 403);
            this.btn_Selecionar.Name = "btn_Selecionar";
            this.btn_Selecionar.Size = new System.Drawing.Size(75, 23);
            this.btn_Selecionar.TabIndex = 16;
            this.btn_Selecionar.Text = "Selecionar";
            this.btn_Selecionar.UseVisualStyleBackColor = true;
            this.btn_Selecionar.Click += new System.EventHandler(this.btn_Selecionar_Click);
            // 
            // Form_PesquisarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 438);
            this.Controls.Add(this.btn_Selecionar);
            this.Controls.Add(this.lst_Pesquisa);
            this.Controls.Add(this.btn_Fechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_PesquisarClientes";
            this.Text = "Lista de Clientes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.ListBox lst_Pesquisa;
        private System.Windows.Forms.Button btn_Selecionar;
    }
}