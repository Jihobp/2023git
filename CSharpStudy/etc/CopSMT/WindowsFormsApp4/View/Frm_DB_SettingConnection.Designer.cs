
namespace WindowsFormsApp4.View
{
    partial class Frm_DB_SettingConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DB_SettingConnection));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.PnlMainTitle = new DevExpress.XtraEditors.PanelControl();
            this.Btn_Test = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Cancle = new DevExpress.XtraEditors.SimpleButton();
            this.LblMainTitle = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtUrl = new DevExpress.XtraEditors.TextEdit();
            this.TxtDBName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PnlMainTitle)).BeginInit();
            this.PnlMainTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUrl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDBName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.TxtDBName);
            this.groupControl1.Controls.Add(this.TxtUrl);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(21, 86);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(550, 144);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "연결정보";
            // 
            // PnlMainTitle
            // 
            this.PnlMainTitle.Controls.Add(this.LblMainTitle);
            this.PnlMainTitle.Location = new System.Drawing.Point(21, 11);
            this.PnlMainTitle.Name = "PnlMainTitle";
            this.PnlMainTitle.Size = new System.Drawing.Size(550, 57);
            this.PnlMainTitle.TabIndex = 1;
            // 
            // Btn_Test
            // 
            this.Btn_Test.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Test.Appearance.Options.UseFont = true;
            this.Btn_Test.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Test.ImageOptions.Image")));
            this.Btn_Test.Location = new System.Drawing.Point(21, 251);
            this.Btn_Test.Name = "Btn_Test";
            this.Btn_Test.Size = new System.Drawing.Size(169, 50);
            this.Btn_Test.TabIndex = 2;
            this.Btn_Test.Text = "TEST";
            // 
            // Btn_Save
            // 
            this.Btn_Save.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save.Appearance.Options.UseFont = true;
            this.Btn_Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Save.ImageOptions.Image")));
            this.Btn_Save.Location = new System.Drawing.Point(207, 251);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(169, 50);
            this.Btn_Save.TabIndex = 2;
            this.Btn_Save.Text = "SAVE";
            // 
            // Btn_Cancle
            // 
            this.Btn_Cancle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancle.Appearance.Options.UseFont = true;
            this.Btn_Cancle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cancle.ImageOptions.Image")));
            this.Btn_Cancle.Location = new System.Drawing.Point(402, 251);
            this.Btn_Cancle.Name = "Btn_Cancle";
            this.Btn_Cancle.Size = new System.Drawing.Size(169, 50);
            this.Btn_Cancle.TabIndex = 2;
            this.Btn_Cancle.Text = "Cancle";
            // 
            // LblMainTitle
            // 
            this.LblMainTitle.Appearance.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LblMainTitle.Appearance.Options.UseFont = true;
            this.LblMainTitle.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.LblMainTitle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("LblMainTitle.ImageOptions.Image")));
            this.LblMainTitle.Location = new System.Drawing.Point(21, 10);
            this.LblMainTitle.Name = "LblMainTitle";
            this.LblMainTitle.Size = new System.Drawing.Size(120, 36);
            this.LblMainTitle.TabIndex = 0;
            this.LblMainTitle.Text = "연결 설정";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(21, 55);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(83, 25);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "연결 주소";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(21, 97);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(125, 25);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "DataBase 이름";
            // 
            // TxtUrl
            // 
            this.TxtUrl.Location = new System.Drawing.Point(186, 48);
            this.TxtUrl.Name = "TxtUrl";
            this.TxtUrl.Properties.Appearance.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUrl.Properties.Appearance.Options.UseFont = true;
            this.TxtUrl.Size = new System.Drawing.Size(329, 28);
            this.TxtUrl.TabIndex = 1;
            // 
            // TxtDBName
            // 
            this.TxtDBName.Location = new System.Drawing.Point(186, 96);
            this.TxtDBName.Name = "TxtDBName";
            this.TxtDBName.Properties.Appearance.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.TxtDBName.Properties.Appearance.Options.UseFont = true;
            this.TxtDBName.Size = new System.Drawing.Size(329, 28);
            this.TxtDBName.TabIndex = 1;
            // 
            // Frm_DB_SettingConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 318);
            this.Controls.Add(this.Btn_Cancle);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Btn_Test);
            this.Controls.Add(this.PnlMainTitle);
            this.Controls.Add(this.groupControl1);
            this.Name = "Frm_DB_SettingConnection";
            this.Text = "Frm_DB_SettingConnection";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PnlMainTitle)).EndInit();
            this.PnlMainTitle.ResumeLayout(false);
            this.PnlMainTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUrl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDBName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit TxtDBName;
        private DevExpress.XtraEditors.TextEdit TxtUrl;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl PnlMainTitle;
        private DevExpress.XtraEditors.LabelControl LblMainTitle;
        private DevExpress.XtraEditors.SimpleButton Btn_Test;
        private DevExpress.XtraEditors.SimpleButton Btn_Save;
        private DevExpress.XtraEditors.SimpleButton Btn_Cancle;
    }
}