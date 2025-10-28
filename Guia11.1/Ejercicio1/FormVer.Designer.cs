namespace Ejercicio1
{
    partial class FormVer
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
            lsbResultado = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // lsbResultado
            // 
            lsbResultado.FormattingEnabled = true;
            lsbResultado.HorizontalScrollbar = true;
            lsbResultado.ItemHeight = 15;
            lsbResultado.Location = new Point(12, 12);
            lsbResultado.Name = "lsbResultado";
            lsbResultado.ScrollAlwaysVisible = true;
            lsbResultado.Size = new Size(468, 199);
            lsbResultado.TabIndex = 0;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(199, 217);
            button1.Name = "button1";
            button1.Size = new Size(75, 38);
            button1.TabIndex = 1;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormVer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 264);
            Controls.Add(button1);
            Controls.Add(lsbResultado);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormVer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Resultados";
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        public ListBox lsbResultado;
    }
}