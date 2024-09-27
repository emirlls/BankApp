using BankManagement.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace BankManagement.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class BankManagementPageModel : AbpPageModel
{
    protected BankManagementPageModel()
    {
        LocalizationResourceType = typeof(BankManagementResource);
    }
}
