using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Interfaces
{
    public interface ISeatsSearchingWithValidation : ISeatsSearching 
    {
        bool SeatsValidation(int value);
        bool SeatsValidation(int value1, int value2);
    }
}
