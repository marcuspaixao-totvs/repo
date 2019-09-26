using System;
using System.Collections.Generic;
using System.Text;
using Parking.Domain;

namespace Parking.Application.Interface
{

    public interface IRateAppService
    {
        bool Create(Rate rate);
        bool Update(Rate rate);
        bool Delete(Rate rate);


    }



}
