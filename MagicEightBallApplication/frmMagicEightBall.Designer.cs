namespace MagicEightBallApplication
{
    partial class frmMagicEightBall
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
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.bpDisplay = new System.Windows.Forms.PictureBox();
            this.btnAsk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bpDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(151, 439);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(202, 20);
            this.txtQuestion.TabIndex = 0;
            this.txtQuestion.Text = "Ask your question";
            this.txtQuestion.TextChanged += new System.EventHandler(this.txtQuestion_TextChanged);
            // 
            // bpDisplay
            // 
            this.bpDisplay.Location = new System.Drawing.Point(39, 37);
            this.bpDisplay.Name = "bpDisplay";
            this.bpDisplay.Size = new System.Drawing.Size(422, 383);
            this.bpDisplay.TabIndex = 1;
            this.bpDisplay.TabStop = false;
            this.bpDisplay.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnAsk
            // 
            this.btnAsk.Location = new System.Drawing.Point(214, 484);
            this.btnAsk.Name = "btnAsk";
            this.btnAsk.Size = new System.Drawing.Size(75, 23);
            this.btnAsk.TabIndex = 2;
            this.btnAsk.Text = "Ask";
            this.btnAsk.UseVisualStyleBackColor = true;
            this.btnAsk.Click += new System.EventHandler(this.btnAsk_Click);
            // 
            // frmMagicEightBall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 519);
            this.Controls.Add(this.btnAsk);
            this.Controls.Add(this.bpDisplay);
            this.Controls.Add(this.txtQuestion);
            this.Name = "frmMagicEightBall";
            this.Text = "Magic Eight Ball";
            ((System.ComponentModel.ISupportInitialize)(this.bpDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.PictureBox bpDisplay;
        private System.Windows.Forms.Button btnAsk;
    }
}

