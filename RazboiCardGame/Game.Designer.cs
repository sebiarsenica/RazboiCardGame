namespace RazboiCardGame
{
    partial class Game
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
            this.Player1_pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Player1_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Player1_pictureBox
            // 
            this.Player1_pictureBox.Image = global::RazboiCardGame.Properties.Resources.trefla;
            this.Player1_pictureBox.Location = new System.Drawing.Point(167, 95);
            this.Player1_pictureBox.Name = "Player1_pictureBox";
            this.Player1_pictureBox.Size = new System.Drawing.Size(271, 357);
            this.Player1_pictureBox.TabIndex = 0;
            this.Player1_pictureBox.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 599);
            this.Controls.Add(this.Player1_pictureBox);
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Player1_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox Player1_pictureBox;
    }
}