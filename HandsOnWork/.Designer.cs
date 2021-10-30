
namespace HandsOnWork
{
    partial class Form_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Menu));
            this.btn_Clientes = new System.Windows.Forms.Button();
            this.btn_funcionarios = new System.Windows.Forms.Button();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Clientes
            // 
            this.btn_Clientes.BackColor = System.Drawing.Color.White;
            this.btn_Clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clientes.Location = new System.Drawing.Point(39, 97);
            this.btn_Clientes.Name = "btn_Clientes";
            this.btn_Clientes.Size = new System.Drawing.Size(139, 48);
            this.btn_Clientes.TabIndex = 0;
            this.btn_Clientes.Text = "CLIENTES";
            this.btn_Clientes.UseVisualStyleBackColor = false;
            this.btn_Clientes.Click += new System.EventHandler(this.btn_Clientes_Click);
            // 
            // btn_funcionarios
            // 
            this.btn_funcionarios.BackColor = System.Drawing.Color.White;
            this.btn_funcionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_funcionarios.Location = new System.Drawing.Point(39, 151);
            this.btn_funcionarios.Name = "btn_funcionarios";
            this.btn_funcionarios.Size = new System.Drawing.Size(139, 48);
            this.btn_funcionarios.TabIndex = 1;
            this.btn_funcionarios.Text = "FUNCIONÁRIOS";
            this.btn_funcionarios.UseVisualStyleBackColor = false;
            this.btn_funcionarios.Click += new System.EventHandler(this.btn_funcionarios_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.White;
            this.lbl_Titulo.Font = new System.Drawing.Font("Bauhaus 93", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(52, 39);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(113, 30);
            this.lbl_Titulo.TabIndex = 4;
            this.lbl_Titulo.Text = "UniBank";
            this.lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(217, 252);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.btn_funcionarios);
            this.Controls.Add(this.btn_Clientes);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Clientes;
        private System.Windows.Forms.Button btn_funcionarios;
        private System.Windows.Forms.Label lbl_Titulo;
    }
}

