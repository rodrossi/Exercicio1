﻿namespace WindowsFormsApp1
{
    partial class FormExercicio3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSalarioAtual = new System.Windows.Forms.TextBox();
            this.txtReajuste = new System.Windows.Forms.TextBox();
            this.btnCalculo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salario Atual";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(43, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "%Reajuste";
            // 
            // txtSalarioAtual
            // 
            this.txtSalarioAtual.Location = new System.Drawing.Point(143, 25);
            this.txtSalarioAtual.Name = "txtSalarioAtual";
            this.txtSalarioAtual.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioAtual.TabIndex = 1;
            // 
            // txtReajuste
            // 
            this.txtReajuste.Location = new System.Drawing.Point(143, 69);
            this.txtReajuste.Name = "txtReajuste";
            this.txtReajuste.Size = new System.Drawing.Size(100, 20);
            this.txtReajuste.TabIndex = 2;
            // 
            // btnCalculo
            // 
            this.btnCalculo.Location = new System.Drawing.Point(154, 122);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(75, 23);
            this.btnCalculo.TabIndex = 3;
            this.btnCalculo.Text = "Calcular";
            this.btnCalculo.UseVisualStyleBackColor = true;
            this.btnCalculo.Click += new System.EventHandler(this.BtnCalculo_Click);
            // 
            // FormExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 257);
            this.Controls.Add(this.btnCalculo);
            this.Controls.Add(this.txtReajuste);
            this.Controls.Add(this.txtSalarioAtual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormExercicio3";
            this.Text = "FormExercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSalarioAtual;
        private System.Windows.Forms.TextBox txtReajuste;
        private System.Windows.Forms.Button btnCalculo;
    }
}