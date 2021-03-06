﻿namespace MecanicaUTN.Vista
{
    partial class frmRepuesto
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.chkGravado = new System.Windows.Forms.CheckBox();
            this.txtImpuesto = new System.Windows.Forms.NumericUpDown();
            this.lblImpuesto = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.splRepuesto = new System.Windows.Forms.SplitContainer();
            this.dtgRepuesto = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.txtImpuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splRepuesto)).BeginInit();
            this.splRepuesto.Panel1.SuspendLayout();
            this.splRepuesto.Panel2.SuspendLayout();
            this.splRepuesto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRepuesto)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(166, 304);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 44;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Location = new System.Drawing.Point(73, 304);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 43;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // chkGravado
            // 
            this.chkGravado.AutoSize = true;
            this.chkGravado.Location = new System.Drawing.Point(73, 259);
            this.chkGravado.Name = "chkGravado";
            this.chkGravado.Size = new System.Drawing.Size(67, 17);
            this.chkGravado.TabIndex = 42;
            this.chkGravado.Text = "Gravado";
            this.chkGravado.UseVisualStyleBackColor = true;
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Location = new System.Drawing.Point(73, 219);
            this.txtImpuesto.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(229, 20);
            this.txtImpuesto.TabIndex = 41;
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.AutoSize = true;
            this.lblImpuesto.Location = new System.Drawing.Point(18, 226);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(53, 13);
            this.lblImpuesto.TabIndex = 40;
            this.lblImpuesto.Text = "Impuesto:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(73, 183);
            this.txtPrecio.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(229, 20);
            this.txtPrecio.TabIndex = 39;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(18, 190);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 38;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(73, 142);
            this.txtCantidad.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(229, 20);
            this.txtCantidad.TabIndex = 37;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(18, 149);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 36;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(73, 96);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(229, 20);
            this.txtMarca.TabIndex = 35;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(15, 109);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 34;
            this.lblMarca.Text = "Marca:";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(73, 57);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(229, 20);
            this.txtModelo.TabIndex = 33;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(15, 64);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(45, 13);
            this.lblModelo.TabIndex = 32;
            this.lblModelo.Text = "Modelo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(73, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(229, 20);
            this.txtNombre.TabIndex = 31;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 30;
            this.lblNombre.Text = "Nombre:";
            // 
            // splRepuesto
            // 
            this.splRepuesto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splRepuesto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splRepuesto.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splRepuesto.Location = new System.Drawing.Point(0, 0);
            this.splRepuesto.Name = "splRepuesto";
            // 
            // splRepuesto.Panel1
            // 
            this.splRepuesto.Panel1.Controls.Add(this.btnCancelar);
            this.splRepuesto.Panel1.Controls.Add(this.txtModelo);
            this.splRepuesto.Panel1.Controls.Add(this.btnAceptar);
            this.splRepuesto.Panel1.Controls.Add(this.lblNombre);
            this.splRepuesto.Panel1.Controls.Add(this.chkGravado);
            this.splRepuesto.Panel1.Controls.Add(this.txtNombre);
            this.splRepuesto.Panel1.Controls.Add(this.txtImpuesto);
            this.splRepuesto.Panel1.Controls.Add(this.lblModelo);
            this.splRepuesto.Panel1.Controls.Add(this.lblImpuesto);
            this.splRepuesto.Panel1.Controls.Add(this.lblMarca);
            this.splRepuesto.Panel1.Controls.Add(this.txtPrecio);
            this.splRepuesto.Panel1.Controls.Add(this.txtMarca);
            this.splRepuesto.Panel1.Controls.Add(this.lblPrecio);
            this.splRepuesto.Panel1.Controls.Add(this.lblCantidad);
            this.splRepuesto.Panel1.Controls.Add(this.txtCantidad);
            // 
            // splRepuesto.Panel2
            // 
            this.splRepuesto.Panel2.Controls.Add(this.dtgRepuesto);
            this.splRepuesto.Panel2.Controls.Add(this.menuStrip1);
            this.splRepuesto.Size = new System.Drawing.Size(741, 466);
            this.splRepuesto.SplitterDistance = 320;
            this.splRepuesto.SplitterWidth = 10;
            this.splRepuesto.TabIndex = 45;
            // 
            // dtgRepuesto
            // 
            this.dtgRepuesto.AllowUserToAddRows = false;
            this.dtgRepuesto.AllowUserToDeleteRows = false;
            this.dtgRepuesto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgRepuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRepuesto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgRepuesto.Location = new System.Drawing.Point(0, 47);
            this.dtgRepuesto.MultiSelect = false;
            this.dtgRepuesto.Name = "dtgRepuesto";
            this.dtgRepuesto.ReadOnly = true;
            this.dtgRepuesto.Size = new System.Drawing.Size(407, 415);
            this.dtgRepuesto.TabIndex = 0;
            this.dtgRepuesto.SelectionChanged += new System.EventHandler(this.dtgRepuesto_SelectionChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(407, 47);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Image = global::MecanicaUTN.Properties.Resources._1423367308_Add;
            this.nuevoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(54, 43);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Image = global::MecanicaUTN.Properties.Resources.accessories_text_editor;
            this.editarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 43);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Image = global::MecanicaUTN.Properties.Resources.descarga;
            this.eliminarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(62, 43);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // frmRepuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 466);
            this.Controls.Add(this.splRepuesto);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmRepuesto";
            this.Text = "Repuesto";
            ((System.ComponentModel.ISupportInitialize)(this.txtImpuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            this.splRepuesto.Panel1.ResumeLayout(false);
            this.splRepuesto.Panel1.PerformLayout();
            this.splRepuesto.Panel2.ResumeLayout(false);
            this.splRepuesto.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splRepuesto)).EndInit();
            this.splRepuesto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRepuesto)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.CheckBox chkGravado;
        private System.Windows.Forms.NumericUpDown txtImpuesto;
        private System.Windows.Forms.Label lblImpuesto;
        private System.Windows.Forms.NumericUpDown txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.SplitContainer splRepuesto;
        private System.Windows.Forms.DataGridView dtgRepuesto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    }
}