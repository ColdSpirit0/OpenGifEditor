using ImageMagick;

namespace OpenGifEditor
{
    internal interface IAnimatedImage
    {
        int FramesCount { get; }
        int Looping { get; }
        int Delay { get; }
        IMagickImage GetFrame(int frameIndex);
        void CropLength(int start, int end);
    }
}