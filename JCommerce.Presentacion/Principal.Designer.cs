namespace JCommerce.Presentacion
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnVentas = new FontAwesome.Sharp.IconMenuItem();
            this.btnConsultaVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNuevaVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCompras = new FontAwesome.Sharp.IconMenuItem();
            this.btnCaja = new FontAwesome.Sharp.IconMenuItem();
            this.btnProveedores = new FontAwesome.Sharp.IconMenuItem();
            this.btnClientes = new FontAwesome.Sharp.IconMenuItem();
            this.btnUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.btnReportes = new FontAwesome.Sharp.IconMenuItem();
            this.btnConfiguracion = new FontAwesome.Sharp.IconMenuItem();
            this.btnParametricas = new FontAwesome.Sharp.IconMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlTitulo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(931, 59);
            this.pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(205, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "JCommerce";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 438);
            this.panel1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnVentas,
            this.btnCompras,
            this.btnCaja,
            this.btnProveedores,
            this.btnClientes,
            this.btnUsuarios,
            this.btnReportes,
            this.btnConfiguracion,
            this.btnParametricas});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(244, 434);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // btnVentas
            // 
            this.btnVentas.AutoSize = false;
            this.btnVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConsultaVentas,
            this.btnNuevaVenta});
            this.btnVentas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVentas.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnVentas.IconColor = System.Drawing.Color.Black;
            this.btnVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVentas.IconSize = 30;
            this.btnVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(200, 35);
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnConsultaVentas
            // 
            this.btnConsultaVentas.Name = "btnConsultaVentas";
            this.btnConsultaVentas.Size = new System.Drawing.Size(178, 22);
            this.btnConsultaVentas.Text = "Ver Ventas";
            // 
            // btnNuevaVenta
            // 
            this.btnNuevaVenta.Name = "btnNuevaVenta";
            this.btnNuevaVenta.Size = new System.Drawing.Size(178, 22);
            this.btnNuevaVenta.Text = "Nueva Venta";
            // 
            // btnCompras
            // 
            this.btnCompras.AutoSize = false;
            this.btnCompras.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCompras.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.btnCompras.IconColor = System.Drawing.Color.Black;
            this.btnCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCompras.IconSize = 30;
            this.btnCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(200, 35);
            this.btnCompras.Text = "Compras";
            this.btnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCaja
            // 
            this.btnCaja.AutoSize = false;
            this.btnCaja.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCaja.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btnCaja.IconColor = System.Drawing.Color.Black;
            this.btnCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCaja.IconSize = 30;
            this.btnCaja.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.Size = new System.Drawing.Size(200, 35);
            this.btnCaja.Text = "  Caja";
            this.btnCaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnProveedores
            // 
            this.btnProveedores.AutoSize = false;
            this.btnProveedores.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProveedores.IconChar = FontAwesome.Sharp.IconChar.IdCardAlt;
            this.btnProveedores.IconColor = System.Drawing.Color.Black;
            this.btnProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProveedores.IconSize = 30;
            this.btnProveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(200, 35);
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClientes
            // 
            this.btnClientes.AutoSize = false;
            this.btnClientes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnClientes.IconColor = System.Drawing.Color.Black;
            this.btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClientes.IconSize = 30;
            this.btnClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(200, 35);
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.AutoSize = false;
            this.btnUsuarios.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnUsuarios.IconColor = System.Drawing.Color.Black;
            this.btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsuarios.IconSize = 30;
            this.btnUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(200, 35);
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnReportes
            // 
            this.btnReportes.AutoSize = false;
            this.btnReportes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReportes.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.btnReportes.IconColor = System.Drawing.Color.Black;
            this.btnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReportes.IconSize = 30;
            this.btnReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(200, 35);
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.AutoSize = false;
            this.btnConfiguracion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfiguracion.IconChar = FontAwesome.Sharp.IconChar.Whmcs;
            this.btnConfiguracion.IconColor = System.Drawing.Color.Black;
            this.btnConfiguracion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfiguracion.IconSize = 30;
            this.btnConfiguracion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(200, 35);
            this.btnConfiguracion.Text = "Configuracion";
            this.btnConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnParametricas
            // 
            this.btnParametricas.AutoSize = false;
            this.btnParametricas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnParametricas.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.btnParametricas.IconColor = System.Drawing.Color.Black;
            this.btnParametricas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnParametricas.IconSize = 30;
            this.btnParametricas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnParametricas.Name = "btnParametricas";
            this.btnParametricas.Size = new System.Drawing.Size(200, 35);
            this.btnParametricas.Text = "Parametricas";
            this.btnParametricas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(260, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(671, 438);
            this.panel2.TabIndex = 2;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 497);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitulo);
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlTitulo;
        private Label lblTitulo;
        private Panel panel1;
        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem btnVentas;
        private FontAwesome.Sharp.IconMenuItem btnCompras;
        private FontAwesome.Sharp.IconMenuItem btnCaja;
        private FontAwesome.Sharp.IconMenuItem btnProveedores;
        private FontAwesome.Sharp.IconMenuItem btnClientes;
        private FontAwesome.Sharp.IconMenuItem btnUsuarios;
        private FontAwesome.Sharp.IconMenuItem btnReportes;
        private FontAwesome.Sharp.IconMenuItem btnConfiguracion;
        private FontAwesome.Sharp.IconMenuItem btnParametricas;
        private Panel panel2;
        private ToolStripMenuItem btnConsultaVentas;
        private ToolStripMenuItem btnNuevaVenta;
    }
}