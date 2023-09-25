
namespace WindowsFormsApp4.View
{
    partial class Frm_Login
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.Btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Login = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Setting = new DevExpress.XtraEditors.SimpleButton();
            this.Chk_SaveID = new DevExpress.XtraEditors.CheckEdit();
            this.Txt_ID = new DevExpress.XtraEditors.TextEdit();
            this.Txt_PW = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chk_SaveID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_PW.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.Btn_Exit);
            this.panelControl1.Controls.Add(this.Btn_Setting);
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(986, 51);
            this.panelControl1.TabIndex = 0;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.Btn_Exit.Location = new System.Drawing.Point(946, 10);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.Btn_Exit.Size = new System.Drawing.Size(35, 30);
            this.Btn_Exit.TabIndex = 0;
            // 
            // Btn_Login
            // 
            this.Btn_Login.Appearance.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Login.Appearance.Options.UseFont = true;
            this.Btn_Login.Location = new System.Drawing.Point(369, 425);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(246, 66);
            this.Btn_Login.TabIndex = 0;
            this.Btn_Login.Text = "LOGIN";
            // 
            // Btn_Setting
            // 
            this.Btn_Setting.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_Setting.Appearance.Options.UseForeColor = true;
            this.Btn_Setting.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Setting.ImageOptions.Image")));
            this.Btn_Setting.Location = new System.Drawing.Point(896, 10);
            this.Btn_Setting.Name = "Btn_Setting";
            this.Btn_Setting.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.Btn_Setting.Size = new System.Drawing.Size(35, 30);
            this.Btn_Setting.TabIndex = 0;
            // 
            // Chk_SaveID
            // 
            this.Chk_SaveID.Location = new System.Drawing.Point(445, 497);
            this.Chk_SaveID.Name = "Chk_SaveID";
            this.Chk_SaveID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chk_SaveID.Properties.Appearance.Options.UseFont = true;
            this.Chk_SaveID.Properties.Caption = "Check ID";
            this.Chk_SaveID.Size = new System.Drawing.Size(90, 22);
            this.Chk_SaveID.TabIndex = 1;
            // 
            // Txt_ID
            // 
            this.Txt_ID.Location = new System.Drawing.Point(369, 336);
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ID.Properties.Appearance.Options.UseFont = true;
            this.Txt_ID.Size = new System.Drawing.Size(246, 32);
            this.Txt_ID.TabIndex = 2;
            // 
            // Txt_PW
            // 
            this.Txt_PW.Location = new System.Drawing.Point(369, 379);
            this.Txt_PW.Name = "Txt_PW";
            this.Txt_PW.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_PW.Properties.Appearance.Options.UseFont = true;
            this.Txt_PW.Size = new System.Drawing.Size(246, 32);
            this.Txt_PW.TabIndex = 2;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.Txt_PW);
            this.Controls.Add(this.Txt_ID);
            this.Controls.Add(this.Chk_SaveID);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.panelControl1);
            this.Name = "Frm_Login";
            this.Size = new System.Drawing.Size(986, 548);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chk_SaveID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_PW.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton Btn_Exit;
        private DevExpress.XtraEditors.SimpleButton Btn_Setting;
        private DevExpress.XtraEditors.SimpleButton Btn_Login;
        private DevExpress.XtraEditors.CheckEdit Chk_SaveID;
        private DevExpress.XtraEditors.TextEdit Txt_ID;
        private DevExpress.XtraEditors.TextEdit Txt_PW;
    }
}
