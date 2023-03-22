﻿using TiisShop.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace TiisShop.Admin.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class TiisShopController : AbpControllerBase
{
    protected TiisShopController()
    {
        LocalizationResource = typeof(TiisShopResource);
    }
}
