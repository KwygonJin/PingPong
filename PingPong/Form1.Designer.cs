namespace PingPong
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.background = new System.Windows.Forms.Panel();
            this.bestScore = new System.Windows.Forms.Label();
            this.currentScore = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.textScore = new System.Windows.Forms.TextBox();
            this.gameBall = new System.Windows.Forms.PictureBox();
            this.gamePanel = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePanel)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.Controls.Add(this.bestScore);
            this.background.Controls.Add(this.currentScore);
            this.background.Controls.Add(this.buttonExit);
            this.background.Controls.Add(this.buttonRestart);
            this.background.Controls.Add(this.textScore);
            this.background.Controls.Add(this.gameBall);
            this.background.Controls.Add(this.gamePanel);
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(800, 450);
            this.background.TabIndex = 0;
            // 
            // bestScore
            // 
            this.bestScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bestScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bestScore.Location = new System.Drawing.Point(256, 159);
            this.bestScore.Name = "bestScore";
            this.bestScore.Size = new System.Drawing.Size(350, 41);
            this.bestScore.TabIndex = 6;
            this.bestScore.Text = "Best score:";
            this.bestScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentScore
            // 
            this.currentScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currentScore.AutoSize = true;
            this.currentScore.Location = new System.Drawing.Point(697, 13);
            this.currentScore.Name = "currentScore";
            this.currentScore.Size = new System.Drawing.Size(83, 16);
            this.currentScore.TabIndex = 5;
            this.currentScore.Text = "currentScore";
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonExit.BackColor = System.Drawing.Color.LightPink;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(382, 279);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(106, 50);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonRestart
            // 
            this.buttonRestart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonRestart.BackColor = System.Drawing.Color.LightPink;
            this.buttonRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRestart.Location = new System.Drawing.Point(382, 223);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(106, 50);
            this.buttonRestart.TabIndex = 3;
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.UseVisualStyleBackColor = false;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // textScore
            // 
            this.textScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textScore.ForeColor = System.Drawing.SystemColors.Highlight;
            this.textScore.Location = new System.Drawing.Point(305, 115);
            this.textScore.Name = "textScore";
            this.textScore.Size = new System.Drawing.Size(250, 41);
            this.textScore.TabIndex = 2;
            this.textScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gameBall
            // 
            this.gameBall.BackColor = System.Drawing.Color.Blue;
            this.gameBall.Location = new System.Drawing.Point(132, 93);
            this.gameBall.Name = "gameBall";
            this.gameBall.Size = new System.Drawing.Size(50, 50);
            this.gameBall.TabIndex = 1;
            this.gameBall.TabStop = false;
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.Color.Red;
            this.gamePanel.Location = new System.Drawing.Point(279, 417);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(209, 21);
            this.gamePanel.TabIndex = 0;
            this.gamePanel.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.background);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.background.ResumeLayout(false);
            this.background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel background;
        private System.Windows.Forms.PictureBox gameBall;
        private System.Windows.Forms.PictureBox gamePanel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox textScore;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label currentScore;
        private System.Windows.Forms.Label bestScore;
    }
}

