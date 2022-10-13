using FluentValidation;
using LibraryManager.Models;

namespace LibraryManager.Utils
{
    public class AdminUserValidation : AbstractValidator<User>
    {
        public AdminUserValidation()
        {
            RuleFor(user => user.name)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .NotEmpty()
                .MinimumLength(3);
            RuleFor(user => user.email)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .EmailAddress()
                .NotEmpty()
                .NotNull();
            RuleFor(user => user.password)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .MinimumLength(6)
                .NotEmpty()
                .NotNull();
        }

    }

    public class LoginValidation : AbstractValidator<User>
    {
        public LoginValidation()
        {
            RuleFor(user => user.email)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .EmailAddress()
                .NotEmpty()
                .NotNull();
            RuleFor(user => user.password)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .MinimumLength(6)
                .NotEmpty()
                .NotNull();
        }

    }

    public class BookValidation : AbstractValidator<Books>
    {
        public BookValidation()
        {
            RuleFor(book => book.title)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .NotNull()
                .MinimumLength(2);
            RuleFor(book => book.author)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .MinimumLength(5)
                .NotEmpty()
                .NotNull();
            RuleFor(book => book.pageCount)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .GreaterThanOrEqualTo(0)
                .NotNull();
        }

    }

    public class UserValidation : AbstractValidator<User>
    {
        public UserValidation()
        {
            RuleFor(user => user.name)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .NotEmpty()
                .MinimumLength(3);
            RuleFor(user => user.email)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .EmailAddress()
                .NotEmpty()
                .NotNull();
            RuleFor(user => user.password)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .MinimumLength(6)
                .NotEmpty()
                .NotNull();
            RuleFor(user => user.role)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .NotNull();
        }

    }

    public class UserUpdateValidation : AbstractValidator<User>
    {
        public UserUpdateValidation()
        {
            RuleFor(user => user.name)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .NotEmpty()
                .MinimumLength(3);
            RuleFor(user => user.email)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .EmailAddress()
                .NotEmpty()
                .NotNull();
            RuleFor(user => user.role)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .NotNull();
        }

    }
}
