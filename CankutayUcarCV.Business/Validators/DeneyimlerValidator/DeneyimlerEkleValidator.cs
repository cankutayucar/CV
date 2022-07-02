using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CankutayUcarCV.DTOs.Concrete.DeneyimlerDtos;
using FluentValidation;

namespace CankutayUcarCV.Business.Validators.DeneyimlerValidator
{
    public class DeneyimlerEkleValidator : AbstractValidator<DeneyimlerEkleDto>
    {
        public DeneyimlerEkleValidator()
        {
            RuleFor(d => d.icerik)
                .NotEmpty().WithMessage("içerik boş bırakılamaz");
            RuleFor(d => d.baslik)
                .NotEmpty().WithMessage("başlık boş bırakılamaz");
            RuleFor(d => d.altBaslik)
                .NotEmpty().WithMessage("alt başlık boş bırakılamaz");
            RuleFor(d => d.baslangic_tarihi)
                .NotEmpty().WithMessage("başlangıç tarihi boş bırakılamaz");
        }
    }
}
