using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CankutayUcarCV.DTOs.Concrete.SertifikalarDtos;
using FluentValidation;

namespace CankutayUcarCV.Business.Validators.SertifikalarValidator
{
    public class SertifikalarEkleValidator : AbstractValidator<SertifikalarEkleDto>
    {
        public SertifikalarEkleValidator()
        {
            RuleFor(s => s.icerik)
                .NotEmpty().WithMessage("sertifika alanı boş geçilemez");
        }
    }
}
