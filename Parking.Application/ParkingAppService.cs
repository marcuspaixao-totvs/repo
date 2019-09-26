using Parking.Application.Interface;
using Parking.Domain;
using Parking.Domain.Interface;
using Parking.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Application
{
    public class ParkingAppService : IParkingAppService
    {
        private  IParkingDomainService _parkingDomainService { get; set; }
        private  IParkingReadRepository _parkingreadRepository { get; set; }

        public ParkingAppService(IParkingDomainService parkingDomainService , IParkingReadRepository parkingreadRepository) 
        {
            _parkingDomainService = parkingDomainService;
            _parkingreadRepository = parkingreadRepository;
        }

        public bool Create(ParkingDto dto)
        {
            return _parkingDomainService.Create(dto);
        }
        /*
        public bool Create(ParkingDto dto)
        {
            throw new NotImplementedException();
        }
        */
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ParkingDto> GetAll()
        {
            return _parkingreadRepository.GetAll();
        }

        public List<ParkingDto> GetAllWithDapper()
        {
            return _parkingreadRepository.GetAllWithDapper();
        }

        public ParkingDto GetById(int id)
        {
            return _parkingreadRepository.GetById(id);
        }
    }
}
