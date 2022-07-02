using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CankutayUcarCV.DTOs.Concrete.Ilgi_AlanlariDtos;
using FluentValidation;

namespace CankutayUcarCV.Business.Validators.Ilgi_AlanlariValidator
{
    public class Ilgi_AlanlariEkleValidator : AbstractValidator<Ilgi_AlanlariEkleDto>
    {
        public Ilgi_AlanlariEkleValidator()
        {
            RuleFor(ia => ia.icerik)
                .NotEmpty().WithMessage("içerik alanı boş geçilemez");
        }
    }
}
