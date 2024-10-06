using SistemaPos.Datos;
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
    public partial class Frm_Articulos : Form
    {
        public Frm_Articulos()
        {
            InitializeComponent();
        }

        private void Frm_Articulos_Load(object sender, EventArgs e)
        {
            this.Listado_iv("%");
        }
        private void Formato()
        {
            dataart.Columns[0].Width = 170;
            dataart.Columns[0].HeaderText = "CODIGO PRODUCTO";
            dataart.Columns[1].Width = 140;
            dataart .Columns[1].HeaderText = "DESCRIPCION";
            dataart.Columns[2].Width = 180;
            dataart.Columns[2].HeaderText = "CODIGO INTERNO";
            dataart.Columns[3].Width = 180;
            dataart.Columns[3].HeaderText = "CODIGO FAMILIA";
            dataart.Columns[4].Width = 180;
            dataart.Columns[4].HeaderText = "DESCRIPCION FAMILIA";
            dataart.Columns[5].Width = 100;
            dataart.Columns[5].HeaderText = "PRECIO COSTO";
            dataart.Columns[6].Width = 100;
            dataart.Columns[6].HeaderText = "PRECIO VENTA";
            dataart.Columns[7].Width = 120;
            dataart.Columns[7].HeaderText = "CANTIDAD";
            dataart.Columns[8].Visible = false;
            dataart.Columns[9].Width = 100;
            dataart.Columns[9].HeaderText = "CREADO POR";
            dataart.Columns[10].Width = 150;
            dataart.Columns[10].HeaderText = "FECHA DE CREACION";
            dataart.Columns[11].Width = 180;
            dataart.Columns[11].HeaderText = "FECHA DE MODIFICACION";
            dataart.Columns[12].Visible = false;
        }
        private void Listado_iv(string cTexto)
        {
            D_Inventario Datos = new D_Inventario();
            dataart.DataSource = Datos.Listado_iv(cTexto);
            this.Formato();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Frm_NuevoArticulo frm_Articulos = new Frm_NuevoArticulo();
            frm_Articulos.ShowDialog();
        }
    }
}
