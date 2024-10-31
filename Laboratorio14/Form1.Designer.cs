namespace Laboratorio14
{
    partial class frmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            txtId = new TextBox();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnSalir = new Button();
            toolStrip1 = new ToolStrip();
            tsbNuevo = new ToolStripButton();
            tsbGuardar = new ToolStripButton();
            tsbCancelar = new ToolStripButton();
            tsbEliminar = new ToolStripButton();
            toolStripLabel1 = new ToolStripLabel();
            tstId = new ToolStripTextBox();
            tsbBuscar = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(24, 72);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 0;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(24, 134);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 1;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(178, 134);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(504, 27);
            txtStock.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(178, 72);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(504, 27);
            txtNombre.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 49);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 4;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(178, 49);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 5;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(178, 111);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 7;
            label3.Text = "Stock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 111);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 6;
            label4.Text = "Precio";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(24, 196);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbGuardar, tsbCancelar, tsbEliminar, toolStripLabel1, tstId, tsbBuscar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(724, 27);
            toolStrip1.TabIndex = 9;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            tsbNuevo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbNuevo.Image = (Image)resources.GetObject("tsbNuevo.Image");
            tsbNuevo.ImageTransparentColor = Color.Magenta;
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(29, 24);
            tsbNuevo.Text = "toolStripButton1";
            tsbNuevo.Click += tsbNuevo_Click;
            // 
            // tsbGuardar
            // 
            tsbGuardar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbGuardar.Image = (Image)resources.GetObject("tsbGuardar.Image");
            tsbGuardar.ImageTransparentColor = Color.Magenta;
            tsbGuardar.Name = "tsbGuardar";
            tsbGuardar.Size = new Size(29, 24);
            tsbGuardar.Text = "toolStripButton2";
            tsbGuardar.Click += tsbGuardar_Click;
            // 
            // tsbCancelar
            // 
            tsbCancelar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbCancelar.Image = (Image)resources.GetObject("tsbCancelar.Image");
            tsbCancelar.ImageTransparentColor = Color.Magenta;
            tsbCancelar.Name = "tsbCancelar";
            tsbCancelar.Size = new Size(29, 24);
            tsbCancelar.Text = "toolStripButton3";
            tsbCancelar.Click += tsbCancelar_Click;
            // 
            // tsbEliminar
            // 
            tsbEliminar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbEliminar.Image = (Image)resources.GetObject("tsbEliminar.Image");
            tsbEliminar.ImageTransparentColor = Color.Magenta;
            tsbEliminar.Name = "tsbEliminar";
            tsbEliminar.Size = new Size(29, 24);
            tsbEliminar.Text = "toolStripButton4";
            tsbEliminar.Click += tsbEliminar_Click;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(96, 24);
            toolStripLabel1.Text = "Buscar por Id";
            // 
            // tstId
            // 
            tstId.Name = "tstId";
            tstId.Size = new Size(100, 27);
            // 
            // tsbBuscar
            // 
            tsbBuscar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbBuscar.Image = (Image)resources.GetObject("tsbBuscar.Image");
            tsbBuscar.ImageTransparentColor = Color.Magenta;
            tsbBuscar.Name = "tsbBuscar";
            tsbBuscar.Size = new Size(29, 24);
            tsbBuscar.Text = "toolStripButton5";
            tsbBuscar.Click += tsbBuscar_Click;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 272);
            Controls.Add(toolStrip1);
            Controls.Add(btnSalir);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtStock);
            Controls.Add(txtNombre);
            Controls.Add(txtPrecio);
            Controls.Add(txtId);
            Name = "frmProductos";
            Text = "Productos";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtPrecio;
        private TextBox txtStock;
        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnSalir;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbNuevo;
        private ToolStripButton tsbGuardar;
        private ToolStripButton tsbCancelar;
        private ToolStripButton tsbEliminar;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox tstId;
        private ToolStripButton tsbBuscar;
    }
}
