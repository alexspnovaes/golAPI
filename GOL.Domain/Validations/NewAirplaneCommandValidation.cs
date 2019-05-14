using FluentValidation;
using GOL.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOL.Domain.Validations
{
    public class NewAirplaneCommandValidation : AbstractValidator<NewAirplaneCommand>
    {
        public NewAirplaneCommandValidation()
        {
            RuleFor(airplane => airplane.Modelo).NotNull().WithMessage("Modelo cannot be null");
        }
    }
}
