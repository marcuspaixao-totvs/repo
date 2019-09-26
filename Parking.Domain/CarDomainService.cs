using Parking.Domain.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Domain.Interface
{
    class CarDomainService : ICarDomainService
    {
        private ParkingDataContext _context { get; set; }
        public CarDomainService(ParkingDataContext context)
        {
            _context = context;
        }
        public bool Create(Car car)
        {
            //var executed = false;
            try
            {
                _context.Car.Add(car);
                _context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }

        }


        public bool Update(Car car)
        {
            //var executed = false;
            try
            {
                _context.Car.Update(car);
                _context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool Delete(Car car)
        {
            //var executed = false;
            try
            {
                _context.Car.Remove(car);
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

