
namespace _7_2_Excel_Data_Integrations
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
            this.btnExcelLoad = new System.Windows.Forms.Button();
            this.btnExcelSave = new System.Windows.Forms.Button();
            this.myListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnExcelLoad
            // 
            this.btnExcelLoad.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnExcelLoad.Location = new System.Drawing.Point(26, 12);
            this.btnExcelLoad.Name = "btnExcelLoad";
            this.btnExcelLoad.Size = new System.Drawing.Size(371, 68);
            this.btnExcelLoad.TabIndex = 0;
            this.btnExcelLoad.Text = "엑셀 파일 불러오기";
            this.btnExcelLoad.UseVisualStyleBackColor = true;
            this.btnExcelLoad.Click += new System.EventHandler(this.btnExcelLoad_Click);
            // 
            // btnExcelSave
            // 
            this.btnExcelSave.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold);
            this.btnExcelSave.Location = new System.Drawing.Point(403, 12);
            this.btnExcelSave.Name = "btnExcelSave";
            this.btnExcelSave.Size = new System.Drawing.Size(371, 68);
            this.btnExcelSave.TabIndex = 0;
            this.btnExcelSave.Text = "엑셀 파일 저장하기";
            this.btnExcelSave.UseVisualStyleBackColor = true;
            this.btnExcelSave.Click += new System.EventHandler(this.btnExcelSave_Click);
            // 
            // myListView
            // 
            this.myListView.FullRowSelect = true;
            this.myListView.GridLines = true;
            this.myListView.HideSelection = false;
            this.myListView.Location = new System.Drawing.Point(26, 103);
            this.myListView.Name = "myListView";
            this.myListView.Size = new System.Drawing.Size(748, 320);
            this.myListView.TabIndex = 1;
            this.myListView.UseCompatibleStateImageBehavior = false;
            this.myListView.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.myListView);
            this.Controls.Add(this.btnExcelSave);
            this.Controls.Add(this.btnExcelLoad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExcelLoad;
        private System.Windows.Forms.Button btnExcelSave;
        private System.Windows.Forms.ListView myListView;
    }
}

