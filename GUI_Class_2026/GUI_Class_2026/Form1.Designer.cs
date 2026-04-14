namespace GUI_Class_2026
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ClickMe = new System.Windows.Forms.Button();
            this.lab_ChangeLabel = new System.Windows.Forms.Label();
            this.btn_ChangeLabel = new System.Windows.Forms.Button();
            this.btn_counter = new System.Windows.Forms.Button();
            this.lab_counter = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "N12310008-蕭丞竣";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_ClickMe
            // 
            this.btn_ClickMe.Location = new System.Drawing.Point(14, 56);
            this.btn_ClickMe.Name = "btn_ClickMe";
            this.btn_ClickMe.Size = new System.Drawing.Size(256, 73);
            this.btn_ClickMe.TabIndex = 1;
            this.btn_ClickMe.Text = "按我一下";
            this.btn_ClickMe.UseVisualStyleBackColor = true;
            this.btn_ClickMe.Click += new System.EventHandler(this.btn_ClickMe_Click);
            // 
            // lab_ChangeLabel
            // 
            this.lab_ChangeLabel.AutoSize = true;
            this.lab_ChangeLabel.Font = new System.Drawing.Font("新細明體", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_ChangeLabel.Location = new System.Drawing.Point(165, 158);
            this.lab_ChangeLabel.Name = "lab_ChangeLabel";
            this.lab_ChangeLabel.Size = new System.Drawing.Size(101, 37);
            this.lab_ChangeLabel.TabIndex = 2;
            this.lab_ChangeLabel.Text = "label2";
            this.lab_ChangeLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_ChangeLabel
            // 
            this.btn_ChangeLabel.Location = new System.Drawing.Point(14, 158);
            this.btn_ChangeLabel.Name = "btn_ChangeLabel";
            this.btn_ChangeLabel.Size = new System.Drawing.Size(117, 40);
            this.btn_ChangeLabel.TabIndex = 3;
            this.btn_ChangeLabel.Text = "按我切換標籤";
            this.btn_ChangeLabel.UseVisualStyleBackColor = true;
            this.btn_ChangeLabel.Click += new System.EventHandler(this.btn_ChangeLabel_Click);
            // 
            // btn_counter
            // 
            this.btn_counter.Location = new System.Drawing.Point(18, 229);
            this.btn_counter.Name = "btn_counter";
            this.btn_counter.Size = new System.Drawing.Size(117, 40);
            this.btn_counter.TabIndex = 3;
            this.btn_counter.Text = "按我+1";
            this.btn_counter.UseVisualStyleBackColor = true;
            this.btn_counter.Click += new System.EventHandler(this.btn_counter_Click);
            // 
            // lab_counter
            // 
            this.lab_counter.AutoSize = true;
            this.lab_counter.Font = new System.Drawing.Font("新細明體", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_counter.Location = new System.Drawing.Point(169, 229);
            this.lab_counter.Name = "lab_counter";
            this.lab_counter.Size = new System.Drawing.Size(34, 37);
            this.lab_counter.TabIndex = 2;
            this.lab_counter.Text = "0";
            this.lab_counter.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "按我放大";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(543, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(545, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "按我複製至label";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(545, 172);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 519);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_counter);
            this.Controls.Add(this.btn_ChangeLabel);
            this.Controls.Add(this.lab_counter);
            this.Controls.Add(this.lab_ChangeLabel);
            this.Controls.Add(this.btn_ClickMe);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ClickMe;
        private System.Windows.Forms.Label lab_ChangeLabel;
        private System.Windows.Forms.Button btn_ChangeLabel;
        private System.Windows.Forms.Button btn_counter;
        private System.Windows.Forms.Label lab_counter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

