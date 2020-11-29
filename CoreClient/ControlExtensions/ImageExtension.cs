using System.Drawing;

namespace CoreClient.ControlExtensions
{
    public static class ImageExtension
    {
        public static Image FromBitmapWithSize(Bitmap source) => new Bitmap(source);
        public static Image FromBitmap32(Bitmap source) => new Bitmap(source, new Size(32, 32));
        public static Image FromBitmap16(Bitmap source) => new Bitmap(source, new Size(16, 16));
    }
}
