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
            this.cbView = new System.Windows.Forms.ComboBox();
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
            this.imgStudentPhotos = new System.Windows.Forms.ImageList(this.components);
            this.pnlTop.SuspendLayout();
            this.cmdStudents.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.cbView);
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
            // cbView
            // 
            this.cbView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbView.FormattingEnabled = true;
            this.cbView.Items.AddRange(new object[] {
            "Details",
            "Large Icons",
            "Tile"});
            this.cbView.Location = new System.Drawing.Point(508, 22);
            this.cbView.Name = "cbView";
            this.cbView.Size = new System.Drawing.Size(107, 28);
            this.cbView.TabIndex = 6;
            this.cbView.SelectedIndexChanged += new System.EventHandler(this.cbView_SelectedIndexChanged);
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
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
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
            this.btnEditStudent.Location = new System.Drawing.Point(815, 14);
            this.btnEditStudent.Name = "btnEditStudent";
            this.btnEditStudent.Size = new System.Drawing.Size(136, 42);
            this.btnEditStudent.TabIndex = 2;
            this.btnEditStudent.Text = "Edit";
            this.btnEditStudent.UseVisualStyleBackColor = true;
            this.btnEditStudent.Click += new System.EventHandler(this.btnEditStudent_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddStudent.AutoSize = true;
            this.btnAddStudent.Location = new System.Drawing.Point(660, 14);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(136, 42);
            this.btnAddStudent.TabIndex = 1;
            this.btnAddStudent.Text = "Add";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteStudent.Location = new System.Drawing.Point(970, 14);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(136, 42);
            this.btnDeleteStudent.TabIndex = 3;
            this.btnDeleteStudent.Text = "Delete";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
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
            this.lvStudents.FullRowSelect = true;
            this.lvStudents.HideSelection = false;
            this.lvStudents.LargeImageList = this.imgStudentPhotos;
            this.lvStudents.Location = new System.Drawing.Point(10, 92);
            this.lvStudents.Name = "lvStudents";
            this.lvStudents.Size = new System.Drawing.Size(1109, 525);
            this.lvStudents.TabIndex = 6;
            this.lvStudents.UseCompatibleStateImageBehavior = false;
            this.lvStudents.View = System.Windows.Forms.View.Details;
            this.lvStudents.DoubleClick += new System.EventHandler(this.lvStudents_DoubleClick);
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
            this.colDepartment.Width = 220;
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
            this.mnuEditStudent.Click += new System.EventHandler(this.mnuEditStudent_Click);
            // 
            // mnuDeleteStudent
            // 
            this.mnuDeleteStudent.Name = "mnuDeleteStudent";
            this.mnuDeleteStudent.Size = new System.Drawing.Size(200, 32);
            this.mnuDeleteStudent.Text = "Delete Student";
            this.mnuDeleteStudent.Click += new System.EventHandler(this.mnuDeleteStudent_Click);
            // 
            // imgStudentPhotos
            // 
            this.imgStudentPhotos.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgStudentPhotos.ImageSize = new System.Drawing.Size(96, 96);
            this.imgStudentPhotos.TransparentColor = System.Drawing.Color.Transparent;
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
            this.Load += new System.EventHandler(this.frmStudents_Load);
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
        private System.Windows.Forms.ComboBox cbView;
        private System.Windows.Forms.ImageList imgStudentPhotos;
    }
}