using System.Drawing;

namespace OpenGifEditor
{
    internal interface IImage
    {
        int Width { get; }
        int Height { get; }

        void Save(string path);
        void Crop(Rectangle rect);
    }
}