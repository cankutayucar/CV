using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CankutayUcarCV.DTOs.Concrete.YeteneklerDtos;
using FluentValidation;

namespace CankutayUcarCV.Business.Validators.YeteneklerValidator
{
    public class YeteneklerGuncelleValidator : AbstractValidator<YeteneklerGuncelleDto>
    {
        public YeteneklerGuncelleValidator()
        {
            RuleFor(y => y.id)
                .NotEmpty().WithMessage("id alanı boş geçilemez");
        }
    }
}
