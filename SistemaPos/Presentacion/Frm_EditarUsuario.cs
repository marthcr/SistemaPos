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
    public partial class Frm : Form
    {
        public Frm()
        {
            InitializeComponent();
        }
        #region "Mis Variables"
        int nEstadoGuarda = 2;
        int nCodigo_us = 0;
        #endregion
        private void Frm_EditarUsuario_Load(object sender, EventArgs e)
        {
            this.Listado_us("%");
            this.Listado_ru();
        }
        private void Formato()
        {
            dvgListado.Columns[0].Width = 170;
            dvgListado.Columns[0].HeaderText = "CODIGO DE USUARIO";
            dvgListado.Columns[1].Width = 140;
            dvgListado.Columns[1].HeaderText = "USUARIO";
            dvgListado.Columns[2].Width = 180;
            dvgListado.Columns[2].HeaderText = "NOMBRE DEL USUARIO";
            dvgListado.Columns[3].Width = 180;
            dvgListado.Columns[3].HeaderText = "ROL DE USUARIO";
            dvgListado.Columns[4].Width = 100;
            dvgListado.Columns[4].HeaderText = "ACTIVO";
            dvgListado.Columns[5].Visible = false;

        }
        private void Limpia_texto()
        {
            txt_usuario.Text = "";
            txt_contrasena.Text = "";
            txt_nombre.Text = "";
            ComboCargo.Text = "";
        }
        private void Listado_us(string cTexto)
        {
            D_Usuarios Datos = new D_Usuarios();
            dvgListado.DataSource = Datos.Listado_us(cTexto);
            this.Formato();
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.Listado_us(txt_buscarusuario.Text);
        }
        private void Listado_ru()
        {
            try
            {
                D_Usuarios Datos = new D_Usuarios();
                ComboCargo.DataSource = Datos.Listado_ru();
                ComboCargo.ValueMember = "codigo_ru";
                ComboCargo.DisplayMember = "descripcion_ru";
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

       
        private void Selecciona_item()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dvgListado.CurrentRow.Cells["codigo_us"].Value)))
            {
                MessageBox.Show("Seleccione un registro correcto",
                                 "Aviso de Sistema",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation);
            }
            else
            {
                
                nCodigo_us = Convert.ToInt32(dvgListado.CurrentRow.Cells["codigo_us"].Value);
                txt_usuario.Text = dvgListado.CurrentRow.Cells["login_us"].Value.ToString();
                txt_contrasena.Text = "";
                txt_nombre.Text = dvgListado.CurrentRow.Cells["nombre_us"].Value.ToString();
                ComboCargo.Text = dvgListado.CurrentRow.Cells["descripcion_ru"].Value.ToString();
                
            }
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text == string.Empty ||
                txt_contrasena.Text == string.Empty ||
                txt_nombre.Text == string.Empty ||
                ComboCargo.Text == string.Empty)
            {
                MessageBox.Show("Ingrese la informacion requerida (*)",
                                "Alerta de Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else //Proceder a guardado de informacion del nuevo usuario
            {
                string Rpta;
                E_Usuarios oPro = new E_Usuarios();
                oPro.Codigo_us = nCodigo_us;
                oPro.Login_us = txt_usuario.Text;
                oPro.Password_us = txt_contrasena.Text;
                oPro.Nombre_us = txt_nombre.Text;
                oPro.Codigo_ru = Convert.ToInt32(ComboCargo.SelectedValue);
                D_Usuarios Datos = new D_Usuarios();
                Rpta = Datos.Guardar_us(nEstadoGuarda, oPro);
                bool esNumero = int.TryParse(Rpta, out int xCodigo);
                if (esNumero == true)
                {
                    nEstadoGuarda = 0;
                    nCodigo_us = 0;
                    this.Limpia_texto();
                    MessageBox.Show("Los datos han sido guardados correctamente con el codigo #" + Rpta.Trim(),
                        "Aviso del Sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                }
            }


        }

        private void dvgListado_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_item();
        }

        private void CheckActivous_Click(object sender, EventArgs e)
        {
            if (dvgListado.Rows.Count>0)
            {
                string Rpta = "";
                D_Usuarios Datos = new D_Usuarios();
                Rpta = Datos.Activo_us(Convert.ToInt32(dvgListado.CurrentRow.Cells["codigo_us"].Value));
                if(Rpta.Equals("OK"))
                {
                    this.Listado_us("%");
                    MessageBox.Show("Proceso de estado actualizado",
                                    "Aviso del Sistema",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
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
}
