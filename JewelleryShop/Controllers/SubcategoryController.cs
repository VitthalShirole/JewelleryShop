using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using JewelleryShop.Models;
using BLL;
using System.Collections.Generic;
using BOL;

namespace JewelleryShop.Controllers;

public class SubcategoryController : Controller
{
    private readonly ILogger<SubcategoryController> _logger;

    public SubcategoryController(ILogger<SubcategoryController> logger)
    {
        _logger = logger;
    }

    public IActionResult Subcategory()

    {
        CatlogueManager mgr = new CatlogueManager();
        List<Subcategory> listt = mgr.allsubcatagories();
        this.ViewData["xyz"] = listt;

        return View();
    }

    // public IActionResult Index()
    // {
    //     CatalogManager manager=new CatalogManager();
    //     List<Product> allProducts=manager.GetAllProducts();
    //     this.ViewData["products"]=allProducts;
    //     return View();
    // }
}