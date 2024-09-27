using BankManagement.Samples;
using Xunit;

namespace BankManagement.EntityFrameworkCore.Domains;

[Collection(BankManagementTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<BankManagementEntityFrameworkCoreTestModule>
{

}
