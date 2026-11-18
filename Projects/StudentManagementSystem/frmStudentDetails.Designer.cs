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
            this.tabStudentInfo = new System.Windows.Forms.TabControl();
            this.tabPersonalInfo = new System.Windows.Forms.TabPage();
            this.tabAcademicInfo = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaveStudent = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.dtpBirthDay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pbStudentPhoto = new System.Windows.Forms.PictureBox();
            this.btnChoosePicture = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.dtpEnrollmentDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cmStudentStatus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabStudentInfo.SuspendLayout();
            this.tabPersonalInfo.SuspendLayout();
            this.tabAcademicInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudentPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabStudentInfo
            // 
            this.tabStudentInfo.Controls.Add(this.tabPersonalInfo);
            this.tabStudentInfo.Controls.Add(this.tabAcademicInfo);
            this.tabStudentInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabStudentInfo.Location = new System.Drawing.Point(5, 5);
            this.tabStudentInfo.Name = "tabStudentInfo";
            this.tabStudentInfo.SelectedIndex = 0;
            this.tabStudentInfo.Size = new System.Drawing.Size(726, 391);
            this.tabStudentInfo.TabIndex = 0;
            // 
            // tabPersonalInfo
            // 
            this.tabPersonalInfo.Controls.Add(this.btnChoosePicture);
            this.tabPersonalInfo.Controls.Add(this.pbStudentPhoto);
            this.tabPersonalInfo.Controls.Add(this.label4);
            this.tabPersonalInfo.Controls.Add(this.rbMale);
            this.tabPersonalInfo.Controls.Add(this.rbFemale);
            this.tabPersonalInfo.Controls.Add(this.label3);
            this.tabPersonalInfo.Controls.Add(this.dtpBirthDay);
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
            // tabAcademicInfo
            // 
            this.tabAcademicInfo.Controls.Add(this.label8);
            this.tabAcademicInfo.Controls.Add(this.cmStudentStatus);
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
            // btnSaveStudent
            // 
            this.btnSaveStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveStudent.Location = new System.Drawing.Point(10, 12);
            this.btnSaveStudent.Name = "btnSaveStudent";
            this.btnSaveStudent.Size = new System.Drawing.Size(168, 42);
            this.btnSaveStudent.TabIndex = 2;
            this.btnSaveStudent.Text = "Save Student";
            this.btnSaveStudent.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(207, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(168, 42);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(10, 46);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(309, 26);
            this.txtStudentID.TabIndex = 9;
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
            // 
            // dtpBirthDay
            // 
            this.dtpBirthDay.CustomFormat = "dd/MM/yyyy";
            this.dtpBirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthDay.Location = new System.Drawing.Point(10, 121);
            this.dtpBirthDay.Name = "dtpBirthDay";
            this.dtpBirthDay.Size = new System.Drawing.Size(309, 26);
            this.dtpBirthDay.TabIndex = 13;
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
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Gender";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pbStudentPhoto
            // 
            this.pbStudentPhoto.BackColor = System.Drawing.Color.Silver;
            this.pbStudentPhoto.Location = new System.Drawing.Point(10, 188);
            this.pbStudentPhoto.Name = "pbStudentPhoto";
            this.pbStudentPhoto.Size = new System.Drawing.Size(124, 74);
            this.pbStudentPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStudentPhoto.TabIndex = 19;
            this.pbStudentPhoto.TabStop = false;
            // 
            // btnChoosePicture
            // 
            this.btnChoosePicture.Location = new System.Drawing.Point(162, 199);
            this.btnChoosePicture.Name = "btnChoosePicture";
            this.btnChoosePicture.Size = new System.Drawing.Size(143, 42);
            this.btnChoosePicture.TabIndex = 4;
            this.btnChoosePicture.Text = "Choose Picture";
            this.btnChoosePicture.UseVisualStyleBackColor = true;
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
            this.nudYear.Size = new System.Drawing.Size(120, 26);
            this.nudYear.TabIndex = 14;
            this.nudYear.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(392, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Enrollment Date";
            // 
            // cmStudentStatus
            // 
            this.cmStudentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmStudentStatus.FormattingEnabled = true;
            this.cmStudentStatus.Items.AddRange(new object[] {
            "Active",
            "Graduated",
            "Suspended"});
            this.cmStudentStatus.Location = new System.Drawing.Point(10, 172);
            this.cmStudentStatus.Name = "cmStudentStatus";
            this.cmStudentStatus.Size = new System.Drawing.Size(310, 28);
            this.cmStudentStatus.TabIndex = 17;
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 401);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabStudentInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddStudent";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Student";
            this.tabStudentInfo.ResumeLayout(false);
            this.tabPersonalInfo.ResumeLayout(false);
            this.tabPersonalInfo.PerformLayout();
            this.tabAcademicInfo.ResumeLayout(false);
            this.tabAcademicInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbStudentPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabStudentInfo;
        private System.Windows.Forms.TabPage tabPersonalInfo;
        private System.Windows.Forms.TabPage tabAcademicInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveStudent;
        private System.Windows.Forms.PictureBox pbStudentPhoto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpBirthDay;
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
        private System.Windows.Forms.ComboBox cmStudentStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpEnrollmentDate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}