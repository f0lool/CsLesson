namespace Домашнее_Задание__7
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
            this.btnClick1 = new System.Windows.Forms.Button();
            this.btnClick2 = new System.Windows.Forms.Button();
            this.btnClick3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClick1
            // 
            this.btnClick1.Location = new System.Drawing.Point(508, 117);
            this.btnClick1.Name = "btnClick1";
            this.btnClick1.Size = new System.Drawing.Size(184, 53);
            this.btnClick1.TabIndex = 0;
            this.btnClick1.Text = "button1";
            this.btnClick1.UseVisualStyleBackColor = true;
            this.btnClick1.Click += new System.EventHandler(this.btnClick1_Click);
            // 
            // btnClick2
            // 
            this.btnClick2.Location = new System.Drawing.Point(508, 189);
            this.btnClick2.Name = "btnClick2";
            this.btnClick2.Size = new System.Drawing.Size(184, 53);
            this.btnClick2.TabIndex = 1;
            this.btnClick2.Text = "button2";
            this.btnClick2.UseVisualStyleBackColor = true;
            this.btnClick2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClick3
            // 
            this.btnClick3.Location = new System.Drawing.Point(508, 257);
            this.btnClick3.Name = "btnClick3";
            this.btnClick3.Size = new System.Drawing.Size(184, 53);
            this.btnClick3.TabIndex = 2;
            this.btnClick3.Text = "button3";
            this.btnClick3.UseVisualStyleBackColor = true;
            this.btnClick3.Click += new System.EventHandler(this.btnClick3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 397);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(152, 41);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "button1";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClick3);
            this.Controls.Add(this.btnClick2);
            this.Controls.Add(this.btnClick1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClick1;
        private System.Windows.Forms.Button btnClick2;
        private System.Windows.Forms.Button btnClick3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExit;
    }
}

