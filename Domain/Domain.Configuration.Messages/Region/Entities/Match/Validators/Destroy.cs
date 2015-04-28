﻿using FluentValidation;
using Demo.Library.Command;
using System;

namespace Demo.Domain.Configuration.Region.Entities.Match.Validators
{
    public class Destroy : AbstractValidator<Commands.Destroy>
    {
        public Destroy()
        {
            RuleFor(x => x.RegionId).NotEmpty();
            RuleFor(x => x.MatchId).NotEmpty();
        }
    }
}