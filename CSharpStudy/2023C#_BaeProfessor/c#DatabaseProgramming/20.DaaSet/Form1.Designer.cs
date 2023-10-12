
namespace _20.DaaSet
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label chartNoLabel;
            System.Windows.Forms.Label patientNameLabel;
            System.Windows.Forms.Label iDNumLabel;
            System.Windows.Forms.Label birthdayTypeLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label telephoneLabel;
            System.Windows.Forms.Label cellphoneLabel;
            System.Windows.Forms.Label zipCodeLabel;
            System.Windows.Forms.Label detailAddressLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label dCCodeLabel;
            System.Windows.Forms.Label foreignLabel;
            System.Windows.Forms.Label snsYnLabel;
            System.Windows.Forms.Label remarkLabel;
            System.Windows.Forms.Label insuCodeLabel;
            System.Windows.Forms.Label insuNoLabel;
            System.Windows.Forms.Label companyNameLabel;
            System.Windows.Forms.Label startDateLabel;
            System.Windows.Forms.Label relCodeLabel;
            System.Windows.Forms.Label masterNameLabel;
            this.chartNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.patientNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.iDNumTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.birthdayDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.telephoneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.cellphoneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.zipCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.zipSeqSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.addressTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.detailAddressTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.emailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dCCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.remarkTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.patientDataGridView = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.cboBirthdayType = new System.Windows.Forms.ComboBox();
            this.cboForeign = new System.Windows.Forms.ComboBox();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new _20.DaaSet.DataSet1();
            this.patientTableAdapter = new _20.DaaSet.DataSet1TableAdapters.PatientTableAdapter();
            this.patientInsuranceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientInsuranceTableAdapter = new _20.DaaSet.DataSet1TableAdapters.PatientInsuranceTableAdapter();
            this.tableAdapterManager = new _20.DaaSet.DataSet1TableAdapters.TableAdapterManager();
            this.patientInsuranceDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insuCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.seqSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.insuNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.companyCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.companyNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.relCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.masterNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.titleTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.insuNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.cboSns = new System.Windows.Forms.ComboBox();
            this.colChartNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            chartNoLabel = new System.Windows.Forms.Label();
            patientNameLabel = new System.Windows.Forms.Label();
            iDNumLabel = new System.Windows.Forms.Label();
            birthdayTypeLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            telephoneLabel = new System.Windows.Forms.Label();
            cellphoneLabel = new System.Windows.Forms.Label();
            zipCodeLabel = new System.Windows.Forms.Label();
            detailAddressLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            dCCodeLabel = new System.Windows.Forms.Label();
            foreignLabel = new System.Windows.Forms.Label();
            snsYnLabel = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            insuCodeLabel = new System.Windows.Forms.Label();
            insuNoLabel = new System.Windows.Forms.Label();
            companyNameLabel = new System.Windows.Forms.Label();
            startDateLabel = new System.Windows.Forms.Label();
            relCodeLabel = new System.Windows.Forms.Label();
            masterNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDNumTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellphoneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zipCodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zipSeqSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailAddressTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dCCodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientInsuranceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientInsuranceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insuCodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seqSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insuNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyCodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relCodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insuNameTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // chartNoLabel
            // 
            chartNoLabel.AutoSize = true;
            chartNoLabel.Location = new System.Drawing.Point(12, 88);
            chartNoLabel.Name = "chartNoLabel";
            chartNoLabel.Size = new System.Drawing.Size(53, 12);
            chartNoLabel.TabIndex = 2;
            chartNoLabel.Text = "환자번호";
            // 
            // patientNameLabel
            // 
            patientNameLabel.AutoSize = true;
            patientNameLabel.Location = new System.Drawing.Point(338, 86);
            patientNameLabel.Name = "patientNameLabel";
            patientNameLabel.Size = new System.Drawing.Size(53, 12);
            patientNameLabel.TabIndex = 4;
            patientNameLabel.Text = "환자이름";
            // 
            // iDNumLabel
            // 
            iDNumLabel.AutoSize = true;
            iDNumLabel.Location = new System.Drawing.Point(12, 117);
            iDNumLabel.Name = "iDNumLabel";
            iDNumLabel.Size = new System.Drawing.Size(77, 12);
            iDNumLabel.TabIndex = 6;
            iDNumLabel.Text = "주민등록번호";
            // 
            // birthdayTypeLabel
            // 
            birthdayTypeLabel.AutoSize = true;
            birthdayTypeLabel.Location = new System.Drawing.Point(12, 143);
            birthdayTypeLabel.Name = "birthdayTypeLabel";
            birthdayTypeLabel.Size = new System.Drawing.Size(53, 12);
            birthdayTypeLabel.TabIndex = 8;
            birthdayTypeLabel.Text = "생일유형";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(336, 146);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(53, 12);
            birthdayLabel.TabIndex = 10;
            birthdayLabel.Text = "생년월일";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(338, 112);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(29, 12);
            genderLabel.TabIndex = 12;
            genderLabel.Text = "성별";
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Location = new System.Drawing.Point(12, 170);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(53, 12);
            telephoneLabel.TabIndex = 14;
            telephoneLabel.Text = "전화번호";
            // 
            // cellphoneLabel
            // 
            cellphoneLabel.AutoSize = true;
            cellphoneLabel.Location = new System.Drawing.Point(338, 170);
            cellphoneLabel.Name = "cellphoneLabel";
            cellphoneLabel.Size = new System.Drawing.Size(65, 12);
            cellphoneLabel.TabIndex = 16;
            cellphoneLabel.Text = "핸드폰번호";
            // 
            // zipCodeLabel
            // 
            zipCodeLabel.AutoSize = true;
            zipCodeLabel.Location = new System.Drawing.Point(10, 207);
            zipCodeLabel.Name = "zipCodeLabel";
            zipCodeLabel.Size = new System.Drawing.Size(53, 12);
            zipCodeLabel.TabIndex = 18;
            zipCodeLabel.Text = "우편번호";
            // 
            // detailAddressLabel
            // 
            detailAddressLabel.AutoSize = true;
            detailAddressLabel.Location = new System.Drawing.Point(12, 237);
            detailAddressLabel.Name = "detailAddressLabel";
            detailAddressLabel.Size = new System.Drawing.Size(53, 12);
            detailAddressLabel.TabIndex = 24;
            detailAddressLabel.Text = "상세주소";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(12, 271);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(41, 12);
            emailLabel.TabIndex = 26;
            emailLabel.Text = "이메일";
            // 
            // dCCodeLabel
            // 
            dCCodeLabel.AutoSize = true;
            dCCodeLabel.Location = new System.Drawing.Point(336, 266);
            dCCodeLabel.Name = "dCCodeLabel";
            dCCodeLabel.Size = new System.Drawing.Size(53, 12);
            dCCodeLabel.TabIndex = 32;
            dCCodeLabel.Text = "할인유형";
            // 
            // foreignLabel
            // 
            foreignLabel.AutoSize = true;
            foreignLabel.Location = new System.Drawing.Point(12, 305);
            foreignLabel.Name = "foreignLabel";
            foreignLabel.Size = new System.Drawing.Size(69, 12);
            foreignLabel.TabIndex = 34;
            foreignLabel.Text = "외국인 유무";
            // 
            // snsYnLabel
            // 
            snsYnLabel.AutoSize = true;
            snsYnLabel.Location = new System.Drawing.Point(336, 305);
            snsYnLabel.Name = "snsYnLabel";
            snsYnLabel.Size = new System.Drawing.Size(77, 12);
            snsYnLabel.TabIndex = 36;
            snsYnLabel.Text = "문자전송유무";
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(12, 336);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(53, 12);
            remarkLabel.TabIndex = 38;
            remarkLabel.Text = "참고사항";
            // 
            // chartNoTextEdit
            // 
            this.chartNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.patientBindingSource, "ChartNo", true));
            this.chartNoTextEdit.Location = new System.Drawing.Point(109, 85);
            this.chartNoTextEdit.Name = "chartNoTextEdit";
            this.chartNoTextEdit.Size = new System.Drawing.Size(204, 20);
            this.chartNoTextEdit.TabIndex = 3;
            // 
            // patientNameTextEdit
            // 
            this.patientNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.patientBindingSource, "PatientName", true));
            this.patientNameTextEdit.Location = new System.Drawing.Point(423, 80);
            this.patientNameTextEdit.Name = "patientNameTextEdit";
            this.patientNameTextEdit.Size = new System.Drawing.Size(204, 20);
            this.patientNameTextEdit.TabIndex = 5;
            // 
            // iDNumTextEdit
            // 
            this.iDNumTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.patientBindingSource, "IDNum", true));
            this.iDNumTextEdit.Location = new System.Drawing.Point(109, 114);
            this.iDNumTextEdit.Name = "iDNumTextEdit";
            this.iDNumTextEdit.Size = new System.Drawing.Size(204, 20);
            this.iDNumTextEdit.TabIndex = 7;
            // 
            // birthdayDateEdit
            // 
            this.birthdayDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.patientBindingSource, "Birthday", true));
            this.birthdayDateEdit.EditValue = null;
            this.birthdayDateEdit.Location = new System.Drawing.Point(423, 140);
            this.birthdayDateEdit.Name = "birthdayDateEdit";
            this.birthdayDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.birthdayDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.birthdayDateEdit.Size = new System.Drawing.Size(204, 20);
            this.birthdayDateEdit.TabIndex = 11;
            // 
            // telephoneTextEdit
            // 
            this.telephoneTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.patientBindingSource, "Telephone", true));
            this.telephoneTextEdit.Location = new System.Drawing.Point(109, 167);
            this.telephoneTextEdit.Name = "telephoneTextEdit";
            this.telephoneTextEdit.Size = new System.Drawing.Size(204, 20);
            this.telephoneTextEdit.TabIndex = 15;
            // 
            // cellphoneTextEdit
            // 
            this.cellphoneTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.patientBindingSource, "Cellphone", true));
            this.cellphoneTextEdit.Location = new System.Drawing.Point(423, 164);
            this.cellphoneTextEdit.Name = "cellphoneTextEdit";
            this.cellphoneTextEdit.Size = new System.Drawing.Size(204, 20);
            this.cellphoneTextEdit.TabIndex = 17;
            // 
            // zipCodeTextEdit
            // 
            this.zipCodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.patientBindingSource, "ZipCode", true));
            this.zipCodeTextEdit.Location = new System.Drawing.Point(109, 204);
            this.zipCodeTextEdit.Name = "zipCodeTextEdit";
            this.zipCodeTextEdit.Size = new System.Drawing.Size(95, 20);
            this.zipCodeTextEdit.TabIndex = 19;
            // 
            // zipSeqSpinEdit
            // 
            this.zipSeqSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.patientBindingSource, "ZipSeq", true));
            this.zipSeqSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.zipSeqSpinEdit.Location = new System.Drawing.Point(213, 204);
            this.zipSeqSpinEdit.Name = "zipSeqSpinEdit";
            this.zipSeqSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.zipSeqSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.zipSeqSpinEdit.TabIndex = 21;
            // 
            // addressTextEdit
            // 
            this.addressTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.patientBindingSource, "Address", true));
            this.addressTextEdit.Location = new System.Drawing.Point(338, 204);
            this.addressTextEdit.Name = "addressTextEdit";
            this.addressTextEdit.Size = new System.Drawing.Size(289, 20);
            this.addressTextEdit.TabIndex = 23;
            // 
            // detailAddressTextEdit
            // 
            this.detailAddressTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.patientBindingSource, "DetailAddress", true));
            this.detailAddressTextEdit.Location = new System.Drawing.Point(109, 234);
            this.detailAddressTextEdit.Name = "detailAddressTextEdit";
            this.detailAddressTextEdit.Size = new System.Drawing.Size(518, 20);
            this.detailAddressTextEdit.TabIndex = 25;
            // 
            // emailTextEdit
            // 
            this.emailTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.patientBindingSource, "Email", true));
            this.emailTextEdit.Location = new System.Drawing.Point(109, 263);
            this.emailTextEdit.Name = "emailTextEdit";
            this.emailTextEdit.Size = new System.Drawing.Size(204, 20);
            this.emailTextEdit.TabIndex = 27;
            // 
            // dCCodeTextEdit
            // 
            this.dCCodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.patientBindingSource, "DCCode", true));
            this.dCCodeTextEdit.Location = new System.Drawing.Point(423, 261);
            this.dCCodeTextEdit.Name = "dCCodeTextEdit";
            this.dCCodeTextEdit.Size = new System.Drawing.Size(204, 20);
            this.dCCodeTextEdit.TabIndex = 33;
            // 
            // remarkTextEdit
            // 
            this.remarkTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.patientBindingSource, "Remark", true));
            this.remarkTextEdit.Location = new System.Drawing.Point(109, 333);
            this.remarkTextEdit.Name = "remarkTextEdit";
            this.remarkTextEdit.Properties.AutoHeight = false;
            this.remarkTextEdit.Size = new System.Drawing.Size(518, 67);
            this.remarkTextEdit.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(301, 35);
            this.button1.TabIndex = 42;
            this.button1.Text = "저장";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // patientDataGridView
            // 
            this.patientDataGridView.AutoGenerateColumns = false;
            this.patientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChartNo,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.colGender,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20});
            this.patientDataGridView.DataSource = this.patientBindingSource;
            this.patientDataGridView.Location = new System.Drawing.Point(645, 12);
            this.patientDataGridView.Name = "patientDataGridView";
            this.patientDataGridView.RowTemplate.Height = 23;
            this.patientDataGridView.Size = new System.Drawing.Size(577, 266);
            this.patientDataGridView.TabIndex = 42;
            this.patientDataGridView.SelectionChanged += new System.EventHandler(this.patientDataGridView_SelectionChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(615, 35);
            this.button2.TabIndex = 43;
            this.button2.Text = "신규환자등록";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(324, 416);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(301, 35);
            this.button3.TabIndex = 44;
            this.button3.Text = "삭제";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cboGender
            // 
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "남자",
            "여자"});
            this.cboGender.Location = new System.Drawing.Point(423, 112);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(204, 20);
            this.cboGender.TabIndex = 45;
            // 
            // cboBirthdayType
            // 
            this.cboBirthdayType.FormattingEnabled = true;
            this.cboBirthdayType.Location = new System.Drawing.Point(109, 140);
            this.cboBirthdayType.Name = "cboBirthdayType";
            this.cboBirthdayType.Size = new System.Drawing.Size(204, 20);
            this.cboBirthdayType.TabIndex = 46;
            // 
            // cboForeign
            // 
            this.cboForeign.FormattingEnabled = true;
            this.cboForeign.Items.AddRange(new object[] {
            "외국인",
            "내국인"});
            this.cboForeign.Location = new System.Drawing.Point(109, 303);
            this.cboForeign.Name = "cboForeign";
            this.cboForeign.Size = new System.Drawing.Size(204, 20);
            this.cboForeign.TabIndex = 47;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // patientInsuranceBindingSource
            // 
            this.patientInsuranceBindingSource.DataMember = "PatientInsurance";
            this.patientInsuranceBindingSource.DataSource = this.dataSet1;
            // 
            // patientInsuranceTableAdapter
            // 
            this.patientInsuranceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PatientInsuranceTableAdapter = this.patientInsuranceTableAdapter;
            this.tableAdapterManager.PatientTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = _20.DaaSet.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // patientInsuranceDataGridView
            // 
            this.patientInsuranceDataGridView.AutoGenerateColumns = false;
            this.patientInsuranceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientInsuranceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn34,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn33,
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32});
            this.patientInsuranceDataGridView.DataSource = this.patientInsuranceBindingSource;
            this.patientInsuranceDataGridView.Location = new System.Drawing.Point(645, 289);
            this.patientInsuranceDataGridView.Name = "patientInsuranceDataGridView";
            this.patientInsuranceDataGridView.RowTemplate.Height = 23;
            this.patientInsuranceDataGridView.Size = new System.Drawing.Size(577, 258);
            this.patientInsuranceDataGridView.TabIndex = 47;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "ChartNo";
            this.dataGridViewTextBoxColumn21.HeaderText = "ChartNo";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "InsuCode";
            this.dataGridViewTextBoxColumn22.HeaderText = "InsuCode";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "InsuName";
            this.dataGridViewTextBoxColumn34.HeaderText = "InsuName";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "Seq";
            this.dataGridViewTextBoxColumn23.HeaderText = "Seq";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "InsuNo";
            this.dataGridViewTextBoxColumn24.HeaderText = "InsuNo";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "CompanyCode";
            this.dataGridViewTextBoxColumn25.HeaderText = "CompanyCode";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "CompanyName";
            this.dataGridViewTextBoxColumn26.HeaderText = "CompanyName";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "StartDate";
            this.dataGridViewTextBoxColumn27.HeaderText = "StartDate";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "EndDate";
            this.dataGridViewTextBoxColumn28.HeaderText = "EndDate";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "RelCode";
            this.dataGridViewTextBoxColumn29.HeaderText = "RelCode";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.Visible = false;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn33.HeaderText = "Title";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "MasterName";
            this.dataGridViewTextBoxColumn30.HeaderText = "MasterName";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "CarNo";
            this.dataGridViewTextBoxColumn31.HeaderText = "CarNo";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "TaAcceptNo";
            this.dataGridViewTextBoxColumn32.HeaderText = "TaAcceptNo";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            // 
            // insuCodeLabel
            // 
            insuCodeLabel.AutoSize = true;
            insuCodeLabel.Location = new System.Drawing.Point(20, 472);
            insuCodeLabel.Name = "insuCodeLabel";
            insuCodeLabel.Size = new System.Drawing.Size(53, 12);
            insuCodeLabel.TabIndex = 49;
            insuCodeLabel.Text = "보험유형";
            // 
            // insuCodeTextEdit
            // 
            this.insuCodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.patientInsuranceBindingSource, "InsuCode", true));
            this.insuCodeTextEdit.Location = new System.Drawing.Point(134, 466);
            this.insuCodeTextEdit.Name = "insuCodeTextEdit";
            this.insuCodeTextEdit.Size = new System.Drawing.Size(229, 20);
            this.insuCodeTextEdit.TabIndex = 50;
            // 
            // seqSpinEdit
            // 
            this.seqSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.patientInsuranceBindingSource, "Seq", true));
            this.seqSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seqSpinEdit.Location = new System.Drawing.Point(396, 492);
            this.seqSpinEdit.Name = "seqSpinEdit";
            this.seqSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seqSpinEdit.Size = new System.Drawing.Size(229, 20);
            this.seqSpinEdit.TabIndex = 52;
            // 
            // insuNoLabel
            // 
            insuNoLabel.AutoSize = true;
            insuNoLabel.Location = new System.Drawing.Point(20, 500);
            insuNoLabel.Name = "insuNoLabel";
            insuNoLabel.Size = new System.Drawing.Size(89, 12);
            insuNoLabel.TabIndex = 53;
            insuNoLabel.Text = "의료보험증번호";
            // 
            // insuNoTextEdit
            // 
            this.insuNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.patientInsuranceBindingSource, "InsuNo", true));
            this.insuNoTextEdit.Location = new System.Drawing.Point(134, 494);
            this.insuNoTextEdit.Name = "insuNoTextEdit";
            this.insuNoTextEdit.Size = new System.Drawing.Size(229, 20);
            this.insuNoTextEdit.TabIndex = 54;
            // 
            // companyCodeTextEdit
            // 
            this.companyCodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.patientInsuranceBindingSource, "CompanyCode", true));
            this.companyCodeTextEdit.Location = new System.Drawing.Point(396, 521);
            this.companyCodeTextEdit.Name = "companyCodeTextEdit";
            this.companyCodeTextEdit.Size = new System.Drawing.Size(229, 20);
            this.companyCodeTextEdit.TabIndex = 56;
            // 
            // companyNameLabel
            // 
            companyNameLabel.AutoSize = true;
            companyNameLabel.Location = new System.Drawing.Point(20, 529);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new System.Drawing.Size(65, 12);
            companyNameLabel.TabIndex = 57;
            companyNameLabel.Text = "사업장기호";
            // 
            // companyNameTextEdit
            // 
            this.companyNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.patientInsuranceBindingSource, "CompanyName", true));
            this.companyNameTextEdit.Location = new System.Drawing.Point(134, 523);
            this.companyNameTextEdit.Name = "companyNameTextEdit";
            this.companyNameTextEdit.Size = new System.Drawing.Size(229, 20);
            this.companyNameTextEdit.TabIndex = 58;
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Location = new System.Drawing.Point(20, 557);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new System.Drawing.Size(107, 12);
            startDateLabel.TabIndex = 59;
            startDateLabel.Text = "취득일자/유효기간";
            // 
            // relCodeLabel
            // 
            relCodeLabel.AutoSize = true;
            relCodeLabel.Location = new System.Drawing.Point(20, 587);
            relCodeLabel.Name = "relCodeLabel";
            relCodeLabel.Size = new System.Drawing.Size(29, 12);
            relCodeLabel.TabIndex = 63;
            relCodeLabel.Text = "관계";
            // 
            // relCodeTextEdit
            // 
            this.relCodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.patientInsuranceBindingSource, "RelCode", true));
            this.relCodeTextEdit.Location = new System.Drawing.Point(134, 584);
            this.relCodeTextEdit.Name = "relCodeTextEdit";
            this.relCodeTextEdit.Size = new System.Drawing.Size(229, 20);
            this.relCodeTextEdit.TabIndex = 64;
            // 
            // masterNameLabel
            // 
            masterNameLabel.AutoSize = true;
            masterNameLabel.Location = new System.Drawing.Point(20, 615);
            masterNameLabel.Name = "masterNameLabel";
            masterNameLabel.Size = new System.Drawing.Size(69, 12);
            masterNameLabel.TabIndex = 65;
            masterNameLabel.Text = "피보험자 명";
            // 
            // masterNameTextEdit
            // 
            this.masterNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.patientInsuranceBindingSource, "MasterName", true));
            this.masterNameTextEdit.Location = new System.Drawing.Point(134, 610);
            this.masterNameTextEdit.Name = "masterNameTextEdit";
            this.masterNameTextEdit.Size = new System.Drawing.Size(229, 20);
            this.masterNameTextEdit.TabIndex = 66;
            // 
            // titleTextEdit
            // 
            this.titleTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.patientInsuranceBindingSource, "Title", true));
            this.titleTextEdit.Location = new System.Drawing.Point(396, 582);
            this.titleTextEdit.Name = "titleTextEdit";
            this.titleTextEdit.Size = new System.Drawing.Size(229, 20);
            this.titleTextEdit.TabIndex = 72;
            // 
            // insuNameTextEdit
            // 
            this.insuNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.patientInsuranceBindingSource, "InsuName", true));
            this.insuNameTextEdit.Location = new System.Drawing.Point(396, 466);
            this.insuNameTextEdit.Name = "insuNameTextEdit";
            this.insuNameTextEdit.Size = new System.Drawing.Size(229, 20);
            this.insuNameTextEdit.TabIndex = 74;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(134, 552);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(229, 21);
            this.dateTimePicker1.TabIndex = 75;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(396, 550);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(229, 21);
            this.dateTimePicker2.TabIndex = 76;
            // 
            // cboSns
            // 
            this.cboSns.FormattingEnabled = true;
            this.cboSns.Items.AddRange(new object[] {
            "예",
            "아니오"});
            this.cboSns.Location = new System.Drawing.Point(423, 301);
            this.cboSns.Name = "cboSns";
            this.cboSns.Size = new System.Drawing.Size(204, 20);
            this.cboSns.TabIndex = 77;
            // 
            // colChartNo
            // 
            this.colChartNo.DataPropertyName = "ChartNo";
            this.colChartNo.HeaderText = "환자번호";
            this.colChartNo.Name = "colChartNo";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PatientName";
            this.dataGridViewTextBoxColumn2.HeaderText = "PatientName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IDNum";
            this.dataGridViewTextBoxColumn3.HeaderText = "IDNum";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BirthdayType";
            this.dataGridViewTextBoxColumn4.HeaderText = "BirthdayType";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Birthday";
            this.dataGridViewTextBoxColumn5.HeaderText = "Birthday";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // colGender
            // 
            this.colGender.DataPropertyName = "Gender";
            this.colGender.HeaderText = "Gender";
            this.colGender.Name = "colGender";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Telephone";
            this.dataGridViewTextBoxColumn7.HeaderText = "Telephone";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Cellphone";
            this.dataGridViewTextBoxColumn8.HeaderText = "Cellphone";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ZipCode";
            this.dataGridViewTextBoxColumn9.HeaderText = "ZipCode";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ZipSeq";
            this.dataGridViewTextBoxColumn10.HeaderText = "ZipSeq";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn11.HeaderText = "Address";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "DetailAddress";
            this.dataGridViewTextBoxColumn12.HeaderText = "DetailAddress";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn13.HeaderText = "Email";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "SnsID";
            this.dataGridViewTextBoxColumn14.HeaderText = "SnsID";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "OldChartNo";
            this.dataGridViewTextBoxColumn15.HeaderText = "OldChartNo";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "DCCode";
            this.dataGridViewTextBoxColumn16.HeaderText = "DCCode";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Foreign";
            this.dataGridViewTextBoxColumn17.HeaderText = "Foreign";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "SnsYn";
            this.dataGridViewTextBoxColumn18.HeaderText = "SnsYn";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Remark";
            this.dataGridViewTextBoxColumn19.HeaderText = "Remark";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "FingerPrintNo";
            this.dataGridViewTextBoxColumn20.HeaderText = "FingerPrintNo";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 645);
            this.Controls.Add(this.cboSns);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(insuCodeLabel);
            this.Controls.Add(this.insuCodeTextEdit);
            this.Controls.Add(this.seqSpinEdit);
            this.Controls.Add(insuNoLabel);
            this.Controls.Add(this.insuNoTextEdit);
            this.Controls.Add(this.companyCodeTextEdit);
            this.Controls.Add(companyNameLabel);
            this.Controls.Add(this.companyNameTextEdit);
            this.Controls.Add(startDateLabel);
            this.Controls.Add(relCodeLabel);
            this.Controls.Add(this.relCodeTextEdit);
            this.Controls.Add(masterNameLabel);
            this.Controls.Add(this.masterNameTextEdit);
            this.Controls.Add(this.titleTextEdit);
            this.Controls.Add(this.insuNameTextEdit);
            this.Controls.Add(this.patientInsuranceDataGridView);
            this.Controls.Add(this.cboForeign);
            this.Controls.Add(this.cboBirthdayType);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.patientDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(chartNoLabel);
            this.Controls.Add(this.chartNoTextEdit);
            this.Controls.Add(patientNameLabel);
            this.Controls.Add(this.patientNameTextEdit);
            this.Controls.Add(iDNumLabel);
            this.Controls.Add(this.iDNumTextEdit);
            this.Controls.Add(birthdayTypeLabel);
            this.Controls.Add(birthdayLabel);
            this.Controls.Add(this.birthdayDateEdit);
            this.Controls.Add(genderLabel);
            this.Controls.Add(telephoneLabel);
            this.Controls.Add(this.telephoneTextEdit);
            this.Controls.Add(cellphoneLabel);
            this.Controls.Add(this.cellphoneTextEdit);
            this.Controls.Add(zipCodeLabel);
            this.Controls.Add(this.zipCodeTextEdit);
            this.Controls.Add(this.zipSeqSpinEdit);
            this.Controls.Add(this.addressTextEdit);
            this.Controls.Add(detailAddressLabel);
            this.Controls.Add(this.detailAddressTextEdit);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextEdit);
            this.Controls.Add(dCCodeLabel);
            this.Controls.Add(this.dCCodeTextEdit);
            this.Controls.Add(foreignLabel);
            this.Controls.Add(snsYnLabel);
            this.Controls.Add(remarkLabel);
            this.Controls.Add(this.remarkTextEdit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDNumTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellphoneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zipCodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zipSeqSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailAddressTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dCCodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientInsuranceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientInsuranceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insuCodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seqSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insuNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyCodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relCodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insuNameTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private DataSet1TableAdapters.PatientTableAdapter patientTableAdapter;
        private DevExpress.XtraEditors.TextEdit chartNoTextEdit;
        private DevExpress.XtraEditors.TextEdit patientNameTextEdit;
        private DevExpress.XtraEditors.TextEdit iDNumTextEdit;
        private DevExpress.XtraEditors.DateEdit birthdayDateEdit;
        private DevExpress.XtraEditors.TextEdit telephoneTextEdit;
        private DevExpress.XtraEditors.TextEdit cellphoneTextEdit;
        private DevExpress.XtraEditors.TextEdit zipCodeTextEdit;
        private DevExpress.XtraEditors.SpinEdit zipSeqSpinEdit;
        private DevExpress.XtraEditors.TextEdit addressTextEdit;
        private DevExpress.XtraEditors.TextEdit detailAddressTextEdit;
        private DevExpress.XtraEditors.TextEdit emailTextEdit;
        private DevExpress.XtraEditors.TextEdit dCCodeTextEdit;
        private DevExpress.XtraEditors.TextEdit remarkTextEdit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView patientDataGridView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.ComboBox cboBirthdayType;
        private System.Windows.Forms.ComboBox cboForeign;
        private System.Windows.Forms.BindingSource patientInsuranceBindingSource;
        private DataSet1TableAdapters.PatientInsuranceTableAdapter patientInsuranceTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView patientInsuranceDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private DevExpress.XtraEditors.TextEdit insuCodeTextEdit;
        private DevExpress.XtraEditors.SpinEdit seqSpinEdit;
        private DevExpress.XtraEditors.TextEdit insuNoTextEdit;
        private DevExpress.XtraEditors.TextEdit companyCodeTextEdit;
        private DevExpress.XtraEditors.TextEdit companyNameTextEdit;
        private DevExpress.XtraEditors.TextEdit relCodeTextEdit;
        private DevExpress.XtraEditors.TextEdit masterNameTextEdit;
        private DevExpress.XtraEditors.TextEdit titleTextEdit;
        private DevExpress.XtraEditors.TextEdit insuNameTextEdit;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox cboSns;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChartNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
    }
}

