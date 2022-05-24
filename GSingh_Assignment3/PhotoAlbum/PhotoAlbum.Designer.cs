namespace PhotoAlbum
{
    partial class PhotoAlbum
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
            this.picAlbum = new System.Windows.Forms.PictureBox();
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.lblFileCreation = new System.Windows.Forms.Label();
            this.lblCreationDateAndTime = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnAddPhotos = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnSaveAlbum = new System.Windows.Forms.Button();
            this.btnOpenAlbum = new System.Windows.Forms.Button();
            this.btnCreateAlbum = new System.Windows.Forms.Button();
            this.grpCanvasColour = new System.Windows.Forms.GroupBox();
            this.rdbGrey = new System.Windows.Forms.RadioButton();
            this.rdbWhite = new System.Windows.Forms.RadioButton();
            this.rdbBlack = new System.Windows.Forms.RadioButton();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picAlbum)).BeginInit();
            this.pnlNavigation.SuspendLayout();
            this.grpCanvasColour.SuspendLayout();
            this.SuspendLayout();
            // 
            // picAlbum
            // 
            this.picAlbum.BackColor = System.Drawing.Color.Black;
            this.picAlbum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAlbum.Location = new System.Drawing.Point(26, 30);
            this.picAlbum.Name = "picAlbum";
            this.picAlbum.Size = new System.Drawing.Size(634, 614);
            this.picAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAlbum.TabIndex = 0;
            this.picAlbum.TabStop = false;
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.Controls.Add(this.lblFileCreation);
            this.pnlNavigation.Controls.Add(this.lblCreationDateAndTime);
            this.pnlNavigation.Controls.Add(this.btnNext);
            this.pnlNavigation.Controls.Add(this.btnPrevious);
            this.pnlNavigation.Controls.Add(this.btnAddPhotos);
            this.pnlNavigation.Controls.Add(this.txtDescription);
            this.pnlNavigation.Controls.Add(this.lblDescription);
            this.pnlNavigation.Location = new System.Drawing.Point(676, 30);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(386, 354);
            this.pnlNavigation.TabIndex = 1;
            // 
            // lblFileCreation
            // 
            this.lblFileCreation.AutoSize = true;
            this.lblFileCreation.Location = new System.Drawing.Point(20, 267);
            this.lblFileCreation.Name = "lblFileCreation";
            this.lblFileCreation.Size = new System.Drawing.Size(0, 17);
            this.lblFileCreation.TabIndex = 10;
            // 
            // lblCreationDateAndTime
            // 
            this.lblCreationDateAndTime.AutoSize = true;
            this.lblCreationDateAndTime.Location = new System.Drawing.Point(17, 237);
            this.lblCreationDateAndTime.Name = "lblCreationDateAndTime";
            this.lblCreationDateAndTime.Size = new System.Drawing.Size(0, 17);
            this.lblCreationDateAndTime.TabIndex = 9;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(261, 290);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(108, 41);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(139, 290);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(116, 41);
            this.btnPrevious.TabIndex = 6;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnAddPhotos
            // 
            this.btnAddPhotos.Location = new System.Drawing.Point(17, 290);
            this.btnAddPhotos.Name = "btnAddPhotos";
            this.btnAddPhotos.Size = new System.Drawing.Size(116, 41);
            this.btnAddPhotos.TabIndex = 5;
            this.btnAddPhotos.Text = "Add Photos";
            this.btnAddPhotos.UseVisualStyleBackColor = true;
            this.btnAddPhotos.Click += new System.EventHandler(this.btnAddPhotos_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(17, 46);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(352, 175);
            this.txtDescription.TabIndex = 4;
            this.txtDescription.Leave += new System.EventHandler(this.txtDescription_Leave);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(14, 16);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(83, 17);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description:";
            // 
            // btnSaveAlbum
            // 
            this.btnSaveAlbum.Location = new System.Drawing.Point(937, 584);
            this.btnSaveAlbum.Name = "btnSaveAlbum";
            this.btnSaveAlbum.Size = new System.Drawing.Size(108, 44);
            this.btnSaveAlbum.TabIndex = 9;
            this.btnSaveAlbum.Text = "Save Album";
            this.btnSaveAlbum.UseVisualStyleBackColor = true;
            this.btnSaveAlbum.Click += new System.EventHandler(this.btnSaveAlbum_Click);
            // 
            // btnOpenAlbum
            // 
            this.btnOpenAlbum.Location = new System.Drawing.Point(815, 584);
            this.btnOpenAlbum.Name = "btnOpenAlbum";
            this.btnOpenAlbum.Size = new System.Drawing.Size(116, 44);
            this.btnOpenAlbum.TabIndex = 8;
            this.btnOpenAlbum.Text = "Open Album";
            this.btnOpenAlbum.UseVisualStyleBackColor = true;
            this.btnOpenAlbum.Click += new System.EventHandler(this.btnOpenAlbum_Click);
            // 
            // btnCreateAlbum
            // 
            this.btnCreateAlbum.Location = new System.Drawing.Point(693, 584);
            this.btnCreateAlbum.Name = "btnCreateAlbum";
            this.btnCreateAlbum.Size = new System.Drawing.Size(116, 44);
            this.btnCreateAlbum.TabIndex = 0;
            this.btnCreateAlbum.Text = "Create Album";
            this.btnCreateAlbum.UseVisualStyleBackColor = true;
            this.btnCreateAlbum.Click += new System.EventHandler(this.btnCreateAlbum_Click);
            // 
            // grpCanvasColour
            // 
            this.grpCanvasColour.Controls.Add(this.rdbGrey);
            this.grpCanvasColour.Controls.Add(this.rdbWhite);
            this.grpCanvasColour.Controls.Add(this.rdbBlack);
            this.grpCanvasColour.Location = new System.Drawing.Point(693, 415);
            this.grpCanvasColour.Name = "grpCanvasColour";
            this.grpCanvasColour.Size = new System.Drawing.Size(352, 135);
            this.grpCanvasColour.TabIndex = 9;
            this.grpCanvasColour.TabStop = false;
            this.grpCanvasColour.Text = "Canvas Colour";
            // 
            // rdbGrey
            // 
            this.rdbGrey.AutoSize = true;
            this.rdbGrey.Location = new System.Drawing.Point(268, 64);
            this.rdbGrey.Name = "rdbGrey";
            this.rdbGrey.Size = new System.Drawing.Size(60, 21);
            this.rdbGrey.TabIndex = 3;
            this.rdbGrey.TabStop = true;
            this.rdbGrey.Text = "Grey";
            this.rdbGrey.UseVisualStyleBackColor = true;
            this.rdbGrey.CheckedChanged += new System.EventHandler(this.rdbGrey_CheckedChanged);
            // 
            // rdbWhite
            // 
            this.rdbWhite.AutoSize = true;
            this.rdbWhite.Location = new System.Drawing.Point(145, 64);
            this.rdbWhite.Name = "rdbWhite";
            this.rdbWhite.Size = new System.Drawing.Size(65, 21);
            this.rdbWhite.TabIndex = 2;
            this.rdbWhite.TabStop = true;
            this.rdbWhite.Text = "White";
            this.rdbWhite.UseVisualStyleBackColor = true;
            this.rdbWhite.CheckedChanged += new System.EventHandler(this.rdbWhite_CheckedChanged);
            // 
            // rdbBlack
            // 
            this.rdbBlack.AutoSize = true;
            this.rdbBlack.Location = new System.Drawing.Point(26, 64);
            this.rdbBlack.Name = "rdbBlack";
            this.rdbBlack.Size = new System.Drawing.Size(63, 21);
            this.rdbBlack.TabIndex = 1;
            this.rdbBlack.TabStop = true;
            this.rdbBlack.Text = "Black";
            this.rdbBlack.UseVisualStyleBackColor = true;
            this.rdbBlack.CheckedChanged += new System.EventHandler(this.rdbBlack_CheckedChanged);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // photoAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 670);
            this.Controls.Add(this.btnSaveAlbum);
            this.Controls.Add(this.btnOpenAlbum);
            this.Controls.Add(this.btnCreateAlbum);
            this.Controls.Add(this.grpCanvasColour);
            this.Controls.Add(this.pnlNavigation);
            this.Controls.Add(this.picAlbum);
            this.MaximizeBox = false;
            this.Name = "photoAlbum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photo Album";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.photoAlbum_FormClosing);
            this.Load += new System.EventHandler(this.photoAlbum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAlbum)).EndInit();
            this.pnlNavigation.ResumeLayout(false);
            this.pnlNavigation.PerformLayout();
            this.grpCanvasColour.ResumeLayout(false);
            this.grpCanvasColour.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picAlbum;
        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblCreationDateAndTime;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnAddPhotos;
        private System.Windows.Forms.Button btnSaveAlbum;
        private System.Windows.Forms.Button btnOpenAlbum;
        private System.Windows.Forms.Button btnCreateAlbum;
        private System.Windows.Forms.GroupBox grpCanvasColour;
        private System.Windows.Forms.RadioButton rdbGrey;
        private System.Windows.Forms.RadioButton rdbWhite;
        private System.Windows.Forms.RadioButton rdbBlack;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.Label lblFileCreation;
    }
}

