﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RentCar
{
    public partial class HistoRentas : Form
    {
        SqlConnection con = null;
        public HistoRentas()
        {
            InitializeComponent();
        }

        private void HistoRentas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentCarDataSet1.Renta' table. You can move, or remove it, as needed.
            this.rentaTableAdapter1.Fill(this.rentCarDataSet1.Renta);


            // TODO: This line of code loads data into the 'rentCarDataSet.Renta' table. You can move, or remove it, as needed.

            //CargarTabla();
        }

        private void BtActualizar_Click(object sender, EventArgs e)
        {
            
         }
        private void BtBorrar_Click(object sender, EventArgs e)
        {
            try
            {

                con = new SqlConnection("Data Source=DESKTOP-7UG5AJD\\SQLEXPRESS02;Initial Catalog=RentCar;Integrated Security=True");
                con.Open();
                string sql = "Select * from Renta WHERE IdRenta = " + "'" + TxtIdRenta.Text + "'" + "";
                SqlCommand comando = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                
                DataTable dt = new DataTable();

                da.Fill(dt);
                DgvRenta.DataSource = dt;
                DgvRenta.Refresh();
                comando.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Ha ocurrido un error");

            }
        }
        private void CargarTabla()
        {
            try
            {
                con = new SqlConnection("Data Source=DESKTOP-7UG5AJD\\SQLEXPRESS02;Initial Catalog=RentCar;Integrated Security=True");
                con.Open();
                string sql = "select * from Renta";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DgvRenta.DataSource = dt;
                DgvRenta.Refresh();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
               
            }

           



        }

        private void TxtIdRenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }
    }
}
