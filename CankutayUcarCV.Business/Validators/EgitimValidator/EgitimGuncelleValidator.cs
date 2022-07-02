using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CankutayUcarCV.DTOs.Concrete.EgitimDtos;
using FluentValidation;

namespace CankutayUcarCV.Business.Validators.EgitimValidator
{
    public class EgitimGuncelleValidator : AbstractValidator<EgitimGuncelleDto>
    {
        public EgitimGuncelleValidator()
        {
            RuleFor(e => e.id)
                .NotEmpty().WithMessage("id alanı boş bırakılamaz");

        }
    }
}
