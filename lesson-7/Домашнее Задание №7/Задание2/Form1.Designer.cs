namespace Задание2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbTextCount = new System.Windows.Forms.Label();
            this.lbTextNumber = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(579, 418);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(77, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbTextCount
            // 
            this.lbTextCount.AutoSize = true;
            this.lbTextCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTextCount.Location = new System.Drawing.Point(12, 9);
            this.lbTextCount.Name = "lbTextCount";
            this.lbTextCount.Size = new System.Drawing.Size(300, 31);
            this.lbTextCount.TabIndex = 1;
            this.lbTextCount.Text = "Количество попыток:";
            // 
            // lbTextNumber
            // 
            this.lbTextNumber.AutoSize = true;
            this.lbTextNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTextNumber.Location = new System.Drawing.Point(175, 413);
            this.lbTextNumber.Name = "lbTextNumber";
            this.lbTextNumber.Size = new System.Drawing.Size(381, 25);
            this.lbTextNumber.TabIndex = 2;
            this.lbTextNumber.Text = "Какое число загадал компьютер?";
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCount.Location = new System.Drawing.Point(306, 9);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(30, 31);
            this.lbCount.TabIndex = 3;
            this.lbCount.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(690, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Проверить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.lbTextNumber);
            this.Controls.Add(this.lbTextCount);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbTextCount;
        private System.Windows.Forms.Label lbTextNumber;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.Button button1;
    }
}

