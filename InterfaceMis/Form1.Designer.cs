namespace InterfaceMis
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnPorta2 = new System.Windows.Forms.Button();
            this.btnPorta1 = new System.Windows.Forms.Button();
            this.btnMix = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Misturador Agrícola";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnPorta2
            // 
            this.btnPorta2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnPorta2.FlatAppearance.BorderSize = 0;
            this.btnPorta2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPorta2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorta2.Location = new System.Drawing.Point(565, 301);
            this.btnPorta2.Name = "btnPorta2";
            this.btnPorta2.Size = new System.Drawing.Size(170, 50);
            this.btnPorta2.TabIndex = 3;
            this.btnPorta2.Text = "Porta 2";
            this.btnPorta2.UseVisualStyleBackColor = false;
            this.btnPorta2.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPorta1
            // 
            this.btnPorta1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnPorta1.FlatAppearance.BorderSize = 0;
            this.btnPorta1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPorta1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorta1.Location = new System.Drawing.Point(267, 301);
            this.btnPorta1.Name = "btnPorta1";
            this.btnPorta1.Size = new System.Drawing.Size(170, 50);
            this.btnPorta1.TabIndex = 2;
            this.btnPorta1.Text = "Porta 1";
            this.btnPorta1.UseVisualStyleBackColor = false;
            this.btnPorta1.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMix
            // 
            this.btnMix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnMix.FlatAppearance.BorderSize = 0;
            this.btnMix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMix.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMix.Location = new System.Drawing.Point(416, 392);
            this.btnMix.Name = "btnMix";
            this.btnMix.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMix.Size = new System.Drawing.Size(170, 50);
            this.btnMix.TabIndex = 1;
            this.btnMix.Text = "Misturar";
            this.btnMix.UseCompatibleTextRendering = true;
            this.btnMix.UseVisualStyleBackColor = false;
            this.btnMix.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::InterfaceMis.Properties.Resources.Nome_da_Empresa__2_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 600);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPorta2);
            this.Controls.Add(this.btnPorta1);
            this.Controls.Add(this.btnMix);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMix;
        private System.Windows.Forms.Button btnPorta1;
        private System.Windows.Forms.Button btnPorta2;
        private System.Windows.Forms.Label label1;
    }
}

