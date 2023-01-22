namespace PedraPapelTesoura
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPedra = new System.Windows.Forms.Button();
            this.btnPapel = new System.Windows.Forms.Button();
            this.btnTesoura = new System.Windows.Forms.Button();
            this.picJogador = new System.Windows.Forms.PictureBox();
            this.picCpu = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPtJogador = new System.Windows.Forms.Label();
            this.lblPtCpu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picJogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCpu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPedra
            // 
            this.btnPedra.BackColor = System.Drawing.Color.PeachPuff;
            this.btnPedra.BackgroundImage = global::PedraPapelTesoura.Properties.Resources.PedraJ;
            this.btnPedra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPedra.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPedra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedra.Location = new System.Drawing.Point(21, 276);
            this.btnPedra.Name = "btnPedra";
            this.btnPedra.Size = new System.Drawing.Size(120, 120);
            this.btnPedra.TabIndex = 0;
            this.btnPedra.Tag = "0";
            this.btnPedra.UseVisualStyleBackColor = false;
            this.btnPedra.Click += new System.EventHandler(this.ClickJogada);
            // 
            // btnPapel
            // 
            this.btnPapel.BackColor = System.Drawing.Color.Cyan;
            this.btnPapel.BackgroundImage = global::PedraPapelTesoura.Properties.Resources.PapelJ;
            this.btnPapel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPapel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPapel.Location = new System.Drawing.Point(192, 276);
            this.btnPapel.Name = "btnPapel";
            this.btnPapel.Size = new System.Drawing.Size(120, 120);
            this.btnPapel.TabIndex = 1;
            this.btnPapel.Tag = "1";
            this.btnPapel.UseVisualStyleBackColor = false;
            this.btnPapel.Click += new System.EventHandler(this.ClickJogada);
            // 
            // btnTesoura
            // 
            this.btnTesoura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTesoura.BackgroundImage = global::PedraPapelTesoura.Properties.Resources.TesouraJ;
            this.btnTesoura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTesoura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTesoura.Location = new System.Drawing.Point(362, 276);
            this.btnTesoura.Name = "btnTesoura";
            this.btnTesoura.Size = new System.Drawing.Size(120, 120);
            this.btnTesoura.TabIndex = 2;
            this.btnTesoura.Tag = "2";
            this.btnTesoura.UseVisualStyleBackColor = false;
            this.btnTesoura.Click += new System.EventHandler(this.ClickJogada);
            // 
            // picJogador
            // 
            this.picJogador.BackColor = System.Drawing.Color.Plum;
            this.picJogador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picJogador.Location = new System.Drawing.Point(12, 68);
            this.picJogador.Name = "picJogador";
            this.picJogador.Size = new System.Drawing.Size(150, 150);
            this.picJogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picJogador.TabIndex = 3;
            this.picJogador.TabStop = false;
            // 
            // picCpu
            // 
            this.picCpu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.picCpu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCpu.Location = new System.Drawing.Point(341, 68);
            this.picCpu.Name = "picCpu";
            this.picCpu.Size = new System.Drawing.Size(150, 150);
            this.picCpu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCpu.TabIndex = 4;
            this.picCpu.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Jogador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Computador";
            // 
            // lblPtJogador
            // 
            this.lblPtJogador.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPtJogador.Location = new System.Drawing.Point(66, 236);
            this.lblPtJogador.Name = "lblPtJogador";
            this.lblPtJogador.Size = new System.Drawing.Size(40, 20);
            this.lblPtJogador.TabIndex = 7;
            this.lblPtJogador.Text = "0";
            this.lblPtJogador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPtCpu
            // 
            this.lblPtCpu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPtCpu.Location = new System.Drawing.Point(397, 236);
            this.lblPtCpu.Name = "lblPtCpu";
            this.lblPtCpu.Size = new System.Drawing.Size(40, 20);
            this.lblPtCpu.TabIndex = 8;
            this.lblPtCpu.Text = "0";
            this.lblPtCpu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(206, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 64);
            this.label3.TabIndex = 9;
            this.label3.Text = "X";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.PaleGreen;
            this.btnNovo.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNovo.Location = new System.Drawing.Point(176, 413);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(150, 34);
            this.btnNovo.TabIndex = 10;
            this.btnNovo.Text = "Novo Jogo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnFechar.Location = new System.Drawing.Point(424, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 11;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DeepPink;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(499, 65);
            this.label4.TabIndex = 12;
            this.label4.Text = "Pedra, papel e tesoura";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(499, 450);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPtCpu);
            this.Controls.Add(this.lblPtJogador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picCpu);
            this.Controls.Add(this.picJogador);
            this.Controls.Add(this.btnTesoura);
            this.Controls.Add(this.btnPapel);
            this.Controls.Add(this.btnPedra);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedra, papel e tesoura";
            ((System.ComponentModel.ISupportInitialize)(this.picJogador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCpu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnPedra;
        private Button btnPapel;
        private Button btnTesoura;
        private PictureBox picJogador;
        private PictureBox picCpu;
        private Label label1;
        private Label label2;
        private Label lblPtJogador;
        private Label lblPtCpu;
        private Label label3;
        private Button btnNovo;
        private Button btnFechar;
        private Label label4;
    }
}