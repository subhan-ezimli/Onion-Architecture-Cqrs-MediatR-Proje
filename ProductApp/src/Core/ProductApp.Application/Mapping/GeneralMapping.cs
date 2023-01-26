﻿using AutoMapper;
using ProductApp.Application.Dto;
using ProductApp.Application.Features.Commands.CreateProduct;
using ProductApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<Product,ProductViewDto>().ReverseMap();
            CreateMap<Product , CreateProductCommand>().ReverseMap();

        }
    }
}
