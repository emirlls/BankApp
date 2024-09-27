using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace BankManagement.Pages;

public class Index_Tests : BankManagementWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
