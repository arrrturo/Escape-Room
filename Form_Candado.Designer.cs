
namespace EscapeRoom
{
    partial class Form_Candado
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
            this.sala06_numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.sala06_pbAtras = new System.Windows.Forms.PictureBox();
            this.sala06_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sala06_pbSolucionado = new System.Windows.Forms.PictureBox();
            this.sala06_pbFail = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sala06_numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sala06_pbAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sala06_pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sala06_pbSolucionado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sala06_pbFail)).BeginInit();
            this.SuspendLayout();
            // 
            // sala06_numericUpDown3
            // 
            this.sala06_numericUpDown3.Location = new System.Drawing.Point(279, 351);
            this.sala06_numericUpDown3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.sala06_numericUpDown3.Name = "sala06_numericUpDown3";
            this.sala06_numericUpDown3.Size = new System.Drawing.Size(70, 20);
            this.sala06_numericUpDown3.TabIndex = 11;
            this.sala06_numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // sala06_pbAtras
            // 
            this.sala06_pbAtras.BackgroundImage = global::EscapeRoom.Properties.Resources.sala06_door_opened;
            this.sala06_pbAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sala06_pbAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sala06_pbAtras.Location = new System.Drawing.Point(46, 340);
            this.sala06_pbAtras.Name = "sala06_pbAtras";
            this.sala06_pbAtras.Size = new System.Drawing.Size(55, 55);
            this.sala06_pbAtras.TabIndex = 8;
            this.sala06_pbAtras.TabStop = false;
            this.sala06_pbAtras.Click += new System.EventHandler(this.pbAtras_Click);
            // 
            // sala06_pictureBox1
            // 
            this.sala06_pictureBox1.BackgroundImage = global::EscapeRoom.Properties.Resources.sala06_Candado;
            this.sala06_pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sala06_pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sala06_pictureBox1.Location = new System.Drawing.Point(47, 43);
            this.sala06_pictureBox1.Name = "sala06_pictureBox1";
            this.sala06_pictureBox1.Size = new System.Drawing.Size(540, 289);
            this.sala06_pictureBox1.TabIndex = 0;
            this.sala06_pictureBox1.TabStop = false;
            this.sala06_pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // sala06_pbSolucionado
            // 
            this.sala06_pbSolucionado.BackgroundImage = global::EscapeRoom.Properties.Resources.sala06_solucionado;
            this.sala06_pbSolucionado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sala06_pbSolucionado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sala06_pbSolucionado.Location = new System.Drawing.Point(64, 59);
            this.sala06_pbSolucionado.Name = "sala06_pbSolucionado";
            this.sala06_pbSolucionado.Size = new System.Drawing.Size(500, 322);
            this.sala06_pbSolucionado.TabIndex = 12;
            this.sala06_pbSolucionado.TabStop = false;
            this.sala06_pbSolucionado.Click += new System.EventHandler(this.pbSolucionado_Click);
            // 
            // sala06_pbFail
            // 
            this.sala06_pbFail.BackgroundImage = global::EscapeRoom.Properties.Resources.sala06_fail;
            this.sala06_pbFail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sala06_pbFail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sala06_pbFail.Location = new System.Drawing.Point(73, 67);
            this.sala06_pbFail.Name = "sala06_pbFail";
            this.sala06_pbFail.Size = new System.Drawing.Size(485, 291);
            this.sala06_pbFail.TabIndex = 13;
            this.sala06_pbFail.TabStop = false;
            this.sala06_pbFail.Click += new System.EventHandler(this.pbFail_Click);
            // 
            // Form_Candado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = global::EscapeRoom.Properties.Resources.sala06_cuadrobueno1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(633, 435);
            this.Controls.Add(this.sala06_numericUpDown3);
            this.Controls.Add(this.sala06_pbAtras);
            this.Controls.Add(this.sala06_pictureBox1);
            this.Controls.Add(this.sala06_pbSolucionado);
            this.Controls.Add(this.sala06_pbFail);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Candado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Candado";
            this.Load += new System.EventHandler(this.Form_Candado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sala06_numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sala06_pbAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sala06_pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sala06_pbSolucionado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sala06_pbFail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox sala06_pictureBox1;
        private System.Windows.Forms.PictureBox sala06_pbAtras;
        private System.Windows.Forms.NumericUpDown sala06_numericUpDown3;
        private System.Windows.Forms.PictureBox sala06_pbSolucionado;
        private System.Windows.Forms.PictureBox sala06_pbFail;
    }
}