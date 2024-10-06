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
    public partial class Frm_NuevoArticulo : Form
    {
        public Frm_NuevoArticulo()
        {
            InitializeComponent();
        }
        private void Listado_fa()
        {
            D_Inventario Datos = new D_Inventario();
            ComboCargo.DataSource = Datos.Listado_fa();
            ComboCargo.ValueMember = "codigo_fa";
            ComboCargo.DisplayMember = "descripcion_fa";
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_NuevoArticulo_Load(object sender, EventArgs e)
        {
            this.Listado_fa();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (txt_codigo.Text == string.Empty)
            {
                MessageBox.Show("Ingrese la informacion requerida (*)",
                                "Alerta de Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else //Proceder a guardado de informacion del nuevo articulo
            {
                string Rpta;
                E_Inventario oPro = new E_Inventario();
                
                //oPro.Codigo_pro = txt_codigo.Text;
                
                D_Inventario Datos = new D_Inventario();
                //Rpta = Datos.Guardar_fa(nEstadoGuarda, oPro);
               //bool esNumero = int.TryParse(Rpta, out int xCodigo);
                //if (esNumero == true)
                {
                   // nEstadoGuarda = 0;
                    //nCodigo_us = 0;

              //      MessageBox.Show("Los datos han sido guardados correctamente con el codigo #" + Rpta.Trim(),
               //         "Aviso del Sistema",
               //         MessageBoxButtons.OK,
               //         MessageBoxIcon.Information);

                }
            }
        }
    }
}
