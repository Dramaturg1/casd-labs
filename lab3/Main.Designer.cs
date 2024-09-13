namespace lab3
{
    partial class Main
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(338, 93);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сортировка массивов случайных чисел по модулям 10, 1000, 10^5, 10^7, 10^9\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(91, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(338, 93);
            this.button2.TabIndex = 2;
            this.button2.Text = "Сортировка массивов, разбитых на несколько отсортированных подмассивов разного ра" +
    "змера";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(91, 301);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(338, 93);
            this.button3.TabIndex = 3;
            this.button3.Text = "Сортировка изначально отсортированных массивов случайных чисел с некоторым числом" +
    "\r\nперестановок двух случайных элементов";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(91, 433);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(338, 93);
            this.button4.TabIndex = 4;
            this.button4.Text = "Сортировка полностью отсортированных массивов, с\r\nнесколькими заменёнными элемент" +
    "ами,с большим количеством\r\nповторений одного элемента";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 570);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

