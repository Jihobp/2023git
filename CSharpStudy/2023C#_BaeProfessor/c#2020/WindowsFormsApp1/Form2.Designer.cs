
namespace WindowsFormsApp1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text상품명 = new System.Windows.Forms.TextBox();
            this.text단가 = new System.Windows.Forms.TextBox();
            this.text금액 = new System.Windows.Forms.TextBox();
            this.text수량 = new System.Windows.Forms.TextBox();
            this.CalculBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "상품명";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "단가";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "수량";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(530, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "금액";
            // 
            // text상품명
            // 
            this.text상품명.Location = new System.Drawing.Point(86, 155);
            this.text상품명.Name = "text상품명";
            this.text상품명.Size = new System.Drawing.Size(100, 21);
            this.text상품명.TabIndex = 4;
            // 
            // text단가
            // 
            this.text단가.Location = new System.Drawing.Point(224, 155);
            this.text단가.Name = "text단가";
            this.text단가.Size = new System.Drawing.Size(100, 21);
            this.text단가.TabIndex = 5;
            // 
            // text금액
            // 
            this.text금액.Location = new System.Drawing.Point(505, 155);
            this.text금액.Name = "text금액";
            this.text금액.Size = new System.Drawing.Size(100, 21);
            this.text금액.TabIndex = 7;
            // 
            // text수량
            // 
            this.text수량.Location = new System.Drawing.Point(367, 155);
            this.text수량.Name = "text수량";
            this.text수량.Size = new System.Drawing.Size(100, 21);
            this.text수량.TabIndex = 6;
            // 
            // CalculBtn
            // 
            this.CalculBtn.Location = new System.Drawing.Point(634, 108);
            this.CalculBtn.Name = "CalculBtn";
            this.CalculBtn.Size = new System.Drawing.Size(114, 68);
            this.CalculBtn.TabIndex = 8;
            this.CalculBtn.Text = "계산하기";
            this.CalculBtn.UseVisualStyleBackColor = true;
            this.CalculBtn.Click += new System.EventHandler(this.CalculBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CalculBtn);
            this.Controls.Add(this.text금액);
            this.Controls.Add(this.text수량);
            this.Controls.Add(this.text단가);
            this.Controls.Add(this.text상품명);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text상품명;
        private System.Windows.Forms.TextBox text단가;
        private System.Windows.Forms.TextBox text금액;
        private System.Windows.Forms.TextBox text수량;
        private System.Windows.Forms.Button CalculBtn;
    }
}