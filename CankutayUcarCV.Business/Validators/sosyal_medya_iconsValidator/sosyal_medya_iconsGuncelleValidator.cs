using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CankutayUcarCV.DTOs.Concrete.sosyal_medya_iconsDtos;
using FluentValidation;

namespace CankutayUcarCV.Business.Validators.sosyal_medya_iconsValidator
{
    public class sosyal_medya_iconsGuncelleValidator : AbstractValidator<sosyal_medya_iconsGuncelleDto>
    {
        public sosyal_medya_iconsGuncelleValidator()
        {
            RuleFor(smi => smi.id)
                .NotEmpty().WithMessage("id alanı boş bırakılamaz");
            RuleFor(smi => smi.Kullanici_id)
                .NotEmpty().WithMessage("kullanıcı id alanı boş bırakılamaz");
        }
    }
}
