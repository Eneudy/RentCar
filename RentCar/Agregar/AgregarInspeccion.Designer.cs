﻿namespace RentCar
{
    partial class AgregarInspeccion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CmbIdEmpleado = new System.Windows.Forms.ComboBox();
            this.CmbIdCliente = new System.Windows.Forms.ComboBox();
            this.CmbIdVehiculo = new System.Windows.Forms.ComboBox();
            this.BtRegistrar = new System.Windows.Forms.Button();
            this.CmbEstadoGomas = new System.Windows.Forms.ComboBox();
            this.CmbRoturaCristal = new System.Windows.Forms.ComboBox();
            this.CmbGato = new System.Windows.Forms.ComboBox();
            this.CmbGomaRepuesto = new System.Windows.Forms.ComboBox();
            this.CmbCombustible = new System.Windows.Forms.ComboBox();
            this.CmbRalladuras = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DtpFechaInspeccion = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DtpFechaInspeccion);
            this.panel1.Controls.Add(this.CmbIdEmpleado);
            this.panel1.Controls.Add(this.CmbIdCliente);
            this.panel1.Controls.Add(this.CmbIdVehiculo);
            this.panel1.Controls.Add(this.BtRegistrar);
            this.panel1.Controls.Add(this.CmbEstadoGomas);
            this.panel1.Controls.Add(this.CmbRoturaCristal);
            this.panel1.Controls.Add(this.CmbGato);
            this.panel1.Controls.Add(this.CmbGomaRepuesto);
            this.panel1.Controls.Add(this.CmbCombustible);
            this.panel1.Controls.Add(this.CmbRalladuras);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(21, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 392);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // CmbIdEmpleado
            // 
            this.CmbIdEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbIdEmpleado.FormattingEnabled = true;
            this.CmbIdEmpleado.Location = new System.Drawing.Point(193, 355);
            this.CmbIdEmpleado.Name = "CmbIdEmpleado";
            this.CmbIdEmpleado.Size = new System.Drawing.Size(121, 21);
            this.CmbIdEmpleado.TabIndex = 29;
            // 
            // CmbIdCliente
            // 
            this.CmbIdCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbIdCliente.FormattingEnabled = true;
            this.CmbIdCliente.Location = new System.Drawing.Point(193, 66);
            this.CmbIdCliente.Name = "CmbIdCliente";
            this.CmbIdCliente.Size = new System.Drawing.Size(121, 21);
            this.CmbIdCliente.TabIndex = 28;
            // 
            // CmbIdVehiculo
            // 
            this.CmbIdVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbIdVehiculo.FormattingEnabled = true;
            this.CmbIdVehiculo.Location = new System.Drawing.Point(193, 27);
            this.CmbIdVehiculo.Name = "CmbIdVehiculo";
            this.CmbIdVehiculo.Size = new System.Drawing.Size(121, 21);
            this.CmbIdVehiculo.TabIndex = 27;
            // 
            // BtRegistrar
            // 
            this.BtRegistrar.Location = new System.Drawing.Point(418, 325);
            this.BtRegistrar.Name = "BtRegistrar";
            this.BtRegistrar.Size = new System.Drawing.Size(87, 51);
            this.BtRegistrar.TabIndex = 26;
            this.BtRegistrar.Text = "Registrar Inspeccion";
            this.BtRegistrar.UseVisualStyleBackColor = true;
            this.BtRegistrar.Click += new System.EventHandler(this.BtRegistrar_Click);
            // 
            // CmbEstadoGomas
            // 
            this.CmbEstadoGomas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEstadoGomas.FormattingEnabled = true;
            this.CmbEstadoGomas.Items.AddRange(new object[] {
            "Buen estado",
            "Mal estado"});
            this.CmbEstadoGomas.Location = new System.Drawing.Point(193, 279);
            this.CmbEstadoGomas.Name = "CmbEstadoGomas";
            this.CmbEstadoGomas.Size = new System.Drawing.Size(121, 21);
            this.CmbEstadoGomas.TabIndex = 25;
            // 
            // CmbRoturaCristal
            // 
            this.CmbRoturaCristal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbRoturaCristal.FormattingEnabled = true;
            this.CmbRoturaCristal.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.CmbRoturaCristal.Location = new System.Drawing.Point(193, 240);
            this.CmbRoturaCristal.Name = "CmbRoturaCristal";
            this.CmbRoturaCristal.Size = new System.Drawing.Size(121, 21);
            this.CmbRoturaCristal.TabIndex = 24;
            // 
            // CmbGato
            // 
            this.CmbGato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbGato.FormattingEnabled = true;
            this.CmbGato.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.CmbGato.Location = new System.Drawing.Point(193, 205);
            this.CmbGato.Name = "CmbGato";
            this.CmbGato.Size = new System.Drawing.Size(121, 21);
            this.CmbGato.TabIndex = 23;
            // 
            // CmbGomaRepuesto
            // 
            this.CmbGomaRepuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbGomaRepuesto.FormattingEnabled = true;
            this.CmbGomaRepuesto.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.CmbGomaRepuesto.Location = new System.Drawing.Point(193, 175);
            this.CmbGomaRepuesto.Name = "CmbGomaRepuesto";
            this.CmbGomaRepuesto.Size = new System.Drawing.Size(121, 21);
            this.CmbGomaRepuesto.TabIndex = 22;
            // 
            // CmbCombustible
            // 
            this.CmbCombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCombustible.FormattingEnabled = true;
            this.CmbCombustible.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.CmbCombustible.Location = new System.Drawing.Point(193, 142);
            this.CmbCombustible.Name = "CmbCombustible";
            this.CmbCombustible.Size = new System.Drawing.Size(121, 21);
            this.CmbCombustible.TabIndex = 21;
            // 
            // CmbRalladuras
            // 
            this.CmbRalladuras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbRalladuras.FormattingEnabled = true;
            this.CmbRalladuras.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.CmbRalladuras.Location = new System.Drawing.Point(193, 104);
            this.CmbRalladuras.Name = "CmbRalladuras";
            this.CmbRalladuras.Size = new System.Drawing.Size(121, 21);
            this.CmbRalladuras.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(71, 363);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "ID de Empleado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Fecha de Inspeccion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Estado de Gomas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "RoturaCristal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Gato";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Goma Respuesto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Combustible";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ralladuras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID Vehiculo";
            // 
            // DtpFechaInspeccion
            // 
            this.DtpFechaInspeccion.Location = new System.Drawing.Point(193, 319);
            this.DtpFechaInspeccion.Name = "DtpFechaInspeccion";
            this.DtpFechaInspeccion.Size = new System.Drawing.Size(121, 20);
            this.DtpFechaInspeccion.TabIndex = 30;
            // 
            // AgregarInspeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 450);
            this.Controls.Add(this.panel1);
            this.Name = "AgregarInspeccion";
            this.Text = "AgregarInspeccion";
            this.Load += new System.EventHandler(this.AgregarInspeccion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtRegistrar;
        private System.Windows.Forms.ComboBox CmbEstadoGomas;
        private System.Windows.Forms.ComboBox CmbRoturaCristal;
        private System.Windows.Forms.ComboBox CmbGato;
        private System.Windows.Forms.ComboBox CmbGomaRepuesto;
        private System.Windows.Forms.ComboBox CmbCombustible;
        private System.Windows.Forms.ComboBox CmbRalladuras;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbIdCliente;
        private System.Windows.Forms.ComboBox CmbIdVehiculo;
        private System.Windows.Forms.ComboBox CmbIdEmpleado;
        private System.Windows.Forms.DateTimePicker DtpFechaInspeccion;
    }
}