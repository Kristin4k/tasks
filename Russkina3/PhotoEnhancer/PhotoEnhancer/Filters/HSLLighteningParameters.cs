using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEnhancer
{
    public class HSLLighteningParameters : IParameters
    {
        public double Coefficient { get; set; }
        public ParameterInfo[] GetDecription()
        {
            return new[]
            {
                new ParameterInfo()
                {
                    Name = "Коэффициент",
                    MinValue = 0.2,
                    MaxValue = 5,
                    DefaultValue = 1,
                    Increment = 0.01
                }
            };
        }

        public void SetValues(double[] values)
        {
            Coefficient = values[0];
        }
    }
}
