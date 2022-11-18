namespace HW3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnLoadLoaclPicture = new System.Windows.Forms.Button();
            this.pbLoadedImge = new System.Windows.Forms.PictureBox();
            this.BtnLoadPictureURL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadedImge)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLoadLoaclPicture
            // 
            this.BtnLoadLoaclPicture.Location = new System.Drawing.Point(0, 39);
            this.BtnLoadLoaclPicture.Name = "BtnLoadLoaclPicture";
            this.BtnLoadLoaclPicture.Size = new System.Drawing.Size(75, 23);
            this.BtnLoadLoaclPicture.TabIndex = 0;
            this.BtnLoadLoaclPicture.Text = "Import";
            this.BtnLoadLoaclPicture.UseVisualStyleBackColor = true;
            this.BtnLoadLoaclPicture.Click += new System.EventHandler(this.BtnLoadPicture_Click);
            // 
            // pbLoadedImge
            // 
            this.pbLoadedImge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbLoadedImge.Location = new System.Drawing.Point(0, 68);
            this.pbLoadedImge.Name = "pbLoadedImge";
            this.pbLoadedImge.Size = new System.Drawing.Size(430, 285);
            this.pbLoadedImge.TabIndex = 1;
            this.pbLoadedImge.TabStop = false;
            // 
            // BtnLoadPictureURL
            // 
            this.BtnLoadPictureURL.Location = new System.Drawing.Point(81, 39);
            this.BtnLoadPictureURL.Name = "BtnLoadPictureURL";
            this.BtnLoadPictureURL.Size = new System.Drawing.Size(75, 23);
            this.BtnLoadPictureURL.TabIndex = 2;
            this.BtnLoadPictureURL.Text = "Import URL";
            this.BtnLoadPictureURL.UseVisualStyleBackColor = true;
            this.BtnLoadPictureURL.Click += new System.EventHandler(this.BtnLoadPictureURL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 365);
            this.Controls.Add(this.BtnLoadPictureURL);
            this.Controls.Add(this.pbLoadedImge);
            this.Controls.Add(this.BtnLoadLoaclPicture);
            this.Name = "Form1";
            this.Text = "Load a Picture";
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadedImge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnLoadLoaclPicture;
        private PictureBox pbLoadedImge;
        private Button BtnLoadPictureURL;
    }
}