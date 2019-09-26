using System;
using System.Collections.Generic;
using Parking.Domain.Extensions;
using Parking.Domain.Context;
using Parking.Dto;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Dapper;

namespace Parking.Infra
{
    public class ParkingReadRepository : IParkingReadRepository
    {

        private readonly ParkingDataContext _context;

        public ParkingReadRepository(ParkingDataContext context)
        {
            _context = context;
        }

        public int Id { get; private set; }

        public List<ParkingDto> GetAll()
        {
            return (from parking in _context.Parking
                   select parking.EntityToDto()).ToList() ;
        }

        public List<ParkingDto> GetAllWithDapper()

        {
            var ret = new List<ParkingDto>();

            using (var connection = _context.Database.GetDbConnection()) 
            {
                ret = connection.Query<ParkingDto>("Select Id, Descripition, Document, Address, Phone from Parking").ToList();
            }

            return ret;
        }

        public ParkingDto GetById(int id)
        {
            return _context.Parking.Where(x=> x.Id == Id)
                .Select(x => x.EntityToDto()).FirstOrDefault();
        }

        
        
    }
}
