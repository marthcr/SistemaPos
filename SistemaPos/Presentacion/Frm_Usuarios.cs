using MySql.Data.MySqlClient;
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
    public partial class Frm_Usuarios : Form
    {
        public Frm_Usuarios()
        {
            InitializeComponent();
        }
        
        #region "Mis Variables"
        internal int nCodigo_us { get; set; }
        internal string cLogin_us { get; set; }

        internal string cnombre_us { get; set; }
        internal string cdescripcion_us { get; set; }
        
        internal int nCodigo_ru { get; set; }


        #endregion


        private void Frm_Usuarios_Load(object sender, EventArgs e)
        {
            this.Listado_us("%");
            label1.Text = "rol" + nCodigo_ru;


        }
        private void Formato()
        {
            dvgLista.Columns[0].Width = 170;
            dvgLista.Columns[0].HeaderText = "CODIGO DE USUARIO";
            dvgLista.Columns[1].Width = 140;
            dvgLista.Columns[1].HeaderText = "USUARIO";
            dvgLista.Columns[2].Width = 180;
            dvgLista.Columns[2].HeaderText = "NOMBRE DEL USUARIO";
            dvgLista.Columns[3].Width = 180;
            dvgLista.Columns[3].HeaderText = "ROL DE USUARIO";
            dvgLista.Columns[4].Width = 100;
            dvgLista.Columns[4].HeaderText = "ACTIVO";
            dvgLista.Columns[5].Visible = false;

        }
        private void Listado_us(string cTexto)
        {
            D_Usuarios Datos = new D_Usuarios();
            dvgLista.DataSource = Datos.Listado_us(cTexto);
            this.Formato();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if (nCodigo_ru == 1)
            {
                Frm_NuevoUuarios oFrm_nus = new Frm_NuevoUuarios();
                oFrm_nus.ShowDialog();
            }
            else
            {
                MessageBox.Show("Requiere permisos de administrador",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            this.Listado_us(txt_buscarusuario.Text);
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            this.Listado_us("%");
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            if (nCodigo_ru == 1)
            {
                Frm oFrm_nus = new Frm();
                oFrm_nus.ShowDialog();
            }
            else
            {
                MessageBox.Show("Requiere permisos de administrador",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);


            }

        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            if (nCodigo_ru == 1)
            {
                if (dvgLista.Rows.Count > 0)
                {
                    string Rpta = "";
                    D_Usuarios Datos = new D_Usuarios();
                    Rpta = Datos.Borrarus(Convert.ToInt32(dvgLista.CurrentRow.Cells[0].Value));
                    if (Rpta.Equals("OK"))
                    {

                        MessageBox.Show("Usuario eliminado correctamente",
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
            else
            {
                MessageBox.Show("Requiere permisos de administrador",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);


            }
        }

        private void dvgLista_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
