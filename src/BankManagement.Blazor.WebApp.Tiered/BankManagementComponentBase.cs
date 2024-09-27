using BankManagement.Localization;
using Volo.Abp.AspNetCore.Components;

namespace BankManagement.Blazor.WebApp.Tiered;

public abstract class BankManagementComponentBase : AbpComponentBase
{
    protected BankManagementComponentBase()
    {
        LocalizationResource = typeof(BankManagementResource);
    }
}
