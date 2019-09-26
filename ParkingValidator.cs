using System;
using System.Text;
using System.Collections.Generic;
using FluentValidation;

namespace Parking.Dto.Validation
{

    public class ParkingValidator : AbstractValidator<ParkingDto>
    {
        public ParkingValidator ()
        {

            RuleFor(x => x.Description).NotEmpty().MaximumLength(200).WithMessage("Informe um nome ou verifique o tamanho máximo do campo Descrição");
            RuleFor(x => x.Document).NotEmpty().WithMessage("Informe pelo menos um documento para o estacionamento");
            RuleFor(x => x.Address).NotEmpty().WithMessage("Informe o endereço do estacionamento");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Informe o telefone do estacionamento");

        }
    }

}
