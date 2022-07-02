using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CankutayUcarCV.DTOs.Concrete.EgitimDtos;
using FluentValidation;

namespace CankutayUcarCV.Business.Validators.EgitimValidator
{
    public class EgitimEkleValidator : AbstractValidator<EgitimEkleDto>
    {
        public EgitimEkleValidator()
        {
            RuleFor(e => e.baslik)
                .NotEmpty().WithMessage("başlık boş bırakılamaz");
            RuleFor(e => e.altBaslik)
                .NotEmpty().WithMessage("alt başlık boş bırakılamaz");
            RuleFor(e => e.icerik)
                .NotEmpty().WithMessage("içerik boş bırakılamaz");
            RuleFor(e => e.baslangic_tarihi)
                .NotEmpty().WithMessage("başlangıç tarihi boş bırakılamaz");
        }
    }
}
