﻿namespace CapaPresentacion
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menusuarios = new FontAwesome.Sharp.IconMenuItem();
            this.menuinventario = new FontAwesome.Sharp.IconMenuItem();
            this.submenucategoria = new FontAwesome.Sharp.IconMenuItem();
            this.submenuproducto = new FontAwesome.Sharp.IconMenuItem();
            this.menuventas = new FontAwesome.Sharp.IconMenuItem();
            this.submenuregistrarventa = new FontAwesome.Sharp.IconMenuItem();
            this.submenuverdetalleventa = new FontAwesome.Sharp.IconMenuItem();
            this.menucompras = new FontAwesome.Sharp.IconMenuItem();
            this.submenuregistrarcompra = new FontAwesome.Sharp.IconMenuItem();
            this.submenuverdetallecompra = new FontAwesome.Sharp.IconMenuItem();
            this.menuclientes = new FontAwesome.Sharp.IconMenuItem();
            this.menuproveedores = new FontAwesome.Sharp.IconMenuItem();
            this.menureportes = new FontAwesome.Sharp.IconMenuItem();
            this.menuacercade = new FontAwesome.Sharp.IconMenuItem();
            this.menutitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menusuarios,
            this.menuinventario,
            this.menuventas,
            this.menucompras,
            this.menuclientes,
            this.menuproveedores,
            this.menureportes,
            this.menuacercade});
            this.menu.Location = new System.Drawing.Point(0, 66);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1090, 73);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menusuarios
            // 
            this.menusuarios.AutoSize = false;
            this.menusuarios.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menusuarios.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.menusuarios.IconColor = System.Drawing.Color.Black;
            this.menusuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menusuarios.IconSize = 50;
            this.menusuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menusuarios.Name = "menusuarios";
            this.menusuarios.Size = new System.Drawing.Size(80, 69);
            this.menusuarios.Text = "Usuarios";
            this.menusuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menusuarios.Click += new System.EventHandler(this.menusuarios_Click);
            // 
            // menuinventario
            // 
            this.menuinventario.AutoSize = false;
            this.menuinventario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenucategoria,
            this.submenuproducto});
            this.menuinventario.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuinventario.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            this.menuinventario.IconColor = System.Drawing.Color.Black;
            this.menuinventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuinventario.IconSize = 50;
            this.menuinventario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuinventario.Name = "menuinventario";
            this.menuinventario.Size = new System.Drawing.Size(80, 69);
            this.menuinventario.Text = "Inventario";
            this.menuinventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // submenucategoria
            // 
            this.submenucategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenucategoria.IconColor = System.Drawing.Color.Black;
            this.submenucategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenucategoria.Name = "submenucategoria";
            this.submenucategoria.Size = new System.Drawing.Size(126, 22);
            this.submenucategoria.Text = "Categoria";
            this.submenucategoria.Click += new System.EventHandler(this.submenucategoria_Click);
            // 
            // submenuproducto
            // 
            this.submenuproducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuproducto.IconColor = System.Drawing.Color.Black;
            this.submenuproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuproducto.Name = "submenuproducto";
            this.submenuproducto.Size = new System.Drawing.Size(126, 22);
            this.submenuproducto.Text = "Producto";
            this.submenuproducto.Click += new System.EventHandler(this.submenuproducto_Click);
            // 
            // menuventas
            // 
            this.menuventas.AutoSize = false;
            this.menuventas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuregistrarventa,
            this.submenuverdetalleventa});
            this.menuventas.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuventas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.menuventas.IconColor = System.Drawing.Color.Black;
            this.menuventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuventas.IconSize = 50;
            this.menuventas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuventas.Name = "menuventas";
            this.menuventas.Size = new System.Drawing.Size(80, 69);
            this.menuventas.Text = "Ventas";
            this.menuventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // submenuregistrarventa
            // 
            this.submenuregistrarventa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuregistrarventa.IconColor = System.Drawing.Color.Black;
            this.submenuregistrarventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuregistrarventa.Name = "submenuregistrarventa";
            this.submenuregistrarventa.Size = new System.Drawing.Size(134, 22);
            this.submenuregistrarventa.Text = "Registrar";
            this.submenuregistrarventa.Click += new System.EventHandler(this.submenuregistrarventa_Click);
            // 
            // submenuverdetalleventa
            // 
            this.submenuverdetalleventa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuverdetalleventa.IconColor = System.Drawing.Color.Black;
            this.submenuverdetalleventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuverdetalleventa.Name = "submenuverdetalleventa";
            this.submenuverdetalleventa.Size = new System.Drawing.Size(134, 22);
            this.submenuverdetalleventa.Text = "Ver Detalle";
            this.submenuverdetalleventa.Click += new System.EventHandler(this.submenuverdetalleventa_Click);
            // 
            // menucompras
            // 
            this.menucompras.AutoSize = false;
            this.menucompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuregistrarcompra,
            this.submenuverdetallecompra});
            this.menucompras.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menucompras.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.menucompras.IconColor = System.Drawing.Color.Black;
            this.menucompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menucompras.IconSize = 50;
            this.menucompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menucompras.Name = "menucompras";
            this.menucompras.Size = new System.Drawing.Size(80, 69);
            this.menucompras.Text = "Compras";
            this.menucompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // submenuregistrarcompra
            // 
            this.submenuregistrarcompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuregistrarcompra.IconColor = System.Drawing.Color.Black;
            this.submenuregistrarcompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuregistrarcompra.Name = "submenuregistrarcompra";
            this.submenuregistrarcompra.Size = new System.Drawing.Size(134, 22);
            this.submenuregistrarcompra.Text = "Registrar";
            this.submenuregistrarcompra.Click += new System.EventHandler(this.submenuregistrarcompra_Click);
            // 
            // submenuverdetallecompra
            // 
            this.submenuverdetallecompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuverdetallecompra.IconColor = System.Drawing.Color.Black;
            this.submenuverdetallecompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuverdetallecompra.Name = "submenuverdetallecompra";
            this.submenuverdetallecompra.Size = new System.Drawing.Size(134, 22);
            this.submenuverdetallecompra.Text = "Ver Detalle";
            this.submenuverdetallecompra.Click += new System.EventHandler(this.submenuverdetallecompra_Click);
            // 
            // menuclientes
            // 
            this.menuclientes.AutoSize = false;
            this.menuclientes.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuclientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.menuclientes.IconColor = System.Drawing.Color.Black;
            this.menuclientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuclientes.IconSize = 50;
            this.menuclientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuclientes.Name = "menuclientes";
            this.menuclientes.Size = new System.Drawing.Size(80, 69);
            this.menuclientes.Text = "Clientes";
            this.menuclientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuclientes.Click += new System.EventHandler(this.menuclientes_Click);
            // 
            // menuproveedores
            // 
            this.menuproveedores.AutoSize = false;
            this.menuproveedores.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuproveedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.menuproveedores.IconColor = System.Drawing.Color.Black;
            this.menuproveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuproveedores.IconSize = 50;
            this.menuproveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuproveedores.Name = "menuproveedores";
            this.menuproveedores.Size = new System.Drawing.Size(80, 69);
            this.menuproveedores.Text = "Proveedores";
            this.menuproveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuproveedores.Click += new System.EventHandler(this.menuproveedores_Click);
            // 
            // menureportes
            // 
            this.menureportes.AutoSize = false;
            this.menureportes.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menureportes.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.menureportes.IconColor = System.Drawing.Color.Black;
            this.menureportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menureportes.IconSize = 50;
            this.menureportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menureportes.Name = "menureportes";
            this.menureportes.Size = new System.Drawing.Size(80, 69);
            this.menureportes.Text = "Reportes";
            this.menureportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menureportes.Click += new System.EventHandler(this.menureportes_Click);
            // 
            // menuacercade
            // 
            this.menuacercade.AutoSize = false;
            this.menuacercade.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuacercade.ForeColor = System.Drawing.Color.Black;
            this.menuacercade.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.menuacercade.IconColor = System.Drawing.Color.Black;
            this.menuacercade.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuacercade.IconSize = 50;
            this.menuacercade.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuacercade.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.menuacercade.Name = "menuacercade";
            this.menuacercade.Size = new System.Drawing.Size(80, 69);
            this.menuacercade.Text = "Acerca de";
            this.menuacercade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menutitulo
            // 
            this.menutitulo.AutoSize = false;
            this.menutitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menutitulo.Location = new System.Drawing.Point(0, 0);
            this.menutitulo.Name = "menutitulo";
            this.menutitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menutitulo.Size = new System.Drawing.Size(1090, 66);
            this.menutitulo.TabIndex = 1;
            this.menutitulo.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de Ventas SADA";
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 139);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1090, 564);
            this.contenedor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(799, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario:";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblusuario.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.ForeColor = System.Drawing.Color.White;
            this.lblusuario.Location = new System.Drawing.Point(861, 28);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(74, 19);
            this.lblusuario.TabIndex = 5;
            this.lblusuario.Text = "lblusuario";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 703);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menutitulo);
            this.MainMenuStrip = this.menu;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menutitulo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem menuacercade;
        private FontAwesome.Sharp.IconMenuItem menusuarios;
        private FontAwesome.Sharp.IconMenuItem menuinventario;
        private FontAwesome.Sharp.IconMenuItem menuventas;
        private FontAwesome.Sharp.IconMenuItem menucompras;
        private FontAwesome.Sharp.IconMenuItem menuclientes;
        private FontAwesome.Sharp.IconMenuItem menuproveedores;
        private FontAwesome.Sharp.IconMenuItem menureportes;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblusuario;
        private FontAwesome.Sharp.IconMenuItem submenucategoria;
        private FontAwesome.Sharp.IconMenuItem submenuproducto;
        private FontAwesome.Sharp.IconMenuItem submenuregistrarventa;
        private FontAwesome.Sharp.IconMenuItem submenuverdetalleventa;
        private FontAwesome.Sharp.IconMenuItem submenuregistrarcompra;
        private FontAwesome.Sharp.IconMenuItem submenuverdetallecompra;
    }
}

