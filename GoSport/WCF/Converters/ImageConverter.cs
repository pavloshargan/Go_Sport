using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace WCF
{
    public static class ImageConverter
    {
        public static Image ToImage(ImageInfo image)
        {
            Image rez = new Image();
            rez.BinaryImage = image.BinaryImage;
            return rez;
        }
        public static ImageInfo ToImageInfo(Image image)
        {
            ImageInfo rez = new ImageInfo();
            rez.BinaryImage = image.BinaryImage;
            return rez;
        }
    }
}
