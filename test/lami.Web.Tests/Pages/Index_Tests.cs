using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace lami.Pages
{
    public class Index_Tests : lamiWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
