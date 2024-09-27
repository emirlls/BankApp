using BankManagement.Localization;
using Volo.Abp.AspNetCore.Components;

namespace BankManagement.Blazor.WebApp.Tiered.Client;

public abstract class BankManagementComponentBase : AbpComponentBase
{
    protected BankManagementComponentBase()
    {
        LocalizationResource = typeof(BankManagementResource);
    }
}
