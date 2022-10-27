namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.button_inserirLista = new System.Windows.Forms.Button();
            this.textBox_listaNomes = new System.Windows.Forms.TextBox();
            this.textBox_listaEmails = new System.Windows.Forms.TextBox();
            this.button_listar = new System.Windows.Forms.Button();
            this.button_limpa = new System.Windows.Forms.Button();
            this.textBox_listaDominios = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOME";
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(87, 14);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(224, 23);
            this.textBox_nome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "EMAIL";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(86, 48);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(225, 23);
            this.textBox_email.TabIndex = 3;
            // 
            // button_inserirLista
            // 
            this.button_inserirLista.Location = new System.Drawing.Point(42, 102);
            this.button_inserirLista.Name = "button_inserirLista";
            this.button_inserirLista.Size = new System.Drawing.Size(108, 23);
            this.button_inserirLista.TabIndex = 4;
            this.button_inserirLista.Text = "INSERIR";
            this.button_inserirLista.UseVisualStyleBackColor = true;
            this.button_inserirLista.Click += new System.EventHandler(this.button_inserirLista_Click);
            // 
            // textBox_listaNomes
            // 
            this.textBox_listaNomes.Location = new System.Drawing.Point(39, 140);
            this.textBox_listaNomes.Multiline = true;
            this.textBox_listaNomes.Name = "textBox_listaNomes";
            this.textBox_listaNomes.ReadOnly = true;
            this.textBox_listaNomes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_listaNomes.Size = new System.Drawing.Size(217, 225);
            this.textBox_listaNomes.TabIndex = 5;
            // 
            // textBox_listaEmails
            // 
            this.textBox_listaEmails.Location = new System.Drawing.Point(300, 140);
            this.textBox_listaEmails.Multiline = true;
            this.textBox_listaEmails.Name = "textBox_listaEmails";
            this.textBox_listaEmails.ReadOnly = true;
            this.textBox_listaEmails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_listaEmails.Size = new System.Drawing.Size(217, 225);
            this.textBox_listaEmails.TabIndex = 6;
            // 
            // button_listar
            // 
            this.button_listar.Location = new System.Drawing.Point(188, 104);
            this.button_listar.Name = "button_listar";
            this.button_listar.Size = new System.Drawing.Size(75, 23);
            this.button_listar.TabIndex = 7;
            this.button_listar.Text = "LISTAR";
            this.button_listar.UseVisualStyleBackColor = true;
            this.button_listar.Click += new System.EventHandler(this.button_listar_Click);
            // 
            // button_limpa
            // 
            this.button_limpa.Location = new System.Drawing.Point(310, 104);
            this.button_limpa.Name = "button_limpa";
            this.button_limpa.Size = new System.Drawing.Size(75, 23);
            this.button_limpa.TabIndex = 8;
            this.button_limpa.Text = "LIMPAR";
            this.button_limpa.UseVisualStyleBackColor = true;
            this.button_limpa.Click += new System.EventHandler(this.button_limpa_Click);
            // 
            // textBox_listaDominios
            // 
            this.textBox_listaDominios.Location = new System.Drawing.Point(558, 140);
            this.textBox_listaDominios.Multiline = true;
            this.textBox_listaDominios.Name = "textBox_listaDominios";
            this.textBox_listaDominios.ReadOnly = true;
            this.textBox_listaDominios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_listaDominios.Size = new System.Drawing.Size(217, 225);
            this.textBox_listaDominios.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_listaDominios);
            this.Controls.Add(this.button_limpa);
            this.Controls.Add(this.button_listar);
            this.Controls.Add(this.textBox_listaEmails);
            this.Controls.Add(this.textBox_listaNomes);
            this.Controls.Add(this.button_inserirLista);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_nome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tela Questao 02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox_nome;
        private Label label2;
        private TextBox textBox_email;
        private Button button_inserirLista;
        private TextBox textBox_listaNomes;
        private TextBox textBox_listaEmails;
        private Button button_listar;
        private Button button_limpa;
        private TextBox textBox_listaDominios;
    }
}