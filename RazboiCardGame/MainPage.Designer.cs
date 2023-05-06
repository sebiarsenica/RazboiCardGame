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
            panelMenu = new Panel();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMenu.Location = new Point(0, 23);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(1365, 608);
            panelMenu.TabIndex = 0;
            // 
            // MainPage
            // 
            ClientSize = new Size(1365, 635);
            Controls.Add(panelMenu);
            MinimumSize = new Size(1365, 635);
            Name = "MainPage";
            ResumeLayout(false);
        }

        #endregion



        private Panel panelMenu;
    }
}