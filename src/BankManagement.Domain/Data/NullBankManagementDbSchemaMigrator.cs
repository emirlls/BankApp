using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace BankManagement.Data;

/* This is used if database provider does't define
 * IBankManagementDbSchemaMigrator implementation.
 */
public class NullBankManagementDbSchemaMigrator : IBankManagementDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
