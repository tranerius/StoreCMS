﻿namespace Treynessen.Localization
{
    public interface IAdminPanelPageLocalization
    {
        string Title { get; }

        string MainPage { get; }
        string Pages { get; }
        string CategoriesAndProducts { get; }
        string Templates { get; }
        string TemplateChunks { get; }
        string Files { get; }
        string Settings { get; }
    }
}