namespace MenuApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlSide = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.menuUserControl1 = new MenuApp.MenuUserControl();
            this.homeUserControl1 = new MenuApp.HomeUserControl();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlLeft.Controls.Add(this.btnExit);
            this.pnlLeft.Controls.Add(this.btnHome);
            this.pnlLeft.Controls.Add(this.pnlSide);
            this.pnlLeft.Controls.Add(this.btnMenu);
            this.pnlLeft.Controls.Add(this.pictureBox1);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(200, 450);
            this.pnlLeft.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Yellow;
            this.btnExit.Font = new System.Drawing.Font("Goudy Stout", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(0, 410);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(43, 40);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Location = new System.Drawing.Point(63, 151);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(137, 52);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlSide
            // 
            this.pnlSide.BackColor = System.Drawing.Color.Yellow;
            this.pnlSide.Location = new System.Drawing.Point(51, 151);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(12, 52);
            this.pnlSide.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.Black;
            this.btnMenu.Location = new System.Drawing.Point(63, 209);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(137, 52);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.DarkGray;
            this.pnlMain.Controls.Add(this.menuUserControl1);
            this.pnlMain.Controls.Add(this.homeUserControl1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(200, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(348, 450);
            this.pnlMain.TabIndex = 1;
            // 
            // menuUserControl1
            // 
            this.menuUserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menuUserControl1.Location = new System.Drawing.Point(0, 0);
            this.menuUserControl1.Name = "menuUserControl1";
            this.menuUserControl1.Size = new System.Drawing.Size(348, 450);
            this.menuUserControl1.TabIndex = 1;
            // 
            // homeUserControl1
            // 
            this.homeUserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.homeUserControl1.Location = new System.Drawing.Point(0, 0);
            this.homeUserControl1.Name = "homeUserControl1";
            this.homeUserControl1.Size = new System.Drawing.Size(348, 450);
            this.homeUserControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 450);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.Button btnMenu;
        private MenuUserControl menuUserControl1;
        private HomeUserControl homeUserControl1;
        private System.Windows.Forms.Button btnExit;
    }
}

