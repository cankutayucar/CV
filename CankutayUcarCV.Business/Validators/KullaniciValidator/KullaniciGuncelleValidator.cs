using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CankutayUcarCV.DTOs.Concrete.KullaniciDtos;
using FluentValidation;

namespace CankutayUcarCV.Business.Validators.KullaniciValidator
{
    public class KullaniciGuncelleValidator : AbstractValidator<KullaniciGuncelleDto>
    {
        public KullaniciGuncelleValidator()
        {
            RuleFor(k => k.id)
                .NotEmpty().WithMessage("id boş geçilemez");
        }
    }
}
