using BankManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace BankManagement.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BankManagementController : AbpControllerBase
{
    protected BankManagementController()
    {
        LocalizationResource = typeof(BankManagementResource);
    }
}
