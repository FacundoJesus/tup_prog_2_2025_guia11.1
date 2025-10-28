namespace Ejercicio1
{
    partial class FormPrincipal
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            btnVerVTVRealizados = new Button();
            btnImportarVTVs = new Button();
            btnExportarVehiculos = new Button();
            btnIniciarCarga = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbDNI = new TextBox();
            btnBuscarPatente = new Button();
            tbApellyNom = new TextBox();
            tbCorreo = new TextBox();
            tbPatente = new TextBox();
            dtpFecha = new DateTimePicker();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnIniciarCarga);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(566, 379);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro de VTV";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbCorreo);
            groupBox2.Controls.Add(tbApellyNom);
            groupBox2.Controls.Add(tbDNI);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(6, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(554, 146);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos del Propietario";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dtpFecha);
            groupBox3.Controls.Add(tbPatente);
            groupBox3.Controls.Add(btnBuscarPatente);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(6, 174);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(554, 146);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos del Vehículo";
            // 
            // btnVerVTVRealizados
            // 
            btnVerVTVRealizados.Location = new Point(584, 34);
            btnVerVTVRealizados.Name = "btnVerVTVRealizados";
            btnVerVTVRealizados.Size = new Size(98, 72);
            btnVerVTVRealizados.TabIndex = 1;
            btnVerVTVRealizados.Text = "Ver VTV Realizados";
            btnVerVTVRealizados.UseVisualStyleBackColor = true;
            // 
            // btnImportarVTVs
            // 
            btnImportarVTVs.Location = new Point(584, 155);
            btnImportarVTVs.Name = "btnImportarVTVs";
            btnImportarVTVs.Size = new Size(98, 72);
            btnImportarVTVs.TabIndex = 2;
            btnImportarVTVs.Text = "Importar VTVs";
            btnImportarVTVs.UseVisualStyleBackColor = true;
            // 
            // btnExportarVehiculos
            // 
            btnExportarVehiculos.Location = new Point(584, 291);
            btnExportarVehiculos.Name = "btnExportarVehiculos";
            btnExportarVehiculos.Size = new Size(98, 72);
            btnExportarVehiculos.TabIndex = 3;
            btnExportarVehiculos.Text = "Exportar Vehículos";
            btnExportarVehiculos.UseVisualStyleBackColor = true;
            // 
            // btnIniciarCarga
            // 
            btnIniciarCarga.Location = new Point(223, 326);
            btnIniciarCarga.Name = "btnIniciarCarga";
            btnIniciarCarga.Size = new Size(135, 43);
            btnIniciarCarga.TabIndex = 4;
            btnIniciarCarga.Text = "Iniciar CargaVTV";
            btnIniciarCarga.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(168, 30);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "DNI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 60);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido y Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(152, 96);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 2;
            label3.Text = "Correo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(151, 48);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 3;
            label4.Text = "Patente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(122, 91);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 4;
            label5.Text = "Fecha de hoy";
            // 
            // tbDNI
            // 
            tbDNI.Location = new Point(204, 27);
            tbDNI.Name = "tbDNI";
            tbDNI.Size = new Size(187, 23);
            tbDNI.TabIndex = 3;
            // 
            // btnBuscarPatente
            // 
            btnBuscarPatente.Location = new Point(408, 40);
            btnBuscarPatente.Name = "btnBuscarPatente";
            btnBuscarPatente.Size = new Size(75, 23);
            btnBuscarPatente.TabIndex = 5;
            btnBuscarPatente.Text = "Buscar";
            btnBuscarPatente.UseVisualStyleBackColor = true;
            // 
            // tbApellyNom
            // 
            tbApellyNom.Location = new Point(204, 60);
            tbApellyNom.Name = "tbApellyNom";
            tbApellyNom.Size = new Size(187, 23);
            tbApellyNom.TabIndex = 4;
            // 
            // tbCorreo
            // 
            tbCorreo.Location = new Point(204, 93);
            tbCorreo.Name = "tbCorreo";
            tbCorreo.Size = new Size(187, 23);
            tbCorreo.TabIndex = 5;
            // 
            // tbPatente
            // 
            tbPatente.Location = new Point(204, 40);
            tbPatente.Name = "tbPatente";
            tbPatente.Size = new Size(187, 23);
            tbPatente.TabIndex = 6;
            // 
            // dtpFecha
            // 
            dtpFecha.CustomFormat = "dd/MM/yyyy";
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.Location = new Point(205, 85);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(186, 23);
            dtpFecha.TabIndex = 7;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 402);
            Controls.Add(btnExportarVehiculos);
            Controls.Add(btnImportarVTVs);
            Controls.Add(btnVerVTVRealizados);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnIniciarCarga;
        private GroupBox groupBox3;
        private Label label5;
        private Label label4;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnVerVTVRealizados;
        private Button btnImportarVTVs;
        private Button btnExportarVehiculos;
        private DateTimePicker dtpFecha;
        private TextBox tbPatente;
        private Button btnBuscarPatente;
        private TextBox tbCorreo;
        private TextBox tbApellyNom;
        private TextBox tbDNI;
    }
}
