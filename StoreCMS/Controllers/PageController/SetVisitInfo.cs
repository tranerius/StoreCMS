﻿using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Treynessen.Functions;
using Treynessen.PagesManagement;
using Treynessen.Database.Context;
using Treynessen.Database.Entities;

namespace Treynessen.Controllers
{
    public partial class PageController : Controller
    {
        [NonAction]
        public void SetVisitInfo(int pageID, PageType pageType)
        {
            string ip = HttpContext.Connection.RemoteIpAddress.ToString();
            int ipStringHash = OtherFunctions.GetHashFromString(ip);
            Visitor visitor = db.Visitors.FirstOrDefault(v => v.IpStringHash == ipStringHash && v.IPAdress.Equals(ip, StringComparison.Ordinal));
            if (visitor == null)
            {
                visitor = new Visitor
                {
                    IPAdress = ip,
                    IpStringHash = ipStringHash,
                    FirstVisit = DateTime.Now,
                    LastVisit = DateTime.Now
                };
                db.Visitors.Add(visitor);
            }
            else
            {
                visitor.LastVisit = DateTime.Now;
            }
            db.VisitedPages.Add(new VisitedPage
            {
                VisitedPageId = pageID,
                PageType = pageType,
                Visitor = visitor
            });
            db.SaveChanges();
        }
    }
}