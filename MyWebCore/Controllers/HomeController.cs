using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BLL;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace MyWebCore
{

    public class HomeController : BaseContoller
    {
        INewsService _newsService;
        IFriendlyLinkService _friendlyLinkService;
        public HomeController(INewsService newsService, IFriendlyLinkService friendlyLinkService)
        {
            _newsService = newsService;
            _friendlyLinkService = friendlyLinkService;
        }
        public IActionResult Index()
        {
            ViewBag.zxzx = _newsService.GetAll().Where(s=>s.Type == "最新资讯").OrderByDescending(s=>s.PublishedTime).Take(10).ToList();
            ViewBag.cgal = _newsService.GetAll().Where(s => s.Type == "成功案例").OrderByDescending(s => s.PublishedTime).Take(10).ToList();
            ViewBag.fwxm = _newsService.GetAll().Where(s => s.Type == "服务项目").OrderByDescending(s => s.PublishedTime).Take(10).ToList();
            ViewBag.fwxm1 = _newsService.GetAll().Where(s => s.Type == "服务项目1").OrderByDescending(s => s.PublishedTime).Take(10).ToList();
            ViewBag.tpcs = _newsService.GetAll().Where(s => s.Type == "投票小常识").OrderByDescending(s => s.PublishedTime).Take(10).ToList();
            ViewBag.cjwt = _newsService.GetAll().Where(s => s.Type == "常见问题").OrderByDescending(s => s.PublishedTime).Take(10).ToList();
            return View();
        }
        public IActionResult GetNewsInfo(int id)
        {
            News news = _newsService.GetById(id);
            return View("NewsInfo",news);
        }
        public string FootView()
        {
            string html = string.Empty;
            List<FriendlyLink> friendlyLinks = _friendlyLinkService.GetAll().OrderByDescending(s => s.PublishDate).Take(20).ToList();
            foreach (FriendlyLink item in friendlyLinks)
            {
                html += string.Format("<a href='{0}' target='_blank'>{1}</a>&nbsp;|&nbsp;", item.LinkUrl,item.Title);
            }
            
            return html;
        }

        public IActionResult SystemManager()
        {
            return View();
        }

        public IActionResult NewsList(string type)
        {
            ViewBag.NewsType = type;
            return View();
        }
        public JsonResult GetNewsList(int page, int limit,string newsType)
        {
            string ab = UnicodeToGB(newsType);
            var newsList = _newsService.GetAll().Where(s=>s.Type == "投票小常识")
                                        .Skip((page-1)*limit)
                                        .Take(limit)
                                        .OrderByDescending(s=>s.PublishedTime)
                                        .Select(a => new {  id=a.Id, title=a.Title, content=a.Content, publishedTime= a.PublishedTime.HasValue?a.PublishedTime.Value.ToShortDateString():"" })
                                        .ToList();

            return Json(new { code = 0, data = newsList, count = _newsService.GetAll().Count() });
        }
        public static string UnicodeToGB(string content)
        {
            Regex objRegex = new Regex("&#x([\\d]{4});", RegexOptions.IgnoreCase);
            Match objMatch = objRegex.Match(content);
            if (objMatch.Success)
            {
                StringBuilder sb = new StringBuilder(content);
                while (objMatch.Success)
                {
                    string code = Convert.ToString(Convert.ToInt32(objMatch.Result("${UnicodeCode}")), 16);
                    byte[] array = new byte[2];
                    array[0] = (byte)Convert.ToInt32(code.Substring(2), 16);
                    array[1] = (byte)Convert.ToInt32(code.Substring(0, 2), 16);

                    sb.Replace(objMatch.Value, Encoding.Unicode.GetString(array));

                    objMatch = objMatch.NextMatch();
                }
                return sb.ToString();
            }
            else
            {
                return content;
            }
        }


        //public IActionResult Contact()
        //{
        //    ViewData["Message"] = "Your contact page.";

        //    return View();
        //}

        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
