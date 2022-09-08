namespace GestionLocal
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.Calcular_IVA = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ganancia_45 = new System.Windows.Forms.TextBox();
            this.txt_ganancia_50 = new System.Windows.Forms.TextBox();
            this.btn_borrarTodo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.text_costo_final = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txt_45_sinIVa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_50_sinIVA = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Calcular_IVA
            // 
            this.Calcular_IVA.BackColor = System.Drawing.SystemColors.Control;
            this.Calcular_IVA.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Calcular_IVA.Location = new System.Drawing.Point(203, 243);
            this.Calcular_IVA.Name = "Calcular_IVA";
            this.Calcular_IVA.Size = new System.Drawing.Size(75, 23);
            this.Calcular_IVA.TabIndex = 1;
            this.Calcular_IVA.Text = "Calcular";
            this.Calcular_IVA.UseVisualStyleBackColor = false;
            this.Calcular_IVA.Click += new System.EventHandler(this.Calcular_IVA_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_Cerrar.Location = new System.Drawing.Point(48, 36);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cerrar.TabIndex = 4;
            this.btn_Cerrar.Text = "x";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(155, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingresar Precio sin IVA";
            // 
            // txt_Precio
            // 
            this.txt_Precio.Location = new System.Drawing.Point(153, 163);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(100, 23);
            this.txt_Precio.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(44, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "IVA+50% de ganancia";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(44, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "IVA+45% de ganancia";
            // 
            // txt_ganancia_45
            // 
            this.txt_ganancia_45.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ganancia_45.Location = new System.Drawing.Point(54, 124);
            this.txt_ganancia_45.Name = "txt_ganancia_45";
            this.txt_ganancia_45.Size = new System.Drawing.Size(100, 23);
            this.txt_ganancia_45.TabIndex = 9;
            // 
            // txt_ganancia_50
            // 
            this.txt_ganancia_50.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ganancia_50.Location = new System.Drawing.Point(54, 219);
            this.txt_ganancia_50.Name = "txt_ganancia_50";
            this.txt_ganancia_50.Size = new System.Drawing.Size(100, 23);
            this.txt_ganancia_50.TabIndex = 10;
            // 
            // btn_borrarTodo
            // 
            this.btn_borrarTodo.BackColor = System.Drawing.SystemColors.Control;
            this.btn_borrarTodo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_borrarTodo.Location = new System.Drawing.Point(95, 243);
            this.btn_borrarTodo.Name = "btn_borrarTodo";
            this.btn_borrarTodo.Size = new System.Drawing.Size(75, 23);
            this.btn_borrarTodo.TabIndex = 22;
            this.btn_borrarTodo.Text = "Borrar";
            this.btn_borrarTodo.UseVisualStyleBackColor = false;
            this.btn_borrarTodo.Click += new System.EventHandler(this.btn_borrarTodo_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.text_costo_final);
            this.panel1.Controls.Add(this.txt_ganancia_50);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_ganancia_45);
            this.panel1.Location = new System.Drawing.Point(533, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 264);
            this.panel1.TabIndex = 23;
           
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(44, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Costo Final";
            // 
            // text_costo_final
            // 
            this.text_costo_final.Location = new System.Drawing.Point(121, 29);
            this.text_costo_final.Name = "text_costo_final";
            this.text_costo_final.Size = new System.Drawing.Size(63, 23);
            this.text_costo_final.TabIndex = 11;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txt_45_sinIVa
            // 
            this.txt_45_sinIVa.Location = new System.Drawing.Point(29, 71);
            this.txt_45_sinIVa.Name = "txt_45_sinIVa";
            this.txt_45_sinIVa.Size = new System.Drawing.Size(100, 23);
            this.txt_45_sinIVa.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(29, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "+45 de ganancia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(29, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "+50 de ganancia";
            // 
            // txt_50_sinIVA
            // 
            this.txt_50_sinIVA.Location = new System.Drawing.Point(29, 125);
            this.txt_50_sinIVA.Name = "txt_50_sinIVA";
            this.txt_50_sinIVA.Size = new System.Drawing.Size(100, 23);
            this.txt_50_sinIVA.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.txt_50_sinIVA);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_45_sinIVa);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(558, 352);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 171);
            this.panel2.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label7.Location = new System.Drawing.Point(29, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 15);
            this.label7.TabIndex = 30;
            this.label7.Text = "Precios sin IVA";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 544);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_borrarTodo);
            this.Controls.Add(this.txt_Precio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.Calcular_IVA);
            this.Name = "Form3";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button Calcular_IVA;
        private Button btn_Cerrar;
        private Label label1;
        private TextBox txt_Precio;
        private Label label2;
        private Label label3;
        private TextBox txt_ganancia_45;
        private TextBox txt_ganancia_50;
        private Button btn_borrarTodo;
        private Panel panel1;
        private Label label4;
        private TextBox text_costo_final;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txt_45_sinIVa;
        private Label label5;
        private Label label6;
        private TextBox txt_50_sinIVA;
        private Panel panel2;
        private Label label7;
    }
}