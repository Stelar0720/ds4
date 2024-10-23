namespace Parcial2
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
            txt_peso_lb = new TextBox();
            txt_altura_ft = new TextBox();
            btn_converitr_peso = new Button();
            btn_convertir_altura = new Button();
            txt_altura_mts = new TextBox();
            txt_peso_kg = new TextBox();
            btn_calcular = new Button();
            btn_limpiar = new Button();
            txt_categoria = new TextBox();
            lst_registro = new ListBox();
            btn_salir = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txt_diferencia = new TextBox();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // txt_peso_lb
            // 
            txt_peso_lb.Location = new Point(157, 75);
            txt_peso_lb.Name = "txt_peso_lb";
            txt_peso_lb.Size = new Size(125, 27);
            txt_peso_lb.TabIndex = 0;
            // 
            // txt_altura_ft
            // 
            txt_altura_ft.Location = new Point(157, 141);
            txt_altura_ft.Name = "txt_altura_ft";
            txt_altura_ft.Size = new Size(125, 27);
            txt_altura_ft.TabIndex = 1;
            // 
            // btn_converitr_peso
            // 
            btn_converitr_peso.Location = new Point(311, 74);
            btn_converitr_peso.Name = "btn_converitr_peso";
            btn_converitr_peso.Size = new Size(94, 29);
            btn_converitr_peso.TabIndex = 2;
            btn_converitr_peso.Text = "Convertir";
            btn_converitr_peso.UseVisualStyleBackColor = true;
            btn_converitr_peso.Click += btn_convertir_peso_Click;
            // 
            // btn_convertir_altura
            // 
            btn_convertir_altura.Location = new Point(311, 141);
            btn_convertir_altura.Name = "btn_convertir_altura";
            btn_convertir_altura.Size = new Size(94, 29);
            btn_convertir_altura.TabIndex = 3;
            btn_convertir_altura.Text = "Convertir";
            btn_convertir_altura.UseVisualStyleBackColor = true;
            btn_convertir_altura.Click += btn_convertir_altura_Click;
            // 
            // txt_altura_mts
            // 
            txt_altura_mts.Location = new Point(432, 142);
            txt_altura_mts.Name = "txt_altura_mts";
            txt_altura_mts.Size = new Size(125, 27);
            txt_altura_mts.TabIndex = 5;
            // 
            // txt_peso_kg
            // 
            txt_peso_kg.Location = new Point(432, 76);
            txt_peso_kg.Name = "txt_peso_kg";
            txt_peso_kg.Size = new Size(125, 27);
            txt_peso_kg.TabIndex = 4;
            // 
            // btn_calcular
            // 
            btn_calcular.Location = new Point(311, 191);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(94, 29);
            btn_calcular.TabIndex = 6;
            btn_calcular.Text = "Calcular";
            btn_calcular.UseVisualStyleBackColor = true;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // btn_limpiar
            // 
            btn_limpiar.Location = new Point(212, 438);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(94, 29);
            btn_limpiar.TabIndex = 7;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = true;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // txt_categoria
            // 
            txt_categoria.Location = new Point(212, 259);
            txt_categoria.Name = "txt_categoria";
            txt_categoria.Size = new Size(125, 27);
            txt_categoria.TabIndex = 8;
            // 
            // lst_registro
            // 
            lst_registro.FormattingEnabled = true;
            lst_registro.Location = new Point(260, 303);
            lst_registro.Name = "lst_registro";
            lst_registro.Size = new Size(187, 104);
            lst_registro.TabIndex = 9;
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(400, 438);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(94, 29);
            btn_salir.TabIndex = 10;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(157, 52);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 11;
            label1.Text = "lb";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(157, 118);
            label2.Name = "label2";
            label2.Size = new Size(19, 20);
            label2.TabIndex = 12;
            label2.Text = "ft";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(432, 52);
            label3.Name = "label3";
            label3.Size = new Size(25, 20);
            label3.TabIndex = 13;
            label3.Text = "kg";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(432, 118);
            label4.Name = "label4";
            label4.Size = new Size(33, 20);
            label4.TabIndex = 14;
            label4.Text = "mts";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 83);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 15;
            label5.Text = "Peso";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(76, 150);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 16;
            label6.Text = "Altura";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(104, 266);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 17;
            label7.Text = "Resultado";
            // 
            // txt_diferencia
            // 
            txt_diferencia.Location = new Point(369, 259);
            txt_diferencia.Name = "txt_diferencia";
            txt_diferencia.Size = new Size(125, 27);
            txt_diferencia.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(212, 236);
            label8.Name = "label8";
            label8.Size = new Size(74, 20);
            label8.TabIndex = 19;
            label8.Text = "Categoria";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(369, 236);
            label9.Name = "label9";
            label9.Size = new Size(35, 20);
            label9.TabIndex = 20;
            label9.Text = "IMC";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 497);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txt_diferencia);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_salir);
            Controls.Add(lst_registro);
            Controls.Add(txt_categoria);
            Controls.Add(btn_limpiar);
            Controls.Add(btn_calcular);
            Controls.Add(txt_altura_mts);
            Controls.Add(txt_peso_kg);
            Controls.Add(btn_convertir_altura);
            Controls.Add(btn_converitr_peso);
            Controls.Add(txt_altura_ft);
            Controls.Add(txt_peso_lb);
            Name = "Form1";
            Text = "IMC Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_peso_lb;
        private TextBox txt_altura_ft;
        private Button btn_converitr_peso;
        private Button btn_convertir_altura;
        private TextBox txt_altura_mts;
        private TextBox txt_peso_kg;
        private Button btn_calcular;
        private Button btn_limpiar;
        private TextBox txt_categoria;
        private ListBox lst_registro;
        private Button btn_salir;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txt_diferencia;
        private Label label8;
        private Label label9;
    }
}
