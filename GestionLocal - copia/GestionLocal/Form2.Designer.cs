namespace GestionLocal
{
    partial class Form2
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
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.btn_Caclcular_caños_res = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_res_1_4 = new System.Windows.Forms.TextBox();
            this.txt_res_1_2 = new System.Windows.Forms.TextBox();
            this.txt_res_3_8 = new System.Windows.Forms.TextBox();
            this.txt_res_5_8 = new System.Windows.Forms.TextBox();
            this.txt_precio_kg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_borrarTodo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_Cerrar.Location = new System.Drawing.Point(67, 30);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cerrar.TabIndex = 9;
            this.btn_Cerrar.Text = "x";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btn_Caclcular_caños_res
            // 
            this.btn_Caclcular_caños_res.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Caclcular_caños_res.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Caclcular_caños_res.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_Caclcular_caños_res.Location = new System.Drawing.Point(234, 210);
            this.btn_Caclcular_caños_res.Name = "btn_Caclcular_caños_res";
            this.btn_Caclcular_caños_res.Size = new System.Drawing.Size(75, 23);
            this.btn_Caclcular_caños_res.TabIndex = 6;
            this.btn_Caclcular_caños_res.Text = "Calcular";
            this.btn_Caclcular_caños_res.UseVisualStyleBackColor = false;
            this.btn_Caclcular_caños_res.Click += new System.EventHandler(this.btn_Caclcular_caños_res_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(18, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "1/4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(18, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "1/2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(18, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "5/8";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(18, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "3/8";
            // 
            // txt_res_1_4
            // 
            this.txt_res_1_4.Location = new System.Drawing.Point(98, 113);
            this.txt_res_1_4.Name = "txt_res_1_4";
            this.txt_res_1_4.Size = new System.Drawing.Size(56, 23);
            this.txt_res_1_4.TabIndex = 15;
            // 
            // txt_res_1_2
            // 
            this.txt_res_1_2.Location = new System.Drawing.Point(98, 169);
            this.txt_res_1_2.Name = "txt_res_1_2";
            this.txt_res_1_2.Size = new System.Drawing.Size(56, 23);
            this.txt_res_1_2.TabIndex = 16;
            // 
            // txt_res_3_8
            // 
            this.txt_res_3_8.Location = new System.Drawing.Point(98, 219);
            this.txt_res_3_8.Name = "txt_res_3_8";
            this.txt_res_3_8.Size = new System.Drawing.Size(56, 23);
            this.txt_res_3_8.TabIndex = 17;
            // 
            // txt_res_5_8
            // 
            this.txt_res_5_8.Location = new System.Drawing.Point(98, 271);
            this.txt_res_5_8.Name = "txt_res_5_8";
            this.txt_res_5_8.Size = new System.Drawing.Size(56, 23);
            this.txt_res_5_8.TabIndex = 18;
            // 
            // txt_precio_kg
            // 
            this.txt_precio_kg.Location = new System.Drawing.Point(223, 136);
            this.txt_precio_kg.Name = "txt_precio_kg";
            this.txt_precio_kg.Size = new System.Drawing.Size(100, 23);
            this.txt_precio_kg.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(212, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Ingresar precio por KG";
            // 
            // btn_borrarTodo
            // 
            this.btn_borrarTodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_borrarTodo.BackColor = System.Drawing.SystemColors.Control;
            this.btn_borrarTodo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_borrarTodo.Location = new System.Drawing.Point(130, 210);
            this.btn_borrarTodo.Name = "btn_borrarTodo";
            this.btn_borrarTodo.Size = new System.Drawing.Size(75, 23);
            this.btn_borrarTodo.TabIndex = 21;
            this.btn_borrarTodo.Text = "Borrar";
            this.btn_borrarTodo.UseVisualStyleBackColor = false;
            this.btn_borrarTodo.Click += new System.EventHandler(this.btn_borrarTodo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(72, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Precio por metro:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_res_5_8);
            this.panel1.Controls.Add(this.txt_res_1_4);
            this.panel1.Controls.Add(this.txt_res_3_8);
            this.panel1.Controls.Add(this.txt_res_1_2);
            this.panel1.Location = new System.Drawing.Point(523, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 408);
            this.panel1.TabIndex = 23;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 544);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_borrarTodo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_precio_kg);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_Caclcular_caños_res);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Cerrar;
        private Button btn_Caclcular_caños_res;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox txt_res_1_4;
        private TextBox txt_res_1_2;
        private TextBox txt_res_3_8;
        private TextBox txt_res_5_8;
        private TextBox txt_precio_kg;
        private Label label6;
        private Button btn_borrarTodo;
        private Label label4;
        private Panel panel1;
    }
}