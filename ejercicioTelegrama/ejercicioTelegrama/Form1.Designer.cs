﻿namespace ejercicioTelegrama
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtTelegrama = new System.Windows.Forms.TextBox();
            this.radioOrdinario = new System.Windows.Forms.RadioButton();
            this.radioUrgente = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Coste:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Texto";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(544, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 117);
            this.button1.TabIndex = 9;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(130, 344);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(253, 31);
            this.txtPrecio.TabIndex = 8;
            // 
            // txtTelegrama
            // 
            this.txtTelegrama.Location = new System.Drawing.Point(57, 110);
            this.txtTelegrama.Name = "txtTelegrama";
            this.txtTelegrama.Size = new System.Drawing.Size(655, 31);
            this.txtTelegrama.TabIndex = 6;
            // 
            // radioOrdinario
            // 
            this.radioOrdinario.AutoSize = true;
            this.radioOrdinario.Location = new System.Drawing.Point(57, 259);
            this.radioOrdinario.Name = "radioOrdinario";
            this.radioOrdinario.Size = new System.Drawing.Size(131, 29);
            this.radioOrdinario.TabIndex = 12;
            this.radioOrdinario.TabStop = true;
            this.radioOrdinario.Text = "Ordinario";
            this.radioOrdinario.UseVisualStyleBackColor = true;
            // 
            // radioUrgente
            // 
            this.radioUrgente.AutoSize = true;
            this.radioUrgente.Location = new System.Drawing.Point(233, 259);
            this.radioUrgente.Name = "radioUrgente";
            this.radioUrgente.Size = new System.Drawing.Size(119, 29);
            this.radioUrgente.TabIndex = 13;
            this.radioUrgente.TabStop = true;
            this.radioUrgente.Text = "Urgente";
            this.radioUrgente.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioUrgente);
            this.Controls.Add(this.radioOrdinario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtTelegrama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtTelegrama;
        private System.Windows.Forms.RadioButton radioOrdinario;
        private System.Windows.Forms.RadioButton radioUrgente;
    }
}

