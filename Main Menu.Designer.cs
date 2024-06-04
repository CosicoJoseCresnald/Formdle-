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
            pnlLanguage = new Panel();
            btnBackLanguage = new Button();
            btnTagalog = new Button();
            btnEnglish = new Button();
            lblChooseDifficulty = new Label();
            pnlDifficulty = new Panel();
            btnBackDiff = new Button();
            btnHard = new Button();
            btnMedium = new Button();
            btnEasy = new Button();
            lblDifficulty = new Label();
            pnlGameMode = new Panel();
            btnBackGM = new Button();
            btn2Player = new Button();
            btn1Player = new Button();
            lblGameMode = new Label();
            btnUnlimited = new Button();
            pnlMainMenu.SuspendLayout();
            pnlLanguage.SuspendLayout();
            pnlDifficulty.SuspendLayout();
            pnlGameMode.SuspendLayout();
            SuspendLayout();
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(171, 299);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(121, 44);
            btnPlay.TabIndex = 0;
            btnPlay.Text = "PLAY";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // pnlMainMenu
            // 
            pnlMainMenu.Controls.Add(btnPlay);
            pnlMainMenu.Dock = DockStyle.Fill;
            pnlMainMenu.Location = new Point(0, 0);
            pnlMainMenu.Name = "pnlMainMenu";
            pnlMainMenu.Size = new Size(460, 622);
            pnlMainMenu.TabIndex = 1;
            // 
            // pnlLanguage
            // 
            pnlLanguage.Controls.Add(btnBackLanguage);
            pnlLanguage.Controls.Add(btnTagalog);
            pnlLanguage.Controls.Add(btnEnglish);
            pnlLanguage.Controls.Add(lblChooseDifficulty);
            pnlLanguage.Dock = DockStyle.Fill;
            pnlLanguage.Location = new Point(0, 0);
            pnlLanguage.Name = "pnlLanguage";
            pnlLanguage.Size = new Size(460, 622);
            pnlLanguage.TabIndex = 2;
            pnlLanguage.Paint += pnlLanguage_Paint;
            // 
            // btnBackLanguage
            // 
            btnBackLanguage.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBackLanguage.Location = new Point(176, 294);
            btnBackLanguage.Name = "btnBackLanguage";
            btnBackLanguage.Size = new Size(108, 34);
            btnBackLanguage.TabIndex = 3;
            btnBackLanguage.Text = "BACK";
            btnBackLanguage.UseVisualStyleBackColor = true;
            btnBackLanguage.Click += btnBackLanguage_Click;
            // 
            // btnTagalog
            // 
            btnTagalog.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTagalog.Location = new Point(176, 236);
            btnTagalog.Name = "btnTagalog";
            btnTagalog.Size = new Size(108, 34);
            btnTagalog.TabIndex = 2;
            btnTagalog.Text = "FILIPINO";
            btnTagalog.UseVisualStyleBackColor = true;
            btnTagalog.Click += btnTagalog_Click1;
            // 
            // btnEnglish
            // 
            btnEnglish.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEnglish.Location = new Point(176, 183);
            btnEnglish.Name = "btnEnglish";
            btnEnglish.Size = new Size(108, 34);
            btnEnglish.TabIndex = 1;
            btnEnglish.Text = "ENGLISH";
            btnEnglish.UseVisualStyleBackColor = true;
            btnEnglish.Click += btnEnglish_Click;
            // 
            // lblChooseDifficulty
            // 
            lblChooseDifficulty.AutoSize = true;
            lblChooseDifficulty.Enabled = false;
            lblChooseDifficulty.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChooseDifficulty.Location = new Point(146, 128);
            lblChooseDifficulty.Name = "lblChooseDifficulty";
            lblChooseDifficulty.Size = new Size(173, 21);
            lblChooseDifficulty.TabIndex = 0;
            lblChooseDifficulty.Text = "Choose a Language:";
            lblChooseDifficulty.Click += lblChooseDifficulty_Click;
            // 
            // pnlDifficulty
            // 
            pnlDifficulty.Controls.Add(btnBackDiff);
            pnlDifficulty.Controls.Add(btnHard);
            pnlDifficulty.Controls.Add(btnMedium);
            pnlDifficulty.Controls.Add(btnEasy);
            pnlDifficulty.Controls.Add(lblDifficulty);
            pnlDifficulty.Dock = DockStyle.Fill;
            pnlDifficulty.Location = new Point(0, 0);
            pnlDifficulty.Name = "pnlDifficulty";
            pnlDifficulty.Size = new Size(460, 622);
            pnlDifficulty.TabIndex = 3;
            // 
            // btnBackDiff
            // 
            btnBackDiff.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBackDiff.Location = new Point(169, 373);
            btnBackDiff.Name = "btnBackDiff";
            btnBackDiff.Size = new Size(108, 34);
            btnBackDiff.TabIndex = 4;
            btnBackDiff.Text = "BACK";
            btnBackDiff.UseVisualStyleBackColor = true;
            btnBackDiff.Click += button1_Click;
            // 
            // btnHard
            // 
            btnHard.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHard.Location = new Point(169, 330);
            btnHard.Name = "btnHard";
            btnHard.Size = new Size(108, 34);
            btnHard.TabIndex = 3;
            btnHard.Text = "HARD";
            btnHard.UseVisualStyleBackColor = true;
            btnHard.Click += btnHard_Click;
            // 
            // btnMedium
            // 
            btnMedium.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMedium.Location = new Point(169, 280);
            btnMedium.Name = "btnMedium";
            btnMedium.Size = new Size(108, 34);
            btnMedium.TabIndex = 2;
            btnMedium.Text = "MEDIUM";
            btnMedium.UseVisualStyleBackColor = true;
            btnMedium.Click += btnMedium_Click;
            // 
            // btnEasy
            // 
            btnEasy.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEasy.Location = new Point(169, 223);
            btnEasy.Name = "btnEasy";
            btnEasy.Size = new Size(108, 34);
            btnEasy.TabIndex = 1;
            btnEasy.Text = "EASY";
            btnEasy.UseVisualStyleBackColor = true;
            btnEasy.Click += btnEasy_Click;
            // 
            // lblDifficulty
            // 
            lblDifficulty.AutoSize = true;
            lblDifficulty.Enabled = false;
            lblDifficulty.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDifficulty.Location = new Point(146, 176);
            lblDifficulty.Name = "lblDifficulty";
            lblDifficulty.Size = new Size(154, 21);
            lblDifficulty.TabIndex = 0;
            lblDifficulty.Text = "Choose a Difficulty";
            // 
            // pnlGameMode
            // 
            pnlGameMode.Controls.Add(btnUnlimited);
            pnlGameMode.Controls.Add(btnBackGM);
            pnlGameMode.Controls.Add(btn2Player);
            pnlGameMode.Controls.Add(btn1Player);
            pnlGameMode.Controls.Add(lblGameMode);
            pnlGameMode.Dock = DockStyle.Fill;
            pnlGameMode.Location = new Point(0, 0);
            pnlGameMode.Name = "pnlGameMode";
            pnlGameMode.Size = new Size(460, 622);
            pnlGameMode.TabIndex = 3;
            // 
            // btnBackGM
            // 
            btnBackGM.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBackGM.Location = new Point(184, 334);
            btnBackGM.Name = "btnBackGM";
            btnBackGM.Size = new Size(108, 34);
            btnBackGM.TabIndex = 7;
            btnBackGM.Text = "BACK";
            btnBackGM.UseVisualStyleBackColor = true;
            btnBackGM.Click += button2_Click;
            // 
            // btn2Player
            // 
            btn2Player.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2Player.Location = new Point(184, 250);
            btn2Player.Name = "btn2Player";
            btn2Player.Size = new Size(108, 34);
            btn2Player.TabIndex = 6;
            btn2Player.Text = "2 - Player";
            btn2Player.UseVisualStyleBackColor = true;
            btn2Player.Click += btn2Player_Click;
            // 
            // btn1Player
            // 
            btn1Player.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1Player.Location = new Point(184, 193);
            btn1Player.Name = "btn1Player";
            btn1Player.Size = new Size(108, 34);
            btn1Player.TabIndex = 5;
            btn1Player.Text = "1 - Player";
            btn1Player.UseVisualStyleBackColor = true;
            btn1Player.Click += btn1Player_Click;
            // 
            // lblGameMode
            // 
            lblGameMode.AutoSize = true;
            lblGameMode.Enabled = false;
            lblGameMode.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGameMode.Location = new Point(146, 156);
            lblGameMode.Name = "lblGameMode";
            lblGameMode.Size = new Size(188, 21);
            lblGameMode.TabIndex = 4;
            lblGameMode.Text = "Choose a Game Mode";
            // 
            // btnUnlimited
            // 
            btnUnlimited.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUnlimited.Location = new Point(184, 294);
            btnUnlimited.Name = "btnUnlimited";
            btnUnlimited.Size = new Size(108, 34);
            btnUnlimited.TabIndex = 8;
            btnUnlimited.Text = "UNLIMITED";
            btnUnlimited.UseVisualStyleBackColor = true;
            btnUnlimited.Click += btnUnlimited_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 250, 250);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(460, 622);
            Controls.Add(pnlGameMode);
            Controls.Add(pnlLanguage);
            Controls.Add(pnlMainMenu);
            Controls.Add(pnlDifficulty);
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
        private Label lblChooseDifficulty;
        private Button btnEnglish;
        private Button btnTagalog;
        private Panel pnlDifficulty;
        private Button btnHard;
        private Button btnMedium;
        private Button btnEasy;
        private Label lblDifficulty;
        private Panel pnlGameMode;
        private Button btn2Player;
        private Button btn1Player;
        private Label lblGameMode;
        private Button btnBackDiff;
        private Button btnBackGM;
        private Button btnBackLanguage;
        private Button button1;
        private Button btnUnlimited;
    }
}
