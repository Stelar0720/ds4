namespace lab122
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
            Txt_nota1 = new TextBox();
            Txt_nota2 = new TextBox();
            Txt_nota3 = new TextBox();
            Txt_promedio = new TextBox();
            Btn_calcular = new Button();
            Btn_limpiar = new Button();
            Btn_salir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(363, 55);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 0;
            label1.Text = "NOTA PROMEDIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(284, 113);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 1;
            label2.Text = "NOTA 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(284, 152);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 2;
            label3.Text = "NOTA 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(284, 190);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 3;
            label4.Text = "NOTA 3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(284, 325);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 4;
            label5.Text = "PROMEDIO";
            // 
            // Txt_nota1
            // 
            Txt_nota1.Location = new Point(430, 106);
            Txt_nota1.Name = "Txt_nota1";
            Txt_nota1.Size = new Size(125, 27);
            Txt_nota1.TabIndex = 5;
            // 
            // Txt_nota2
            // 
            Txt_nota2.Location = new Point(430, 145);
            Txt_nota2.Name = "Txt_nota2";
            Txt_nota2.Size = new Size(125, 27);
            Txt_nota2.TabIndex = 6;
            // 
            // Txt_nota3
            // 
            Txt_nota3.Location = new Point(430, 187);
            Txt_nota3.Name = "Txt_nota3";
            Txt_nota3.Size = new Size(125, 27);
            Txt_nota3.TabIndex = 7;
            // 
            // Txt_promedio
            // 
            Txt_promedio.Location = new Point(430, 322);
            Txt_promedio.Name = "Txt_promedio";
            Txt_promedio.Size = new Size(125, 27);
            Txt_promedio.TabIndex = 8;
            // 
            // Btn_calcular
            // 
            Btn_calcular.Location = new Point(177, 248);
            Btn_calcular.Name = "Btn_calcular";
            Btn_calcular.Size = new Size(94, 29);
            Btn_calcular.TabIndex = 9;
            Btn_calcular.Text = "CALCULAR";
            Btn_calcular.UseVisualStyleBackColor = true;
            Btn_calcular.Click += Btn_calcular_Click;
            // 
            // Btn_limpiar
            // 
            Btn_limpiar.Location = new Point(375, 247);
            Btn_limpiar.Name = "Btn_limpiar";
            Btn_limpiar.Size = new Size(94, 29);
            Btn_limpiar.TabIndex = 10;
            Btn_limpiar.Text = "LIMPIAR";
            Btn_limpiar.UseVisualStyleBackColor = true;
            Btn_limpiar.Click += Btn_limpiar_Click;
            // 
            // Btn_salir
            // 
            Btn_salir.Location = new Point(591, 248);
            Btn_salir.Name = "Btn_salir";
            Btn_salir.Size = new Size(94, 29);
            Btn_salir.TabIndex = 11;
            Btn_salir.Text = "SALIR";
            Btn_salir.UseVisualStyleBackColor = true;
            Btn_salir.Click += Btn_salir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 450);
            Controls.Add(Btn_salir);
            Controls.Add(Btn_limpiar);
            Controls.Add(Btn_calcular);
            Controls.Add(Txt_promedio);
            Controls.Add(Txt_nota3);
            Controls.Add(Txt_nota2);
            Controls.Add(Txt_nota1);
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
        private TextBox Txt_nota1;
        private TextBox Txt_nota2;
        private TextBox Txt_nota3;
        private TextBox Txt_promedio;
        private Button Btn_calcular;
        private Button Btn_limpiar;
        private Button Btn_salir;
    }
}
