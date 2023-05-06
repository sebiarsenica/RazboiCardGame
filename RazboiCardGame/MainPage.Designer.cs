namespace RazboiCardGame
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            panelMenu = new Panel();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            label3 = new Label();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMenu.BackgroundImage = (Image)resources.GetObject("panelMenu.BackgroundImage");
            panelMenu.BackgroundImageLayout = ImageLayout.None;
            panelMenu.Controls.Add(label3);
            panelMenu.Controls.Add(label2);
            panelMenu.Controls.Add(linkLabel1);
            panelMenu.Controls.Add(label1);
            panelMenu.Location = new Point(0, 23);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(1365, 608);
            panelMenu.TabIndex = 0;
            panelMenu.Paint += panelMenu_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("ArcadeClassic", 47.9999962F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(952, 184);
            label2.Name = "label2";
            label2.Size = new Size(237, 64);
            label2.TabIndex = 3;
            label2.Text = "REGULI\r\n";
            label2.Click += label2_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.White;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.BorderStyle = BorderStyle.FixedSingle;
            linkLabel1.Font = new Font("ArcadeClassic", 47.9999962F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.ForeColor = Color.Yellow;
            linkLabel1.LinkBehavior = LinkBehavior.AlwaysUnderline;
            linkLabel1.LinkColor = Color.Purple;
            linkLabel1.Location = new Point(48, 463);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(204, 66);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "START";
            linkLabel1.UseWaitCursor = true;
            linkLabel1.VisitedLinkColor = Color.White;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            linkLabel1.MouseLeave += linkLabel1_MouseLeave;
            linkLabel1.MouseHover += linkLabel1_MouseHover;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("ArcadeClassic", 92.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 136);
            label1.Name = "label1";
            label1.Size = new Size(460, 123);
            label1.TabIndex = 0;
            label1.Text = "Razboi";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("ArcadeClassic", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(944, 255);
            label3.Name = "label3";
            label3.Size = new Size(182, 48);
            label3.TabIndex = 4;
            label3.Text = "label3";
            // 
            // MainPage
            // 
            ClientSize = new Size(1365, 635);
            Controls.Add(panelMenu);
            MinimumSize = new Size(1365, 635);
            Name = "MainPage";
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion



        private Panel panelMenu;
        private Label label1;
        private LinkLabel linkLabel1;
        private Label label2;
        private Label label3;
    }
}