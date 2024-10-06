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
    public partial class Frm_NuevoUuarios : Form
    {
        public Frm_NuevoUuarios()
        {
            InitializeComponent();
        }
        
        int nCodigo_us =0;
        int nEstadoGuarda = 1;
        

        private void Limpia_texto()
        {
            txt_usuario.Text = "";
            txt_contrasena.Text = "";
            txt_nombre.Text = "";
            ComboCargo.Text = "";
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
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text == string.Empty ||
                txt_contrasena.Text==string.Empty ||
                txt_nombre.Text==string.Empty ||
                ComboCargo.Text==string.Empty) 
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
                oPro.Login_us= txt_usuario.Text;
                oPro.Password_us = txt_contrasena.Text;
                oPro.Nombre_us = txt_nombre.Text;
                oPro.Codigo_ru = Convert.ToInt32(ComboCargo.SelectedValue);
                D_Usuarios Datos = new D_Usuarios();
                Rpta = Datos.Guardar_us(nEstadoGuarda, oPro);
                bool esNumero = int.TryParse(Rpta, out int xCodigo);
                if (esNumero==true)
                {
                    nEstadoGuarda = 0;
                    nCodigo_us= 0;
                    this.Limpia_texto();
                    MessageBox.Show("Los datos han sido guardados correctamente con el codigo #"+Rpta.Trim(),
                        "Aviso del Sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    
                }
            }
            
        }


        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this .Close();
        }

        private void Frm_NuevoUuarios_Load(object sender, EventArgs e)
        {
           this.Listado_ru();
        }

        private void ComboCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
