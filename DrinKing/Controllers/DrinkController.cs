﻿using DrinKing.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using DrinKing.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinKing.ViewModels;

namespace DrinKing.Controllers
{
    public class DrinkController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IDrinkRepository _drinkRepository;
        public DrinkController(ICategoryRepository categoryRepository, IDrinkRepository drinkRepository)
        {
            _categoryRepository = categoryRepository;
            _drinkRepository = drinkRepository;
        }
        public ViewResult List()
        {
            ViewBag.Name = "Dotnet, How?";
            DrinkListViewModel vm = new DrinkListViewModel();
            vm.Drinks = _drinkRepository.Drinks;
            vm.CurrentCategory = "DrinkCategory";
            return View(vm);
        }
    }
}
