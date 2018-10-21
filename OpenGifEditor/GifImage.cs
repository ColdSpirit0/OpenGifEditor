using ImageMagick;
using System;
using System.Drawing;

namespace OpenGifEditor
{
    class GifImage : IImage, IAnimatedImage
    {
        private MagickImageCollection collection;

        public int Width { get; private set; }
        public int Height { get; private set; }

        public int FramesCount { get; private set; }

        public int Looping { get; private set; }
        public int Delay { get; private set; }

        public GifImage(string path)
        {
            collection = new MagickImageCollection(path);
            collection.Coalesce();

            // setup data
            Width = collection[0].Width;
            Height = collection[0].Height;

            FramesCount = collection.Count;

            Delay = collection[0].AnimationDelay;
            Looping = collection[0].AnimationIterations;
        }

        public IMagickImage GetFrame(int frameIndex)
        {
            return collection[frameIndex];
        }

        public void Crop(Rectangle cropRect)
        {
            // validate input
            if (!(
                cropRect.X >= 0 &&
                cropRect.Y >= 0 &&
                cropRect.Width >= 0 &&
                cropRect.Height >= 0 &&
                cropRect.X + cropRect.Width <= Width &&
                cropRect.Y + cropRect.Height <= Height
            )) throw new ArgumentOutOfRangeException();

            // crop each frame
            foreach (var image in collection)
            {
                image.Crop(new MagickGeometry(cropRect));
            }

            collection.RePage();

            // reset values
            Width = collection[0].Width;
            Height = collection[0].Height;
        }

        public void Save(string path)
        {
            var saveCollection = collection.Clone();
            saveCollection.OptimizePlus();
            //collection.OptimizePlus();

            QuantizeSettings quanitizeSettings = new QuantizeSettings();
            quanitizeSettings.Colors = 256;
            saveCollection.Quantize(quanitizeSettings);

            saveCollection.Write(path);
        }

        public void CropLength(int start, int end)
        {
            end++;

            // validate input
            if (!((start >= 0) && (end <= FramesCount) && (start <= end))) throw new ArgumentOutOfRangeException();

            // remove tail
            for (int i = 0; i < (FramesCount - 1 - end); i++)
            {
                collection.RemoveAt(end);
            }

            // remove head
            for (int i = 0; i < start; i++)
            {
                collection.RemoveAt(0);
            }

            FramesCount = collection.Count;
        }
    }
}
