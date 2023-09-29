using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class GuideValidator : AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama kısmını boş geçemezsiniz...!"); ;
            RuleFor(x => x.Description).MinimumLength(10).MaximumLength(200).WithMessage("Açıklama 50-1500 karakter olabilir...!");
           // RuleFor(x => x.Image).NotEmpty().WithMessage("Lütfen Görsel Seçiniz...!");
            RuleFor(x=>x.Name).NotEmpty().WithMessage("Rehber Ad kısmını boş geçemezsiniz...!"); ;
        }
    }
}
