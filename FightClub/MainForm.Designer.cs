namespace FightClub
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
            this.FightLog = new System.Windows.Forms.ListBox();
            this.LogLabel = new System.Windows.Forms.Label();
            this.userHpProgress = new System.Windows.Forms.ProgressBar();
            this.compHpProgress = new System.Windows.Forms.ProgressBar();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.compNameLabel = new System.Windows.Forms.Label();
            this.userHpLabel = new System.Windows.Forms.Label();
            this.compHpLabel = new System.Windows.Forms.Label();
            this.defendPanel = new System.Windows.Forms.Panel();
            this.defLab = new System.Windows.Forms.Label();
            this.headDefendButton = new System.Windows.Forms.Button();
            this.BodyDefendButton = new System.Windows.Forms.Button();
            this.LegsDefendButton = new System.Windows.Forms.Button();
            this.AttackPanel = new System.Windows.Forms.Panel();
            this.attackLegsbutton = new System.Windows.Forms.Button();
            this.attackBodybutton = new System.Windows.Forms.Button();
            this.attackHeadButton = new System.Windows.Forms.Button();
            this.AttackLabel = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
            this.defendPanel.SuspendLayout();
            this.AttackPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FightLog
            // 
            this.FightLog.BackColor = System.Drawing.SystemColors.MenuText;
            this.FightLog.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FightLog.ForeColor = System.Drawing.SystemColors.Info;
            this.FightLog.FormattingEnabled = true;
            this.FightLog.ItemHeight = 15;
            this.FightLog.Location = new System.Drawing.Point(12, 264);
            this.FightLog.Name = "FightLog";
            this.FightLog.Size = new System.Drawing.Size(740, 169);
            this.FightLog.TabIndex = 0;
            // 
            // LogLabel
            // 
            this.LogLabel.AutoSize = true;
            this.LogLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogLabel.Location = new System.Drawing.Point(13, 246);
            this.LogLabel.Name = "LogLabel";
            this.LogLabel.Size = new System.Drawing.Size(64, 15);
            this.LogLabel.TabIndex = 1;
            this.LogLabel.Text = "Ход боя:";
            // 
            // userHpProgress
            // 
            this.userHpProgress.Location = new System.Drawing.Point(16, 34);
            this.userHpProgress.Name = "userHpProgress";
            this.userHpProgress.Size = new System.Drawing.Size(179, 23);
            this.userHpProgress.TabIndex = 2;
            // 
            // compHpProgress
            // 
            this.compHpProgress.Location = new System.Drawing.Point(573, 34);
            this.compHpProgress.Name = "compHpProgress";
            this.compHpProgress.Size = new System.Drawing.Size(179, 23);
            this.compHpProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.compHpProgress.TabIndex = 3;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameLabel.Location = new System.Drawing.Point(13, 9);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(37, 16);
            this.userNameLabel.TabIndex = 4;
            this.userNameLabel.Text = "Имя";
            // 
            // compNameLabel
            // 
            this.compNameLabel.AutoSize = true;
            this.compNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.compNameLabel.Location = new System.Drawing.Point(662, 9);
            this.compNameLabel.Name = "compNameLabel";
            this.compNameLabel.Size = new System.Drawing.Size(90, 16);
            this.compNameLabel.TabIndex = 5;
            this.compNameLabel.Text = "Компьютер";
            // 
            // userHpLabel
            // 
            this.userHpLabel.AutoSize = true;
            this.userHpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userHpLabel.Location = new System.Drawing.Point(201, 41);
            this.userHpLabel.Name = "userHpLabel";
            this.userHpLabel.Size = new System.Drawing.Size(16, 16);
            this.userHpLabel.TabIndex = 6;
            this.userHpLabel.Text = "0";
            // 
            // compHpLabel
            // 
            this.compHpLabel.AutoSize = true;
            this.compHpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.compHpLabel.Location = new System.Drawing.Point(516, 41);
            this.compHpLabel.Name = "compHpLabel";
            this.compHpLabel.Size = new System.Drawing.Size(16, 16);
            this.compHpLabel.TabIndex = 7;
            this.compHpLabel.Text = "0";
            // 
            // defendPanel
            // 
            this.defendPanel.Controls.Add(this.LegsDefendButton);
            this.defendPanel.Controls.Add(this.BodyDefendButton);
            this.defendPanel.Controls.Add(this.headDefendButton);
            this.defendPanel.Controls.Add(this.defLab);
            this.defendPanel.Location = new System.Drawing.Point(204, 149);
            this.defendPanel.Name = "defendPanel";
            this.defendPanel.Size = new System.Drawing.Size(363, 100);
            this.defendPanel.TabIndex = 8;
            // 
            // defLab
            // 
            this.defLab.AutoSize = true;
            this.defLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.defLab.Location = new System.Drawing.Point(138, 9);
            this.defLab.Name = "defLab";
            this.defLab.Size = new System.Drawing.Size(83, 15);
            this.defLab.TabIndex = 0;
            this.defLab.Text = "Защищайся";
            // 
            // headDefendButton
            // 
            this.headDefendButton.Location = new System.Drawing.Point(12, 56);
            this.headDefendButton.Name = "headDefendButton";
            this.headDefendButton.Size = new System.Drawing.Size(75, 23);
            this.headDefendButton.TabIndex = 1;
            this.headDefendButton.Text = "Голова";
            this.headDefendButton.UseVisualStyleBackColor = true;
            this.headDefendButton.Click += new System.EventHandler(this.headDefendButton_Click);
            // 
            // BodyDefendButton
            // 
            this.BodyDefendButton.Location = new System.Drawing.Point(146, 56);
            this.BodyDefendButton.Name = "BodyDefendButton";
            this.BodyDefendButton.Size = new System.Drawing.Size(75, 23);
            this.BodyDefendButton.TabIndex = 2;
            this.BodyDefendButton.Text = "Корпус";
            this.BodyDefendButton.UseVisualStyleBackColor = true;
            this.BodyDefendButton.Click += new System.EventHandler(this.BodyDefendButton_Click);
            // 
            // LegsDefendButton
            // 
            this.LegsDefendButton.Location = new System.Drawing.Point(276, 56);
            this.LegsDefendButton.Name = "LegsDefendButton";
            this.LegsDefendButton.Size = new System.Drawing.Size(75, 23);
            this.LegsDefendButton.TabIndex = 3;
            this.LegsDefendButton.Text = "Ноги";
            this.LegsDefendButton.UseVisualStyleBackColor = true;
            this.LegsDefendButton.Click += new System.EventHandler(this.LegsDefendButton_Click);
            // 
            // AttackPanel
            // 
            this.AttackPanel.Controls.Add(this.attackLegsbutton);
            this.AttackPanel.Controls.Add(this.attackBodybutton);
            this.AttackPanel.Controls.Add(this.attackHeadButton);
            this.AttackPanel.Controls.Add(this.AttackLabel);
            this.AttackPanel.Location = new System.Drawing.Point(204, 149);
            this.AttackPanel.Name = "AttackPanel";
            this.AttackPanel.Size = new System.Drawing.Size(363, 100);
            this.AttackPanel.TabIndex = 9;
            // 
            // attackLegsbutton
            // 
            this.attackLegsbutton.Location = new System.Drawing.Point(276, 56);
            this.attackLegsbutton.Name = "attackLegsbutton";
            this.attackLegsbutton.Size = new System.Drawing.Size(75, 23);
            this.attackLegsbutton.TabIndex = 3;
            this.attackLegsbutton.Text = "Ноги";
            this.attackLegsbutton.UseVisualStyleBackColor = true;
            this.attackLegsbutton.Click += new System.EventHandler(this.attackLegsbutton_Click);
            // 
            // attackBodybutton
            // 
            this.attackBodybutton.Location = new System.Drawing.Point(146, 56);
            this.attackBodybutton.Name = "attackBodybutton";
            this.attackBodybutton.Size = new System.Drawing.Size(75, 23);
            this.attackBodybutton.TabIndex = 2;
            this.attackBodybutton.Text = "Корпус";
            this.attackBodybutton.UseVisualStyleBackColor = true;
            this.attackBodybutton.Click += new System.EventHandler(this.attackBodybutton_Click);
            // 
            // attackHeadButton
            // 
            this.attackHeadButton.Location = new System.Drawing.Point(12, 56);
            this.attackHeadButton.Name = "attackHeadButton";
            this.attackHeadButton.Size = new System.Drawing.Size(75, 23);
            this.attackHeadButton.TabIndex = 1;
            this.attackHeadButton.Text = "Голова";
            this.attackHeadButton.UseVisualStyleBackColor = true;
            this.attackHeadButton.Click += new System.EventHandler(this.attackHeadButton_Click);
            // 
            // AttackLabel
            // 
            this.AttackLabel.AutoSize = true;
            this.AttackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AttackLabel.Location = new System.Drawing.Point(155, 9);
            this.AttackLabel.Name = "AttackLabel";
            this.AttackLabel.Size = new System.Drawing.Size(52, 15);
            this.AttackLabel.TabIndex = 0;
            this.AttackLabel.Text = "Атакуй";
            // 
            // helpButton
            // 
            this.helpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpButton.Location = new System.Drawing.Point(729, 238);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(23, 23);
            this.helpButton.TabIndex = 10;
            this.helpButton.Text = "?";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 445);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.compHpLabel);
            this.Controls.Add(this.userHpLabel);
            this.Controls.Add(this.compNameLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.compHpProgress);
            this.Controls.Add(this.userHpProgress);
            this.Controls.Add(this.LogLabel);
            this.Controls.Add(this.FightLog);
            this.Controls.Add(this.AttackPanel);
            this.Controls.Add(this.defendPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "MainForm";
            this.Text = "Fight Club";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.defendPanel.ResumeLayout(false);
            this.defendPanel.PerformLayout();
            this.AttackPanel.ResumeLayout(false);
            this.AttackPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox FightLog;
        private System.Windows.Forms.Label LogLabel;
        private System.Windows.Forms.ProgressBar userHpProgress;
        private System.Windows.Forms.ProgressBar compHpProgress;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label compNameLabel;
        private System.Windows.Forms.Label userHpLabel;
        private System.Windows.Forms.Label compHpLabel;
        private System.Windows.Forms.Panel defendPanel;
        private System.Windows.Forms.Panel AttackPanel;
        private System.Windows.Forms.Button attackLegsbutton;
        private System.Windows.Forms.Button attackBodybutton;
        private System.Windows.Forms.Button attackHeadButton;
        private System.Windows.Forms.Label AttackLabel;
        private System.Windows.Forms.Button LegsDefendButton;
        private System.Windows.Forms.Button BodyDefendButton;
        private System.Windows.Forms.Button headDefendButton;
        private System.Windows.Forms.Label defLab;
        private System.Windows.Forms.Button helpButton;
    }
}