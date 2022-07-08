using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CankutayUcarCV.DTOs.Concrete.KullaniciDtos;
using FluentValidation;

namespace CankutayUcarCV.Business.Validators.KullaniciValidator
{
    public class KullaniciSifreValidator : AbstractValidator<KullaniciSifreDto>
    {
        public KullaniciSifreValidator()
        {
            RuleFor(p => p.EskiSifre)
                .NotEmpty().WithMessage("Parola Boş Geçilemez");
            RuleFor(p=>p.YeniSIFRE)
                .NotEmpty().WithMessage("Parola Boş Geçilemez");
            RuleFor(p => p.YeniSIFREONAYLA)
                .NotEmpty().WithMessage("Parola Boş Geçilemez");
            RuleFor(p => p.YeniSIFRE).Equal(a => a.YeniSIFREONAYLA).WithMessage("parolalar aynı değil");

        }
    }
}
