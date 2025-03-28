﻿using CarBook.Application.Features.Mediator.Queries.CommentQueries;
using CarBook.Application.Features.Mediator.Results.CommentResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.CommentHandlers
{
    public class GetCommentByIdQueryHandler : IRequestHandler<GetCommentByIdQuery, GetCommentByIdQueryResult>
    {
        private readonly IRepository<Comment> _commentRepository;

        public GetCommentByIdQueryHandler(IRepository<Comment> commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public async Task<GetCommentByIdQueryResult> Handle(GetCommentByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _commentRepository.GetByIdAsync(request.Id);
            return new GetCommentByIdQueryResult
            {
                BlogId = value.BlogId,
                CommentId = value.CommentId,
                CreatedDate = value.CreatedDate,
                Description = value.Description,
                Name = value.Name,
            };
        }
    }
}
