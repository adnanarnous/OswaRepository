using System.Threading.Tasks;
using OswaTech.Models.TokenAuth;
using OswaTech.Web.Controllers;
using Shouldly;
using Xunit;

namespace OswaTech.Web.Tests.Controllers
{
    public class HomeController_Tests: OswaTechWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}