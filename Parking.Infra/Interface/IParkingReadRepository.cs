using Parking.Dto;
using System;
using System.Collections.Generic;
using System.Text;


public interface IParkingReadRepository
{
    List<ParkingDto> GetAll();
    ParkingDto GetById(int id);
    List<ParkingDto> GetAllWithDapper();
}




