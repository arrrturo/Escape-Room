
namespace EscapeRoom
{
    partial class Form_Pergamino
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
            this.sala06_pbPapiro = new System.Windows.Forms.PictureBox();
            this.sala06_pbAtras = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sala06_pbPapiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sala06_pbAtras)).BeginInit();
            this.SuspendLayout();
            // 
            // sala06_pbPapiro
            // 
            this.sala06_pbPapiro.BackgroundImage = global::EscapeRoom.Properties.Resources.sala06_Papiro1;
            this.sala06_pbPapiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sala06_pbPapiro.Location = new System.Drawing.Point(16, 93);
            this.sala06_pbPapiro.Name = "sala06_pbPapiro";
            this.sala06_pbPapiro.Size = new System.Drawing.Size(300, 330);
            this.sala06_pbPapiro.TabIndex = 0;
            this.sala06_pbPapiro.TabStop = false;
            // 
            // sala06_pbAtras
            // 
            this.sala06_pbAtras.BackgroundImage = global::EscapeRoom.Properties.Resources.sala06_door_opened;
            this.sala06_pbAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sala06_pbAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sala06_pbAtras.Location = new System.Drawing.Point(262, 32);
            this.sala06_pbAtras.Name = "sala06_pbAtras";
            this.sala06_pbAtras.Size = new System.Drawing.Size(55, 55);
            this.sala06_pbAtras.TabIndex = 6;
            this.sala06_pbAtras.TabStop = false;
            this.sala06_pbAtras.Click += new System.EventHandler(this.pbAtras_Click);
            // 
            // Form_Pergamino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = global::EscapeRoom.Properties.Resources.sala06_cuadrobueno1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(334, 461);
            this.Controls.Add(this.sala06_pbAtras);
            this.Controls.Add(this.sala06_pbPapiro);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Pergamino";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Pergamino";
            this.Load += new System.EventHandler(this.Form_Pergamino_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sala06_pbPapiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sala06_pbAtras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox sala06_pbPapiro;
        private System.Windows.Forms.PictureBox sala06_pbAtras;
    }
}