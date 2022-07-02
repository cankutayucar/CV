using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CankutayUcarCV.DTOs.Concrete.DeneyimlerDtos;
using FluentValidation;

namespace CankutayUcarCV.Business.Validators.DeneyimlerValidator
{
    public class DeneyimlerUpdateValidator : AbstractValidator<DeneyimlerGuncelleDto>
    {
        public DeneyimlerUpdateValidator()
        {
            RuleFor(d => d.id)
                .NotEmpty().WithMessage("id boş geçilemez");
        }
    }
}
