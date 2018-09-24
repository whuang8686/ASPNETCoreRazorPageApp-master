using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace ASPNetRazorPageDemo.Pages
{
    public class CreateFXTradeModel : PageModel
    {
        [BindProperty]
        //public Book PostBook { get; set; }

        public string Message { get; set; }
        public List<string> MessageList { get; set; }

        //public JsonResult IndexModel()
        //{
        //    this.PostBook = new Book();
              //return null;
        //}

        public void OnGet()
        {
            Message = "系統時間："+DateTime.Now.ToString() ;
            //ReadyDropDownList();
        }

        public JsonResult OnGetList()
        {
            List<string> lstString = new List<string>
            {
                "Val 1",
                "Val 2",
                "Val 3"
            };
            return new JsonResult(lstString);
        }

        public ActionResult OnPostSend()
        {
            string sPostValue1 = "";
            string sPostValue2 = "";
            string sPostValue3 = "";
            {
                MemoryStream stream = new MemoryStream();
                Request.Body.CopyTo(stream);
                stream.Position = 0;
                using (StreamReader reader = new StreamReader(stream))
                {
                    string requestBody = reader.ReadToEnd();
                    if(requestBody.Length > 0)
                    {
                        var obj = JsonConvert.DeserializeObject<PostData>(requestBody);
                        if(obj != null)
                        {
                            sPostValue1 = obj.Item1;
                            sPostValue2 = obj.Item2;
                            sPostValue3 = obj.Item3;
                        }
                    }
                }
            }
            List<string> lstString = new List<string>
            {
                sPostValue1,
                sPostValue2,
                sPostValue3
            };
            return new JsonResult(lstString);
        }

        //private void ReadyDropDownList()
        //{
        //    var list = new List<SelectListItem>();
        //    list.Add(new SelectListItem { Text = "1-Books", Value = "1" });
        //    list.Add(new SelectListItem { Text = "2-PChome", Value = "2" });
        //
        //    ViewData["dp"] = list;
        //}
    }

    //public class Book
    //{
    //public string Name { get; set; }

    //public SourceType Source { get; set; }
    //}

    //public enum SourceType
    //{
    //Default = 0,
    //Books = 1,
    //PCHome = 2
    //}

}