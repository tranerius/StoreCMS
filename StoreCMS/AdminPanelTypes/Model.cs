﻿using Treynessen.PagesManagement;

namespace Treynessen.AdminPanelTypes
{
    public class Model
    {
        public AdminPanelPages? PageId { get; set; }
        public PageType? PageType { get; set; }
        public int? itemID { get; set; }

        public string Name { get; set; }
        public string Path { get; set; }

        public Microsoft.AspNetCore.Http.IFormFile uploadedFile { get; set; }
        public int? imageID { get; set; }

        public PageModel PageModel { get; set; }
        public TemplateModel TemplateModel { get; set; }
        public StyleModel StyleModel { get; set; }
        public AccessSettingsModel AccessSettingsModel { get; set; }
    }
}