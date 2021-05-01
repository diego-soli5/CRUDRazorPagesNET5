﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDRazorPages.Domain.Extensions
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<DataAccess.Entities.MovieEntity, Models.Movie.Movie>().ReverseMap();
            CreateMap<DataAccess.Entities.DirectorEntity, Models.Director.Director>().ReverseMap();
            CreateMap<DataAccess.Entities.DirectorEntity, Models.Director.ViewModel.DirectorForDDLViewModel>();
        }
    }
}
