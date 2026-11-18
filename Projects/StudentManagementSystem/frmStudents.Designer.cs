namespace StudentManagementSystem
{
    partial class frmStudents
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnEditStudent = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.lvStudents = new System.Windows.Forms.ListView();
            this.colStudentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDepartment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAcademicYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBirthDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStudentStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEnrollmentDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdStudents = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuEditStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeleteStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTop.SuspendLayout();
            this.cmdStudents.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.txtSearch);
            this.pnlTop.Controls.Add(this.lblSearch);
            this.pnlTop.Controls.Add(this.btnEditStudent);
            this.pnlTop.Controls.Add(this.btnAddStudent);
            this.pnlTop.Controls.Add(this.btnDeleteStudent);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(10, 10);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1109, 82);
            this.pnlTop.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(85, 14);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(360, 42);
            this.txtSearch.TabIndex = 4;
            // 
            // lblSearch
            // 
            this.lblSearch.Location = new System.Drawing.Point(3, 22);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(76, 34);
            this.lblSearch.TabIndex = 5;
            this.lblSearch.Text = "Search";
            // 
            // btnEditStudent
            // 
            this.btnEditStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditStudent.Location = new System.Drawing.Point(732, 14);
            this.btnEditStudent.Name = "btnEditStudent";
            this.btnEditStudent.Size = new System.Drawing.Size(168, 42);
            this.btnEditStudent.TabIndex = 2;
            this.btnEditStudent.Text = "Edit";
            this.btnEditStudent.UseVisualStyleBackColor = true;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddStudent.AutoSize = true;
            this.btnAddStudent.Location = new System.Drawing.Point(538, 14);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(168, 42);
            this.btnAddStudent.TabIndex = 1;
            this.btnAddStudent.Text = "Add";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteStudent.Location = new System.Drawing.Point(926, 14);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(168, 42);
            this.btnDeleteStudent.TabIndex = 3;
            this.btnDeleteStudent.Text = "Delete";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            // 
            // lvStudents
            // 
            this.lvStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colStudentID,
            this.colFullName,
            this.colDepartment,
            this.colAcademicYear,
            this.colGender,
            this.colBirthDate,
            this.colStudentStatus,
            this.colEnrollmentDate});
            this.lvStudents.ContextMenuStrip = this.cmdStudents;
            this.lvStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvStudents.HideSelection = false;
            this.lvStudents.Location = new System.Drawing.Point(10, 92);
            this.lvStudents.Name = "lvStudents";
            this.lvStudents.Size = new System.Drawing.Size(1109, 525);
            this.lvStudents.TabIndex = 6;
            this.lvStudents.UseCompatibleStateImageBehavior = false;
            this.lvStudents.View = System.Windows.Forms.View.Details;
            // 
            // colStudentID
            // 
            this.colStudentID.Text = "Student ID";
            this.colStudentID.Width = 100;
            // 
            // colFullName
            // 
            this.colFullName.Text = "Full Name";
            this.colFullName.Width = 180;
            // 
            // colDepartment
            // 
            this.colDepartment.Text = "Department";
            this.colDepartment.Width = 180;
            // 
            // colAcademicYear
            // 
            this.colAcademicYear.Text = "Year";
            this.colAcademicYear.Width = 110;
            // 
            // colGender
            // 
            this.colGender.Text = "Gender";
            this.colGender.Width = 90;
            // 
            // colBirthDate
            // 
            this.colBirthDate.Text = "Birth Date";
            this.colBirthDate.Width = 110;
            // 
            // colStudentStatus
            // 
            this.colStudentStatus.Text = "Status";
            this.colStudentStatus.Width = 110;
            // 
            // colEnrollmentDate
            // 
            this.colEnrollmentDate.Text = "Entrollment Date";
            this.colEnrollmentDate.Width = 160;
            // 
            // cmdStudents
            // 
            this.cmdStudents.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmdStudents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditStudent,
            this.mnuDeleteStudent});
            this.cmdStudents.Name = "cmdStudents";
            this.cmdStudents.Size = new System.Drawing.Size(201, 68);
            // 
            // mnuEditStudent
            // 
            this.mnuEditStudent.Name = "mnuEditStudent";
            this.mnuEditStudent.Size = new System.Drawing.Size(200, 32);
            this.mnuEditStudent.Text = "Edit Student";
            // 
            // mnuDeleteStudent
            // 
            this.mnuDeleteStudent.Name = "mnuDeleteStudent";
            this.mnuDeleteStudent.Size = new System.Drawing.Size(200, 32);
            this.mnuDeleteStudent.Text = "Delete Student";
            // 
            // frmStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 627);
            this.Controls.Add(this.lvStudents);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmStudents";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Students Management";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.cmdStudents.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnEditStudent;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ListView lvStudents;
        private System.Windows.Forms.ColumnHeader colStudentID;
        private System.Windows.Forms.ColumnHeader colFullName;
        private System.Windows.Forms.ColumnHeader colDepartment;
        private System.Windows.Forms.ColumnHeader colAcademicYear;
        private System.Windows.Forms.ColumnHeader colGender;
        private System.Windows.Forms.ColumnHeader colBirthDate;
        private System.Windows.Forms.ContextMenuStrip cmdStudents;
        private System.Windows.Forms.ToolStripMenuItem mnuEditStudent;
        private System.Windows.Forms.ToolStripMenuItem mnuDeleteStudent;
        private System.Windows.Forms.ColumnHeader colStudentStatus;
        private System.Windows.Forms.ColumnHeader colEnrollmentDate;
    }
}