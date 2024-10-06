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
    public partial class Frm_NuevaFamilia : Form
    {
        public Frm_NuevaFamilia()
        {
            InitializeComponent();
        }
        #region "MIs variables"
        int nCodigo_fa = 0;
        internal int nCodigo_us { get; set; }
        int nEstadoGuarda = 1;
        #endregion

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (txt_nombrefamilias.Text == string.Empty)
            {
                MessageBox.Show("Ingrese la informacion requerida (*)",
                                "Alerta de Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else //Proceder a guardado de informacion de la nueva Familia
            {
                string Rpta;
                E_Familias oPro = new E_Familias();
                oPro.Codigo_fa = nCodigo_fa;
                oPro.Descripcion = txt_nombrefamilias.Text;
                oPro.Codigo_us = nCodigo_us;
                D_Inventario Datos = new D_Inventario();
                Rpta = Datos.Guardar_fa(nEstadoGuarda, oPro);
                bool esNumero = int.TryParse(Rpta, out int xCodigo);
                if (esNumero == true)
                {
                    nEstadoGuarda = 0;
                    nCodigo_us = 0;

                    MessageBox.Show("Los datos han sido guardados correctamente con el codigo #" + Rpta.Trim(),
                        "Aviso del Sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                }
            }
        }
    }
}
