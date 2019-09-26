using Parking.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Domain.Extensions
{
    public static class ExtensionHelper
    {
        public static Parking DtoToEntity(this ParkingDto dto)
        {
            return new Parking()
            {
                Address = dto.Address,
                Description = dto.Description,
                Document = dto.Document,
               // Id = dto.Id,
                Phone = dto.Phone
            };
        }

        public static ParkingDto EntityToDto(this Parking parking)
        {
            return new ParkingDto()
            {
                Address = parking.Address,
                Description = parking.Description,
                Document = parking.Document,
                //Id = parking.Id,
                Phone = parking.Phone
            };
        }


    }
}
