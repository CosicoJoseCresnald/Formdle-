namespace Winformdle
{
    partial class MainMenu
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
            btnPlay = new Button();
            pnlMainMenu = new Panel();
            panel1 = new Panel();
            btnExit = new Button();
            pnlLanguage = new Panel();
            label3 = new Label();
            btnBackLanguage = new Button();
            btnTagalog = new Button();
            btnEnglish = new Button();
            pnlDifficulty = new Panel();
            label1 = new Label();
            btnBackDifficulty = new Button();
            btnHard = new Button();
            btnMedium = new Button();
            btnEasy = new Button();
            pnlGameMode = new Panel();
            label2 = new Label();
            btnBackGameMode = new Button();
            btn2Player = new Button();
            btn1Player = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pnlMainMenu.SuspendLayout();
            pnlLanguage.SuspendLayout();
            pnlDifficulty.SuspendLayout();
            pnlGameMode.SuspendLayout();
            SuspendLayout();
            // 
            // btnPlay
            // 
            btnPlay.Image = Properties.Resources.play_button;
            btnPlay.Location = new Point(146, 213);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(154, 71);
            btnPlay.TabIndex = 0;
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // pnlMainMenu
            // 
            pnlMainMenu.BackgroundImage = Properties.Resources.BG;
            pnlMainMenu.BackgroundImageLayout = ImageLayout.Stretch;
            pnlMainMenu.Controls.Add(panel1);
            pnlMainMenu.Controls.Add(btnExit);
            pnlMainMenu.Controls.Add(btnPlay);
            pnlMainMenu.Dock = DockStyle.Fill;
            pnlMainMenu.Location = new Point(0, 0);
            pnlMainMenu.Name = "pnlMainMenu";
            pnlMainMenu.Size = new Size(449, 622);
            pnlMainMenu.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.bg_fixed;
            panel1.Location = new Point(113, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 48);
            panel1.TabIndex = 5;
            // 
            // btnExit
            // 
            btnExit.Image = Properties.Resources.exit_button;
            btnExit.Location = new Point(146, 300);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(154, 75);
            btnExit.TabIndex = 4;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pnlLanguage
            // 
            pnlLanguage.BackgroundImage = Properties.Resources.BG;
            pnlLanguage.Controls.Add(label3);
            pnlLanguage.Controls.Add(btnBackLanguage);
            pnlLanguage.Controls.Add(btnTagalog);
            pnlLanguage.Controls.Add(btnEnglish);
            pnlLanguage.Dock = DockStyle.Fill;
            pnlLanguage.Location = new Point(0, 0);
            pnlLanguage.Name = "pnlLanguage";
            pnlLanguage.Size = new Size(449, 622);
            pnlLanguage.TabIndex = 2;
            pnlLanguage.Paint += pnlLanguage_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Impact", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(74, 100);
            label3.Name = "label3";
            label3.Size = new Size(311, 43);
            label3.TabIndex = 6;
            label3.Text = "Choose A Language";
            // 
            // btnBackLanguage
            // 
            btnBackLanguage.BackColor = Color.White;
            btnBackLanguage.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBackLanguage.Location = new Point(176, 349);
            btnBackLanguage.Name = "btnBackLanguage";
            btnBackLanguage.Size = new Size(108, 34);
            btnBackLanguage.TabIndex = 3;
            btnBackLanguage.Text = "BACK";
            btnBackLanguage.UseVisualStyleBackColor = false;
            btnBackLanguage.Click += btnBackLanguage_Click;
            // 
            // btnTagalog
            // 
            btnTagalog.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTagalog.Image = Properties.Resources.tagalog_button;
            btnTagalog.Location = new Point(148, 265);
            btnTagalog.Name = "btnTagalog";
            btnTagalog.Size = new Size(157, 69);
            btnTagalog.TabIndex = 2;
            btnTagalog.UseVisualStyleBackColor = true;
            btnTagalog.Click += btnTagalog_Click1;
            // 
            // btnEnglish
            // 
            btnEnglish.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEnglish.Image = Properties.Resources.english_button;
            btnEnglish.Location = new Point(148, 174);
            btnEnglish.Name = "btnEnglish";
            btnEnglish.Size = new Size(155, 71);
            btnEnglish.TabIndex = 1;
            btnEnglish.UseVisualStyleBackColor = true;
            btnEnglish.Click += btnEnglish_Click;
            // 
            // pnlDifficulty
            // 
            pnlDifficulty.BackgroundImage = Properties.Resources.BG;
            pnlDifficulty.BackgroundImageLayout = ImageLayout.Stretch;
            pnlDifficulty.Controls.Add(label1);
            pnlDifficulty.Controls.Add(btnBackDifficulty);
            pnlDifficulty.Controls.Add(btnHard);
            pnlDifficulty.Controls.Add(btnMedium);
            pnlDifficulty.Controls.Add(btnEasy);
            pnlDifficulty.Dock = DockStyle.Fill;
            pnlDifficulty.Location = new Point(0, 0);
            pnlDifficulty.Name = "pnlDifficulty";
            pnlDifficulty.Size = new Size(449, 622);
            pnlDifficulty.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(82, 93);
            label1.Name = "label1";
            label1.Size = new Size(303, 43);
            label1.TabIndex = 5;
            label1.Text = "Choose A Difficulty";
            // 
            // btnBackDifficulty
            // 
            btnBackDifficulty.BackColor = Color.White;
            btnBackDifficulty.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackDifficulty.ForeColor = SystemColors.ControlText;
            btnBackDifficulty.Location = new Point(161, 444);
            btnBackDifficulty.Name = "btnBackDifficulty";
            btnBackDifficulty.Size = new Size(123, 34);
            btnBackDifficulty.TabIndex = 4;
            btnBackDifficulty.Text = "BACK";
            btnBackDifficulty.UseVisualStyleBackColor = false;
            btnBackDifficulty.Click += btnBackDifficulty_Click;
            // 
            // btnHard
            // 
            btnHard.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHard.Image = Properties.Resources.hard_button;
            btnHard.Location = new Point(146, 351);
            btnHard.Name = "btnHard";
            btnHard.Size = new Size(154, 75);
            btnHard.TabIndex = 3;
            btnHard.UseVisualStyleBackColor = true;
            btnHard.Click += btnHard_Click;
            // 
            // btnMedium
            // 
            btnMedium.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMedium.Image = Properties.Resources.medium_button__2_;
            btnMedium.Location = new Point(146, 265);
            btnMedium.Name = "btnMedium";
            btnMedium.Size = new Size(154, 69);
            btnMedium.TabIndex = 2;
            btnMedium.UseVisualStyleBackColor = true;
            btnMedium.Click += btnMedium_Click;
            // 
            // btnEasy
            // 
            btnEasy.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEasy.Image = Properties.Resources.easy_button;
            btnEasy.Location = new Point(146, 175);
            btnEasy.Name = "btnEasy";
            btnEasy.Size = new Size(155, 71);
            btnEasy.TabIndex = 1;
            btnEasy.UseVisualStyleBackColor = true;
            btnEasy.Click += btnEasy_Click;
            // 
            // pnlGameMode
            // 
            pnlGameMode.BackgroundImage = Properties.Resources.BG;
            pnlGameMode.BackgroundImageLayout = ImageLayout.Stretch;
            pnlGameMode.Controls.Add(label2);
            pnlGameMode.Controls.Add(btnBackGameMode);
            pnlGameMode.Controls.Add(btn2Player);
            pnlGameMode.Controls.Add(btn1Player);
            pnlGameMode.Dock = DockStyle.Fill;
            pnlGameMode.Location = new Point(0, 0);
            pnlGameMode.Name = "pnlGameMode";
            pnlGameMode.Size = new Size(449, 622);
            pnlGameMode.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Impact", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(63, 100);
            label2.Name = "label2";
            label2.Size = new Size(333, 43);
            label2.TabIndex = 8;
            label2.Text = "Choose A GameMode";
            // 
            // btnBackGameMode
            // 
            btnBackGameMode.BackColor = Color.White;
            btnBackGameMode.FlatAppearance.BorderColor = Color.Black;
            btnBackGameMode.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackGameMode.Location = new Point(161, 361);
            btnBackGameMode.Name = "btnBackGameMode";
            btnBackGameMode.Size = new Size(123, 34);
            btnBackGameMode.TabIndex = 7;
            btnBackGameMode.Text = "BACK";
            btnBackGameMode.UseVisualStyleBackColor = false;
            btnBackGameMode.Click += btnBackGameMode_Click;
            // 
            // btn2Player
            // 
            btn2Player.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2Player.Image = Properties.Resources._2___player_button;
            btn2Player.Location = new Point(146, 271);
            btn2Player.Name = "btn2Player";
            btn2Player.Size = new Size(152, 72);
            btn2Player.TabIndex = 6;
            btn2Player.UseVisualStyleBackColor = true;
            btn2Player.Click += btn2Player_Click;
            // 
            // btn1Player
            // 
            btn1Player.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1Player.Image = Properties.Resources._1___player_button;
            btn1Player.Location = new Point(148, 173);
            btn1Player.Name = "btn1Player";
            btn1Player.Size = new Size(153, 73);
            btn1Player.TabIndex = 5;
            btn1Player.UseVisualStyleBackColor = true;
            btn1Player.Click += btn1Player_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 250, 250);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(449, 622);
            Controls.Add(pnlMainMenu);
            Controls.Add(pnlDifficulty);
            Controls.Add(pnlGameMode);
            Controls.Add(pnlLanguage);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formdle";
            FormClosed += MainMenu_FormClosed;
            Load += Form1_Load;
            pnlMainMenu.ResumeLayout(false);
            pnlLanguage.ResumeLayout(false);
            pnlLanguage.PerformLayout();
            pnlDifficulty.ResumeLayout(false);
            pnlDifficulty.PerformLayout();
            pnlGameMode.ResumeLayout(false);
            pnlGameMode.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnPlay;
        private Panel pnlMainMenu;
        private Panel pnlLanguage;
        private Button btnEnglish;
        private Button btnTagalog;
        private Panel pnlDifficulty;
        private Button btnHard;
        private Button btnMedium;
        private Button btnEasy;
        private Panel pnlGameMode;
        private Button btn2Player;
        private Button btn1Player;
        private Button btnExit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnBackDifficulty;
        private Button btnBackGameMode;
        private Button btnBackLanguage;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
