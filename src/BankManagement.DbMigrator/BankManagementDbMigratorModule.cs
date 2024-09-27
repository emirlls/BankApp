using BankManagement.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace BankManagement.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BankManagementEntityFrameworkCoreModule),
    typeof(BankManagementApplicationContractsModule)
    )]
public class BankManagementDbMigratorModule : AbpModule
{
}
