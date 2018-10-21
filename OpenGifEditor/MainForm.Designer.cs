namespace OpenGifEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTotalFrames = new System.Windows.Forms.Label();
            this.trackBarFrames = new System.Windows.Forms.TrackBar();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.labelCurrentFrame = new System.Windows.Forms.Label();
            this.textBoxCropRight = new System.Windows.Forms.TextBox();
            this.textBoxCropTop = new System.Windows.Forms.TextBox();
            this.textBoxCropLeft = new System.Windows.Forms.TextBox();
            this.textBoxCropBottom = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabMethods = new System.Windows.Forms.TabControl();
            this.cropPage = new System.Windows.Forms.TabPage();
            this.labelCropBottom = new System.Windows.Forms.Label();
            this.buttonCrop = new System.Windows.Forms.Button();
            this.labelCropRight = new System.Windows.Forms.Label();
            this.labelCropLeft = new System.Windows.Forms.Label();
            this.labelCropTop = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonCropLength = new System.Windows.Forms.Button();
            this.buttonSetEnd = new System.Windows.Forms.Button();
            this.buttonSetStart = new System.Windows.Forms.Button();
            this.textBoxCropEnd = new System.Windows.Forms.TextBox();
            this.textBoxCropStart = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFrames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabMethods.SuspendLayout();
            this.cropPage.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTotalFrames
            // 
            this.labelTotalFrames.AutoSize = true;
            this.labelTotalFrames.Location = new System.Drawing.Point(4, 29);
            this.labelTotalFrames.Name = "labelTotalFrames";
            this.labelTotalFrames.Size = new System.Drawing.Size(77, 13);
            this.labelTotalFrames.TabIndex = 2;
            this.labelTotalFrames.Text = "Total frames: 0";
            // 
            // trackBarFrames
            // 
            this.trackBarFrames.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trackBarFrames.Enabled = false;
            this.trackBarFrames.Location = new System.Drawing.Point(0, 369);
            this.trackBarFrames.Maximum = 1;
            this.trackBarFrames.Name = "trackBarFrames";
            this.trackBarFrames.Size = new System.Drawing.Size(434, 45);
            this.trackBarFrames.TabIndex = 3;
            this.trackBarFrames.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarFrames.Scroll += new System.EventHandler(this.trackBarFrames_Scroll);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(3, 3);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 4;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(82, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Gif | *.gif";
            // 
            // labelCurrentFrame
            // 
            this.labelCurrentFrame.AutoSize = true;
            this.labelCurrentFrame.Location = new System.Drawing.Point(4, 45);
            this.labelCurrentFrame.Name = "labelCurrentFrame";
            this.labelCurrentFrame.Size = new System.Drawing.Size(82, 13);
            this.labelCurrentFrame.TabIndex = 6;
            this.labelCurrentFrame.Text = "Current frame: 0";
            // 
            // textBoxCropRight
            // 
            this.textBoxCropRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCropRight.Location = new System.Drawing.Point(65, 58);
            this.textBoxCropRight.Name = "textBoxCropRight";
            this.textBoxCropRight.Size = new System.Drawing.Size(75, 20);
            this.textBoxCropRight.TabIndex = 7;
            this.textBoxCropRight.Text = "0";
            this.textBoxCropRight.TextChanged += new System.EventHandler(this.CoordsChanged);
            // 
            // textBoxCropTop
            // 
            this.textBoxCropTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCropTop.Location = new System.Drawing.Point(65, 32);
            this.textBoxCropTop.Name = "textBoxCropTop";
            this.textBoxCropTop.Size = new System.Drawing.Size(75, 20);
            this.textBoxCropTop.TabIndex = 8;
            this.textBoxCropTop.Text = "0";
            this.textBoxCropTop.TextChanged += new System.EventHandler(this.CoordsChanged);
            // 
            // textBoxCropLeft
            // 
            this.textBoxCropLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCropLeft.Location = new System.Drawing.Point(65, 6);
            this.textBoxCropLeft.Name = "textBoxCropLeft";
            this.textBoxCropLeft.Size = new System.Drawing.Size(75, 20);
            this.textBoxCropLeft.TabIndex = 9;
            this.textBoxCropLeft.Text = "0";
            this.textBoxCropLeft.TextChanged += new System.EventHandler(this.CoordsChanged);
            // 
            // textBoxCropBottom
            // 
            this.textBoxCropBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCropBottom.Location = new System.Drawing.Point(65, 84);
            this.textBoxCropBottom.Name = "textBoxCropBottom";
            this.textBoxCropBottom.Size = new System.Drawing.Size(75, 20);
            this.textBoxCropBottom.TabIndex = 10;
            this.textBoxCropBottom.Text = "0";
            this.textBoxCropBottom.TextChanged += new System.EventHandler(this.CoordsChanged);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "image";
            this.saveFileDialog.Filter = "Gif | *.gif";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(434, 363);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.trackBarFrames);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 414);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.tabMethods);
            this.panel2.Controls.Add(this.buttonOpen);
            this.panel2.Controls.Add(this.labelCurrentFrame);
            this.panel2.Controls.Add(this.buttonSave);
            this.panel2.Controls.Add(this.labelTotalFrames);
            this.panel2.Location = new System.Drawing.Point(452, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 229);
            this.panel2.TabIndex = 12;
            // 
            // tabMethods
            // 
            this.tabMethods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMethods.Controls.Add(this.cropPage);
            this.tabMethods.Controls.Add(this.tabPage2);
            this.tabMethods.Enabled = false;
            this.tabMethods.Location = new System.Drawing.Point(3, 61);
            this.tabMethods.Name = "tabMethods";
            this.tabMethods.SelectedIndex = 0;
            this.tabMethods.Size = new System.Drawing.Size(154, 165);
            this.tabMethods.TabIndex = 6;
            // 
            // cropPage
            // 
            this.cropPage.Controls.Add(this.labelCropBottom);
            this.cropPage.Controls.Add(this.buttonCrop);
            this.cropPage.Controls.Add(this.labelCropRight);
            this.cropPage.Controls.Add(this.textBoxCropLeft);
            this.cropPage.Controls.Add(this.labelCropLeft);
            this.cropPage.Controls.Add(this.labelCropTop);
            this.cropPage.Controls.Add(this.textBoxCropTop);
            this.cropPage.Controls.Add(this.textBoxCropRight);
            this.cropPage.Controls.Add(this.textBoxCropBottom);
            this.cropPage.Location = new System.Drawing.Point(4, 22);
            this.cropPage.Name = "cropPage";
            this.cropPage.Padding = new System.Windows.Forms.Padding(3);
            this.cropPage.Size = new System.Drawing.Size(146, 139);
            this.cropPage.TabIndex = 0;
            this.cropPage.Text = "Crop";
            this.cropPage.UseVisualStyleBackColor = true;
            // 
            // labelCropBottom
            // 
            this.labelCropBottom.AutoSize = true;
            this.labelCropBottom.Location = new System.Drawing.Point(6, 87);
            this.labelCropBottom.Name = "labelCropBottom";
            this.labelCropBottom.Size = new System.Drawing.Size(40, 13);
            this.labelCropBottom.TabIndex = 7;
            this.labelCropBottom.Text = "Bottom";
            // 
            // buttonCrop
            // 
            this.buttonCrop.Location = new System.Drawing.Point(30, 110);
            this.buttonCrop.Name = "buttonCrop";
            this.buttonCrop.Size = new System.Drawing.Size(75, 23);
            this.buttonCrop.TabIndex = 11;
            this.buttonCrop.Text = "Crop";
            this.buttonCrop.UseVisualStyleBackColor = true;
            this.buttonCrop.Click += new System.EventHandler(this.buttonCrop_Click);
            // 
            // labelCropRight
            // 
            this.labelCropRight.AutoSize = true;
            this.labelCropRight.Location = new System.Drawing.Point(6, 61);
            this.labelCropRight.Name = "labelCropRight";
            this.labelCropRight.Size = new System.Drawing.Size(32, 13);
            this.labelCropRight.TabIndex = 6;
            this.labelCropRight.Text = "Right";
            // 
            // labelCropLeft
            // 
            this.labelCropLeft.AutoSize = true;
            this.labelCropLeft.Location = new System.Drawing.Point(6, 9);
            this.labelCropLeft.Name = "labelCropLeft";
            this.labelCropLeft.Size = new System.Drawing.Size(25, 13);
            this.labelCropLeft.TabIndex = 4;
            this.labelCropLeft.Text = "Left";
            // 
            // labelCropTop
            // 
            this.labelCropTop.AutoSize = true;
            this.labelCropTop.Location = new System.Drawing.Point(6, 35);
            this.labelCropTop.Name = "labelCropTop";
            this.labelCropTop.Size = new System.Drawing.Size(26, 13);
            this.labelCropTop.TabIndex = 5;
            this.labelCropTop.Text = "Top";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonCropLength);
            this.tabPage2.Controls.Add(this.buttonSetEnd);
            this.tabPage2.Controls.Add(this.buttonSetStart);
            this.tabPage2.Controls.Add(this.textBoxCropEnd);
            this.tabPage2.Controls.Add(this.textBoxCropStart);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(146, 139);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Crop length";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonCropLength
            // 
            this.buttonCropLength.Location = new System.Drawing.Point(34, 75);
            this.buttonCropLength.Name = "buttonCropLength";
            this.buttonCropLength.Size = new System.Drawing.Size(75, 23);
            this.buttonCropLength.TabIndex = 4;
            this.buttonCropLength.Text = "Crop length";
            this.buttonCropLength.UseVisualStyleBackColor = true;
            this.buttonCropLength.Click += new System.EventHandler(this.buttonCropLength_Click);
            // 
            // buttonSetEnd
            // 
            this.buttonSetEnd.Location = new System.Drawing.Point(6, 32);
            this.buttonSetEnd.Name = "buttonSetEnd";
            this.buttonSetEnd.Size = new System.Drawing.Size(75, 23);
            this.buttonSetEnd.TabIndex = 3;
            this.buttonSetEnd.Text = "Set end";
            this.buttonSetEnd.UseVisualStyleBackColor = true;
            this.buttonSetEnd.Click += new System.EventHandler(this.buttonSetEnd_Click);
            // 
            // buttonSetStart
            // 
            this.buttonSetStart.Location = new System.Drawing.Point(6, 4);
            this.buttonSetStart.Name = "buttonSetStart";
            this.buttonSetStart.Size = new System.Drawing.Size(75, 23);
            this.buttonSetStart.TabIndex = 2;
            this.buttonSetStart.Text = "Set start";
            this.buttonSetStart.UseVisualStyleBackColor = true;
            this.buttonSetStart.Click += new System.EventHandler(this.buttonSetStart_Click);
            // 
            // textBoxCropEnd
            // 
            this.textBoxCropEnd.Location = new System.Drawing.Point(84, 34);
            this.textBoxCropEnd.Name = "textBoxCropEnd";
            this.textBoxCropEnd.Size = new System.Drawing.Size(56, 20);
            this.textBoxCropEnd.TabIndex = 1;
            this.textBoxCropEnd.Text = "0";
            this.textBoxCropEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxCropStart
            // 
            this.textBoxCropStart.Location = new System.Drawing.Point(84, 6);
            this.textBoxCropStart.Name = "textBoxCropStart";
            this.textBoxCropStart.Size = new System.Drawing.Size(56, 20);
            this.textBoxCropStart.TabIndex = 0;
            this.textBoxCropStart.Text = "0";
            this.textBoxCropStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(452, 403);
            this.progressBar.Maximum = 2;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(160, 23);
            this.progressBar.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Open Gif Editor";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFrames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabMethods.ResumeLayout(false);
            this.cropPage.ResumeLayout(false);
            this.cropPage.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelTotalFrames;
        private System.Windows.Forms.TrackBar trackBarFrames;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label labelCurrentFrame;
        private System.Windows.Forms.TextBox textBoxCropRight;
        private System.Windows.Forms.TextBox textBoxCropTop;
        private System.Windows.Forms.TextBox textBoxCropLeft;
        private System.Windows.Forms.TextBox textBoxCropBottom;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabMethods;
        private System.Windows.Forms.TabPage cropPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonCrop;
        private System.Windows.Forms.Label labelCropBottom;
        private System.Windows.Forms.Label labelCropRight;
        private System.Windows.Forms.Label labelCropLeft;
        private System.Windows.Forms.Label labelCropTop;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button buttonCropLength;
        private System.Windows.Forms.Button buttonSetEnd;
        private System.Windows.Forms.Button buttonSetStart;
        private System.Windows.Forms.TextBox textBoxCropEnd;
        private System.Windows.Forms.TextBox textBoxCropStart;
    }
}

