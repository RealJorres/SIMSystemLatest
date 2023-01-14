using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMSystem
{
    class ConvertSignature
    {
        public static byte[] toBinaryArray(Image img, ImageFormat format)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, format);
            byte[] arr = ms.ToArray();
            ms.Dispose();
            return arr;
        }

        public static Image toImage(byte[] arr)
        {
            MemoryStream ms = new MemoryStream(arr);
            Image img = Image.FromStream(ms, false, false);
            ms.Dispose();
            return img;
        }
    }
}
