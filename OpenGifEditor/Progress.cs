using System;
using System.Threading;
using System.Windows.Forms;

namespace GifEditor
{
    class Progress : IDisposable
    {
        ProgressBar pb;

        public Progress(ProgressBar pb)
        {
            this.pb = pb;
            pb.Maximum = 3;

            ChangeValue(1);
        }

        private void ChangeValue(int value)
        {
            pb.Value = value;
            pb.Refresh();
            pb.Update();
            pb.Invalidate();
            pb.Parent.Invalidate();
            pb.Parent.Update();
            pb.Parent.Invalidate();
            Application.DoEvents();
        }

        public void Dispose()
        {
            ChangeValue(0);
        }
    }
}
