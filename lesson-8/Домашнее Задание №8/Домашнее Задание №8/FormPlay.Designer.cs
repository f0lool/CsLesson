namespace Домашнее_Задание__8
{
    partial class FormPlay
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
            this.lbQuestion = new System.Windows.Forms.Label();
            this.cboxTrue = new System.Windows.Forms.CheckBox();
            this.btnAns = new System.Windows.Forms.Button();
            this.lbTextScore = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbQuestion
            // 
            this.lbQuestion.AutoSize = true;
            this.lbQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbQuestion.Location = new System.Drawing.Point(26, 83);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(99, 33);
            this.lbQuestion.TabIndex = 0;
            this.lbQuestion.Text = "label1";
            // 
            // cboxTrue
            // 
            this.cboxTrue.AutoSize = true;
            this.cboxTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxTrue.Location = new System.Drawing.Point(411, 401);
            this.cboxTrue.Name = "cboxTrue";
            this.cboxTrue.Size = new System.Drawing.Size(141, 37);
            this.cboxTrue.TabIndex = 1;
            this.cboxTrue.Text = "Правда";
            this.cboxTrue.UseVisualStyleBackColor = true;
            // 
            // btnAns
            // 
            this.btnAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAns.Location = new System.Drawing.Point(594, 401);
            this.btnAns.Name = "btnAns";
            this.btnAns.Size = new System.Drawing.Size(194, 41);
            this.btnAns.TabIndex = 2;
            this.btnAns.Text = "Ответить";
            this.btnAns.UseVisualStyleBackColor = true;
            this.btnAns.Click += new System.EventHandler(this.btnAns_Click);
            // 
            // lbTextScore
            // 
            this.lbTextScore.AutoSize = true;
            this.lbTextScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTextScore.Location = new System.Drawing.Point(12, 9);
            this.lbTextScore.Name = "lbTextScore";
            this.lbTextScore.Size = new System.Drawing.Size(579, 39);
            this.lbTextScore.TabIndex = 3;
            this.lbTextScore.Text = "Количество правильных ответов";
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCount.Location = new System.Drawing.Point(597, 15);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(32, 33);
            this.lbCount.TabIndex = 4;
            this.lbCount.Text = "0";
            // 
            // FormPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.lbTextScore);
            this.Controls.Add(this.btnAns);
            this.Controls.Add(this.cboxTrue);
            this.Controls.Add(this.lbQuestion);
            this.Name = "FormPlay";
            this.Text = "FormPlay";
            this.Load += new System.EventHandler(this.FormPlay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbQuestion;
        private System.Windows.Forms.CheckBox cboxTrue;
        private System.Windows.Forms.Button btnAns;
        private System.Windows.Forms.Label lbTextScore;
        private System.Windows.Forms.Label lbCount;
    }
}