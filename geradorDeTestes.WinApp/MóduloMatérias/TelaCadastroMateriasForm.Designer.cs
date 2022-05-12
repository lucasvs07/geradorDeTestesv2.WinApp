namespace geradorDeTestes.WinApp
{
    partial class TelaCadastroMateriasForm
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
            this.textBoxNumMateria = new System.Windows.Forms.TextBox();
            this.textBoxNomeMateria = new System.Windows.Forms.TextBox();
            this.comboBoxDisciplina = new System.Windows.Forms.ComboBox();
            this.radioButtonSerie1 = new System.Windows.Forms.RadioButton();
            this.radioButtonSerie2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalvarMateria = new System.Windows.Forms.Button();
            this.btnCancelarMateria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNumMateria
            // 
            this.textBoxNumMateria.Location = new System.Drawing.Point(76, 12);
            this.textBoxNumMateria.Name = "textBoxNumMateria";
            this.textBoxNumMateria.Size = new System.Drawing.Size(100, 23);
            this.textBoxNumMateria.TabIndex = 0;
            this.textBoxNumMateria.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxNomeMateria
            // 
            this.textBoxNomeMateria.Location = new System.Drawing.Point(76, 50);
            this.textBoxNomeMateria.Name = "textBoxNomeMateria";
            this.textBoxNomeMateria.Size = new System.Drawing.Size(263, 23);
            this.textBoxNomeMateria.TabIndex = 2;
            this.textBoxNomeMateria.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // comboBoxDisciplina
            // 
            this.comboBoxDisciplina.FormattingEnabled = true;
            this.comboBoxDisciplina.Location = new System.Drawing.Point(76, 90);
            this.comboBoxDisciplina.Name = "comboBoxDisciplina";
            this.comboBoxDisciplina.Size = new System.Drawing.Size(121, 23);
            this.comboBoxDisciplina.TabIndex = 3;
            this.comboBoxDisciplina.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // radioButtonSerie1
            // 
            this.radioButtonSerie1.AutoSize = true;
            this.radioButtonSerie1.Location = new System.Drawing.Point(76, 146);
            this.radioButtonSerie1.Name = "radioButtonSerie1";
            this.radioButtonSerie1.Size = new System.Drawing.Size(63, 19);
            this.radioButtonSerie1.TabIndex = 4;
            this.radioButtonSerie1.TabStop = true;
            this.radioButtonSerie1.Text = "1ª série";
            this.radioButtonSerie1.UseVisualStyleBackColor = true;
            this.radioButtonSerie1.CheckedChanged += new System.EventHandler(this.radioButtonSerie1_CheckedChanged);
            // 
            // radioButtonSerie2
            // 
            this.radioButtonSerie2.AutoSize = true;
            this.radioButtonSerie2.Location = new System.Drawing.Point(176, 146);
            this.radioButtonSerie2.Name = "radioButtonSerie2";
            this.radioButtonSerie2.Size = new System.Drawing.Size(63, 19);
            this.radioButtonSerie2.TabIndex = 5;
            this.radioButtonSerie2.TabStop = true;
            this.radioButtonSerie2.Text = "2ª série";
            this.radioButtonSerie2.UseVisualStyleBackColor = true;
            this.radioButtonSerie2.CheckedChanged += new System.EventHandler(this.radioButtonSerie2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Disciplina:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Série";
            // 
            // btnSalvarMateria
            // 
            this.btnSalvarMateria.Location = new System.Drawing.Point(206, 259);
            this.btnSalvarMateria.Name = "btnSalvarMateria";
            this.btnSalvarMateria.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarMateria.TabIndex = 10;
            this.btnSalvarMateria.Text = "Salvar";
            this.btnSalvarMateria.UseVisualStyleBackColor = true;
            this.btnSalvarMateria.Click += new System.EventHandler(this.btnSalvarMateria_Click);
            // 
            // btnCancelarMateria
            // 
            this.btnCancelarMateria.Location = new System.Drawing.Point(287, 259);
            this.btnCancelarMateria.Name = "btnCancelarMateria";
            this.btnCancelarMateria.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarMateria.TabIndex = 11;
            this.btnCancelarMateria.Text = "Cancelar";
            this.btnCancelarMateria.UseVisualStyleBackColor = true;
            this.btnCancelarMateria.Click += new System.EventHandler(this.btnCancelarMateria_Click);
            // 
            // TelaCadastroMateriasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 294);
            this.Controls.Add(this.btnCancelarMateria);
            this.Controls.Add(this.btnSalvarMateria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonSerie2);
            this.Controls.Add(this.radioButtonSerie1);
            this.Controls.Add(this.comboBoxDisciplina);
            this.Controls.Add(this.textBoxNomeMateria);
            this.Controls.Add(this.textBoxNumMateria);
            this.Name = "TelaCadastroMateriasForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Cadastro De Matérias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumMateria;
        private System.Windows.Forms.TextBox textBoxNomeMateria;
        private System.Windows.Forms.ComboBox comboBoxDisciplina;
        private System.Windows.Forms.RadioButton radioButtonSerie1;
        private System.Windows.Forms.RadioButton radioButtonSerie2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalvarMateria;
        private System.Windows.Forms.Button btnCancelarMateria;
    }
}