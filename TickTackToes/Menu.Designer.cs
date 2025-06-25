namespace TickTackToes
{
    partial class Menu
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
            StartMultiplayer = new Button();
            StartSoloGame = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            Exit = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // StartMultiplayer
            // 
            StartMultiplayer.BackColor = Color.DarkSeaGreen;
            StartMultiplayer.Dock = DockStyle.Fill;
            StartMultiplayer.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StartMultiplayer.Location = new Point(3, 42);
            StartMultiplayer.Name = "StartMultiplayer";
            StartMultiplayer.Size = new Size(194, 33);
            StartMultiplayer.TabIndex = 1;
            StartMultiplayer.Text = "Multiplayer(local)";
            StartMultiplayer.UseVisualStyleBackColor = false;
            StartMultiplayer.Click += StartMultiplayer_Click;
            // 
            // StartSoloGame
            // 
            StartSoloGame.BackColor = Color.DarkSeaGreen;
            StartSoloGame.Dock = DockStyle.Fill;
            StartSoloGame.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StartSoloGame.Location = new Point(3, 3);
            StartSoloGame.Name = "StartSoloGame";
            StartSoloGame.Size = new Size(194, 33);
            StartSoloGame.TabIndex = 0;
            StartSoloGame.Text = "Solo game";
            StartSoloGame.UseVisualStyleBackColor = false;
            StartSoloGame.Click += SoloGameClick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(StartSoloGame, 0, 0);
            tableLayoutPanel1.Controls.Add(StartMultiplayer, 0, 1);
            tableLayoutPanel1.Controls.Add(Exit, 0, 2);
            tableLayoutPanel1.Location = new Point(468, 243);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(200, 119);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // Exit
            // 
            Exit.BackColor = Color.DarkSeaGreen;
            Exit.Dock = DockStyle.Fill;
            Exit.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Exit.Location = new Point(3, 81);
            Exit.Name = "Exit";
            Exit.Size = new Size(194, 35);
            Exit.TabIndex = 2;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._8339bec72f606bb96256b486fe867580;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1129, 697);
            Controls.Add(tableLayoutPanel1);
            Name = "Menu";
            Text = "TickTackToe";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button StartMultiplayer;
        private Button StartSoloGame;
        private TableLayoutPanel tableLayoutPanel1;
        private Button Exit;
    }
}