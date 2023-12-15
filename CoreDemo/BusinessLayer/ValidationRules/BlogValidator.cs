﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog başlığını boş geçemezsiniz.");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog içeriğini boş geçemezsiniz.");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog görselini boş geçemezsiniz.");
            RuleFor(x => x.BlogImage).MaximumLength(150).WithMessage("Lütfen 150 karakterden daha az veri girişi yapın.");
            RuleFor(x => x.BlogImage).MinimumLength(10).WithMessage("Lütfen 10 karakterden daha fazla veri girişi yapın.");
        }
    }
}
