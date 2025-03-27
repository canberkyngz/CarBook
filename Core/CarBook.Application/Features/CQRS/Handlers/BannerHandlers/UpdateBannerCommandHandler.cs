using CarBook.Application.Features.CQRS.Commands.AboutCommands;
using CarBook.Application.Features.CQRS.Commands.BannerCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class UpdateBannerCommandHandler
    {
        private readonly IRepository<Banner> _bannerRepository;

        public UpdateBannerCommandHandler(IRepository<Banner> bannerRepository)
        {
            _bannerRepository = bannerRepository;
        }

        public async Task Handle(UpdateBannerCommand command)
        {
            var value = await _bannerRepository.GetByIdAsync(command.BannerId);
            value.Description = command?.Description;
            value.Title = command?.Title;
            value.VideoUrl = command?.VideoUrl;
            value.VideoDescription = command?.VideoDescription;
            await _bannerRepository.UpdateAsync(value);
        }
    }
}
