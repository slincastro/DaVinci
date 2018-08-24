using System;
using System.Collections.Generic;

namespace DaVinci.WebAPI.Domain
{
    public class SystemComponent
    {
        public SystemComponent(string systemName, string description)
        {

            Name = !string.IsNullOrEmpty(systemName) ? systemName 
            : throw new ArgumentException("Field name is required");
            Description = description;
        }

        public string Name { get; set; }
        public string Description { get; set; }
    }
}