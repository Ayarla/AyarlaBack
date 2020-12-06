using System.Threading.Tasks;
using Ayarla.Models.TokenAuth;
using Ayarla.Web.Controllers;
using Shouldly;
using Xunit;

namespace Ayarla.Web.Tests.Controllers
{
    public class HomeController_Tests: AyarlaWebTestBase
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