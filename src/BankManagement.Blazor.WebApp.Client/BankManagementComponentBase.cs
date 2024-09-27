using BankManagement.Localization;
using Volo.Abp.AspNetCore.Components;

namespace BankManagement.Blazor.WebApp.Client;

public abstract class BankManagementComponentBase : AbpComponentBase
{
    protected BankManagementComponentBase()
    {
        LocalizationResource = typeof(BankManagementResource);
    }
}
