﻿using CarBook.Application.Features.Mediator.Queries.CarPricingQueries;
using CarBook.Application.Features.Mediator.Results.CarPricingResults;
using CarBook.Application.Interfaces.CarPricingInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.CarPricingHandlers
{
    public class GetCarPricingWithCarsQueryHadnler : IRequestHandler<GetCarPricingQuery, List<GetCarPricingQueryResult>>
    {
        private readonly ICarPricingRepository _carPricingRepository;

        public GetCarPricingWithCarsQueryHadnler(ICarPricingRepository carPricingRepository)
        {
            _carPricingRepository = carPricingRepository;
        }

        public async  Task<List<GetCarPricingQueryResult>> Handle(GetCarPricingQuery request, CancellationToken cancellationToken)
        {
            var values =  _carPricingRepository.GetCarPricingWithCars();
            return values.Select(x=> new GetCarPricingQueryResult
            {
                Amount = x.Amount,
                Brand = x.Car?.Brand?.Name,
                CarPricingId =x.CarPricingID,
                CoverImageUrl = x.Car?.CoverImageUrl,
                Model = x.Car?.Model,
                CartId = x.CarID
            }).ToList();
        }
    }
}
