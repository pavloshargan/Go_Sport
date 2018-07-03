using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace WCF.Converters
{
    public static class ImageConverter
    {
        public static Image ToImage(ImageInfo image)
        {
            Image rez = new Image();
            rez.BinaryImage = image.BinaryImage;
            return rez;
        }
    }
}
