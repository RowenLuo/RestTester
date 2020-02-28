using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestTester.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public int ApiCount { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool IsShared { get; set; }
    }
}