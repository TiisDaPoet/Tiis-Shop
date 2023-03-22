using Volo.Abp.Modularity;

namespace TiisShop.Admin;

[DependsOn(
    typeof(TiisShopAdminApplicationModule),
    typeof(TiisShopDomainTestModule)
    )]
public class TiisShopApplicationTestModule : AbpModule
{

}
