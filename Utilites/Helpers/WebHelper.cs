using Microsoft.AspNetCore.Http;

namespace CoreAndUtilites.Helpers
{
    public class WebHelper
    {
        public string rootPlusGuid { get; set; }
        public void Add(IFormFile file, string zroot)
        {
            if (file.Length > 0)
            {
                rootPlusGuid= zroot + Guid.NewGuid().ToString()+Path.GetExtension(file.FileName);
                if (!Directory.Exists(zroot))
                {
                    Directory.CreateDirectory(zroot);
                }
                using (FileStream fileStream = File.Create(rootPlusGuid))
                {
                    file.CopyTo(fileStream);
                    fileStream.Flush();
                }


            }
           
        }

        public void Update(IFormFile file, string zroot)
        {
                if (!Directory.Exists(zroot))
                {
                    Directory.CreateDirectory(zroot);
                }

                
                    if (file!=null)
                        {
                        rootPlusGuid = zroot + Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                        
                        using (FileStream fileStream = File.Create(rootPlusGuid))
                            {
                                file.CopyTo(fileStream);
                                fileStream.Flush();


                              }
                      

                     }
  
        }

    }
        


}
