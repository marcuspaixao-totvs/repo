using Parking.Application.Interface;
using Parking.Domain;
using Parking.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Application
{
    public class CarAppService : ICarAppService
    {
        private ICarDomainService _carDomainService { get; set; }

        public CarAppService(ICarDomainService carDomainService)
        {
            _carDomainService = carDomainService;
        }

        public bool Create(Car car)
        {
            return _carDomainService.Create(car);
        }

        public bool Update(Car car)
        {
            return _carDomainService.Update(car);
        }

        public bool Delete(Car car)
        {
            return _carDomainService.Delete(car);
        }


    }
}
