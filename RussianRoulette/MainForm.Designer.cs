namespace RussianRoulette
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PtsBox = new System.Windows.Forms.TextBox();
            this.PtsLbl = new System.Windows.Forms.Label();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.Chances = new System.Windows.Forms.Label();
            this.ChanceBox = new System.Windows.Forms.TextBox();
            this.SpinChmberBtn = new System.Windows.Forms.Button();
            this.StrtGameBtn = new System.Windows.Forms.Button();
            this.PlayAginBtn = new System.Windows.Forms.Button();
            this.ChmberBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ShootMeBtn = new System.Windows.Forms.Button();
            this.ShootAwyBtn = new System.Windows.Forms.Button();
            this.BulletLoc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PtsBox
            // 
            this.PtsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.PtsBox.Location = new System.Drawing.Point(722, 36);
            this.PtsBox.Name = "PtsBox";
            this.PtsBox.ReadOnly = true;
            this.PtsBox.Size = new System.Drawing.Size(100, 27);
            this.PtsBox.TabIndex = 0;
            this.PtsBox.Text = "0";
            // 
            // PtsLbl
            // 
            this.PtsLbl.AutoSize = true;
            this.PtsLbl.BackColor = System.Drawing.SystemColors.Control;
            this.PtsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.PtsLbl.Location = new System.Drawing.Point(722, 13);
            this.PtsLbl.Name = "PtsLbl";
            this.PtsLbl.Size = new System.Drawing.Size(100, 20);
            this.PtsLbl.TabIndex = 1;
            this.PtsLbl.Text = "Your Points:";
            // 
            // ResultBox
            // 
            this.ResultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.ResultBox.Location = new System.Drawing.Point(12, 530);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.ReadOnly = true;
            this.ResultBox.Size = new System.Drawing.Size(855, 41);
            this.ResultBox.TabIndex = 6;
            this.ResultBox.Text = "To Begin The Game Load The Bullet";
            this.ResultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Chances
            // 
            this.Chances.AutoSize = true;
            this.Chances.BackColor = System.Drawing.SystemColors.Control;
            this.Chances.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chances.Location = new System.Drawing.Point(722, 79);
            this.Chances.Name = "Chances";
            this.Chances.Size = new System.Drawing.Size(114, 20);
            this.Chances.TabIndex = 7;
            this.Chances.Text = "Chances Left:";
            // 
            // ChanceBox
            // 
            this.ChanceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.ChanceBox.Location = new System.Drawing.Point(722, 102);
            this.ChanceBox.Name = "ChanceBox";
            this.ChanceBox.ReadOnly = true;
            this.ChanceBox.Size = new System.Drawing.Size(114, 27);
            this.ChanceBox.TabIndex = 8;
            this.ChanceBox.Text = "2";
            // 
            // SpinChmberBtn
            // 
            this.SpinChmberBtn.BackColor = System.Drawing.SystemColors.Control;
            this.SpinChmberBtn.Enabled = false;
            this.SpinChmberBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpinChmberBtn.Location = new System.Drawing.Point(12, 104);
            this.SpinChmberBtn.Name = "SpinChmberBtn";
            this.SpinChmberBtn.Size = new System.Drawing.Size(145, 76);
            this.SpinChmberBtn.TabIndex = 9;
            this.SpinChmberBtn.Text = "Spin Chambers";
            this.SpinChmberBtn.UseVisualStyleBackColor = false;
            this.SpinChmberBtn.Click += new System.EventHandler(this.SpinChmberBtn_Click);
            // 
            // StrtGameBtn
            // 
            this.StrtGameBtn.BackColor = System.Drawing.SystemColors.Control;
            this.StrtGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrtGameBtn.Location = new System.Drawing.Point(12, 13);
            this.StrtGameBtn.Name = "StrtGameBtn";
            this.StrtGameBtn.Size = new System.Drawing.Size(145, 77);
            this.StrtGameBtn.TabIndex = 10;
            this.StrtGameBtn.Text = "Load The Gun";
            this.StrtGameBtn.UseVisualStyleBackColor = false;
            this.StrtGameBtn.Click += new System.EventHandler(this.StrtGameBtn_Click);
            // 
            // PlayAginBtn
            // 
            this.PlayAginBtn.BackColor = System.Drawing.SystemColors.Control;
            this.PlayAginBtn.Enabled = false;
            this.PlayAginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayAginBtn.Location = new System.Drawing.Point(12, 447);
            this.PlayAginBtn.Name = "PlayAginBtn";
            this.PlayAginBtn.Size = new System.Drawing.Size(145, 77);
            this.PlayAginBtn.TabIndex = 11;
            this.PlayAginBtn.Text = "Play Again";
            this.PlayAginBtn.UseVisualStyleBackColor = false;
            this.PlayAginBtn.Click += new System.EventHandler(this.PlayAginBtn_Click);
            // 
            // ChmberBox
            // 
            this.ChmberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.ChmberBox.Location = new System.Drawing.Point(722, 168);
            this.ChmberBox.Name = "ChmberBox";
            this.ChmberBox.ReadOnly = true;
            this.ChmberBox.Size = new System.Drawing.Size(125, 27);
            this.ChmberBox.TabIndex = 16;
            this.ChmberBox.Text = "6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(722, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Chambers Left:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RussianRoulette.Resources.GunChmbers;
            this.pictureBox1.Location = new System.Drawing.Point(163, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(553, 521);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // ShootMeBtn
            // 
            this.ShootMeBtn.BackColor = System.Drawing.SystemColors.Control;
            this.ShootMeBtn.BackgroundImage = global::RussianRoulette.Resources.Blood;
            this.ShootMeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ShootMeBtn.Enabled = false;
            this.ShootMeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShootMeBtn.Location = new System.Drawing.Point(722, 335);
            this.ShootMeBtn.Name = "ShootMeBtn";
            this.ShootMeBtn.Size = new System.Drawing.Size(145, 87);
            this.ShootMeBtn.TabIndex = 3;
            this.ShootMeBtn.Text = "Shoot Your Self";
            this.ShootMeBtn.UseVisualStyleBackColor = false;
            this.ShootMeBtn.Click += new System.EventHandler(this.ShootMeBtn_Click);
            // 
            // ShootAwyBtn
            // 
            this.ShootAwyBtn.BackColor = System.Drawing.SystemColors.Control;
            this.ShootAwyBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShootAwyBtn.BackgroundImage")));
            this.ShootAwyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShootAwyBtn.Enabled = false;
            this.ShootAwyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.ShootAwyBtn.Location = new System.Drawing.Point(722, 437);
            this.ShootAwyBtn.Name = "ShootAwyBtn";
            this.ShootAwyBtn.Size = new System.Drawing.Size(145, 87);
            this.ShootAwyBtn.TabIndex = 2;
            this.ShootAwyBtn.Text = "Shoot Away";
            this.ShootAwyBtn.UseVisualStyleBackColor = false;
            this.ShootAwyBtn.Click += new System.EventHandler(this.ShootAwyBtn_Click);
            // 
            // BulletLoc
            // 
            this.BulletLoc.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BulletLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.BulletLoc.ForeColor = System.Drawing.SystemColors.Control;
            this.BulletLoc.Location = new System.Drawing.Point(62, 186);
            this.BulletLoc.Name = "BulletLoc";
            this.BulletLoc.ReadOnly = true;
            this.BulletLoc.Size = new System.Drawing.Size(33, 27);
            this.BulletLoc.TabIndex = 17;
            this.BulletLoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BulletLoc.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(879, 583);
            this.Controls.Add(this.BulletLoc);
            this.Controls.Add(this.ChmberBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PlayAginBtn);
            this.Controls.Add(this.StrtGameBtn);
            this.Controls.Add(this.SpinChmberBtn);
            this.Controls.Add(this.ChanceBox);
            this.Controls.Add(this.Chances);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.ShootMeBtn);
            this.Controls.Add(this.ShootAwyBtn);
            this.Controls.Add(this.PtsLbl);
            this.Controls.Add(this.PtsBox);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Russian Roulette";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PtsBox;
        private System.Windows.Forms.Label PtsLbl;
        private System.Windows.Forms.Button ShootAwyBtn;
        private System.Windows.Forms.Button ShootMeBtn;
        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.Label Chances;
        private System.Windows.Forms.TextBox ChanceBox;
        private System.Windows.Forms.Button SpinChmberBtn;
        private System.Windows.Forms.Button StrtGameBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button PlayAginBtn;
        private System.Windows.Forms.TextBox ChmberBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BulletLoc;
    }
}

