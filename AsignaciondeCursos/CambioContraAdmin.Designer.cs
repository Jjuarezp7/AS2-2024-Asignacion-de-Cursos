﻿
namespace AsignaciondeCursos
{
    partial class CambioContraAdmin
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
            this.Txt_correo = new System.Windows.Forms.TextBox();
            this.Lbl_correo = new System.Windows.Forms.Label();
            this.Lbl_loginadmin = new System.Windows.Forms.Label();
            this.Txt_confirmarcontra = new System.Windows.Forms.TextBox();
            this.Lbl_confirmarcontra = new System.Windows.Forms.Label();
            this.Txt_contra = new System.Windows.Forms.TextBox();
            this.Lbl_contraseña = new System.Windows.Forms.Label();
            this.Btn_cambiocontra = new System.Windows.Forms.Button();
            this.Btn_regresar = new System.Windows.Forms.Button();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_correo
            // 
            this.Txt_correo.Location = new System.Drawing.Point(171, 58);
            this.Txt_correo.Name = "Txt_correo";
            this.Txt_correo.Size = new System.Drawing.Size(310, 20);
            this.Txt_correo.TabIndex = 5;
            // 
            // Lbl_correo
            // 
            this.Lbl_correo.AutoSize = true;
            this.Lbl_correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_correo.Location = new System.Drawing.Point(113, 59);
            this.Lbl_correo.Name = "Lbl_correo";
            this.Lbl_correo.Size = new System.Drawing.Size(52, 16);
            this.Lbl_correo.TabIndex = 4;
            this.Lbl_correo.Text = "Correo:";
            // 
            // Lbl_loginadmin
            // 
            this.Lbl_loginadmin.AutoSize = true;
            this.Lbl_loginadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_loginadmin.Location = new System.Drawing.Point(45, 9);
            this.Lbl_loginadmin.Name = "Lbl_loginadmin";
            this.Lbl_loginadmin.Size = new System.Drawing.Size(519, 24);
            this.Lbl_loginadmin.TabIndex = 3;
            this.Lbl_loginadmin.Text = "Cambio de contraseña de personal administrativo/catedrático";
            // 
            // Txt_confirmarcontra
            // 
            this.Txt_confirmarcontra.Location = new System.Drawing.Point(171, 136);
            this.Txt_confirmarcontra.Name = "Txt_confirmarcontra";
            this.Txt_confirmarcontra.Size = new System.Drawing.Size(310, 20);
            this.Txt_confirmarcontra.TabIndex = 19;
            this.Txt_confirmarcontra.Visible = false;
            // 
            // Lbl_confirmarcontra
            // 
            this.Lbl_confirmarcontra.AutoSize = true;
            this.Lbl_confirmarcontra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_confirmarcontra.Location = new System.Drawing.Point(27, 137);
            this.Lbl_confirmarcontra.Name = "Lbl_confirmarcontra";
            this.Lbl_confirmarcontra.Size = new System.Drawing.Size(138, 16);
            this.Lbl_confirmarcontra.TabIndex = 20;
            this.Lbl_confirmarcontra.Text = "Confirmar contraseña:";
            this.Lbl_confirmarcontra.Visible = false;
            // 
            // Txt_contra
            // 
            this.Txt_contra.Location = new System.Drawing.Point(171, 96);
            this.Txt_contra.Name = "Txt_contra";
            this.Txt_contra.Size = new System.Drawing.Size(310, 20);
            this.Txt_contra.TabIndex = 18;
            this.Txt_contra.Visible = false;
            // 
            // Lbl_contraseña
            // 
            this.Lbl_contraseña.AutoSize = true;
            this.Lbl_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_contraseña.Location = new System.Drawing.Point(88, 97);
            this.Lbl_contraseña.Name = "Lbl_contraseña";
            this.Lbl_contraseña.Size = new System.Drawing.Size(80, 16);
            this.Lbl_contraseña.TabIndex = 17;
            this.Lbl_contraseña.Text = "Contraseña:";
            this.Lbl_contraseña.Visible = false;
            // 
            // Btn_cambiocontra
            // 
            this.Btn_cambiocontra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cambiocontra.Location = new System.Drawing.Point(269, 179);
            this.Btn_cambiocontra.Name = "Btn_cambiocontra";
            this.Btn_cambiocontra.Size = new System.Drawing.Size(108, 50);
            this.Btn_cambiocontra.TabIndex = 21;
            this.Btn_cambiocontra.Text = "Cambiar contraseña";
            this.Btn_cambiocontra.UseVisualStyleBackColor = true;
            this.Btn_cambiocontra.Visible = false;
            this.Btn_cambiocontra.Click += new System.EventHandler(this.Btn_cambiocontra_Click);
            // 
            // Btn_regresar
            // 
            this.Btn_regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_regresar.Location = new System.Drawing.Point(12, 189);
            this.Btn_regresar.Name = "Btn_regresar";
            this.Btn_regresar.Size = new System.Drawing.Size(85, 31);
            this.Btn_regresar.TabIndex = 22;
            this.Btn_regresar.Text = "Regresar";
            this.Btn_regresar.UseVisualStyleBackColor = true;
            this.Btn_regresar.Click += new System.EventHandler(this.Btn_regresar_Click);
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_buscar.Location = new System.Drawing.Point(505, 51);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(85, 31);
            this.Btn_buscar.TabIndex = 23;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.UseVisualStyleBackColor = true;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // CambioContraAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(606, 246);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.Btn_regresar);
            this.Controls.Add(this.Btn_cambiocontra);
            this.Controls.Add(this.Txt_confirmarcontra);
            this.Controls.Add(this.Lbl_confirmarcontra);
            this.Controls.Add(this.Txt_contra);
            this.Controls.Add(this.Lbl_contraseña);
            this.Controls.Add(this.Txt_correo);
            this.Controls.Add(this.Lbl_correo);
            this.Controls.Add(this.Lbl_loginadmin);
            this.Name = "CambioContraAdmin";
            this.Text = "Cambio de contraseña de personal administrativo/catedrático";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_correo;
        private System.Windows.Forms.Label Lbl_correo;
        private System.Windows.Forms.Label Lbl_loginadmin;
        private System.Windows.Forms.TextBox Txt_confirmarcontra;
        private System.Windows.Forms.Label Lbl_confirmarcontra;
        private System.Windows.Forms.TextBox Txt_contra;
        private System.Windows.Forms.Label Lbl_contraseña;
        private System.Windows.Forms.Button Btn_cambiocontra;
        private System.Windows.Forms.Button Btn_regresar;
        private System.Windows.Forms.Button Btn_buscar;
    }
}