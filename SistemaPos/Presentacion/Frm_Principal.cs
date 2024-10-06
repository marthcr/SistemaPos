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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SistemaPos.Presentacion
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }
        #region "Mis Variables"
        internal int nCodigo_us { get; set; }
        internal string cLogin_us { get; set; }

        internal string cnombre_us { get; set; }
        internal string cdescripcion_us { get; set; }
        internal int nCodigo_ru { get; set; }
        string re = "";
        #endregion
        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            lbl_login.Text = "Nombre: " + cnombre_us;
            lbl_rol.Text = "Rol Usuario: " + cdescripcion_us;
        }

        private void Usuarios_Click(object sender, EventArgs e)
        {

            DataTable Tabla = new DataTable();
            D_Usuarios Datos = new D_Usuarios();
            Tabla = Datos.Listado_us(cdescripcion_us);
            if (Tabla.Rows.Count > 0)
            {
                Frm_Usuarios frm_Usuarios = new Frm_Usuarios();

                frm_Usuarios.nCodigo_ru = Convert.ToInt32(Tabla.Rows[0][5]);
                if (this.panel4.Controls.Count > 0)
                    this.panel4.Controls.RemoveAt(0);

                frm_Usuarios.TopLevel = false;
                frm_Usuarios.Dock = DockStyle.Fill;
                this.panel4.Controls.Add(frm_Usuarios);
                this.panel4.Tag = frm_Usuarios;
                frm_Usuarios.Show();


            }

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Productos_Click(object sender, EventArgs e)
        {




            DataTable Tabla = new DataTable();
            D_Usuarios Datos = new D_Usuarios();
            Tabla = Datos.Listado_us(cdescripcion_us);
            if (Tabla.Rows.Count > 0)
            {
                Frm_Inventario frm_Productos = new Frm_Inventario();

                frm_Productos.cdescripcion_us = Convert.ToString(Tabla.Rows[0][3]);
                if (this.panel4.Controls.Count > 0)
                    this.panel4.Controls.RemoveAt(0);

                frm_Productos.TopLevel = false;
                frm_Productos.Dock = DockStyle.Fill;
                this.panel4.Controls.Add(frm_Productos);
                this.panel4.Tag = frm_Productos;
                frm_Productos.Show();
            }
        }
    }
}
