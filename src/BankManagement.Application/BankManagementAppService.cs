using System;
using System.Collections.Generic;
using System.Text;
using BankManagement.Localization;
using Volo.Abp.Application.Services;

namespace BankManagement;

/* Inherit your application services from this class.
 */
public abstract class BankManagementAppService : ApplicationService
{
    protected BankManagementAppService()
    {
        LocalizationResource = typeof(BankManagementResource);
    }
}
