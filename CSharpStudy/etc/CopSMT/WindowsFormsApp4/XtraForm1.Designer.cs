
using DevExpress.Utils.Layout;
using DevExpress.XtraDataLayout;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using System;

namespace WindowsFormsApp4
{
    partial class XtraForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraForm1));
            this.PnlMainTitle = new DevExpress.XtraEditors.PanelControl();
            this.LblMainTitle = new DevExpress.XtraEditors.LabelControl();
            this.Gc_Mold = new DevExpress.XtraGrid.GridControl();
            this.Gv_Mold = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_ExcelDown = new DevExpress.XtraEditors.SimpleButton();
            this.BtnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSave_Mold = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_MoldRow_Del = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_MoldRow_Add = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_MoldRow_Ins = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.Gc_MoldItem = new DevExpress.XtraGrid.GridControl();
            this.Gv_MoldItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.PnlMainTitle)).BeginInit();
            this.PnlMainTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gc_Mold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gv_Mold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gc_MoldItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gv_MoldItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlMainTitle
            // 
            this.PnlMainTitle.Controls.Add(this.LblMainTitle);
            this.PnlMainTitle.Location = new System.Drawing.Point(12, 11);
            this.PnlMainTitle.Name = "PnlMainTitle";
            this.PnlMainTitle.Size = new System.Drawing.Size(1256, 49);
            this.PnlMainTitle.TabIndex = 1;
            // 
            // LblMainTitle
            // 
            this.LblMainTitle.Appearance.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.LblMainTitle.Appearance.Options.UseFont = true;
            this.LblMainTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LblMainTitle.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.LblMainTitle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("LblMainTitle.ImageOptions.Image")));
            this.LblMainTitle.Location = new System.Drawing.Point(5, 6);
            this.LblMainTitle.Name = "LblMainTitle";
            this.LblMainTitle.Size = new System.Drawing.Size(175, 35);
            this.LblMainTitle.TabIndex = 0;
            this.LblMainTitle.Text = "금형정보";
            // 
            // Gc_Mold
            // 
            this.Gc_Mold.Location = new System.Drawing.Point(0, 53);
            this.Gc_Mold.MainView = this.Gv_Mold;
            this.Gc_Mold.Name = "Gc_Mold";
            this.Gc_Mold.Size = new System.Drawing.Size(1256, 196);
            this.Gc_Mold.TabIndex = 1;
            this.Gc_Mold.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.Gv_Mold});
            // 
            // Gv_Mold
            // 
            this.Gv_Mold.GridControl = this.Gc_Mold;
            this.Gv_Mold.Name = "Gv_Mold";
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.panelControl2);
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Controls.Add(this.groupControl4);
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Controls.Add(this.Gc_Mold);
            this.groupControl1.Location = new System.Drawing.Point(12, 66);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1256, 574);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "금형";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.simpleButton1);
            this.panelControl2.Controls.Add(this.simpleButton4);
            this.panelControl2.Controls.Add(this.simpleButton2);
            this.panelControl2.Controls.Add(this.simpleButton3);
            this.panelControl2.Location = new System.Drawing.Point(1, 250);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1255, 61);
            this.panelControl2.TabIndex = 310;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton1.Location = new System.Drawing.Point(5, 9);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(88, 38);
            this.simpleButton1.TabIndex = 305;
            this.simpleButton1.Text = "행삽입";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton4.Location = new System.Drawing.Point(282, 9);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(88, 38);
            this.simpleButton4.TabIndex = 308;
            this.simpleButton4.Text = "저  장";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton2.Location = new System.Drawing.Point(97, 9);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(88, 38);
            this.simpleButton2.TabIndex = 306;
            this.simpleButton2.Text = "행추가";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton3.Location = new System.Drawing.Point(189, 9);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(88, 38);
            this.simpleButton3.TabIndex = 307;
            this.simpleButton3.Text = "행삭제";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_ExcelDown);
            this.panelControl1.Controls.Add(this.BtnPrint);
            this.panelControl1.Controls.Add(this.BtnSave_Mold);
            this.panelControl1.Controls.Add(this.Btn_MoldRow_Del);
            this.panelControl1.Controls.Add(this.Btn_MoldRow_Add);
            this.panelControl1.Controls.Add(this.Btn_MoldRow_Ins);
            this.panelControl1.Location = new System.Drawing.Point(0, 26);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1256, 61);
            this.panelControl1.TabIndex = 4;
            // 
            // btn_ExcelDown
            // 
            this.btn_ExcelDown.Appearance.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExcelDown.Appearance.Options.UseFont = true;
            this.btn_ExcelDown.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ExcelDown.ImageOptions.Image")));
            this.btn_ExcelDown.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_ExcelDown.Location = new System.Drawing.Point(375, 5);
            this.btn_ExcelDown.Name = "btn_ExcelDown";
            this.btn_ExcelDown.Size = new System.Drawing.Size(94, 38);
            this.btn_ExcelDown.TabIndex = 309;
            this.btn_ExcelDown.Text = "엑셀다운";
            // 
            // BtnPrint
            // 
            this.BtnPrint.Appearance.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrint.Appearance.Options.UseFont = true;
            this.BtnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrint.ImageOptions.Image")));
            this.BtnPrint.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.BtnPrint.Location = new System.Drawing.Point(475, 5);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(140, 38);
            this.BtnPrint.TabIndex = 309;
            this.BtnPrint.Text = "금형관리대장";
            // 
            // BtnSave_Mold
            // 
            this.BtnSave_Mold.Appearance.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave_Mold.Appearance.Options.UseFont = true;
            this.BtnSave_Mold.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave_Mold.ImageOptions.Image")));
            this.BtnSave_Mold.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.BtnSave_Mold.Location = new System.Drawing.Point(282, 5);
            this.BtnSave_Mold.Name = "BtnSave_Mold";
            this.BtnSave_Mold.Size = new System.Drawing.Size(88, 38);
            this.BtnSave_Mold.TabIndex = 308;
            this.BtnSave_Mold.Text = "저  장";
            // 
            // Btn_MoldRow_Del
            // 
            this.Btn_MoldRow_Del.Appearance.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_MoldRow_Del.Appearance.Options.UseFont = true;
            this.Btn_MoldRow_Del.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_MoldRow_Del.ImageOptions.Image")));
            this.Btn_MoldRow_Del.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.Btn_MoldRow_Del.Location = new System.Drawing.Point(189, 5);
            this.Btn_MoldRow_Del.Name = "Btn_MoldRow_Del";
            this.Btn_MoldRow_Del.Size = new System.Drawing.Size(88, 38);
            this.Btn_MoldRow_Del.TabIndex = 307;
            this.Btn_MoldRow_Del.Text = "행삭제";
            // 
            // Btn_MoldRow_Add
            // 
            this.Btn_MoldRow_Add.Appearance.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_MoldRow_Add.Appearance.Options.UseFont = true;
            this.Btn_MoldRow_Add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_MoldRow_Add.ImageOptions.Image")));
            this.Btn_MoldRow_Add.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.Btn_MoldRow_Add.Location = new System.Drawing.Point(97, 5);
            this.Btn_MoldRow_Add.Name = "Btn_MoldRow_Add";
            this.Btn_MoldRow_Add.Size = new System.Drawing.Size(88, 38);
            this.Btn_MoldRow_Add.TabIndex = 306;
            this.Btn_MoldRow_Add.Text = "행추가";
            // 
            // Btn_MoldRow_Ins
            // 
            this.Btn_MoldRow_Ins.Appearance.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_MoldRow_Ins.Appearance.Options.UseFont = true;
            this.Btn_MoldRow_Ins.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_MoldRow_Ins.ImageOptions.Image")));
            this.Btn_MoldRow_Ins.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.Btn_MoldRow_Ins.Location = new System.Drawing.Point(5, 5);
            this.Btn_MoldRow_Ins.Name = "Btn_MoldRow_Ins";
            this.Btn_MoldRow_Ins.Size = new System.Drawing.Size(88, 38);
            this.Btn_MoldRow_Ins.TabIndex = 305;
            this.Btn_MoldRow_Ins.Text = "행삽입";
            // 
            // groupControl4
            // 
            this.groupControl4.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl4.CaptionImageOptions.Image")));
            this.groupControl4.Controls.Add(this.pictureEdit2);
            this.groupControl4.Location = new System.Drawing.Point(926, 310);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(330, 249);
            this.groupControl4.TabIndex = 2;
            this.groupControl4.Text = "이미지";
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.Location = new System.Drawing.Point(0, 22);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Size = new System.Drawing.Size(330, 226);
            this.pictureEdit2.TabIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl3.CaptionImageOptions.Image")));
            this.groupControl3.Controls.Add(this.pictureEdit1);
            this.groupControl3.Location = new System.Drawing.Point(589, 310);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(330, 249);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "이미지";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(0, 22);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(330, 226);
            this.pictureEdit1.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImageOptions.Image")));
            this.groupControl2.Controls.Add(this.Gc_MoldItem);
            this.groupControl2.Location = new System.Drawing.Point(1, 310);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(580, 249);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "금형 품목";
            // 
            // Gc_MoldItem
            // 
            this.Gc_MoldItem.Location = new System.Drawing.Point(-1, 23);
            this.Gc_MoldItem.MainView = this.Gv_MoldItem;
            this.Gc_MoldItem.Name = "Gc_MoldItem";
            this.Gc_MoldItem.Size = new System.Drawing.Size(580, 226);
            this.Gc_MoldItem.TabIndex = 1;
            this.Gc_MoldItem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.Gv_MoldItem});
            // 
            // Gv_MoldItem
            // 
            this.Gv_MoldItem.GridControl = this.Gc_MoldItem;
            this.Gv_MoldItem.Name = "Gv_MoldItem";
            // 
            // tablePanel1
            // 
            this.tablePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F)});
            this.tablePanel1.Controls.Add(this.dataLayoutControl1);
            this.tablePanel1.Location = new System.Drawing.Point(12, 673);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(1256, 249);
            this.tablePanel1.TabIndex = 1;
            // 
            // dataLayoutControl1
            // 
            this.tablePanel1.SetColumn(this.dataLayoutControl1, 1);
            this.dataLayoutControl1.Location = new System.Drawing.Point(108, 3);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.tablePanel1.SetRow(this.dataLayoutControl1, 0);
            this.dataLayoutControl1.Size = new System.Drawing.Size(1145, 20);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1145, 20);
            this.Root.TextVisible = false;
            // 
            // XtraForm1
            // 
            this.ClientSize = new System.Drawing.Size(1331, 734);
            this.Controls.Add(this.tablePanel1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.PnlMainTitle);
            this.Name = "XtraForm1";
            ((System.ComponentModel.ISupportInitialize)(this.PnlMainTitle)).EndInit();
            this.PnlMainTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Gc_Mold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gv_Mold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Gc_MoldItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gv_MoldItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            this.ResumeLayout(false);

        }

        private void Btn_ItemRow_Del_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private PanelControl PnlMainTitle;
        private DevExpress.XtraEditors.LabelControl LblMainTitle;
        private DevExpress.XtraGrid.GridControl Gc_Mold;
        private DevExpress.XtraGrid.Views.Grid.GridView Gv_Mold;
        private GroupControl groupControl1;
        private GroupControl groupControl4;
        private GroupControl groupControl3;
        private GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl Gc_MoldItem;
        private DevExpress.XtraGrid.Views.Grid.GridView Gv_MoldItem;
        private PanelControl panelControl1;
        private PictureEdit pictureEdit2;
        private PictureEdit pictureEdit1;
        private TablePanel tablePanel1;
        private DataLayoutControl dataLayoutControl1;
        private LayoutControlGroup Root;
        private SimpleButton btn_ExcelDown;
        private SimpleButton BtnPrint;
        private SimpleButton BtnSave_Mold;
        private SimpleButton Btn_MoldRow_Del;
        private SimpleButton Btn_MoldRow_Add;
        private SimpleButton Btn_MoldRow_Ins;
        private PanelControl panelControl2;
        private SimpleButton simpleButton1;
        private SimpleButton simpleButton4;
        private SimpleButton simpleButton2;
        private SimpleButton simpleButton3;
    }
}