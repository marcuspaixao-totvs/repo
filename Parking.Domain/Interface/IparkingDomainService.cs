﻿using Parking.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Domain.Interface
{



    public interface  IParkingDomainService
    {
        bool Create(ParkingDto parking);
        
    }
}
