namespace Life
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.msToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.msToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.msToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.msToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.msToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.gameOfLife = new Life.GameOfLife();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.speedToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(99, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // speedToolStripMenuItem
            // 
            this.speedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msToolStripMenuItem,
            this.msToolStripMenuItem1,
            this.msToolStripMenuItem2,
            this.toolStripMenuItem2,
            this.msToolStripMenuItem3,
            this.msToolStripMenuItem4,
            this.msToolStripMenuItem5,
            this.msToolStripMenuItem6});
            this.speedToolStripMenuItem.Name = "speedToolStripMenuItem";
            this.speedToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.speedToolStripMenuItem.Text = "Speed";
            // 
            // msToolStripMenuItem
            // 
            this.msToolStripMenuItem.Name = "msToolStripMenuItem";
            this.msToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.msToolStripMenuItem.Text = "25ms";
            this.msToolStripMenuItem.Click += new System.EventHandler(this.msToolStripMenuItem_Click);
            // 
            // msToolStripMenuItem1
            // 
            this.msToolStripMenuItem1.Name = "msToolStripMenuItem1";
            this.msToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.msToolStripMenuItem1.Text = "50ms";
            this.msToolStripMenuItem1.Click += new System.EventHandler(this.msToolStripMenuItem1_Click);
            // 
            // msToolStripMenuItem2
            // 
            this.msToolStripMenuItem2.Name = "msToolStripMenuItem2";
            this.msToolStripMenuItem2.Size = new System.Drawing.Size(114, 22);
            this.msToolStripMenuItem2.Text = "100ms";
            this.msToolStripMenuItem2.Click += new System.EventHandler(this.msToolStripMenuItem2_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(114, 22);
            this.toolStripMenuItem2.Text = "250ms";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // msToolStripMenuItem3
            // 
            this.msToolStripMenuItem3.Name = "msToolStripMenuItem3";
            this.msToolStripMenuItem3.Size = new System.Drawing.Size(114, 22);
            this.msToolStripMenuItem3.Text = "500ms";
            this.msToolStripMenuItem3.Click += new System.EventHandler(this.msToolStripMenuItem3_Click);
            // 
            // msToolStripMenuItem4
            // 
            this.msToolStripMenuItem4.Name = "msToolStripMenuItem4";
            this.msToolStripMenuItem4.Size = new System.Drawing.Size(114, 22);
            this.msToolStripMenuItem4.Text = "750ms";
            this.msToolStripMenuItem4.Click += new System.EventHandler(this.msToolStripMenuItem4_Click);
            // 
            // msToolStripMenuItem5
            // 
            this.msToolStripMenuItem5.Name = "msToolStripMenuItem5";
            this.msToolStripMenuItem5.Size = new System.Drawing.Size(114, 22);
            this.msToolStripMenuItem5.Text = "1000ms";
            this.msToolStripMenuItem5.Click += new System.EventHandler(this.msToolStripMenuItem5_Click);
            // 
            // msToolStripMenuItem6
            // 
            this.msToolStripMenuItem6.Name = "msToolStripMenuItem6";
            this.msToolStripMenuItem6.Size = new System.Drawing.Size(114, 22);
            this.msToolStripMenuItem6.Text = "2500ms";
            this.msToolStripMenuItem6.Click += new System.EventHandler(this.msToolStripMenuItem6_Click);
            // 
            // gameOfLife
            // 
            this.gameOfLife.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameOfLife.GridSize = 15;
            this.gameOfLife.Interval = 500;
            this.gameOfLife.Location = new System.Drawing.Point(0, 24);
            this.gameOfLife.Name = "gameOfLife";
            this.gameOfLife.Running = false;
            this.gameOfLife.Size = new System.Drawing.Size(784, 510);
            this.gameOfLife.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 534);
            this.Controls.Add(this.gameOfLife);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Game of Life";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private GameOfLife gameOfLife;
        private System.Windows.Forms.ToolStripMenuItem speedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem msToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem msToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem msToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem msToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem msToolStripMenuItem6;
    }
}

