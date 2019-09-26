using Parking.Application.Interface;
using Parking.Domain;
using Parking.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Application
{
    public class RateAppService : IRateAppService
    {
        private IRateDomainService _rateDomainService { get; set; }

        public RateAppService(IRateDomainService rateDomainService)
        {
            _rateDomainService = rateDomainService;
        }

        public bool Create(Rate rate)
        {
            return _rateDomainService.Create(rate);
        }

        public bool Update(Rate rate)
        {
            return _rateDomainService.Update(rate);
        }

        public bool Delete(Rate rate)
        {
            return _rateDomainService.Delete(rate);
        }

    }
}
