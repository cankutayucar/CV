using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CankutayUcarCV.DTOs.Concrete.SertifikalarDtos;
using FluentValidation;

namespace CankutayUcarCV.Business.Validators.SertifikalarValidator
{
    public class SertifikalarGuncelleValidator : AbstractValidator<SertifikalarGuncelleDto>
    {
        public SertifikalarGuncelleValidator()
        {
            RuleFor(s => s.id)
                .NotEmpty().WithMessage("id alanı boş geçilemez");
            RuleFor(s => s.icerik)
                .NotEmpty().WithMessage("sertifika boş geçilemez");
        }
    }
}
