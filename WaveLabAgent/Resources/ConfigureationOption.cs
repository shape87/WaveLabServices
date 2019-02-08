using System;
using System.Collections.Generic;
using System.Text;

namespace WaveLabAgent.Resources
{
    public class ConfigurationOption
    {
        public Int32 ID { get; set; }
        public String Name { get; set; }
        public Boolean Required { get; set; }
        public String Description { get; set; }
        public string ValueType { get; set; }

        public string[] Options { get; set; }
        public Boolean ShouldSerializeOptions()
        { return Options != null; }

        public dynamic Value { get; set; }
    }
}
