namespace RentCar
{
    partial class UserVentas
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtRentar = new System.Windows.Forms.Button();
            this.btRegistCliente = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(723, 478);
            this.panel3.TabIndex = 3;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::RentCar.Properties.Resources._5b0e65cf_8104_49f3_8256_bb3d8370b8bb;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 474);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Controls.Add(this.BtRentar);
            this.panel2.Controls.Add(this.btRegistCliente);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 474);
            this.panel2.TabIndex = 2;
            // 
            // BtRentar
            // 
            this.BtRentar.Location = new System.Drawing.Point(44, 80);
            this.BtRentar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtRentar.Name = "BtRentar";
            this.BtRentar.Size = new System.Drawing.Size(189, 63);
            this.BtRentar.TabIndex = 0;
            this.BtRentar.Text = "Rentar";
            this.BtRentar.UseVisualStyleBackColor = true;
            // 
            // btRegistCliente
            // 
            this.btRegistCliente.Location = new System.Drawing.Point(44, 256);
            this.btRegistCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btRegistCliente.Name = "btRegistCliente";
            this.btRegistCliente.Size = new System.Drawing.Size(189, 63);
            this.btRegistCliente.TabIndex = 1;
            this.btRegistCliente.Text = "Registrar Cliente";
            this.btRegistCliente.UseVisualStyleBackColor = true;
            this.btRegistCliente.Click += new System.EventHandler(this.btRegistCliente_Click_1);
            // 
            // UserVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 473);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserVentas";
            this.Text = "UserVentas";
            this.Load += new System.EventHandler(this.UserVentas_Load);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtRentar;
        private System.Windows.Forms.Button btRegistCliente;
    }
}