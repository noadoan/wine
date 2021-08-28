using BLL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApi_Wine_World.Controllers
{  [EnableCors(origins: "*", methods: "*", headers: "*")]
    public class ImageController : ApiController
    {

            [HttpPost]
            public HttpResponseMessage uploadImage(int Id)
            {
                //string imageName = null;
                var httpReqest = HttpContext.Current.Request;
                // upload image
                var postedFile = httpReqest.Files["Image"];

                byte[] buffer = new byte[16 * 1024];
                byte[] g;
                using (MemoryStream ms = new MemoryStream())
                {
                    int read;
                    while ((read = postedFile.InputStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        ms.Write(buffer, 0, read);
                    }
                    //return ms.ToArray();
                    g = ms.ToArray();
                }
            ProductService productService = new ProductService();
            productService.GetProducts(Id, g);
            return Request.CreateResponse(g);
        }
            //public IHttpActionResult Get()
            //{
                //using (LilelileEntities db = new LilelileEntities())
                //{
                //    Images Imagef = db.Images.FirstOrDefault();

                //    // MemoryStream mem = new MemoryStream(Imagef.Filevalue);
                //    Stream stream = new MemoryStream(Imagef.Filevalue);

                //    HttpResponseMessage response = new HttpResponseMessage();

                //    response.Content = new StreamContent(stream);
                //    response.Content.Headers.ContentType = new MediaTypeHeaderValue("image/jpeg");
                //    //byte[] byteArray = imageConverter.GetImageAsBytes(@"\filepath-to-image.jpeg");
                //    List<Byte[]> imageList = new List<Byte[]>();
                //    imageList.AddRange(db.Images.Select(x => x.Filevalue));
                //    return Json(imageList);


                //}
            //}

        }
    }


