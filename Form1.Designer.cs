namespace Magic8Ball
{
    partial class Magic8Ball
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Magic8Ball));
            this.submitButton = new System.Windows.Forms.Button();
            this.questionBox = new System.Windows.Forms.TextBox();
            this.answerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.submitButton.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.Color.Black;
            this.submitButton.Location = new System.Drawing.Point(33, 24);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(218, 82);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "TELL MEEEEEE!!!";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // questionBox
            // 
            this.questionBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.questionBox.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.questionBox.Location = new System.Drawing.Point(33, 127);
            this.questionBox.Multiline = true;
            this.questionBox.Name = "questionBox";
            this.questionBox.Size = new System.Drawing.Size(218, 53);
            this.questionBox.TabIndex = 2;
            this.questionBox.Text = "Ask me a question here. MUAHAHAHAHA";
            this.questionBox.TextChanged += new System.EventHandler(this.questionBox_TextChanged);
            // 
            // answerLabel
            // 
            this.answerLabel.BackColor = System.Drawing.Color.Transparent;
            this.answerLabel.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerLabel.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.answerLabel.Location = new System.Drawing.Point(517, 406);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(175, 74);
            this.answerLabel.TabIndex = 3;
            this.answerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Magic8Ball
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1206, 911);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.questionBox);
            this.Controls.Add(this.submitButton);
            this.DoubleBuffered = true;
            this.Name = "Magic8Ball";
            this.Text = "Magic8Ball";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox questionBox;
        private System.Windows.Forms.Label answerLabel;
    }
}

