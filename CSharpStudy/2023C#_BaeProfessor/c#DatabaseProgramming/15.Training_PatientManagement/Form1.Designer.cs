
namespace _15.Training_PatientManagement
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textChartNo = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textIDNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textZipCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textGender = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("나눔고딕 에코", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(1, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 82);
            this.button1.TabIndex = 0;
            this.button1.Text = "c-insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕 에코", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(-2, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕 에코", 15.75F);
            this.label2.Location = new System.Drawing.Point(249, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "환자번호";
            // 
            // textChartNo
            // 
            this.textChartNo.Font = new System.Drawing.Font("나눔고딕 에코", 15.75F);
            this.textChartNo.Location = new System.Drawing.Point(387, 38);
            this.textChartNo.Name = "textChartNo";
            this.textChartNo.Size = new System.Drawing.Size(110, 32);
            this.textChartNo.TabIndex = 3;
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("나눔고딕 에코", 15.75F);
            this.textName.Location = new System.Drawing.Point(387, 93);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(230, 32);
            this.textName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕 에코", 15.75F);
            this.label3.Location = new System.Drawing.Point(249, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "환자이름";
            // 
            // textIDNumber
            // 
            this.textIDNumber.Font = new System.Drawing.Font("나눔고딕 에코", 15.75F);
            this.textIDNumber.Location = new System.Drawing.Point(387, 148);
            this.textIDNumber.Name = "textIDNumber";
            this.textIDNumber.Size = new System.Drawing.Size(230, 32);
            this.textIDNumber.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕 에코", 15.75F);
            this.label4.Location = new System.Drawing.Point(249, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "주민등록번호";
            // 
            // textZipCode
            // 
            this.textZipCode.Font = new System.Drawing.Font("나눔고딕 에코", 15.75F);
            this.textZipCode.Location = new System.Drawing.Point(387, 207);
            this.textZipCode.Name = "textZipCode";
            this.textZipCode.Size = new System.Drawing.Size(230, 32);
            this.textZipCode.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕 에코", 15.75F);
            this.label5.Location = new System.Drawing.Point(249, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "우편번호";
            // 
            // textAddress
            // 
            this.textAddress.Font = new System.Drawing.Font("나눔고딕 에코", 15.75F);
            this.textAddress.Location = new System.Drawing.Point(387, 265);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(230, 32);
            this.textAddress.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕 에코", 15.75F);
            this.label6.Location = new System.Drawing.Point(249, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "주소";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("나눔고딕 에코", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(145, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 82);
            this.button2.TabIndex = 12;
            this.button2.Text = "Insert";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("나눔고딕 에코", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(322, 405);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 82);
            this.button3.TabIndex = 13;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textGender
            // 
            this.textGender.Font = new System.Drawing.Font("나눔고딕 에코", 15.75F);
            this.textGender.Location = new System.Drawing.Point(387, 322);
            this.textGender.Name = "textGender";
            this.textGender.Size = new System.Drawing.Size(230, 32);
            this.textGender.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔고딕 에코", 15.75F);
            this.label7.Location = new System.Drawing.Point(249, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "성별";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("나눔고딕 에코", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Location = new System.Drawing.Point(499, 405);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 82);
            this.button4.TabIndex = 16;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(683, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(431, 364);
            this.listBox1.TabIndex = 17;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("나눔고딕 에코", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Location = new System.Drawing.Point(683, 408);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 82);
            this.button5.TabIndex = 16;
            this.button5.Text = "Select";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("나눔고딕 에코", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.Location = new System.Drawing.Point(514, 38);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(103, 32);
            this.button6.TabIndex = 18;
            this.button6.Text = "환자조회";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 504);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textGender);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textZipCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textIDNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textChartNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textChartNo;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textIDNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textZipCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textGender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

