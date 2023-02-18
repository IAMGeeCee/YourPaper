
namespace YourPaper_Desktop
{
    partial class Upload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Upload));
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.imgImage = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ofdFileSelect = new System.Windows.Forms.OpenFileDialog();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMinimise = new System.Windows.Forms.Button();
            this.btnMaximise = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgImage)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.Location = new System.Drawing.Point(171, 107);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(467, 25);
            this.txtTitle.TabIndex = 0;
            // 
            // pnlForm
            // 
            this.pnlForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlForm.Controls.Add(this.btnUpload);
            this.pnlForm.Controls.Add(this.btnSelectImage);
            this.pnlForm.Controls.Add(this.imgImage);
            this.pnlForm.Controls.Add(this.label3);
            this.pnlForm.Controls.Add(this.txtDescription);
            this.pnlForm.Controls.Add(this.label2);
            this.pnlForm.Controls.Add(this.label1);
            this.pnlForm.Controls.Add(this.txtTitle);
            this.pnlForm.Location = new System.Drawing.Point(0, 31);
            this.pnlForm.Margin = new System.Windows.Forms.Padding(30);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(760, 494);
            this.pnlForm.TabIndex = 1;
            // 
            // btnUpload
            // 
            this.btnUpload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Location = new System.Drawing.Point(3, 427);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(752, 55);
            this.btnUpload.TabIndex = 7;
            this.btnUpload.Text = "Upload!";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectImage.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectImage.ForeColor = System.Drawing.Color.White;
            this.btnSelectImage.Location = new System.Drawing.Point(171, 210);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(467, 29);
            this.btnSelectImage.TabIndex = 6;
            this.btnSelectImage.Text = "Select Image";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // imgImage
            // 
            this.imgImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgImage.Location = new System.Drawing.Point(171, 245);
            this.imgImage.Name = "imgImage";
            this.imgImage.Size = new System.Drawing.Size(467, 169);
            this.imgImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgImage.TabIndex = 5;
            this.imgImage.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(56, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(171, 165);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(467, 25);
            this.txtDescription.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(111, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title:";
            // 
            // ofdFileSelect
            // 
            this.ofdFileSelect.FileName = "openFileDialog1";
            this.ofdFileSelect.Title = "Select Image";
            // 
            // pnlTop
            // 
            this.pnlTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnlTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Controls.Add(this.btnMinimise);
            this.pnlTop.Controls.Add(this.btnMaximise);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(760, 32);
            this.pnlTop.TabIndex = 4;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.pnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(8, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(61, 15);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "YourPaper";
            // 
            // btnMinimise
            // 
            this.btnMinimise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimise.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimise.FlatAppearance.BorderSize = 0;
            this.btnMinimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimise.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimise.ForeColor = System.Drawing.Color.White;
            this.btnMinimise.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimise.Location = new System.Drawing.Point(612, -1);
            this.btnMinimise.Name = "btnMinimise";
            this.btnMinimise.Size = new System.Drawing.Size(49, 34);
            this.btnMinimise.TabIndex = 4;
            this.btnMinimise.Text = "";
            this.btnMinimise.UseVisualStyleBackColor = false;
            this.btnMinimise.Click += new System.EventHandler(this.btnMinimise_Click);
            this.btnMinimise.MouseEnter += new System.EventHandler(this.TitleButton_MouseHover);
            this.btnMinimise.MouseLeave += new System.EventHandler(this.TitleButton_MouseLeave);
            this.btnMinimise.MouseHover += new System.EventHandler(this.TitleButton_MouseHover);
            // 
            // btnMaximise
            // 
            this.btnMaximise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximise.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximise.FlatAppearance.BorderSize = 0;
            this.btnMaximise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximise.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximise.ForeColor = System.Drawing.Color.White;
            this.btnMaximise.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximise.Image")));
            this.btnMaximise.Location = new System.Drawing.Point(661, -1);
            this.btnMaximise.Name = "btnMaximise";
            this.btnMaximise.Size = new System.Drawing.Size(49, 34);
            this.btnMaximise.TabIndex = 3;
            this.btnMaximise.UseVisualStyleBackColor = false;
            this.btnMaximise.Click += new System.EventHandler(this.btnMaximise_Click);
            this.btnMaximise.MouseEnter += new System.EventHandler(this.TitleButton_MouseHover);
            this.btnMaximise.MouseLeave += new System.EventHandler(this.TitleButton_MouseLeave);
            this.btnMaximise.MouseHover += new System.EventHandler(this.TitleButton_MouseHover);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(711, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 34);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseHover);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(165, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Upload a wallpaper";
            // 
            // Upload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(760, 525);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Upload";
            this.Text = "Upload";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgImage)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.PictureBox imgImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog ofdFileSelect;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnMinimise;
        private System.Windows.Forms.Button btnMaximise;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
    }
}