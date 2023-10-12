using DTOLayer.AnnouncementDTOs;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class AnnouncementUpdateValidator : AbstractValidator<AnnouncementUpdateDTO>
    {
        public AnnouncementUpdateValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık kısmını boş geçemezsiniz...!");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Lütfen içerik Seçiniz...!");
            RuleFor(x => x.Title).MinimumLength(5).MaximumLength(50).WithMessage("Başlık 5-50 karakter olabilir...!");
            RuleFor(x => x.Content).MinimumLength(5).MaximumLength(50).WithMessage("içerik 20-500 karakter olabilir...!");
        }
    }
}
