using System;
using System.Drawing;
using System.Windows.Forms;

namespace projeto_avaliacao_cs
{
    partial class frmGalo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGalo));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblDificuldade = new System.Windows.Forms.Label();
            this.rbtFacil = new System.Windows.Forms.RadioButton();
            this.rbtNormal = new System.Windows.Forms.RadioButton();
            this.rbtDificil = new System.Windows.Forms.RadioButton();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Zorque", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(186, 46);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(251, 38);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Jogo do Galo";
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Zorque", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(496, 153);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(106, 60);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "Novo Jogo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Zorque", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(540, 480);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(106, 37);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblDificuldade
            // 
            this.lblDificuldade.AutoSize = true;
            this.lblDificuldade.Font = new System.Drawing.Font("Zorque", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDificuldade.Location = new System.Drawing.Point(490, 245);
            this.lblDificuldade.Name = "lblDificuldade";
            this.lblDificuldade.Size = new System.Drawing.Size(119, 19);
            this.lblDificuldade.TabIndex = 4;
            this.lblDificuldade.Text = "Dificuldade:";
            // 
            // rbtFacil
            // 
            this.rbtFacil.AutoSize = true;
            this.rbtFacil.Font = new System.Drawing.Font("Zorque", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtFacil.Location = new System.Drawing.Point(494, 267);
            this.rbtFacil.Name = "rbtFacil";
            this.rbtFacil.Size = new System.Drawing.Size(56, 17);
            this.rbtFacil.TabIndex = 5;
            this.rbtFacil.TabStop = true;
            this.rbtFacil.Text = "Fácil";
            this.rbtFacil.UseVisualStyleBackColor = true;
            // 
            // rbtNormal
            // 
            this.rbtNormal.AutoSize = true;
            this.rbtNormal.Font = new System.Drawing.Font("Zorque", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtNormal.Location = new System.Drawing.Point(494, 290);
            this.rbtNormal.Name = "rbtNormal";
            this.rbtNormal.Size = new System.Drawing.Size(71, 17);
            this.rbtNormal.TabIndex = 6;
            this.rbtNormal.TabStop = true;
            this.rbtNormal.Text = "Normal";
            this.rbtNormal.UseVisualStyleBackColor = true;
            // 
            // rbtDificil
            // 
            this.rbtDificil.AutoSize = true;
            this.rbtDificil.Font = new System.Drawing.Font("Zorque", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtDificil.Location = new System.Drawing.Point(494, 313);
            this.rbtDificil.Name = "rbtDificil";
            this.rbtDificil.Size = new System.Drawing.Size(62, 17);
            this.rbtDificil.TabIndex = 7;
            this.rbtDificil.TabStop = true;
            this.rbtDificil.Text = "Difícil";
            this.rbtDificil.UseVisualStyleBackColor = true;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Font = new System.Drawing.Font("Zorque", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.Location = new System.Drawing.Point(494, 364);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(113, 37);
            this.btnReiniciar.TabIndex = 8;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Zorque", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(585, 518);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(77, 13);
            this.lblMarca.TabIndex = 9;
            this.lblMarca.Text = "Rui Cunha ®";
            // 
            // frmGalo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(658, 529);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.rbtDificil);
            this.Controls.Add(this.rbtNormal);
            this.Controls.Add(this.rbtFacil);
            this.Controls.Add(this.lblDificuldade);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmGalo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo do Galo";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmGalo_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblDificuldade;
        private System.Windows.Forms.RadioButton rbtFacil;
        private System.Windows.Forms.RadioButton rbtNormal;
        private System.Windows.Forms.RadioButton rbtDificil;
        private System.Windows.Forms.Button btnReiniciar;
        private Label lblMarca;
    }
}