using Parking.Domain.Context;
using Parking.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Domain.Interface
{
    class ParkingDomainService : IParkingDomainService
    {
        private ParkingDataContext _context { get; set; }
        public ParkingDomainService(ParkingDataContext context)
        {
            _context = context;
        }
        public bool Create(ParkingDto parkingDto)
        {
            //var executed = false;
            try
            {
                _context.Parking.Add(new Parking()
                {
                    Address = parkingDto.Address,
                    Description = parkingDto.Description,
                    Document = parkingDto.Document,
                    Phone = parkingDto.Phone

                }   );



                _context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }

        }
    }


}

