using Xunit;

namespace BankManagement.EntityFrameworkCore;

[CollectionDefinition(BankManagementTestConsts.CollectionDefinitionName)]
public class BankManagementEntityFrameworkCoreCollection : ICollectionFixture<BankManagementEntityFrameworkCoreFixture>
{

}
