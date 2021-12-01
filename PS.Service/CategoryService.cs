﻿using System.Collections.Generic;
using System.Linq;
using PS.Data;
using PS.Data.Infrastructures;
using PS.Domain;

namespace PS.Service
{
    public class CategoryService:Service<Category>,ICategoryService
    {
        public CategoryService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}