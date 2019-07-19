﻿using System;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Treynessen.Functions;
using Treynessen.Extensions;
using Treynessen.AdminPanelTypes;
using Treynessen.SettingsManagement;
using Treynessen.TemplatesManagement;

namespace Treynessen.Controllers
{
    public partial class AdminPanelController : Controller
    {
        [NonAction]
        public IActionResult EditSettings(SettingsModel model, HttpContext context)
        {
            ConfigurationHandler configurationHandler = context.RequestServices.GetRequiredService<ConfigurationHandler>();
            configurationHandler.ChangeConfigFile(model);
            if (!string.IsNullOrEmpty(model.ProductBlockTemplate))
            {
                IHostingEnvironment env = context.RequestServices.GetRequiredService<IHostingEnvironment>();
                string pathToTemplate = env.GetProductBlockTemplateFullPath();
                string oldTemplate = OtherFunctions.GetFileContent(pathToTemplate);
                if (!model.ProductBlockTemplate.Equals(oldTemplate, StringComparison.InvariantCulture))
                {
                    using (StreamWriter writer = new StreamWriter(pathToTemplate))
                    {
                        writer.Write(model.ProductBlockTemplate);
                    }
                    string[] additions = {
                        "@using Treynessen.Functions;",
                        "@using Treynessen.ImagesManagement;",
                        "@using Treynessen.Database.Entities;",
                        "@addTagHelper Treynessen.TagHelpers.ImageTagHelper, StoreCMS"
                    };
                    string cshtmlTemplate = TemplatesManagementFunctions.SourceToCSHTML(
                        db: db,
                        source: model.ProductBlockTemplate,
                        modelType: "ProductPage",
                        env: env,
                        skipChunkName: null,
                        additions: additions
                    );
                    using (StreamWriter writer = new StreamWriter(env.GetProductBlockCshtmlFullPath()))
                    {
                        writer.Write(cshtmlTemplate);
                    }
                }
            }
            return StatusCode(200);
        }
    }
}