namespace TadepalliS_BONUSStudentGrades
{
    partial class frmDistribution
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lstOut = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(600, 60);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "ICS4U GRADES DISTRIBUTION";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstOut
            // 
            this.lstOut.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOut.FormattingEnabled = true;
            this.lstOut.ItemHeight = 23;
            this.lstOut.Location = new System.Drawing.Point(12, 103);
            this.lstOut.Name = "lstOut";
            this.lstOut.Size = new System.Drawing.Size(600, 234);
            this.lstOut.TabIndex = 2;
            // 
            // frmDistribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(624, 370);
            this.Controls.Add(this.lstOut);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmDistribution";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmDistribution_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lstOut;
    }
}