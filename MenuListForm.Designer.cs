
namespace restauntPos
{
    partial class MenuListForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.burgerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chickenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.snackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bevarageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 27);
            this.listView1.Name = "listView1";
            this.listView1.OwnerDraw = true;
            this.listView1.Size = new System.Drawing.Size(800, 307);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.burgerToolStripMenuItem,
            this.chickenToolStripMenuItem,
            this.snackToolStripMenuItem,
            this.bevarageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // burgerToolStripMenuItem
            // 
            this.burgerToolStripMenuItem.Name = "burgerToolStripMenuItem";
            this.burgerToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.burgerToolStripMenuItem.Text = "burger";
            this.burgerToolStripMenuItem.Click += new System.EventHandler(this.burgerToolStripMenuItem_Click);
            // 
            // chickenToolStripMenuItem
            // 
            this.chickenToolStripMenuItem.Name = "chickenToolStripMenuItem";
            this.chickenToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.chickenToolStripMenuItem.Text = "chicken";
            this.chickenToolStripMenuItem.Click += new System.EventHandler(this.chickenToolStripMenuItem_Click);
            // 
            // snackToolStripMenuItem
            // 
            this.snackToolStripMenuItem.Name = "snackToolStripMenuItem";
            this.snackToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.snackToolStripMenuItem.Text = "side";
            this.snackToolStripMenuItem.Click += new System.EventHandler(this.snackToolStripMenuItem_Click);
            // 
            // bevarageToolStripMenuItem
            // 
            this.bevarageToolStripMenuItem.Name = "bevarageToolStripMenuItem";
            this.bevarageToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.bevarageToolStripMenuItem.Text = "bevarage";
            this.bevarageToolStripMenuItem.Click += new System.EventHandler(this.bevarageToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 373);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(401, 21);
            this.textBox1.TabIndex = 2;
            // 
            // MenuListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuListForm";
            this.Text = "MenuListForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem burgerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chickenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem snackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bevarageToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
    }
}