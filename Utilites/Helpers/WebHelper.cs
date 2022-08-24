using Microsoft.AspNetCore.Http;

namespace CoreAndUtilites.Helpers
{
    public class WebHelper
    {

        public string Add(IFormFile file, string zroot)
        {
            if (file.Length > 0)
            {
                if (!Directory.Exists(zroot))
                {
                    Directory.CreateDirectory(zroot);
                }
                using (FileStream fileStream = System.IO.File.Create(zroot + file.FileName))
                {
                    file.CopyTo(fileStream);
                    fileStream.Flush();
                    return "Success upload";
                }


            }
            else
            {
                return "Error";

            }
        }

    }
}
