
namespace _15.Training_PatientManagement
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
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblCount = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblRow = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("나눔고딕 에코", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Location = new System.Drawing.Point(16, 435);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(825, 82);
            this.button5.TabIndex = 34;
            this.button5.Text = "Select";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(392, 375);
            this.dataGridView1.TabIndex = 37;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("나눔고딕 에코", 15.75F);
            this.lblCount.Location = new System.Drawing.Point(12, 404);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(90, 24);
            this.lblCount.TabIndex = 38;
            this.lblCount.Text = "숫자조회";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(410, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(431, 124);
            this.listBox1.TabIndex = 39;
            // 
            // lblRow
            // 
            this.lblRow.AutoSize = true;
            this.lblRow.Font = new System.Drawing.Font("나눔고딕 에코", 15.75F);
            this.lblRow.Location = new System.Drawing.Point(157, 402);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(90, 24);
            this.lblRow.TabIndex = 40;
            this.lblRow.Text = "숫자조회";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("나눔고딕 에코", 15.75F);
            this.lblData.Location = new System.Drawing.Point(302, 402);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(90, 24);
            this.lblData.TabIndex = 41;
            this.lblData.Text = "숫자조회";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(410, 138);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(431, 124);
            this.listBox2.TabIndex = 42;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 12;
            this.listBox3.Location = new System.Drawing.Point(410, 263);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(431, 124);
            this.listBox3.TabIndex = 43;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 529);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblRow);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblRow;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
    }
}