﻿using Microsoft.EntityFrameworkCore;
using Treynessen.Database.Context;
using Treynessen.Database.Entities;

namespace Treynessen.Functions
{
    public static partial class OtherFunctions
    {
        public static bool HasMainPage(CMSDatabase db)
        {
            UsualPage usualPage =db.UsualPages.FirstOrDefaultAsync(up => up.RequestPathWithoutAlias.Equals("/") && up.Alias.Equals("index")).Result;
            db.Entry(usualPage).State = EntityState.Detached;
            return usualPage == null ? false : true;
        }
    }
}
