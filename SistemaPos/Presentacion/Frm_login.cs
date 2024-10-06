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
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();
           
        }
        
        #region "Mis metodos"
        private void Logout(object sender, FormClosedEventArgs e)
        {
            this.txtLogin_us.Text = "";
            this.txtPassword_us.Text = "";
            this.Show();
            this.txtLogin_us.Select();
        }

        #endregion
        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_login_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            DataTable TablaLogin = new DataTable();
            D_Usuarios Datos = new D_Usuarios();
            TablaLogin = Datos.Login_us(txtLogin_us.Text, txtPassword_us.Text);
            if (TablaLogin.Rows.Count > 0 )
            {
                Frm_Principal frm_Principal = new Frm_Principal();
                frm_Principal.nCodigo_us = Convert.ToInt32(TablaLogin.Rows[0][0]);
                frm_Principal.cLogin_us=Convert.ToString(TablaLogin.Rows[0][1]);
                frm_Principal.cnombre_us= Convert.ToString(TablaLogin.Rows[0][2]);
                frm_Principal.cdescripcion_us = Convert.ToString(TablaLogin.Rows[0][3]);
                frm_Principal.nCodigo_ru = Convert.ToInt32(TablaLogin.Rows[0][4]);
                frm_Principal.Show();
                frm_Principal.FormClosed += Logout;
                Frm_Usuarios frm_Usuarios = new Frm_Usuarios();
                
                frm_Usuarios.nCodigo_ru = Convert.ToInt32(TablaLogin.Rows[0][4]);
               

               
               

                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos verifique nuevamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
