using Microsoft.AspNetCore.Http;
using System.Drawing;

namespace DigiMoallem.BLL.Helpers.Security
{
    public static class ImageValidator
    {
        public static bool IsImage(this IFormFile file) {
            try
            {
                // convert file to image success
                var image = Image.FromStream(file.OpenReadStream());
                return true;
            }
            catch 
            {
                return false;
            }
        }
    }
}
