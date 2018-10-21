using ImageMagick;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OpenGifEditor
{
    public partial class MainForm : Form
    {
        GifImage gif;
        MagickImage overlay;
        Rectangle cropRect;

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(string path) : this()
        {
            OpenFile(path);
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                OpenFile(openFileDialog.FileName);
            }
        }

        private void OpenFile(string path)
        {
            gif = new GifImage(path);
            cropRect = new Rectangle();

            // save the path
            saveFileDialog.FileName = System.IO.Path.GetFileName(path);

            // show image
            GenerateOverlay();
            ShowFrame(0);

            // setup elements
            labelTotalFrames.Text = string.Format("Total frames: {0}", gif.FramesCount);
            trackBarFrames.Maximum = gif.FramesCount - 1;
            trackBarFrames.Value = 0;
            textBoxCropStart.Text = "1";
            textBoxCropEnd.Text = (gif.FramesCount).ToString();

            // enable elements
            var elementsToEnable = new List<Control>
            {
                trackBarFrames, tabMethods, buttonSave
            };

            foreach (var element in elementsToEnable)
            {
                element.Enabled = true;
            }
        }

        private void trackBarFrames_Scroll(object sender, EventArgs e)
        {
            ShowFrame(trackBarFrames.Value);
        }

        private int ParseInt(string str, int defaultValue = 0)
        {
            if (int.TryParse(str, out int i))
            {
                return i;
            }
            else
            {
                return defaultValue;
            }
        }

        private MagickImage GenerateOverlay()
        {
            Size resolution = new Size(gif.Width, gif.Height);

            Rectangle cropValues = new Rectangle(
                ParseInt(textBoxCropLeft.Text),
                ParseInt(textBoxCropTop.Text),
                ParseInt(textBoxCropRight.Text),
                ParseInt(textBoxCropBottom.Text)
            );

            cropRect = new Rectangle(
                cropValues.X,
                cropValues.Y,
                resolution.Width - cropValues.Right,
                resolution.Height - cropValues.Bottom
            );

            MagickImage overlay = new MagickImage(
                MagickColor.FromRgba(255, 0, 0, 128),
                resolution.Width,
                resolution.Height
            );

            // draw transparent rectangle
            overlay.Composite(
                new MagickImage(
                    MagickColor.FromRgba(0, 0, 0, 0),
                    cropRect.Width,
                    cropRect.Height
                ),
                cropRect.X,
                cropRect.Y
            );

            this.overlay = overlay;
            return overlay;
        }

        private void ShowFrame(int frameIndex)
        {
            MagickImage renderImage = new MagickImage(gif.GetFrame(frameIndex));
            renderImage.Composite(overlay, CompositeOperator.Over);

            labelCurrentFrame.Text = string.Format("Current frame: {0}", trackBarFrames.Value + 1);
            labelCurrentFrame.Update();

            pictureBox1.Image = renderImage.ToBitmap();
        }

        private void CoordsChanged(object sender, EventArgs e)
        {
            GenerateOverlay();
            ShowFrame(trackBarFrames.Value);
        }

        private void ResetCropFields()
        {
            foreach (var textBox in new TextBox[] {
                textBoxCropLeft,
                textBoxCropTop,
                textBoxCropRight,
                textBoxCropBottom
            })
            {
                textBox.Text = "0";
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                gif.Save(saveFileDialog.FileName);
            }
        }

        private void buttonCrop_Click(object sender, EventArgs e)
        {
            gif.Crop(cropRect);
            ResetCropFields();
            GenerateOverlay();
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            //if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            OpenFile(files[0]);
        }

        private void buttonSetStart_Click(object sender, EventArgs e)
        {
            textBoxCropStart.Text = (trackBarFrames.Value + 1).ToString();
        }

        private void buttonSetEnd_Click(object sender, EventArgs e)
        {
            textBoxCropEnd.Text = (trackBarFrames.Value + 1).ToString();
        }

        private void buttonCropLength_Click(object sender, EventArgs e)
        {
            int start = ParseInt(textBoxCropStart.Text, 1) - 1;
            int end = ParseInt(textBoxCropEnd.Text, gif.FramesCount-1) - 1;

            gif.CropLength(start, end);

            // reinit ui
            trackBarFrames.Maximum = gif.FramesCount - 1;
            trackBarFrames.Value = 0;
            labelTotalFrames.Text = string.Format("Total frames: {0}", gif.FramesCount);
            textBoxCropStart.Text = "1";
            textBoxCropEnd.Text = (gif.FramesCount).ToString();
            ShowFrame(0);
        }
    }
}
