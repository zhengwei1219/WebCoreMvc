using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace MyWebCore.Controllers
{
    public class PublishController : Controller
    {
        INewsService _newsService;
        IFriendlyLinkService _friendlyLinkService;
        public PublishController(INewsService newsService, IFriendlyLinkService friendlyLinkService)
        {
            _newsService = newsService;
            _friendlyLinkService = friendlyLinkService;
    }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PublishNews()
        {
            try
            {
                string publishBy = Request.Form["account"];
                if(publishBy != "zhengwei")
                {
                    throw new Exception("发布人有误！");
                }
                string title = Request.Form["title"];
                string content = Request.Form["content"]; 
                    string newstype = Request.Form["newstype"];
                News news = new News();
                news.Title = title;
                news.PublishedBy = publishBy;
                news.PublishedTime = DateTime.Now;
                news.Content = content;
                news.BrowsedTimes = 1000;
                news.Type = newstype;
                _newsService.Add(news);
            }
            catch (Exception ex)
            {

                throw new Exception("发布出错");
            }
            return Content("OK");
        }
        public IActionResult PublishFriendlylink()
        {
            try
            {
                string friendlyUse = Request.Form["friendlyUse"];
                if (friendlyUse != "zhengwei")
                {
                    throw new Exception("发布人有误！");
                }
                string url = Request.Form["friendlylink"];
                string friendlyName = Request.Form["friendlyName"];
                FriendlyLink friendlyLink = new FriendlyLink();
                friendlyLink.LinkUrl = url;
                friendlyLink.Title = friendlyName;
                friendlyLink.PublishDate = DateTime.Now;
                _friendlyLinkService.Add(friendlyLink);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return Content("OK");
        }
    }
}