using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AlisPieShop.Models;
using AlisPieShop.ViewModels;

namespace AlisPieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            PiesListViewModel pieListViewModel = new PiesListViewModel();
            pieListViewModel.Pies = _pieRepository.Pies;

            pieListViewModel.CurrentCategory = "Cheese Cakes";
            return View(pieListViewModel);
        }
    }
}