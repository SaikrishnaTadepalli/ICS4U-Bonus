namespace TadepalliS_BONUSStudentGrades
{
    partial class frmMain
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lsvOut = new System.Windows.Forms.ListView();
            this.btnStudentGrades = new System.Windows.Forms.Button();
            this.btnDistribution = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(850, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ICS4U REPORT CARD MARKS - Tuesday, January 07, 2020 12:12:48 PM";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lsvOut
            // 
            this.lsvOut.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lsvOut.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvOut.HideSelection = false;
            this.lsvOut.Location = new System.Drawing.Point(12, 89);
            this.lsvOut.Name = "lsvOut";
            this.lsvOut.Size = new System.Drawing.Size(850, 299);
            this.lsvOut.TabIndex = 1;
            this.lsvOut.UseCompatibleStateImageBehavior = false;
            this.lsvOut.View = System.Windows.Forms.View.Details;
            // 
            // btnStudentGrades
            // 
            this.btnStudentGrades.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnStudentGrades.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentGrades.Location = new System.Drawing.Point(12, 407);
            this.btnStudentGrades.Name = "btnStudentGrades";
            this.btnStudentGrades.Size = new System.Drawing.Size(300, 60);
            this.btnStudentGrades.TabIndex = 2;
            this.btnStudentGrades.Text = "Student Grades";
            this.btnStudentGrades.UseVisualStyleBackColor = false;
            this.btnStudentGrades.Click += new System.EventHandler(this.btnStudentGrades_Click);
            // 
            // btnDistribution
            // 
            this.btnDistribution.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDistribution.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDistribution.Location = new System.Drawing.Point(562, 407);
            this.btnDistribution.Name = "btnDistribution";
            this.btnDistribution.Size = new System.Drawing.Size(300, 60);
            this.btnDistribution.TabIndex = 3;
            this.btnDistribution.Text = "Grade Distribution";
            this.btnDistribution.UseVisualStyleBackColor = false;
            this.btnDistribution.Click += new System.EventHandler(this.btnDistribution_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Student";
            this.columnHeader1.Width = 290;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Test 1";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 95;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Test 2";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 95;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Text 3";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 95;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Final Exam";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 140;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Average";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 110;
            // 
            // tmrTime
            // 
            this.tmrTime.Enabled = true;
            this.tmrTime.Interval = 1000;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(876, 484);
            this.Controls.Add(this.btnDistribution);
            this.Controls.Add(this.btnStudentGrades);
            this.Controls.Add(this.lsvOut);
            this.Controls.Add(this.lblTitle);
            this.KeyPreview = true;
            this.Name = "frmMain";
            this.Text = "Student Grades";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListView lsvOut;
        private System.Windows.Forms.Button btnStudentGrades;
        private System.Windows.Forms.Button btnDistribution;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Timer tmrTime;
    }
}

