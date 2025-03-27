﻿using CarBook.Application.Features.Mediator.Results.StatisticsResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UdemyCarBook.Application.Features.Mediator.Queries.StatisticsQueries
{
    public class GetBlogCountQuery:IRequest<GetBlogCountQueryResult>
    {
    }
}
