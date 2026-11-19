namespace StudentManagementSystem
{
    partial class frmStudentDetails
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
            this.components = new System.ComponentModel.Container();
            this.tabsStudentInfo = new System.Windows.Forms.TabControl();
            this.tabPersonalInfo = new System.Windows.Forms.TabPage();
            this.btnChoosePicture = new System.Windows.Forms.Button();
            this.pbStudentPhoto = new System.Windows.Forms.PictureBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.tabAcademicInfo = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.cbStudentStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpEnrollmentDate = new System.Windows.Forms.DateTimePicker();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveStudent = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabsStudentInfo.SuspendLayout();
            this.tabPersonalInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudentPhoto)).BeginInit();
            this.tabAcademicInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabsStudentInfo
            // 
            this.tabsStudentInfo.Controls.Add(this.tabPersonalInfo);
            this.tabsStudentInfo.Controls.Add(this.tabAcademicInfo);
            this.tabsStudentInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsStudentInfo.Location = new System.Drawing.Point(5, 5);
            this.tabsStudentInfo.Name = "tabsStudentInfo";
            this.tabsStudentInfo.SelectedIndex = 0;
            this.tabsStudentInfo.Size = new System.Drawing.Size(726, 391);
            this.tabsStudentInfo.TabIndex = 0;
            // 
            // tabPersonalInfo
            // 
            this.tabPersonalInfo.Controls.Add(this.btnChoosePicture);
            this.tabPersonalInfo.Controls.Add(this.pbStudentPhoto);
            this.tabPersonalInfo.Controls.Add(this.lblGender);
            this.tabPersonalInfo.Controls.Add(this.rbMale);
            this.tabPersonalInfo.Controls.Add(this.rbFemale);
            this.tabPersonalInfo.Controls.Add(this.label3);
            this.tabPersonalInfo.Controls.Add(this.dtpBirthDate);
            this.tabPersonalInfo.Controls.Add(this.label2);
            this.tabPersonalInfo.Controls.Add(this.txtFullName);
            this.tabPersonalInfo.Controls.Add(this.label1);
            this.tabPersonalInfo.Controls.Add(this.txtStudentID);
            this.tabPersonalInfo.Location = new System.Drawing.Point(4, 29);
            this.tabPersonalInfo.Name = "tabPersonalInfo";
            this.tabPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonalInfo.Size = new System.Drawing.Size(718, 358);
            this.tabPersonalInfo.TabIndex = 0;
            this.tabPersonalInfo.Text = "Personal Info";
            this.tabPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // btnChoosePicture
            // 
            this.btnChoosePicture.Location = new System.Drawing.Point(162, 199);
            this.btnChoosePicture.Name = "btnChoosePicture";
            this.btnChoosePicture.Size = new System.Drawing.Size(96, 51);
            this.btnChoosePicture.TabIndex = 4;
            this.btnChoosePicture.Text = "Choose Picture";
            this.btnChoosePicture.UseVisualStyleBackColor = true;
            this.btnChoosePicture.Click += new System.EventHandler(this.btnChoosePicture_Click);
            // 
            // pbStudentPhoto
            // 
            this.pbStudentPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbStudentPhoto.Location = new System.Drawing.Point(10, 188);
            this.pbStudentPhoto.Name = "pbStudentPhoto";
            this.pbStudentPhoto.Size = new System.Drawing.Size(124, 74);
            this.pbStudentPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStudentPhoto.TabIndex = 19;
            this.pbStudentPhoto.TabStop = false;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(390, 98);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(63, 20);
            this.lblGender.TabIndex = 17;
            this.lblGender.Text = "Gender";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(503, 122);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(68, 24);
            this.rbMale.TabIndex = 16;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbFemaleAndMale_CheckedChanged);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(394, 122);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(87, 24);
            this.rbFemale.TabIndex = 15;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.CheckedChanged += new System.EventHandler(this.rbFemaleAndMale_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Birth Date";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.CustomFormat = "dd/MM/yyyy";
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthDate.Location = new System.Drawing.Point(10, 121);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(309, 26);
            this.dtpBirthDate.TabIndex = 13;
            this.dtpBirthDate.ValueChanged += new System.EventHandler(this.dtpBirthDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Full Name";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(394, 46);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(310, 26);
            this.txtFullName.TabIndex = 11;
            this.txtFullName.TextChanged += new System.EventHandler(this.txtFullName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Student ID";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(10, 46);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(309, 26);
            this.txtStudentID.TabIndex = 9;
            this.txtStudentID.TextChanged += new System.EventHandler(this.txtStudentID_TextChanged);
            // 
            // tabAcademicInfo
            // 
            this.tabAcademicInfo.Controls.Add(this.label8);
            this.tabAcademicInfo.Controls.Add(this.cbStudentStatus);
            this.tabAcademicInfo.Controls.Add(this.label7);
            this.tabAcademicInfo.Controls.Add(this.dtpEnrollmentDate);
            this.tabAcademicInfo.Controls.Add(this.nudYear);
            this.tabAcademicInfo.Controls.Add(this.label6);
            this.tabAcademicInfo.Controls.Add(this.cbDepartment);
            this.tabAcademicInfo.Controls.Add(this.label5);
            this.tabAcademicInfo.Location = new System.Drawing.Point(4, 29);
            this.tabAcademicInfo.Name = "tabAcademicInfo";
            this.tabAcademicInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabAcademicInfo.Size = new System.Drawing.Size(718, 358);
            this.tabAcademicInfo.TabIndex = 1;
            this.tabAcademicInfo.Text = "Academic Info";
            this.tabAcademicInfo.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(392, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Academic Year";
            // 
            // cbStudentStatus
            // 
            this.cbStudentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStudentStatus.FormattingEnabled = true;
            this.cbStudentStatus.Items.AddRange(new object[] {
            "Active",
            "Graduated",
            "Suspended"});
            this.cbStudentStatus.Location = new System.Drawing.Point(10, 172);
            this.cbStudentStatus.Name = "cbStudentStatus";
            this.cbStudentStatus.Size = new System.Drawing.Size(310, 28);
            this.cbStudentStatus.TabIndex = 17;
            this.cbStudentStatus.SelectedIndexChanged += new System.EventHandler(this.cbStudentStatus_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(392, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Enrollment Date";
            // 
            // dtpEnrollmentDate
            // 
            this.dtpEnrollmentDate.CustomFormat = "dd/MM/yyyy";
            this.dtpEnrollmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnrollmentDate.Location = new System.Drawing.Point(396, 59);
            this.dtpEnrollmentDate.Name = "dtpEnrollmentDate";
            this.dtpEnrollmentDate.Size = new System.Drawing.Size(309, 26);
            this.dtpEnrollmentDate.TabIndex = 15;
            // 
            // nudYear
            // 
            this.nudYear.Location = new System.Drawing.Point(396, 172);
            this.nudYear.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudYear.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudYear.Name = "nudYear";
            this.nudYear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nudYear.Size = new System.Drawing.Size(120, 26);
            this.nudYear.TabIndex = 14;
            this.nudYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudYear.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Student Status";
            // 
            // cbDepartment
            // 
            this.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Items.AddRange(new object[] {
            "Computer Engineering",
            "Software Engineering",
            "Electrical Engineering",
            "Mechanical Engineering",
            "Civil Engineering"});
            this.cbDepartment.Location = new System.Drawing.Point(10, 59);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(310, 28);
            this.cbDepartment.TabIndex = 12;
            this.cbDepartment.SelectedIndexChanged += new System.EventHandler(this.cbDepartment_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Department";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSaveStudent);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(5, 332);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 64);
            this.panel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(207, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(168, 42);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveStudent
            // 
            this.btnSaveStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveStudent.Location = new System.Drawing.Point(10, 12);
            this.btnSaveStudent.Name = "btnSaveStudent";
            this.btnSaveStudent.Size = new System.Drawing.Size(168, 42);
            this.btnSaveStudent.TabIndex = 2;
            this.btnSaveStudent.Text = "Save Student";
            this.btnSaveStudent.UseVisualStyleBackColor = true;
            this.btnSaveStudent.Click += new System.EventHandler(this.btnSaveStudent_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Images|*.jpg;*.jpeg;*.png;*.bmp\"";
            this.openFileDialog1.InitialDirectory = "C:\\Users\\horo\\Desktop\\Repos\\csharp-windows-forms\\Projects\\StudentManagementSystem" +
    "\\images\\";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmStudentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 401);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabsStudentInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStudentDetails";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Student";
            this.Load += new System.EventHandler(this.frmStudentDetails_Load);
            this.tabsStudentInfo.ResumeLayout(false);
            this.tabPersonalInfo.ResumeLayout(false);
            this.tabPersonalInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudentPhoto)).EndInit();
            this.tabAcademicInfo.ResumeLayout(false);
            this.tabAcademicInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabsStudentInfo;
        private System.Windows.Forms.TabPage tabPersonalInfo;
        private System.Windows.Forms.TabPage tabAcademicInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveStudent;
        private System.Windows.Forms.PictureBox pbStudentPhoto;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnChoosePicture;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbStudentStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpEnrollmentDate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}