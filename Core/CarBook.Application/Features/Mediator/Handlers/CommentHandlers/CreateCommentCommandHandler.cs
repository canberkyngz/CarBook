using CarBook.Application.Features.Mediator.Commands.CommentCommands;
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
    public class CreateCommentCommandHandler : IRequestHandler<CreateCommnetCommand>
    {
        private readonly IRepository<Comment> _commentRepository;

        public CreateCommentCommandHandler(IRepository<Comment> commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public async Task Handle(CreateCommnetCommand request, CancellationToken cancellationToken)
        {
            await _commentRepository.CreateAsync(new Comment
            {
                BlogId = request.BlogId,
                CreatedDate =DateTime.Parse(DateTime.Now.ToShortDateString()),
                Description = request.Description,
                Name = request.Name,
                Email = request.Email,
            });
        }
    }
}
