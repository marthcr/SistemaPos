namespace SistemaPos.Presentacion
{
    partial class Frm_Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_rol = new System.Windows.Forms.Label();
            this.lbl_login = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Empresa = new FontAwesome.Sharp.IconButton();
            this.Usuarios = new FontAwesome.Sharp.IconButton();
            this.Reportes = new FontAwesome.Sharp.IconButton();
            this.Proveedores = new FontAwesome.Sharp.IconButton();
            this.Productos = new FontAwesome.Sharp.IconButton();
            this.Clientes = new FontAwesome.Sharp.IconButton();
            this.Compras = new FontAwesome.Sharp.IconButton();
            this.Ventas = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.Empresa);
            this.panel1.Controls.Add(this.Usuarios);
            this.panel1.Controls.Add(this.Reportes);
            this.panel1.Controls.Add(this.Proveedores);
            this.panel1.Controls.Add(this.Productos);
            this.panel1.Controls.Add(this.Clientes);
            this.panel1.Controls.Add(this.Compras);
            this.panel1.Controls.Add(this.Ventas);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 652);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_rol);
            this.panel3.Controls.Add(this.lbl_login);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(213, 614);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(881, 38);
            this.panel3.TabIndex = 1;
            // 
            // lbl_rol
            // 
            this.lbl_rol.AutoSize = true;
            this.lbl_rol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rol.Location = new System.Drawing.Point(559, 11);
            this.lbl_rol.Name = "lbl_rol";
            this.lbl_rol.Size = new System.Drawing.Size(91, 18);
            this.lbl_rol.TabIndex = 1;
            this.lbl_rol.Text = "Rol Usuario:";
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.Location = new System.Drawing.Point(379, 11);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(70, 18);
            this.lbl_login.TabIndex = 0;
            this.lbl_login.Text = "Nombre: ";
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(213, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(881, 614);
            this.panel4.TabIndex = 2;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // Empresa
            // 
            this.Empresa.Dock = System.Windows.Forms.DockStyle.Top;
            this.Empresa.FlatAppearance.BorderSize = 0;
            this.Empresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empresa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Empresa.IconChar = FontAwesome.Sharp.IconChar.BusinessTime;
            this.Empresa.IconColor = System.Drawing.Color.Black;
            this.Empresa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Empresa.IconSize = 32;
            this.Empresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Empresa.Location = new System.Drawing.Point(0, 548);
            this.Empresa.Name = "Empresa";
            this.Empresa.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Empresa.Size = new System.Drawing.Size(213, 60);
            this.Empresa.TabIndex = 9;
            this.Empresa.Text = "Mi Empresa";
            this.Empresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Empresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Empresa.UseVisualStyleBackColor = true;
            // 
            // Usuarios
            // 
            this.Usuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.Usuarios.FlatAppearance.BorderSize = 0;
            this.Usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Usuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuarios.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Usuarios.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
            this.Usuarios.IconColor = System.Drawing.Color.Black;
            this.Usuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Usuarios.IconSize = 32;
            this.Usuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Usuarios.Location = new System.Drawing.Point(0, 488);
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Usuarios.Size = new System.Drawing.Size(213, 60);
            this.Usuarios.TabIndex = 8;
            this.Usuarios.Text = "Usuarios";
            this.Usuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Usuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Usuarios.UseVisualStyleBackColor = true;
            this.Usuarios.Click += new System.EventHandler(this.Usuarios_Click);
            // 
            // Reportes
            // 
            this.Reportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.Reportes.FlatAppearance.BorderSize = 0;
            this.Reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reportes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Reportes.IconChar = FontAwesome.Sharp.IconChar.ArrowTrendUp;
            this.Reportes.IconColor = System.Drawing.Color.Black;
            this.Reportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Reportes.IconSize = 32;
            this.Reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Reportes.Location = new System.Drawing.Point(0, 428);
            this.Reportes.Name = "Reportes";
            this.Reportes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Reportes.Size = new System.Drawing.Size(213, 60);
            this.Reportes.TabIndex = 7;
            this.Reportes.Text = "Reportes";
            this.Reportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Reportes.UseVisualStyleBackColor = true;
            // 
            // Proveedores
            // 
            this.Proveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.Proveedores.FlatAppearance.BorderSize = 0;
            this.Proveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Proveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proveedores.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Proveedores.IconChar = FontAwesome.Sharp.IconChar.City;
            this.Proveedores.IconColor = System.Drawing.Color.Black;
            this.Proveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Proveedores.IconSize = 32;
            this.Proveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Proveedores.Location = new System.Drawing.Point(0, 368);
            this.Proveedores.Name = "Proveedores";
            this.Proveedores.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Proveedores.Size = new System.Drawing.Size(213, 60);
            this.Proveedores.TabIndex = 6;
            this.Proveedores.Text = "Proveedores";
            this.Proveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Proveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Proveedores.UseVisualStyleBackColor = true;
            // 
            // Productos
            // 
            this.Productos.Dock = System.Windows.Forms.DockStyle.Top;
            this.Productos.FlatAppearance.BorderSize = 0;
            this.Productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Productos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Productos.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.Productos.IconColor = System.Drawing.Color.Black;
            this.Productos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Productos.IconSize = 32;
            this.Productos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Productos.Location = new System.Drawing.Point(0, 308);
            this.Productos.Name = "Productos";
            this.Productos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Productos.Size = new System.Drawing.Size(213, 60);
            this.Productos.TabIndex = 5;
            this.Productos.Text = "Productos";
            this.Productos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Productos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Productos.UseVisualStyleBackColor = true;
            this.Productos.Click += new System.EventHandler(this.Productos_Click);
            // 
            // Clientes
            // 
            this.Clientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.Clientes.FlatAppearance.BorderSize = 0;
            this.Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Clientes.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.Clientes.IconColor = System.Drawing.Color.Black;
            this.Clientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Clientes.IconSize = 32;
            this.Clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Clientes.Location = new System.Drawing.Point(0, 248);
            this.Clientes.Name = "Clientes";
            this.Clientes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Clientes.Size = new System.Drawing.Size(213, 60);
            this.Clientes.TabIndex = 4;
            this.Clientes.Text = "Clientes";
            this.Clientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Clientes.UseVisualStyleBackColor = true;
            // 
            // Compras
            // 
            this.Compras.Dock = System.Windows.Forms.DockStyle.Top;
            this.Compras.FlatAppearance.BorderSize = 0;
            this.Compras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Compras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Compras.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Compras.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.Compras.IconColor = System.Drawing.Color.Black;
            this.Compras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Compras.IconSize = 32;
            this.Compras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Compras.Location = new System.Drawing.Point(0, 188);
            this.Compras.Name = "Compras";
            this.Compras.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Compras.Size = new System.Drawing.Size(213, 60);
            this.Compras.TabIndex = 3;
            this.Compras.Text = "Compras";
            this.Compras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Compras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Compras.UseVisualStyleBackColor = true;
            // 
            // Ventas
            // 
            this.Ventas.Dock = System.Windows.Forms.DockStyle.Top;
            this.Ventas.FlatAppearance.BorderSize = 0;
            this.Ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ventas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Ventas.IconChar = FontAwesome.Sharp.IconChar.Shop;
            this.Ventas.IconColor = System.Drawing.Color.Black;
            this.Ventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Ventas.IconSize = 32;
            this.Ventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ventas.Location = new System.Drawing.Point(0, 128);
            this.Ventas.Name = "Ventas";
            this.Ventas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Ventas.Size = new System.Drawing.Size(213, 60);
            this.Ventas.TabIndex = 2;
            this.Ventas.Text = "Ventas";
            this.Ventas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Ventas.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::SistemaPos.Properties.Resources.descargar__2_;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 128);
            this.panel2.TabIndex = 1;
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 652);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Principal";
            this.Text = "Frm_Principal";
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton Ventas;
        private FontAwesome.Sharp.IconButton Usuarios;
        private FontAwesome.Sharp.IconButton Reportes;
        private FontAwesome.Sharp.IconButton Proveedores;
        private FontAwesome.Sharp.IconButton Productos;
        private FontAwesome.Sharp.IconButton Clientes;
        private FontAwesome.Sharp.IconButton Compras;
        private FontAwesome.Sharp.IconButton Empresa;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_rol;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
    }
}