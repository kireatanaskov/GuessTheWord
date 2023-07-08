namespace GuessTheWord
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblWord = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbVreme = new System.Windows.Forms.ProgressBar();
            this.lblPresotanatoVreme = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblHint = new System.Windows.Forms.Label();
            this.lblHintsLeft = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 290);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 22);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter a letter:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "ENTER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWord.Location = new System.Drawing.Point(8, 207);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(79, 29);
            this.lblWord.TabIndex = 3;
            this.lblWord.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbVreme
            // 
            this.pbVreme.Location = new System.Drawing.Point(8, 431);
            this.pbVreme.Maximum = 60;
            this.pbVreme.Name = "pbVreme";
            this.pbVreme.Size = new System.Drawing.Size(828, 45);
            this.pbVreme.TabIndex = 4;
            this.pbVreme.Value = 60;
            // 
            // lblPresotanatoVreme
            // 
            this.lblPresotanatoVreme.AutoSize = true;
            this.lblPresotanatoVreme.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPresotanatoVreme.Location = new System.Drawing.Point(8, 389);
            this.lblPresotanatoVreme.Name = "lblPresotanatoVreme";
            this.lblPresotanatoVreme.Size = new System.Drawing.Size(120, 29);
            this.lblPresotanatoVreme.TabIndex = 5;
            this.lblPresotanatoVreme.Text = "Time Left:";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTimer.Location = new System.Drawing.Point(134, 389);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(79, 29);
            this.lblTimer.TabIndex = 6;
            this.lblTimer.Text = "label3";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(12, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 66);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHint.Location = new System.Drawing.Point(7, 127);
            this.lblHint.MaximumSize = new System.Drawing.Size(600, 0);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(64, 25);
            this.lblHint.TabIndex = 8;
            this.lblHint.Text = "label2";
            // 
            // lblHintsLeft
            // 
            this.lblHintsLeft.AutoSize = true;
            this.lblHintsLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHintsLeft.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblHintsLeft.Location = new System.Drawing.Point(12, 9);
            this.lblHintsLeft.Name = "lblHintsLeft";
            this.lblHintsLeft.Size = new System.Drawing.Size(58, 22);
            this.lblHintsLeft.TabIndex = 9;
            this.lblHintsLeft.Text = "label2";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // statusStrip2
            // 
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip2.Location = new System.Drawing.Point(0, 490);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(847, 26);
            this.statusStrip2.TabIndex = 11;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // GameForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 516);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.lblHintsLeft);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblPresotanatoVreme);
            this.Controls.Add(this.pbVreme);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "GameForm";
            this.Text = "Guess The Word";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
            this.Load += new System.EventHandler(this.GameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar pbVreme;
        private System.Windows.Forms.Label lblPresotanatoVreme;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Label lblHintsLeft;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}