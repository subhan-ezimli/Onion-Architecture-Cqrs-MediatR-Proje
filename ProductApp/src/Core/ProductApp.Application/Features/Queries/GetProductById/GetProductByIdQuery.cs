using AutoMapper;
using MediatR;
using ProductApp.Application.Dto;
using ProductApp.Application.Features.Queries.GetAllProducts;
using ProductApp.Application.Interfaces.Repository;
using ProductApp.Application.Wrappers;
using ProductApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Features.Queries.GetProductById
{
    public class GetProductByIdQuery : IRequest<ServiceResponse<ProductViewDto>>
    {
        public Guid Id  { get; set; }
        public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ServiceResponse<ProductViewDto>>
        {
            private readonly IMapper _mapper;
            private readonly IProductRepository _productRepository;

            public GetProductByIdQueryHandler(IMapper mapper, IProductRepository productRepository)
            {
                _mapper = mapper;
                _productRepository = productRepository;
            }

            public async Task<ServiceResponse<ProductViewDto>> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
            {
                var product = await _productRepository.GetByIdAsync(request.Id);
                var dto = _mapper.Map<Product, ProductViewDto>(product);
                return new ServiceResponse<ProductViewDto>(dto);
                    
              }
        }

    }
}
