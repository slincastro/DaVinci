using System;
using DaVinci.WebAPI.Domain;
using Xunit;

namespace DaVinci.WebAPI.Tests.DomainTests
{
    public class SystemComponentTests
    {
        [Fact]
        public void ShouldCreateValidObject()
        {
            const string description = "Description of valid system weon";
            const string systemName = "ValidSystem";
            
            var expectedSystem = new 
            { 
                    Name = systemName, 
                    Description = description
            };

            var system = new SystemComponent(systemName , description);

            Assert.Equal(expectedSystem.Name, system.Name);
            Assert.Equal(expectedSystem.Description, system.Description);
        }

        [Fact]
        public void ShouldThrowArgumentExceptionWithMessageWhenInvalidName()
        {
            var description = "some beautiful description";
            string expectedExceptionMessage = "Field name is required";

            var exception = Assert.Throws<ArgumentException>(()=>new SystemComponent(string.Empty, description));
            
            Assert.Equal(expectedExceptionMessage, exception.Message);
        }
    }
}