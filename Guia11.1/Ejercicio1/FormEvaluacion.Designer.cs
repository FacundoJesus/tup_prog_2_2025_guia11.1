namespace Ejercicio1
{
    partial class FormEvaluacion
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
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            lsbNombre = new ListBox();
            lsbDescrpcion = new ListBox();
            tbMinimo = new TextBox();
            tbMaximo = new TextBox();
            tbValorMedido = new TextBox();
            checkBox1 = new CheckBox();
            btnSiguiente = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 37);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 85);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "Descripción:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbValorMedido);
            groupBox1.Controls.Add(tbMaximo);
            groupBox1.Controls.Add(tbMinimo);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 131);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(544, 100);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Evaluación Paramétrica";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(418, 19);
            label6.Name = "label6";
            label6.Size = new Size(77, 15);
            label6.TabIndex = 3;
            label6.Text = "Valor Medido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(311, 19);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 2;
            label5.Text = "Máximo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(192, 19);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 1;
            label4.Text = "Mínimo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 44);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 0;
            label3.Text = "Valores (%):";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Location = new Point(12, 237);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(544, 100);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Evaluación Simple";
            // 
            // lsbNombre
            // 
            lsbNombre.FormattingEnabled = true;
            lsbNombre.ItemHeight = 15;
            lsbNombre.Location = new Point(90, 27);
            lsbNombre.Name = "lsbNombre";
            lsbNombre.Size = new Size(466, 34);
            lsbNombre.TabIndex = 4;
            // 
            // lsbDescrpcion
            // 
            lsbDescrpcion.FormattingEnabled = true;
            lsbDescrpcion.ItemHeight = 15;
            lsbDescrpcion.Location = new Point(90, 76);
            lsbDescrpcion.Name = "lsbDescrpcion";
            lsbDescrpcion.Size = new Size(466, 34);
            lsbDescrpcion.TabIndex = 5;
            // 
            // tbMinimo
            // 
            tbMinimo.Location = new Point(167, 41);
            tbMinimo.Name = "tbMinimo";
            tbMinimo.Size = new Size(100, 23);
            tbMinimo.TabIndex = 4;
            // 
            // tbMaximo
            // 
            tbMaximo.Location = new Point(288, 41);
            tbMaximo.Name = "tbMaximo";
            tbMaximo.Size = new Size(100, 23);
            tbMaximo.TabIndex = 5;
            // 
            // tbValorMedido
            // 
            tbValorMedido.Location = new Point(406, 41);
            tbValorMedido.Name = "tbValorMedido";
            tbValorMedido.Size = new Size(100, 23);
            tbValorMedido.TabIndex = 6;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(167, 47);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(196, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "¿El funcionamiento es Correcto?";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            btnSiguiente.DialogResult = DialogResult.OK;
            btnSiguiente.Location = new Point(228, 343);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(94, 34);
            btnSiguiente.TabIndex = 6;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // FormEvaluacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 390);
            Controls.Add(btnSiguiente);
            Controls.Add(lsbDescrpcion);
            Controls.Add(lsbNombre);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormEvaluacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Evaluacion Vehicular";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private GroupBox groupBox2;
        private Button btnSiguiente;
        public TextBox tbMinimo;
        public TextBox tbValorMedido;
        public TextBox tbMaximo;
        public CheckBox checkBox1;
        public ListBox lsbNombre;
        public ListBox lsbDescrpcion;
    }
}