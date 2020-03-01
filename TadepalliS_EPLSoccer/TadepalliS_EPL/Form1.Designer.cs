namespace TadepalliS_EPL
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
            this.lsvOut = new System.Windows.Forms.ListView();
            this.btnPredict = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblFirstPlace = new System.Windows.Forms.Label();
            this.lblSecondPlace = new System.Windows.Forms.Label();
            this.lblThirdPlace = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
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
            this.lsvOut.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvOut.HideSelection = false;
            this.lsvOut.Location = new System.Drawing.Point(12, 12);
            this.lsvOut.Name = "lsvOut";
            this.lsvOut.Size = new System.Drawing.Size(817, 400);
            this.lsvOut.TabIndex = 0;
            this.lsvOut.UseCompatibleStateImageBehavior = false;
            this.lsvOut.View = System.Windows.Forms.View.Details;
            // 
            // btnPredict
            // 
            this.btnPredict.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPredict.Location = new System.Drawing.Point(12, 431);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(289, 95);
            this.btnPredict.TabIndex = 2;
            this.btnPredict.Text = "Predict";
            this.btnPredict.UseVisualStyleBackColor = true;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(12, 532);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(289, 92);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblFirstPlace
            // 
            this.lblFirstPlace.BackColor = System.Drawing.Color.Gold;
            this.lblFirstPlace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFirstPlace.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstPlace.Location = new System.Drawing.Point(307, 431);
            this.lblFirstPlace.Name = "lblFirstPlace";
            this.lblFirstPlace.Size = new System.Drawing.Size(522, 54);
            this.lblFirstPlace.TabIndex = 4;
            this.lblFirstPlace.Text = "1st:";
            this.lblFirstPlace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSecondPlace
            // 
            this.lblSecondPlace.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblSecondPlace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSecondPlace.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondPlace.Location = new System.Drawing.Point(307, 500);
            this.lblSecondPlace.Name = "lblSecondPlace";
            this.lblSecondPlace.Size = new System.Drawing.Size(522, 54);
            this.lblSecondPlace.TabIndex = 5;
            this.lblSecondPlace.Text = "2nd:";
            this.lblSecondPlace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThirdPlace
            // 
            this.lblThirdPlace.BackColor = System.Drawing.Color.BurlyWood;
            this.lblThirdPlace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblThirdPlace.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThirdPlace.Location = new System.Drawing.Point(307, 569);
            this.lblThirdPlace.Name = "lblThirdPlace";
            this.lblThirdPlace.Size = new System.Drawing.Size(522, 54);
            this.lblThirdPlace.TabIndex = 6;
            this.lblThirdPlace.Text = "3rd:";
            this.lblThirdPlace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Match";
            this.columnHeader1.Width = 65;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Team";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Score";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 65;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Team";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Score";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 65;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Outcome";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 200;
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnPredict;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(843, 636);
            this.Controls.Add(this.lblThirdPlace);
            this.Controls.Add(this.lblSecondPlace);
            this.Controls.Add(this.lblFirstPlace);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPredict);
            this.Controls.Add(this.lsvOut);
            this.Name = "frmMain";
            this.Text = "EPL Winner";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvOut;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnPredict;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblFirstPlace;
        private System.Windows.Forms.Label lblSecondPlace;
        private System.Windows.Forms.Label lblThirdPlace;
    }
}

