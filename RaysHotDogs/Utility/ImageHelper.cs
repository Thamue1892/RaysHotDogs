using System.Net;
using Android.Graphics;

namespace RaysHotDogs.Utility
{
    public class ImageHelper
    {
        public static Bitmap GetImageBitmapFromUrl(string url)
        {
            Bitmap imageBitmap = null;

            using (var WebClient = new WebClient())
            {
                var imageBytes = WebClient.DownloadData(url);
                if (imageBytes != null && imageBytes.Length > 0)
                {
                    imageBitmap = BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);
                }

                return imageBitmap;
            }
        }
    }
}