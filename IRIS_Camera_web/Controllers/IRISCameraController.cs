using IRIS_Camera_web.Models; 
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace IRIS_Camera_web.Controllers
{
    public class IRISCameraController : Controller
    {
         
        public ActionResult Index()
        {

            return View();
        }
         
        
        [HttpPost]
        public string Save_Image_Capture(string base64image)
        {
            if(base64image != "undefined")
            {
                Random rnd = new Random();
                int num = rnd.Next();

                var strPath = @"C:\Users\admin\Desktop\IMAGES_FACE\" + num.ToString() + "test.jpg";

                byte[] bytes = Convert.FromBase64String(base64image);

                using (var ms = new MemoryStream(bytes))
                {
                    //Image image = Image.FromStream(ms);
                    //image.Save(strPath, ImageFormat.Bmp);
                    return "Saved Succsssfuly";
                }

            }
            
              
            return "The picture has not been Capture yet";
        }

           

    }
}