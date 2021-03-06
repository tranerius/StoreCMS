﻿using System;
using Treynessen.PagesManagement;

namespace Treynessen.AdminPanelTypes
{
    public class Model
    {
        public AdminPanelPages? PageId { get; set; }
        public PageType? PageType { get; set; }
        public int? itemID { get; set; }

        public DateTime? CurrentLogDate { get; set; }

        public string Name { get; set; }
        public string Path { get; set; }

        public PageModel PageModel { get; set; }
        public RedirectionModel RedirectionModel { get; set; }
        public TemplateModel TemplateModel { get; set; }
        public StyleModel StyleModel { get; set; }
        public UserTypeModel UserTypeModel { get; set; }
        public SynonymForStringModel SynonymForStringModel { get; set; }
        public UserModel UserModel { get; set; }
        public SettingsModel SettingsModel { get; set; }
    }
}