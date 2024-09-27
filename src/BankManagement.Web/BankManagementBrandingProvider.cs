using Microsoft.Extensions.Localization;
using BankManagement.Localization;
using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace BankManagement.Web;

[Dependency(ReplaceServices = true)]
public class BankManagementBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<BankManagementResource> _localizer;

    public BankManagementBrandingProvider(IStringLocalizer<BankManagementResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
