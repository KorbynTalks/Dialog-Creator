
namespace Dialog_Creator
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.versionText = new System.Windows.Forms.Label();
            this.createdBy = new System.Windows.Forms.Label();
            this.builtWithText = new System.Windows.Forms.Label();
            this.visualStudioInfo = new System.Windows.Forms.Label();
            this.netFrameworkInfo = new System.Windows.Forms.Label();
            this.testedBy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 129);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // versionText
            // 
            this.versionText.AutoSize = true;
            this.versionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionText.Location = new System.Drawing.Point(156, 40);
            this.versionText.Name = "versionText";
            this.versionText.Size = new System.Drawing.Size(0, 24);
            this.versionText.TabIndex = 1;
            // 
            // createdBy
            // 
            this.createdBy.AutoSize = true;
            this.createdBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdBy.Location = new System.Drawing.Point(156, 64);
            this.createdBy.Name = "createdBy";
            this.createdBy.Size = new System.Drawing.Size(157, 15);
            this.createdBy.TabIndex = 2;
            this.createdBy.Text = "Created by KorbynTalks";
            // 
            // builtWithText
            // 
            this.builtWithText.AutoSize = true;
            this.builtWithText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.builtWithText.Location = new System.Drawing.Point(157, 94);
            this.builtWithText.Name = "builtWithText";
            this.builtWithText.Size = new System.Drawing.Size(70, 15);
            this.builtWithText.TabIndex = 3;
            this.builtWithText.Text = "Built with:\r\n";
            // 
            // visualStudioInfo
            // 
            this.visualStudioInfo.AutoSize = true;
            this.visualStudioInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualStudioInfo.Location = new System.Drawing.Point(157, 109);
            this.visualStudioInfo.Name = "visualStudioInfo";
            this.visualStudioInfo.Size = new System.Drawing.Size(195, 15);
            this.visualStudioInfo.TabIndex = 4;
            this.visualStudioInfo.Text = "Visual Studio 2022 version 17.13.0";
            // 
            // netFrameworkInfo
            // 
            this.netFrameworkInfo.AutoSize = true;
            this.netFrameworkInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netFrameworkInfo.Location = new System.Drawing.Point(157, 124);
            this.netFrameworkInfo.Name = "netFrameworkInfo";
            this.netFrameworkInfo.Size = new System.Drawing.Size(0, 15);
            this.netFrameworkInfo.TabIndex = 5;
            // 
            // testedBy
            // 
            this.testedBy.AutoSize = true;
            this.testedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testedBy.Location = new System.Drawing.Point(18, 168);
            this.testedBy.Name = "testedBy";
            this.testedBy.Size = new System.Drawing.Size(165, 15);
            this.testedBy.TabIndex = 7;
            this.testedBy.Text = "Tested by: Cheps, and Myself";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 192);
            this.Controls.Add(this.testedBy);
            this.Controls.Add(this.netFrameworkInfo);
            this.Controls.Add(this.visualStudioInfo);
            this.Controls.Add(this.builtWithText);
            this.Controls.Add(this.createdBy);
            this.Controls.Add(this.versionText);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.Load += new System.EventHandler(this.About_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label versionText;
        private System.Windows.Forms.Label createdBy;
        private System.Windows.Forms.Label builtWithText;
        private System.Windows.Forms.Label visualStudioInfo;
        private System.Windows.Forms.Label netFrameworkInfo;
        private System.Windows.Forms.Label testedBy;
    }
}