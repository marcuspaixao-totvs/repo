using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Dto.Validation
{
    public class AssociateValidator : AbstractValidator<ParkingDto>
    {
        public AssociateValidator()
        {
            RuleFor(x => x.Description)
                .MaximumLength(200).WithMessage("Verifique o tamanho máximo do campo Descrição")
                .NotEmpty().WithMessage("Informe o campo Descrição");
            RuleFor(x => x.Document)
                .NotEmpty().WithMessage("Informe o documento do estacionamento");
            RuleFor(x => x.Address)
                .NotEmpty().WithMessage("Informe o endereço do estacionamento");
            RuleFor(x => x.Phone)
                .NotEmpty().WithMessage("Informe o telefone do estacionamento");
        }
    }
}
