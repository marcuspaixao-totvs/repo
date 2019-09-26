using Parking.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Application.Interface
{

    public interface IParkingAppService
    {
       
        bool Create(ParkingDto dto);
        bool Delete(int id);
        List<ParkingDto> GetAll();
        List<ParkingDto> GetAllWithDapper();
        ParkingDto GetById(int id);
    }


}
