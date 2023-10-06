using DTOLayer.AnnouncementDTOs;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class AnnouncementValidator : AbstractValidator<AnnouncementAddDTO>
    {
        public AnnouncementValidator()
        {
            RuleFor(x => x.Tİtle).NotEmpty().WithMessage("Başlık kısmını boş geçemezsiniz...!");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Lütfen içerik Seçiniz...!");
            RuleFor(x => x.Tİtle).MinimumLength(5).MaximumLength(50).WithMessage("Başlık 5-50 karakter olabilir...!");
            RuleFor(x => x.Content).MinimumLength(5).MaximumLength(50).WithMessage("içerik 20-500 karakter olabilir...!");
        }
    }
}
