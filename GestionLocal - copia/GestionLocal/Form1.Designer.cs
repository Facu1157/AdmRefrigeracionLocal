namespace GestionLocal
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
            this.PanelLateral = new System.Windows.Forms.Panel();
            this.btn_gases = new System.Windows.Forms.Button();
            this.btn_precio_IVA = new System.Windows.Forms.Button();
            this.btn_caños = new System.Windows.Forms.Button();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.pnl_Contenedor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelLateral.SuspendLayout();
            this.pnl_Contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelLateral
            // 
            this.PanelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.PanelLateral.Controls.Add(this.btn_gases);
            this.PanelLateral.Controls.Add(this.btn_precio_IVA);
            this.PanelLateral.Controls.Add(this.btn_caños);
            this.PanelLateral.Controls.Add(this.PanelLogo);
            this.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLateral.Location = new System.Drawing.Point(0, 0);
            this.PanelLateral.Name = "PanelLateral";
            this.PanelLateral.Size = new System.Drawing.Size(250, 583);
            this.PanelLateral.TabIndex = 0;
            // 
            // btn_gases
            // 
            this.btn_gases.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_gases.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(114)))), ((int)(((byte)(123)))));
            this.btn_gases.FlatAppearance.BorderSize = 0;
            this.btn_gases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gases.Location = new System.Drawing.Point(0, 246);
            this.btn_gases.Name = "btn_gases";
            this.btn_gases.Size = new System.Drawing.Size(250, 45);
            this.btn_gases.TabIndex = 4;
            this.btn_gases.Text = "Gases ";
            this.btn_gases.UseVisualStyleBackColor = false;
            this.btn_gases.Click += new System.EventHandler(this.btn_gases_Click);
            // 
            // btn_precio_IVA
            // 
            this.btn_precio_IVA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(114)))), ((int)(((byte)(123)))));
            this.btn_precio_IVA.FlatAppearance.BorderSize = 0;
            this.btn_precio_IVA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_precio_IVA.Location = new System.Drawing.Point(0, 420);
            this.btn_precio_IVA.Name = "btn_precio_IVA";
            this.btn_precio_IVA.Size = new System.Drawing.Size(250, 45);
            this.btn_precio_IVA.TabIndex = 3;
            this.btn_precio_IVA.Text = "Calcular Precios Poductos";
            this.btn_precio_IVA.UseVisualStyleBackColor = false;
            this.btn_precio_IVA.Click += new System.EventHandler(this.btn_precio_IVA_Click);
            // 
            // btn_caños
            // 
            this.btn_caños.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(114)))), ((int)(((byte)(123)))));
            this.btn_caños.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_caños.FlatAppearance.BorderSize = 0;
            this.btn_caños.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_caños.Location = new System.Drawing.Point(0, 100);
            this.btn_caños.Name = "btn_caños";
            this.btn_caños.Size = new System.Drawing.Size(250, 45);
            this.btn_caños.TabIndex = 1;
            this.btn_caños.Text = "Calcular caños";
            this.btn_caños.UseVisualStyleBackColor = false;
            this.btn_caños.Click += new System.EventHandler(this.btn_caños_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(250, 100);
            this.PanelLogo.TabIndex = 0;
            // 
            // pnl_Contenedor
            // 
            this.pnl_Contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.pnl_Contenedor.Controls.Add(this.label1);
            this.pnl_Contenedor.Controls.Add(this.pictureBox1);
            this.pnl_Contenedor.Location = new System.Drawing.Point(250, 0);
            this.pnl_Contenedor.Name = "pnl_Contenedor";
            this.pnl_Contenedor.Size = new System.Drawing.Size(782, 583);
            this.pnl_Contenedor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(301, 547);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Refrigeración San Martin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::GestionLocal.Properties.Resources.snowflake;
            this.pictureBox1.Location = new System.Drawing.Point(124, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 583);
            this.Controls.Add(this.pnl_Contenedor);
            this.Controls.Add(this.PanelLateral);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Form1";
            this.Text = "Form1";
            this.PanelLateral.ResumeLayout(false);
            this.pnl_Contenedor.ResumeLayout(false);
            this.pnl_Contenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PanelLateral;
        private Button btn_caños;
        private Panel PanelLogo;
        private Button btn_precio_IVA;
        private Panel pnl_Contenedor;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btn_gases;
    }
}