using System;
using System.Collections.Generic;
using System.Text;
using Parking.Domain;

namespace Parking.Application.Interface
{

    public interface ICarAppService
    {
        bool Create(Car car);
        bool Update(Car car);
        bool Delete(Car car);
    }



}
