namespace ProyectoNuevoMatematica
{
    partial class juegoLaberinto
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picCheese = new System.Windows.Forms.PictureBox();
            this.picWalker = new System.Windows.Forms.PictureBox();
            this.picLaberynth = new System.Windows.Forms.PictureBox();
            this.picMouse = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheese)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWalker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLaberynth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMouse)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ProyectoNuevoMatematica.Properties.Resources.go_back256_248561;
            this.pictureBox1.Location = new System.Drawing.Point(832, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "SALIDA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(559, 716);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "LLEGADA";
            // 
            // picCheese
            // 
            this.picCheese.Image = global::ProyectoNuevoMatematica.Properties.Resources.Puerto;
            this.picCheese.Location = new System.Drawing.Point(848, 660);
            this.picCheese.Name = "picCheese";
            this.picCheese.Size = new System.Drawing.Size(75, 75);
            this.picCheese.TabIndex = 19;
            this.picCheese.TabStop = false;
            // 
            // picWalker
            // 
            this.picWalker.Image = global::ProyectoNuevoMatematica.Properties.Resources.Barco;
            this.picWalker.Location = new System.Drawing.Point(298, 38);
            this.picWalker.Name = "picWalker";
            this.picWalker.Size = new System.Drawing.Size(25, 25);
            this.picWalker.TabIndex = 18;
            this.picWalker.TabStop = false;
            // 
            // picLaberynth
            // 
            this.picLaberynth.Image = global::ProyectoNuevoMatematica.Properties.Resources.Laberinto;
            this.picLaberynth.Location = new System.Drawing.Point(98, 13);
            this.picLaberynth.Name = "picLaberynth";
            this.picLaberynth.Size = new System.Drawing.Size(728, 722);
            this.picLaberynth.TabIndex = 17;
            this.picLaberynth.TabStop = false;
            // 
            // picMouse
            // 
            this.picMouse.Image = global::ProyectoNuevoMatematica.Properties.Resources.Faro;
            this.picMouse.Location = new System.Drawing.Point(12, 13);
            this.picMouse.Name = "picMouse";
            this.picMouse.Size = new System.Drawing.Size(75, 105);
            this.picMouse.TabIndex = 16;
            this.picMouse.TabStop = false;
            // 
            // juegoLaberinto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoNuevoMatematica.Properties.Resources.game_background_design_by_dizcreator_d56kuxn;
            this.ClientSize = new System.Drawing.Size(935, 749);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picCheese);
            this.Controls.Add(this.picWalker);
            this.Controls.Add(this.picLaberynth);
            this.Controls.Add(this.picMouse);
            this.Controls.Add(this.pictureBox1);
            this.Name = "juegoLaberinto";
            this.Text = "Laberinto";
            this.Load += new System.EventHandler(this.juegoLaberinto_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.juegoLaberinto_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheese)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWalker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLaberynth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picCheese;
        private System.Windows.Forms.PictureBox picWalker;
        private System.Windows.Forms.PictureBox picLaberynth;
        private System.Windows.Forms.PictureBox picMouse;
    }
}