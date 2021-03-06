﻿using AquariumMonitor.APIModels;
using AquariumMonitor.Models;
using AquariumMonitor.Models.APIModels;
using AutoMapper;

namespace AquariumAPI.Models
{
    public class AquariumProfile : Profile
    {
        public AquariumProfile()
        {
            CreateMap<Unit, string>().ConvertUsing(a => a.Name);

            CreateMap<AquariumType, string>().ConvertUsing(a => a.Name);

            CreateMap<Aquarium, AquariumModel>()
                .ForMember(a => a.Url, opt => opt.ResolveUsing<AquariumUrlResolver>())
                .ReverseMap();

            CreateMap<Measurement, MeasurementModel>()
                .ForMember(a => a.Url,
                opt => opt.ResolveUsing<MeasurementUrlResolver>())
                .ReverseMap();

            CreateMap<WaterChange, WaterChangeModel>()
                .ForMember(a => a.Url,
                opt => opt.ResolveUsing<WaterChangeUrlResolver>())
                .ReverseMap();

            CreateMap<User, UserModel>()
                .ForMember(a => a.Url,
                opt => opt.ResolveUsing<UserUrlResolver>())
                .ReverseMap();
        }
    }
}
