using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Domain.Interface
{



    public interface  ICarDomainService
    {
        bool Create(Car car);
        bool Update(Car car);
        bool Delete(Car car);

    }
}
