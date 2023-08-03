
namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Gc_Item = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Gc_ItemExam = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LblMainTitle = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.radioGroup2 = new DevExpress.XtraEditors.RadioGroup();
            this.Btn_Up = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_down = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Row_Ins = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Row_Add = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Row_Del = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Save = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.Gc_Item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gc_ItemExam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Gc_Item
            // 
            this.Gc_Item.Location = new System.Drawing.Point(0, 110);
            this.Gc_Item.MainView = this.gridView1;
            this.Gc_Item.Name = "Gc_Item";
            this.Gc_Item.Size = new System.Drawing.Size(435, 505);
            this.Gc_Item.TabIndex = 0;
            this.Gc_Item.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.Gc_Item;
            this.gridView1.Name = "gridView1";
            // 
            // Gc_ItemExam
            // 
            this.Gc_ItemExam.Location = new System.Drawing.Point(441, 110);
            this.Gc_ItemExam.MainView = this.gridView2;
            this.Gc_ItemExam.Name = "Gc_ItemExam";
            this.Gc_ItemExam.Size = new System.Drawing.Size(780, 505);
            this.Gc_ItemExam.TabIndex = 0;
            this.Gc_ItemExam.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.Gc_ItemExam;
            this.gridView2.Name = "gridView2";
            // 
            // LblMainTitle
            // 
            this.LblMainTitle.Appearance.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.LblMainTitle.Appearance.Options.UseFont = true;
            this.LblMainTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LblMainTitle.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.LblMainTitle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("LblMainTitle.ImageOptions.Image")));
            this.LblMainTitle.Location = new System.Drawing.Point(12, 12);
            this.LblMainTitle.Name = "LblMainTitle";
            this.LblMainTitle.Size = new System.Drawing.Size(300, 22);
            this.LblMainTitle.TabIndex = 60;
            this.LblMainTitle.Text = "품목별 검사유형정보";
            this.LblMainTitle.Click += new System.EventHandler(this.LblMainTitle_Click);
         
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "품목구분";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 37);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "검사구분";
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(88, 26);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Size = new System.Drawing.Size(342, 38);
            this.radioGroup1.TabIndex = 1;
            // 
            // radioGroup2
            // 
            this.radioGroup2.Location = new System.Drawing.Point(94, 26);
            this.radioGroup2.Name = "radioGroup2";
            this.radioGroup2.Size = new System.Drawing.Size(681, 38);
            this.radioGroup2.TabIndex = 1;
            // 
            // Btn_Up
            // 
            this.Btn_Up.Location = new System.Drawing.Point(5, 66);
            this.Btn_Up.Name = "Btn_Up";
            this.Btn_Up.Size = new System.Drawing.Size(86, 34);
            this.Btn_Up.TabIndex = 2;
            this.Btn_Up.Text = "simpleButton1";
            // 
            // Btn_down
            // 
            this.Btn_down.Location = new System.Drawing.Point(95, 66);
            this.Btn_down.Name = "Btn_down";
            this.Btn_down.Size = new System.Drawing.Size(86, 34);
            this.Btn_down.TabIndex = 2;
            this.Btn_down.Text = "simpleButton1";
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(235, 66);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(86, 34);
            this.Btn_Add.TabIndex = 2;
            this.Btn_Add.Text = "일괄추가";
            // 
            // Btn_Row_Ins
            // 
            this.Btn_Row_Ins.Location = new System.Drawing.Point(327, 66);
            this.Btn_Row_Ins.Name = "Btn_Row_Ins";
            this.Btn_Row_Ins.Size = new System.Drawing.Size(86, 34);
            this.Btn_Row_Ins.TabIndex = 2;
            this.Btn_Row_Ins.Text = "행삽입";
            // 
            // Btn_Row_Add
            // 
            this.Btn_Row_Add.Location = new System.Drawing.Point(419, 66);
            this.Btn_Row_Add.Name = "Btn_Row_Add";
            this.Btn_Row_Add.Size = new System.Drawing.Size(86, 34);
            this.Btn_Row_Add.TabIndex = 2;
            this.Btn_Row_Add.Text = "행추가";
            // 
            // Btn_Row_Del
            // 
            this.Btn_Row_Del.Location = new System.Drawing.Point(511, 65);
            this.Btn_Row_Del.Name = "Btn_Row_Del";
            this.Btn_Row_Del.Size = new System.Drawing.Size(86, 34);
            this.Btn_Row_Del.TabIndex = 2;
            this.Btn_Row_Del.Text = "행삭제";
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(603, 65);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(86, 34);
            this.Btn_Save.TabIndex = 2;
            this.Btn_Save.Text = "저장";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 614);
            this.Controls.Add(this.LblMainTitle);
            this.Controls.Add(this.Gc_ItemExam);
            this.Controls.Add(this.Gc_Item);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Gc_Item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gc_ItemExam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl Gc_Item;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl Gc_ItemExam;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.LabelControl LblMainTitle;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton Btn_Save;
        private DevExpress.XtraEditors.SimpleButton Btn_Row_Del;
        private DevExpress.XtraEditors.SimpleButton Btn_Row_Add;
        private DevExpress.XtraEditors.SimpleButton Btn_Row_Ins;
        private DevExpress.XtraEditors.SimpleButton Btn_Add;
        private DevExpress.XtraEditors.SimpleButton Btn_down;
        private DevExpress.XtraEditors.SimpleButton Btn_Up;
        private DevExpress.XtraEditors.RadioGroup radioGroup2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}

