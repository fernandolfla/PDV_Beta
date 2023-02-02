using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Beta.Component
{
    public class ResizeIMG
    {
        public static void ResizeImage(string originalFile, string newFile, int newWidth, int maxHeight/*, bool onlyResizeIfWider*/)
        {
            Image fullsizeImage = Image.FromFile(originalFile);

            // Prevent using images internal thumbnail
            fullsizeImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
            fullsizeImage.RotateFlip(RotateFlipType.Rotate180FlipNone);

            //if (onlyResizeIfWider)
            //{
            //    if (fullsizeImage.Width <= newWidth)
            //    {
            //        newWidth = fullsizeImage.Width;
            //    }
            //}

            int newHeight = fullsizeImage.Height * newWidth / fullsizeImage.Width;
            if (newHeight > maxHeight)
            {
                // Resize with height instead
                newWidth = fullsizeImage.Width * maxHeight / fullsizeImage.Height;
                newHeight = maxHeight;
            }

            Image newImage = fullsizeImage.GetThumbnailImage(newWidth, newHeight, null, IntPtr.Zero);

            // Clear handle to original file so that we can overwrite it if necessary
            fullsizeImage.Dispose();

            // Save resized picture
            newImage.Save(newFile);
        }
    }
}
