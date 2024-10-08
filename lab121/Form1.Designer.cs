namespace lab121
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Txt_velocidad = new TextBox();
            Txt_tiempo = new TextBox();
            Txt_distancia = new TextBox();
            Btn_calcular = new Button();
            Btn_limpiar = new Button();
            Btn_salir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(324, 55);
            label1.Name = "label1";
            label1.Size = new Size(157, 20);
            label1.TabIndex = 0;
            label1.Text = "CALCULAR DISTANCIA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(242, 206);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 1;
            label2.Text = "TIEMPO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(242, 132);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 2;
            label3.Text = "VELOCIDAD";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(242, 332);
            label4.Name = "label4";
            label4.Size = new Size(167, 20);
            label4.TabIndex = 3;
            label4.Text = "DISTANCIA RECORRIDA";
            // 
            // Txt_velocidad
            // 
            Txt_velocidad.Location = new Point(426, 125);
            Txt_velocidad.Name = "Txt_velocidad";
            Txt_velocidad.Size = new Size(125, 27);
            Txt_velocidad.TabIndex = 4;
            // 
            // Txt_tiempo
            // 
            Txt_tiempo.Location = new Point(426, 199);
            Txt_tiempo.Name = "Txt_tiempo";
            Txt_tiempo.Size = new Size(125, 27);
            Txt_tiempo.TabIndex = 5;
            // 
            // Txt_distancia
            // 
            Txt_distancia.Location = new Point(426, 325);
            Txt_distancia.Name = "Txt_distancia";
            Txt_distancia.Size = new Size(125, 27);
            Txt_distancia.TabIndex = 6;
            // 
            // Btn_calcular
            // 
            Btn_calcular.Location = new Point(158, 251);
            Btn_calcular.Name = "Btn_calcular";
            Btn_calcular.Size = new Size(94, 29);
            Btn_calcular.TabIndex = 7;
            Btn_calcular.Text = "calcular";
            Btn_calcular.UseVisualStyleBackColor = true;
            Btn_calcular.Click += Btn_calcular_Click;
            // 
            // Btn_limpiar
            // 
            Btn_limpiar.Location = new Point(352, 251);
            Btn_limpiar.Name = "Btn_limpiar";
            Btn_limpiar.Size = new Size(94, 29);
            Btn_limpiar.TabIndex = 8;
            Btn_limpiar.Text = "limpiar";
            Btn_limpiar.UseVisualStyleBackColor = true;
            Btn_limpiar.Click += Btn_limpiar_Click;
            // 
            // Btn_salir
            // 
            Btn_salir.Location = new Point(545, 251);
            Btn_salir.Name = "Btn_salir";
            Btn_salir.Size = new Size(94, 29);
            Btn_salir.TabIndex = 9;
            Btn_salir.Text = "salir";
            Btn_salir.UseVisualStyleBackColor = true;
            Btn_salir.Click += Btn_salir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Btn_salir);
            Controls.Add(Btn_limpiar);
            Controls.Add(Btn_calcular);
            Controls.Add(Txt_distancia);
            Controls.Add(Txt_tiempo);
            Controls.Add(Txt_velocidad);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Txt_velocidad;
        private TextBox Txt_tiempo;
        private TextBox Txt_distancia;
        private Button Btn_calcular;
        private Button Btn_limpiar;
        private Button Btn_salir;
    }
}
