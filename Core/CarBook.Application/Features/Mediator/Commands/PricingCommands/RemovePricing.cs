﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.PricingCommands
{
    public class RemovePricing : IRequest
    {
        public int Id { get; set; }

        public RemovePricing(int id)
        {
            Id = id;
        }
    }
}
