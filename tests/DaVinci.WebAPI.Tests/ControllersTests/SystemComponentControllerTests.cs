using System.Collections.Generic;
using System.Linq;
using DaVinci.WebAPI.Controllers;
using DaVinci.WebAPI.Domain;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace DaVinci.WebAPI.Tests.ControllersTests
{
    public class SystemComponentControllerTests
    {
        [Fact]
        public void ShouldReturnOkAndThreeSystemCompenentsWhenCallingGet()
        {
            var systemComponentController = new SystemComponentController();
            
            var response = systemComponentController.Get();

            var result = Assert.IsType<OkObjectResult>(response);

            var model = Assert.IsAssignableFrom<List<SystemComponent>>(result.Value);
            Assert.Equal(3, model.Count);
        }

        [Fact]
        public void ShouldBeController()
        {
            var parentClass = typeof(SystemComponentController).BaseType.Name;
            const string ExpectedParentType = "Controller";
            Assert.Equal(ExpectedParentType, parentClass);
        }

        [Fact]
        public void ShouldHaveRouteAttributeInController()
        {
            var classAttributes = typeof(SystemComponentController)
                                    .GetCustomAttributes(typeof(RouteAttribute),false)
                                    .FirstOrDefault();
 
            Assert.IsType<RouteAttribute>(classAttributes);
        }
    }
}