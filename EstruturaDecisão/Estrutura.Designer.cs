﻿
namespace EstruturaDecisão
{
    partial class TelaEstrutura
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaEstrutura));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl01 = new System.Windows.Forms.Label();
            this.lbl02 = new System.Windows.Forms.Label();
            this.lbl03 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnDescobrir = new System.Windows.Forms.Button();
            this.nNum01 = new System.Windows.Forms.NumericUpDown();
            this.nNum02 = new System.Windows.Forms.NumericUpDown();
            this.nNum03 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nNum01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNum02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNum03)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Anton", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Qual é o maior valor?";
            // 
            // lbl01
            // 
            this.lbl01.AutoSize = true;
            this.lbl01.BackColor = System.Drawing.Color.Transparent;
            this.lbl01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl01.Location = new System.Drawing.Point(34, 107);
            this.lbl01.Name = "lbl01";
            this.lbl01.Size = new System.Drawing.Size(114, 25);
            this.lbl01.TabIndex = 1;
            this.lbl01.Text = "Número 01:";
            // 
            // lbl02
            // 
            this.lbl02.AutoSize = true;
            this.lbl02.BackColor = System.Drawing.Color.Transparent;
            this.lbl02.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl02.Location = new System.Drawing.Point(34, 149);
            this.lbl02.Name = "lbl02";
            this.lbl02.Size = new System.Drawing.Size(114, 25);
            this.lbl02.TabIndex = 2;
            this.lbl02.Text = "Número 02:";
            // 
            // lbl03
            // 
            this.lbl03.AutoSize = true;
            this.lbl03.BackColor = System.Drawing.Color.Transparent;
            this.lbl03.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl03.Location = new System.Drawing.Point(34, 189);
            this.lbl03.Name = "lbl03";
            this.lbl03.Size = new System.Drawing.Size(114, 25);
            this.lbl03.TabIndex = 3;
            this.lbl03.Text = "Número 03:";
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.AliceBlue;
            this.lblResultado.Location = new System.Drawing.Point(39, 268);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(417, 97);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDescobrir
            // 
            this.btnDescobrir.Location = new System.Drawing.Point(351, 226);
            this.btnDescobrir.Name = "btnDescobrir";
            this.btnDescobrir.Size = new System.Drawing.Size(105, 29);
            this.btnDescobrir.TabIndex = 5;
            this.btnDescobrir.Text = "Descobrir";
            this.btnDescobrir.UseVisualStyleBackColor = true;
            this.btnDescobrir.Click += new System.EventHandler(this.btnDescobrir_Click);
            // 
            // nNum01
            // 
            this.nNum01.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nNum01.Location = new System.Drawing.Point(156, 106);
            this.nNum01.Name = "nNum01";
            this.nNum01.Size = new System.Drawing.Size(175, 27);
            this.nNum01.TabIndex = 6;
            this.nNum01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nNum02
            // 
            this.nNum02.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nNum02.Location = new System.Drawing.Point(156, 148);
            this.nNum02.Name = "nNum02";
            this.nNum02.Size = new System.Drawing.Size(175, 27);
            this.nNum02.TabIndex = 7;
            this.nNum02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nNum03
            // 
            this.nNum03.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nNum03.Location = new System.Drawing.Point(156, 188);
            this.nNum03.Name = "nNum03";
            this.nNum03.Size = new System.Drawing.Size(175, 27);
            this.nNum03.TabIndex = 8;
            this.nNum03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TelaEstrutura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(486, 374);
            this.Controls.Add(this.nNum03);
            this.Controls.Add(this.nNum02);
            this.Controls.Add(this.nNum01);
            this.Controls.Add(this.btnDescobrir);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lbl03);
            this.Controls.Add(this.lbl02);
            this.Controls.Add(this.lbl01);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "TelaEstrutura";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estrutura de Decisão";
            ((System.ComponentModel.ISupportInitialize)(this.nNum01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNum02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNum03)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl01;
        private System.Windows.Forms.Label lbl02;
        private System.Windows.Forms.Label lbl03;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnDescobrir;
        private System.Windows.Forms.NumericUpDown nNum01;
        private System.Windows.Forms.NumericUpDown nNum02;
        private System.Windows.Forms.NumericUpDown nNum03;
    }
}

