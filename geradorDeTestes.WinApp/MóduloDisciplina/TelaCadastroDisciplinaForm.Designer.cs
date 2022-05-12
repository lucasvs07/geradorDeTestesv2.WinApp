namespace geradorDeTestes.WinApp
{
    partial class TelaCadastroDisciplinaForm
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
            this.btnSalvarDisciplina = new System.Windows.Forms.Button();
            this.btnCancelarDisciplina = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelNumeroDisciplina = new System.Windows.Forms.Label();
            this.labelNomeDisciplina = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalvarDisciplina
            // 
            this.btnSalvarDisciplina.Location = new System.Drawing.Point(184, 193);
            this.btnSalvarDisciplina.Name = "btnSalvarDisciplina";
            this.btnSalvarDisciplina.Size = new System.Drawing.Size(102, 38);
            this.btnSalvarDisciplina.TabIndex = 0;
            this.btnSalvarDisciplina.Text = "Salvar";
            this.btnSalvarDisciplina.UseVisualStyleBackColor = true;
            this.btnSalvarDisciplina.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelarDisciplina
            // 
            this.btnCancelarDisciplina.Location = new System.Drawing.Point(292, 193);
            this.btnCancelarDisciplina.Name = "btnCancelarDisciplina";
            this.btnCancelarDisciplina.Size = new System.Drawing.Size(102, 38);
            this.btnCancelarDisciplina.TabIndex = 1;
            this.btnCancelarDisciplina.Text = "Cancelar";
            this.btnCancelarDisciplina.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(87, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(307, 23);
            this.textBox2.TabIndex = 3;
            // 
            // labelNumeroDisciplina
            // 
            this.labelNumeroDisciplina.AutoSize = true;
            this.labelNumeroDisciplina.Location = new System.Drawing.Point(13, 16);
            this.labelNumeroDisciplina.Name = "labelNumeroDisciplina";
            this.labelNumeroDisciplina.Size = new System.Drawing.Size(54, 15);
            this.labelNumeroDisciplina.TabIndex = 4;
            this.labelNumeroDisciplina.Text = "Numero:";
            // 
            // labelNomeDisciplina
            // 
            this.labelNomeDisciplina.AutoSize = true;
            this.labelNomeDisciplina.Location = new System.Drawing.Point(16, 60);
            this.labelNomeDisciplina.Name = "labelNomeDisciplina";
            this.labelNomeDisciplina.Size = new System.Drawing.Size(43, 15);
            this.labelNomeDisciplina.TabIndex = 5;
            this.labelNomeDisciplina.Text = "Nome:";
            // 
            // TelaCadastroDisciplinaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 243);
            this.Controls.Add(this.labelNomeDisciplina);
            this.Controls.Add(this.labelNumeroDisciplina);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCancelarDisciplina);
            this.Controls.Add(this.btnSalvarDisciplina);
            this.Name = "TelaCadastroDisciplinaForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Cadastro de Disciplina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvarDisciplina;
        private System.Windows.Forms.Button btnCancelarDisciplina;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelNumeroDisciplina;
        private System.Windows.Forms.Label labelNomeDisciplina;
    }
}
