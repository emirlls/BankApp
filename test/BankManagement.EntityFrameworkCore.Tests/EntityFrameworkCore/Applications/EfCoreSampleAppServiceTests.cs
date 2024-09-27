using BankManagement.Samples;
using Xunit;

namespace BankManagement.EntityFrameworkCore.Applications;

[Collection(BankManagementTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<BankManagementEntityFrameworkCoreTestModule>
{

}
