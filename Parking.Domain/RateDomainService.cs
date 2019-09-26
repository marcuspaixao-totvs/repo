using Parking.Domain.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Domain.Interface
{
    class RateDomainService : IRateDomainService
    {
        private ParkingDataContext _context { get; set; }
        public RateDomainService(ParkingDataContext context)
        {
            _context = context;
        }
        public bool Create(Rate rate)
        {
            //var executed = false;
            try
            {
                _context.Rate.Add(rate);
                _context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }

        }


        public bool Update(Rate rate)
        {
            //var executed = false;
            try
            {
                _context.Rate.Update(rate);
                _context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool Delete(Rate rate)
        {
            //var executed = false;
            try
            {
                _context.Rate.Remove(rate);
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

