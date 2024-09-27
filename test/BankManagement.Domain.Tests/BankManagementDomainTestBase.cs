using Volo.Abp.Modularity;

namespace BankManagement;

/* Inherit from this class for your domain layer tests. */
public abstract class BankManagementDomainTestBase<TStartupModule> : BankManagementTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
