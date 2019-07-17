﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Treynessen.Security;
using Treynessen.Database;
using Treynessen.PagesManagement;
using Treynessen.AdminPanelTypes;
using Treynessen.ImagesManagement;
using Treynessen.Database.Entities;

namespace Treynessen.Controllers
{
    public partial class AdminPanelController : Controller
    {
        [HttpDelete]
        public IActionResult AdminPanel(AdminPanelPages pageID, int? itemID, int? imageID, string path)
        {
            AccessLevelConfiguration accessLevelConfiguration = HttpContext.RequestServices.GetService<AccessLevelConfiguration>();
            HttpContext.Items["AccessLevelConfiguration"] = accessLevelConfiguration;
            User user = SecurityFunctions.CheckCookies(db, HttpContext);
            if (!SecurityFunctions.HasAccessTo(pageID, user, HttpContext))
                return RedirectToAction(nameof(AdminPanel));
            switch (pageID)
            {
                case AdminPanelPages.DeletePage:
                    DatabaseInteraction.DeletePage(db, PageType.Usual, itemID, HttpContext);
                    return StatusCode(200);

                case AdminPanelPages.DeleteCategory:
                    DatabaseInteraction.DeletePage(db, PageType.Category, itemID, HttpContext);
                    return StatusCode(200);

                case AdminPanelPages.DeleteProduct:
                    DatabaseInteraction.DeleteProduct(db, itemID, HttpContext);
                    return StatusCode(200);

                case AdminPanelPages.DeleteProductImage:
                    ImagesManagementFunctions.DeleteProductImage(db, itemID, imageID, HttpContext);
                    return StatusCode(200);

                default:
                    return RedirectToAction(nameof(AdminPanel));
            }
        }
    }
}