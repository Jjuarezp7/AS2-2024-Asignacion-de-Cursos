﻿
namespace AsignaciondeCursos
{
    partial class Boleta
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
            this.Lbl_generarb = new System.Windows.Forms.Label();
            this.Lbl_carnet = new System.Windows.Forms.Label();
            this.Txt_carnetCer1 = new System.Windows.Forms.TextBox();
            this.Txt_carnetCer2 = new System.Windows.Forms.TextBox();
            this.Txt_carnetCer3 = new System.Windows.Forms.TextBox();
            this.Lbl_semestre = new System.Windows.Forms.Label();
            this.Btn_generar = new System.Windows.Forms.Button();
            this.Btn_regresar = new System.Windows.Forms.Button();
            this.Cbo_semestre = new System.Windows.Forms.ComboBox();
            this.Cbo_anio = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Lbl_generarb
            // 
            this.Lbl_generarb.AutoSize = true;
            this.Lbl_generarb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_generarb.Location = new System.Drawing.Point(147, 9);
            this.Lbl_generarb.Name = "Lbl_generarb";
            this.Lbl_generarb.Size = new System.Drawing.Size(315, 24);
            this.Lbl_generarb.TabIndex = 0;
            this.Lbl_generarb.Text = "Generación de boleta de inscripción";
            // 
            // Lbl_carnet
            // 
            this.Lbl_carnet.AutoSize = true;
            this.Lbl_carnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_carnet.Location = new System.Drawing.Point(88, 53);
            this.Lbl_carnet.Name = "Lbl_carnet";
            this.Lbl_carnet.Size = new System.Drawing.Size(93, 16);
            this.Lbl_carnet.TabIndex = 1;
            this.Lbl_carnet.Text = "No. de Carnet:";
            // 
            // Txt_carnetCer1
            // 
            this.Txt_carnetCer1.Location = new System.Drawing.Point(91, 73);
            this.Txt_carnetCer1.Name = "Txt_carnetCer1";
            this.Txt_carnetCer1.Size = new System.Drawing.Size(100, 20);
            this.Txt_carnetCer1.TabIndex = 2;
            this.Txt_carnetCer1.TextChanged += new System.EventHandler(this.Txt_carnetCer1_TextChanged);
            // 
            // Txt_carnetCer2
            // 
            this.Txt_carnetCer2.Location = new System.Drawing.Point(237, 73);
            this.Txt_carnetCer2.Name = "Txt_carnetCer2";
            this.Txt_carnetCer2.Size = new System.Drawing.Size(100, 20);
            this.Txt_carnetCer2.TabIndex = 3;
            this.Txt_carnetCer2.TextChanged += new System.EventHandler(this.Txt_carnetCer2_TextChanged);
            // 
            // Txt_carnetCer3
            // 
            this.Txt_carnetCer3.Location = new System.Drawing.Point(383, 73);
            this.Txt_carnetCer3.Name = "Txt_carnetCer3";
            this.Txt_carnetCer3.Size = new System.Drawing.Size(100, 20);
            this.Txt_carnetCer3.TabIndex = 4;
            this.Txt_carnetCer3.TextChanged += new System.EventHandler(this.Txt_carnetCer3_TextChanged);
            // 
            // Lbl_semestre
            // 
            this.Lbl_semestre.AutoSize = true;
            this.Lbl_semestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_semestre.Location = new System.Drawing.Point(88, 123);
            this.Lbl_semestre.Name = "Lbl_semestre";
            this.Lbl_semestre.Size = new System.Drawing.Size(69, 16);
            this.Lbl_semestre.TabIndex = 5;
            this.Lbl_semestre.Text = "Semestre:";
            // 
            // Btn_generar
            // 
            this.Btn_generar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_generar.Location = new System.Drawing.Point(184, 209);
            this.Btn_generar.Name = "Btn_generar";
            this.Btn_generar.Size = new System.Drawing.Size(87, 35);
            this.Btn_generar.TabIndex = 7;
            this.Btn_generar.Text = "Generar";
            this.Btn_generar.UseVisualStyleBackColor = true;
            // 
            // Btn_regresar
            // 
            this.Btn_regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_regresar.Location = new System.Drawing.Point(321, 209);
            this.Btn_regresar.Name = "Btn_regresar";
            this.Btn_regresar.Size = new System.Drawing.Size(87, 35);
            this.Btn_regresar.TabIndex = 8;
            this.Btn_regresar.Text = "Regresar";
            this.Btn_regresar.UseVisualStyleBackColor = true;
            // 
            // Cbo_semestre
            // 
            this.Cbo_semestre.FormattingEnabled = true;
            this.Cbo_semestre.Items.AddRange(new object[] {
            "1",
            "2"});
            this.Cbo_semestre.Location = new System.Drawing.Point(91, 142);
            this.Cbo_semestre.Name = "Cbo_semestre";
            this.Cbo_semestre.Size = new System.Drawing.Size(121, 21);
            this.Cbo_semestre.TabIndex = 9;
            // 
            // Cbo_anio
            // 
            this.Cbo_anio.FormattingEnabled = true;
            this.Cbo_anio.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024"});
            this.Cbo_anio.Location = new System.Drawing.Point(251, 142);
            this.Cbo_anio.Name = "Cbo_anio";
            this.Cbo_anio.Size = new System.Drawing.Size(121, 21);
            this.Cbo_anio.TabIndex = 10;
            // 
            // Boleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 273);
            this.Controls.Add(this.Cbo_anio);
            this.Controls.Add(this.Cbo_semestre);
            this.Controls.Add(this.Btn_regresar);
            this.Controls.Add(this.Btn_generar);
            this.Controls.Add(this.Lbl_semestre);
            this.Controls.Add(this.Txt_carnetCer3);
            this.Controls.Add(this.Txt_carnetCer2);
            this.Controls.Add(this.Txt_carnetCer1);
            this.Controls.Add(this.Lbl_carnet);
            this.Controls.Add(this.Lbl_generarb);
            this.Name = "Boleta";
            this.Text = "Boleta de inscripción";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_generarb;
        private System.Windows.Forms.Label Lbl_carnet;
        private System.Windows.Forms.TextBox Txt_carnetCer1;
        private System.Windows.Forms.TextBox Txt_carnetCer2;
        private System.Windows.Forms.TextBox Txt_carnetCer3;
        private System.Windows.Forms.Label Lbl_semestre;
        private System.Windows.Forms.Button Btn_generar;
        private System.Windows.Forms.Button Btn_regresar;
        private System.Windows.Forms.ComboBox Cbo_semestre;
        private System.Windows.Forms.ComboBox Cbo_anio;
    }
}

