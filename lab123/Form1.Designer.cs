namespace lab123
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
            label5 = new Label();
            label6 = new Label();
            Txt_ladoa = new TextBox();
            Txt_ladob = new TextBox();
            Txt_ladoc = new TextBox();
            Txt_semiperimetro = new TextBox();
            Txt_area = new TextBox();
            Btn_semiperimetro = new Button();
            Btn_area = new Button();
            Btn_limpiar = new Button();
            Btn_salir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(232, 30);
            label1.Name = "label1";
            label1.Size = new Size(328, 20);
            label1.TabIndex = 0;
            label1.Text = "Calcular el area y semiperimetro de un triangulo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(190, 118);
            label2.Name = "label2";
            label2.Size = new Size(206, 20);
            label2.TabIndex = 1;
            label2.Text = "Ingresa la longitud del lado A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(190, 169);
            label3.Name = "label3";
            label3.Size = new Size(205, 20);
            label3.TabIndex = 2;
            label3.Text = "Ingresa la longitud del lado B";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(190, 223);
            label4.Name = "label4";
            label4.Size = new Size(205, 20);
            label4.TabIndex = 3;
            label4.Text = "Ingresa la longitud del lado C";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(190, 332);
            label5.Name = "label5";
            label5.Size = new Size(165, 20);
            label5.TabIndex = 4;
            label5.Text = "Calcular Semiperimetro";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(190, 383);
            label6.Name = "label6";
            label6.Size = new Size(131, 20);
            label6.TabIndex = 5;
            label6.Text = "Area del Triangulo";
            // 
            // Txt_ladoa
            // 
            Txt_ladoa.Location = new Point(435, 111);
            Txt_ladoa.Name = "Txt_ladoa";
            Txt_ladoa.Size = new Size(125, 27);
            Txt_ladoa.TabIndex = 6;
            // 
            // Txt_ladob
            // 
            Txt_ladob.Location = new Point(435, 171);
            Txt_ladob.Name = "Txt_ladob";
            Txt_ladob.Size = new Size(125, 27);
            Txt_ladob.TabIndex = 7;
            // 
            // Txt_ladoc
            // 
            Txt_ladoc.Location = new Point(435, 220);
            Txt_ladoc.Name = "Txt_ladoc";
            Txt_ladoc.Size = new Size(125, 27);
            Txt_ladoc.TabIndex = 8;
            // 
            // Txt_semiperimetro
            // 
            Txt_semiperimetro.Location = new Point(435, 325);
            Txt_semiperimetro.Name = "Txt_semiperimetro";
            Txt_semiperimetro.Size = new Size(125, 27);
            Txt_semiperimetro.TabIndex = 9;
            // 
            // Txt_area
            // 
            Txt_area.Location = new Point(435, 376);
            Txt_area.Name = "Txt_area";
            Txt_area.Size = new Size(125, 27);
            Txt_area.TabIndex = 10;
            // 
            // Btn_semiperimetro
            // 
            Btn_semiperimetro.Location = new Point(123, 275);
            Btn_semiperimetro.Name = "Btn_semiperimetro";
            Btn_semiperimetro.Size = new Size(132, 29);
            Btn_semiperimetro.TabIndex = 11;
            Btn_semiperimetro.Text = "Semiperimetro";
            Btn_semiperimetro.UseVisualStyleBackColor = true;
            Btn_semiperimetro.Click += Btn_semiperimetro_Click;
            // 
            // Btn_area
            // 
            Btn_area.Location = new Point(287, 275);
            Btn_area.Name = "Btn_area";
            Btn_area.Size = new Size(94, 29);
            Btn_area.TabIndex = 12;
            Btn_area.Text = "Area";
            Btn_area.UseVisualStyleBackColor = true;
            Btn_area.Click += Btn_area_Click;
            // 
            // Btn_limpiar
            // 
            Btn_limpiar.Location = new Point(422, 275);
            Btn_limpiar.Name = "Btn_limpiar";
            Btn_limpiar.Size = new Size(94, 29);
            Btn_limpiar.TabIndex = 13;
            Btn_limpiar.Text = "Limpiar";
            Btn_limpiar.UseVisualStyleBackColor = true;
            Btn_limpiar.Click += Btn_limpiar_Click;
            // 
            // Btn_salir
            // 
            Btn_salir.Location = new Point(551, 275);
            Btn_salir.Name = "Btn_salir";
            Btn_salir.Size = new Size(94, 29);
            Btn_salir.TabIndex = 14;
            Btn_salir.Text = "Salir";
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
            Controls.Add(Btn_area);
            Controls.Add(Btn_semiperimetro);
            Controls.Add(Txt_area);
            Controls.Add(Txt_semiperimetro);
            Controls.Add(Txt_ladoc);
            Controls.Add(Txt_ladob);
            Controls.Add(Txt_ladoa);
            Controls.Add(label6);
            Controls.Add(label5);
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
        private Label label5;
        private Label label6;
        private TextBox Txt_ladoa;
        private TextBox Txt_ladob;
        private TextBox Txt_ladoc;
        private TextBox Txt_semiperimetro;
        private TextBox Txt_area;
        private Button Btn_semiperimetro;
        private Button Btn_area;
        private Button Btn_limpiar;
        private Button Btn_salir;
    }
}
