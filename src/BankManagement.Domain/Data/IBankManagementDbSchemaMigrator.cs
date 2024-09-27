using System.Threading.Tasks;

namespace BankManagement.Data;

public interface IBankManagementDbSchemaMigrator
{
    Task MigrateAsync();
}
