using Microsoft.AspNetCore.Builder;
using BankManagement;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<BankManagementWebTestModule>();

public partial class Program
{
}
