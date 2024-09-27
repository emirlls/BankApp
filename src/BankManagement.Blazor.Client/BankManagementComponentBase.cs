using BankManagement.Localization;
using Volo.Abp.AspNetCore.Components;

namespace BankManagement.Blazor.Client;

public abstract class BankManagementComponentBase : AbpComponentBase
{
    protected BankManagementComponentBase()
    {
        LocalizationResource = typeof(BankManagementResource);
    }
}
