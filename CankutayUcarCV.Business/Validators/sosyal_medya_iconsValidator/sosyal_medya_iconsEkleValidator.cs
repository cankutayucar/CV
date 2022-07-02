using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CankutayUcarCV.DTOs.Concrete.sosyal_medya_iconsDtos;
using FluentValidation;

namespace CankutayUcarCV.Business.Validators.sosyal_medya_iconsValidator
{
    public class sosyal_medya_iconsEkleValidator : AbstractValidator<sosyal_medya_iconsEkleDto>
    {
        public sosyal_medya_iconsEkleValidator()
        {
            RuleFor(smi => smi.Kullanici_id)
                .NotEmpty().WithMessage("kullanıcı id alanı boş geçilemez");
            RuleFor(smi => smi.icon)
                .NotEmpty().WithMessage("icon boş bırakılamaz");
            RuleFor(smi => smi.link)
                .NotEmpty().WithMessage("link boş bırakılamaz");
        }
    }
}
