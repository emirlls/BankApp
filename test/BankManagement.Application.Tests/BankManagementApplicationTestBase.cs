using Volo.Abp.Modularity;

namespace BankManagement;

public abstract class BankManagementApplicationTestBase<TStartupModule> : BankManagementTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
