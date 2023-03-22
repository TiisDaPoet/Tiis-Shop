using System;
using System.Collections.Generic;
using System.Text;
using TiisShop.Localization;
using Volo.Abp.Application.Services;

namespace TiisShop.Admin;

/* Inherit your application services from this class.
 */
public abstract class TiisShopAdminAppService : ApplicationService
{
    protected TiisShopAdminAppService()
    {
        LocalizationResource = typeof(TiisShopResource);
    }
}
