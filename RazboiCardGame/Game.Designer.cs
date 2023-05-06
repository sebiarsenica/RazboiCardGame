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
            Player1_pictureBox = new PictureBox();
            Player2_pictureBox = new PictureBox();
            Player1_BottomLabel = new Label();
            Player1_UpperLabel = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            Player2_UpperLabel = new Label();
            Player2_BottomLabel = new Label();
            label1 = new Label();
            Player1_label_noc = new Label();
            label3 = new Label();
            Player2_label_noc = new Label();
            DrawCard_button = new Button();
            Winner_label = new Label();
            ((System.ComponentModel.ISupportInitialize)Player1_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Player2_pictureBox).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Player1_pictureBox
            // 
            Player1_pictureBox.Anchor = AnchorStyles.None;
            Player1_pictureBox.Location = new Point(12, 12);
            Player1_pictureBox.Name = "Player1_pictureBox";
            Player1_pictureBox.Size = new Size(320, 401);
            Player1_pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            Player1_pictureBox.TabIndex = 0;
            Player1_pictureBox.TabStop = false;
            // 
            // Player2_pictureBox
            // 
            Player2_pictureBox.Anchor = AnchorStyles.None;
            Player2_pictureBox.Location = new Point(14, 12);
            Player2_pictureBox.Name = "Player2_pictureBox";
            Player2_pictureBox.Size = new Size(320, 401);
            Player2_pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            Player2_pictureBox.TabIndex = 1;
            Player2_pictureBox.TabStop = false;
            // 
            // Player1_BottomLabel
            // 
            Player1_BottomLabel.Anchor = AnchorStyles.None;
            Player1_BottomLabel.AutoSize = true;
            Player1_BottomLabel.BackColor = Color.Transparent;
            Player1_BottomLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            Player1_BottomLabel.ForeColor = Color.Black;
            Player1_BottomLabel.Location = new Point(297, 386);
            Player1_BottomLabel.Name = "Player1_BottomLabel";
            Player1_BottomLabel.Size = new Size(0, 40);
            Player1_BottomLabel.TabIndex = 2;
            // 
            // Player1_UpperLabel
            // 
            Player1_UpperLabel.Anchor = AnchorStyles.None;
            Player1_UpperLabel.AutoSize = true;
            Player1_UpperLabel.BackColor = Color.Transparent;
            Player1_UpperLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            Player1_UpperLabel.ForeColor = Color.Black;
            Player1_UpperLabel.Location = new Point(-1, -1);
            Player1_UpperLabel.Name = "Player1_UpperLabel";
            Player1_UpperLabel.Size = new Size(0, 40);
            Player1_UpperLabel.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(Player1_UpperLabel);
            panel1.Controls.Add(Player1_BottomLabel);
            panel1.Controls.Add(Player1_pictureBox);
            panel1.Location = new Point(128, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(346, 424);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(Player2_UpperLabel);
            panel2.Controls.Add(Player2_BottomLabel);
            panel2.Controls.Add(Player2_pictureBox);
            panel2.Location = new Point(912, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(346, 424);
            panel2.TabIndex = 5;
            // 
            // Player2_UpperLabel
            // 
            Player2_UpperLabel.Anchor = AnchorStyles.None;
            Player2_UpperLabel.AutoSize = true;
            Player2_UpperLabel.BackColor = Color.Transparent;
            Player2_UpperLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            Player2_UpperLabel.ForeColor = Color.Black;
            Player2_UpperLabel.Location = new Point(-1, -1);
            Player2_UpperLabel.Name = "Player2_UpperLabel";
            Player2_UpperLabel.Size = new Size(0, 40);
            Player2_UpperLabel.TabIndex = 6;
            // 
            // Player2_BottomLabel
            // 
            Player2_BottomLabel.Anchor = AnchorStyles.None;
            Player2_BottomLabel.AutoSize = true;
            Player2_BottomLabel.BackColor = Color.Transparent;
            Player2_BottomLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            Player2_BottomLabel.ForeColor = Color.Black;
            Player2_BottomLabel.Location = new Point(297, 386);
            Player2_BottomLabel.Name = "Player2_BottomLabel";
            Player2_BottomLabel.Size = new Size(0, 40);
            Player2_BottomLabel.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(7, 9);
            label1.Name = "label1";
            label1.Size = new Size(284, 50);
            label1.TabIndex = 6;
            label1.Text = "Player 1 cards: ";
            // 
            // Player1_label_noc
            // 
            Player1_label_noc.AutoSize = true;
            Player1_label_noc.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            Player1_label_noc.Location = new Point(272, 9);
            Player1_label_noc.Name = "Player1_label_noc";
            Player1_label_noc.Size = new Size(128, 50);
            Player1_label_noc.TabIndex = 7;
            Player1_label_noc.Text = "label1";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(879, 9);
            label3.Name = "label3";
            label3.Size = new Size(284, 50);
            label3.TabIndex = 9;
            label3.Text = "Player 2 cards: ";
            // 
            // Player2_label_noc
            // 
            Player2_label_noc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Player2_label_noc.AutoSize = true;
            Player2_label_noc.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            Player2_label_noc.Location = new Point(1152, 9);
            Player2_label_noc.Name = "Player2_label_noc";
            Player2_label_noc.Size = new Size(128, 50);
            Player2_label_noc.TabIndex = 8;
            Player2_label_noc.Text = "label2";
            // 
            // DrawCard_button
            // 
            DrawCard_button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DrawCard_button.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            DrawCard_button.Location = new Point(604, 452);
            DrawCard_button.Name = "DrawCard_button";
            DrawCard_button.Size = new Size(178, 38);
            DrawCard_button.TabIndex = 10;
            DrawCard_button.Text = "Draw";
            DrawCard_button.UseVisualStyleBackColor = true;
            DrawCard_button.Click += DrawCard_button_Click;
            // 
            // Winner_label
            // 
            Winner_label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Winner_label.AutoSize = true;
            Winner_label.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            Winner_label.ForeColor = Color.IndianRed;
            Winner_label.Location = new Point(657, 514);
            Winner_label.Name = "Winner_label";
            Winner_label.Size = new Size(68, 50);
            Winner_label.TabIndex = 11;
            Winner_label.Text = "\"\" ";
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1349, 596);
            Controls.Add(Winner_label);
            Controls.Add(DrawCard_button);
            Controls.Add(label3);
            Controls.Add(Player2_label_noc);
            Controls.Add(Player1_label_noc);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(1365, 635);
            Name = "Game";
            Text = "Game";
            FormClosed += Game_FormClosed;
            Load += Game_Load;
            ((System.ComponentModel.ISupportInitialize)Player1_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Player2_pictureBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Player1_pictureBox;
        private PictureBox Player2_pictureBox;
        private Label Player1_BottomLabel;
        private Label Player1_UpperLabel;
        private Panel panel1;
        private Panel panel2;
        private Label Player2_UpperLabel;
        private Label Player2_BottomLabel;
        private Label label1;
        private Label Player1_label_noc;
        private Label label3;
        private Label Player2_label_noc;
        private Button DrawCard_button;
        private Label Winner_label;
    }
}