using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CankutayUcarCV.DTOs.Concrete.YeteneklerDtos;
using FluentValidation;

namespace CankutayUcarCV.Business.Validators.YeteneklerValidator
{
    public class YeteneklerEkleValidator : AbstractValidator<YeteneklerEkleDto>
    {
        public YeteneklerEkleValidator()
        {
            RuleFor(y => y.icerik)
                .NotEmpty().WithMessage("içerik alanı boş geçilemez");
        }
    }
}
