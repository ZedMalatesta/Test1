using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Interfaces
{
    public interface IFreightItem
    {
        double FreightCapacity { get; }
        double FreightWeight { get; }
    }
}
