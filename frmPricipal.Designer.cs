namespace projeto_avaliacao_cs
{
    partial class frmPricipal
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.btnSnake = new System.Windows.Forms.Button();
            this.btnGalo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Zorque", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(231, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(329, 42);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Escolha o jogo:";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Zorque", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(696, 405);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(92, 33);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Zorque", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(12, 405);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(92, 33);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Zorque", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(727, 439);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(77, 13);
            this.lblMarca.TabIndex = 8;
            this.lblMarca.Text = "Rui Cunha ®";
            // 
            // btnSnake
            // 
            this.btnSnake.BackgroundImage = global::projeto_avaliacao_cs.Properties.Resources.kisspng_cute_snake_pixel_art_bead_pixel_art_5ac28736c013b3_2279507415226980387868;
            this.btnSnake.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSnake.Font = new System.Drawing.Font("Zorque", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSnake.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnSnake.Location = new System.Drawing.Point(247, 132);
            this.btnSnake.Name = "btnSnake";
            this.btnSnake.Size = new System.Drawing.Size(135, 155);
            this.btnSnake.TabIndex = 9;
            this.btnSnake.Text = "Snake";
            this.btnSnake.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSnake.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnSnake.UseVisualStyleBackColor = true;
            this.btnSnake.Click += new System.EventHandler(this.btnSnake_Click);
            // 
            // btnGalo
            // 
            this.btnGalo.BackgroundImage = global::projeto_avaliacao_cs.Properties.Resources.Jogo_velha_educamais;
            this.btnGalo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGalo.Font = new System.Drawing.Font("Zorque", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGalo.Location = new System.Drawing.Point(58, 132);
            this.btnGalo.Name = "btnGalo";
            this.btnGalo.Size = new System.Drawing.Size(135, 155);
            this.btnGalo.TabIndex = 1;
            this.btnGalo.Text = "Jogo do Galo";
            this.btnGalo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGalo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGalo.UseVisualStyleBackColor = true;
            this.btnGalo.Click += new System.EventHandler(this.btnGalo_Click);
            // 
            // frmPricipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSnake);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGalo);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmPricipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmPricipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnGalo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Button btnSnake;
    }
}