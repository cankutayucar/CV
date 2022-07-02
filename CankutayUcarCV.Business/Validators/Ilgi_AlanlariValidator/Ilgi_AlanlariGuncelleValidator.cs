using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CankutayUcarCV.DTOs.Concrete.Ilgi_AlanlariDtos;
using FluentValidation;

namespace CankutayUcarCV.Business.Validators.Ilgi_AlanlariValidator
{
    public class Ilgi_AlanlariGuncelleValidator : AbstractValidator<Ilgi_AlanlariGuncelleDto>
    {
        public Ilgi_AlanlariGuncelleValidator()
        {
            RuleFor(ia => ia.id)
                .NotEmpty().WithMessage("id alanı boş bırakılamaz");
        }
    }
}
