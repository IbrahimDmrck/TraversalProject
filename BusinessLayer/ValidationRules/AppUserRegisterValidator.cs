using DTOLayer.AppUserDTOs;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDTO>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş geçemezsiniz...!");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad alanı boş geçemezsiniz...!");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail alanı boş geçemezsiniz...!");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı adı alanı boş geçemezsiniz...!");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanı boş geçemezsiniz...!");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre tekrar boş geçilemez...!");
            RuleFor(x => x.Username).MinimumLength(5).WithMessage("kullanıcı adı en az 5 karakter olmalı");
            RuleFor(x => x.Username).MaximumLength(20).WithMessage("kullanıcı adı en fazla 20 karakter olmalı");
            RuleFor(x => x.Password).Equal(y => y.ConfirmPassword).WithMessage("Şifre aynı değil !");
        }
    }
}
