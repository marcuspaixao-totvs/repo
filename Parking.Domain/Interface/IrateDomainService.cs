using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Domain.Interface
{



    public interface  IRateDomainService
    {
        bool Create(Rate rate);
        bool Update(Rate rate);
        bool Delete(Rate rate);


    }
}
