﻿namespace RentCar
{
    partial class HistoRentas
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtIdRenta = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DgvRenta = new System.Windows.Forms.DataGridView();
            this.rentaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rentCarDataSet1 = new RentCar.RentCarDataSet();
            this.rentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentaTableAdapter1 = new RentCar.RentCarDataSetTableAdapters.RentaTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentCarDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMostrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxtIdRenta);
            this.panel1.Controls.Add(this.btBuscar);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 62);
            this.panel1.TabIndex = 1;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(752, 15);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(189, 28);
            this.btnMostrar.TabIndex = 4;
            this.btnMostrar.Text = "Mostrar toda las rentas";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID Renta";
            // 
            // TxtIdRenta
            // 
            this.TxtIdRenta.Location = new System.Drawing.Point(141, 18);
            this.TxtIdRenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtIdRenta.Name = "TxtIdRenta";
            this.TxtIdRenta.Size = new System.Drawing.Size(479, 22);
            this.TxtIdRenta.TabIndex = 2;
            this.TxtIdRenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIdRenta_KeyPress);
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(629, 15);
            this.btBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(100, 28);
            this.btBuscar.TabIndex = 1;
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.BtBorrar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DgvRenta);
            this.panel2.Location = new System.Drawing.Point(16, 84);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1277, 353);
            this.panel2.TabIndex = 2;
            // 
            // DgvRenta
            // 
            this.DgvRenta.AllowUserToAddRows = false;
            this.DgvRenta.AllowUserToDeleteRows = false;
            this.DgvRenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRenta.Location = new System.Drawing.Point(5, 4);
            this.DgvRenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DgvRenta.Name = "DgvRenta";
            this.DgvRenta.ReadOnly = true;
            this.DgvRenta.Size = new System.Drawing.Size(1268, 326);
            this.DgvRenta.TabIndex = 0;
            // 
            // rentaBindingSource1
            // 
            this.rentaBindingSource1.DataMember = "Renta";
            this.rentaBindingSource1.DataSource = this.rentCarDataSet1;
            // 
            // rentCarDataSet1
            // 
            this.rentCarDataSet1.DataSetName = "RentCarDataSet";
            this.rentCarDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rentaBindingSource
            // 
            this.rentaBindingSource.DataMember = "Renta";
            // 
            // rentaTableAdapter1
            // 
            this.rentaTableAdapter1.ClearBeforeFill = true;
            // 
            // HistoRentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 452);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HistoRentas";
            this.Text = "HistoRentas";
            this.Load += new System.EventHandler(this.HistoRentas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvRenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentCarDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Panel panel2;
        private RentCarDataSet rentCarDataSet;
        private System.Windows.Forms.BindingSource rentaBindingSource;
        private RentCarDataSetTableAdapters.RentaTableAdapter rentaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVehiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depositoRentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoXdiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDiasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDevolucionDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox TxtIdRenta;
        private RentCarDataSet rentCarDataSet1;
        private System.Windows.Forms.BindingSource rentaBindingSource1;
        private RentCarDataSetTableAdapters.RentaTableAdapter rentaTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvRenta;
        private System.Windows.Forms.Button btnMostrar;
    }
}