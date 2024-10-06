using SistemaPos.Datos;
using SistemaPos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPos.Presentacion
{
    public partial class Frm_FamiliasInv : Form
    {
        public Frm_FamiliasInv()
        {
            InitializeComponent();
        }
        internal int nCodigo_fa { get; set; }
        internal string nDescripcion { get; set; }
        
        internal string cLogin_us { get; set; }
        internal int nCodigo_us { get; set; }
        private void Formato()
        {
            dvgListaInv.Columns[0].Width = 170;
            dvgListaInv.Columns[0].HeaderText = "CODIGO FAMILIA";
            dvgListaInv.Columns[1].Width = 140;
            dvgListaInv.Columns[1].HeaderText = "DESCRIPCION";
            dvgListaInv.Columns[2].Visible = false;
            dvgListaInv.Columns[3].Visible = false;
            dvgListaInv.Columns[4].Width = 180;
            dvgListaInv.Columns[4].HeaderText = "CREADO POR";
            
        }
        private void ListadoFamilias_iv(string cTexto)
        {
            D_Inventario Datos = new D_Inventario();
            dvgListaInv.DataSource = Datos.ListadoFamilias_iv(cTexto);
            this.Formato();
        }
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

            Frm_NuevaFamilia frm_NuevaFamilia = new Frm_NuevaFamilia();
            DataTable Tabla = new DataTable();
            D_Usuarios Datos = new D_Usuarios();
            E_Usuarios pr = new E_Usuarios();
            Tabla = Datos.Listado_us(cLogin_us);
            if (Tabla.Rows.Count > 0)
            {


                frm_NuevaFamilia.nCodigo_us = Convert.ToInt32(Tabla.Rows[0][0]);


            }
                frm_NuevaFamilia.ShowDialog();
        }

        private void Frm_FamiliasInv_Load(object sender, EventArgs e)
        {
            this.ListadoFamilias_iv("%");
            
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            this.ListadoFamilias_iv("%");
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            string Rpta = "";
            D_Inventario Datos = new D_Inventario();
            Rpta = Datos.Borrarfa(Convert.ToInt32(dvgListaInv.CurrentRow.Cells[0].Value));
            if (Rpta.Equals("OK"))
            {

                MessageBox.Show("Familia seleccionada eliminada correctamente",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Rpta,
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
