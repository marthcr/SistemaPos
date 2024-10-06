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
    public partial class Frm_Inventario : Form
    {
        public Frm_Inventario()
        {
            InitializeComponent();
        }
        #region "Mis Variables"
        internal int nCodigo_pro { get; set; }
        internal string nDescripcion_pro { get; set; }
        internal string nCodigomanual_pro { get; set; }
        internal string nCodigo_me { get; set; }
        internal string nCodigo_fa { get; set; }
        internal decimal nPu_costo { get; set; }
        internal decimal nPu_venta { get; set; }
        internal decimal nPu_descuento { get; set; }
        internal int nCodigo_us { get; set; }
        internal string cnombre_us { get; set; }

        internal string cdescripcion_us { get; set; }
        #endregion
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Frm_Articulos frm_Articulos = new Frm_Articulos();
            frm_Articulos.ShowDialog();
        }

        private void Frm_Productos_Load(object sender, EventArgs e)
        {
            this.Listado_iv("%");
        }
        private void Formato()
        {
            dvgListaInv.Columns[0].Width = 170;
            dvgListaInv.Columns[0].HeaderText = "CODIGO PRODUCTO";
            dvgListaInv.Columns[1].Width = 140;
            dvgListaInv.Columns[1].HeaderText = "DESCRIPCION";
            dvgListaInv.Columns[2].Width = 180;
            dvgListaInv.Columns[2].HeaderText = "CODIGO INTERNO";
            dvgListaInv.Columns[3].Visible = false;
            dvgListaInv.Columns[4].Width = 180;
            dvgListaInv.Columns[4].HeaderText = "CODIGO FAMILIA";
            dvgListaInv.Columns[5].Width = 100;
            dvgListaInv.Columns[5].HeaderText = "PRECIO VENTA";
            dvgListaInv.Columns[6].Width = 100;
            dvgListaInv.Columns[6].HeaderText = "CANTIDAD";
            dvgListaInv.Columns[7].Visible = false;
            dvgListaInv.Columns[8].Visible = false;
            dvgListaInv.Columns[9].Visible = false;
            dvgListaInv.Columns[10].Visible = false;
            dvgListaInv.Columns[11].Visible = false;
            dvgListaInv.Columns[12].Visible = false;
        }
        private void Listado_iv(string cTexto)
        {
            D_Inventario Datos = new D_Inventario();
            dvgListaInv.DataSource = Datos.Listado_iv(cTexto);
            this.Formato();
        }

        private void guna2ImageButton5_Click(object sender, EventArgs e)
        {
            Frm_FamiliasInv frm_familiasinv = new Frm_FamiliasInv();
            DataTable Tabla = new DataTable();
            D_Usuarios Datos = new D_Usuarios();
            E_Usuarios pr = new E_Usuarios();
            Tabla = Datos.Listado_us(cdescripcion_us);
            if (Tabla.Rows.Count > 0)
            {
                

                frm_familiasinv.cLogin_us = Convert.ToString(Tabla.Rows[0][1]);
                
                
            }
            frm_familiasinv.ShowDialog();
        }
    }
}
