﻿using Microsoft.AspNetCore.Mvc;
using Treynessen.Database.Entities;
using Treynessen.AdminPanelTypes;
using Treynessen.Functions;

namespace Treynessen.Controllers
{
    public partial class AdminPanelController : Controller
    {
        [HttpGet]
        public IActionResult AdminPanel(AdminPanelModel model)
        {
            User user = DataCheck.CheckCookies(db, HttpContext);
            if(!DataCheck.HasAccessTo(AdminPanelPages.MainPage, user, HttpContext))
                return LoginForm();
            if (!DataCheck.HasAccessTo(model.PageId, user, HttpContext))
                model.PageId = AdminPanelPages.MainPage;

            HttpContext.Items["User"] = user;

            switch (model.PageId.Value)
            {
                case AdminPanelPages.Pages:
                    return Pages();
                case AdminPanelPages.AddPage:
                    return AddPage();
                case AdminPanelPages.EditPage:
                    return EditPage(model.PageType, model.itemID);
                case AdminPanelPages.Categories:
                    return Categories();
                case AdminPanelPages.ShowCategoryProducts:
                    return ShowCategoryProducts(model.itemID);
                case AdminPanelPages.AddProduct:
                    return AddProduct(model.PageModel);
                case AdminPanelPages.ProductImages:
                    return ProductImages(model.itemID);
                case AdminPanelPages.EditProduct:
                    return EditProduct(model.itemID, model.PageModel);
                case AdminPanelPages.Templates:
                    return Templates();
                case AdminPanelPages.AddTemplate:
                    return AddTemplate();
                case AdminPanelPages.EditTemplate:
                    return EditTemplate(model.itemID);
                case AdminPanelPages.TemplateChunks:
                    return TemplateChunks();
                case AdminPanelPages.AddTemplateChunk:
                    return AddTemplateChunk();
                case AdminPanelPages.EditTemplateChunk:
                    return EditTemplateChunk(model.itemID);
                case AdminPanelPages.Settings:
                    return Settings();
                default:
                    return MainPage();
            }
        }
    }
}