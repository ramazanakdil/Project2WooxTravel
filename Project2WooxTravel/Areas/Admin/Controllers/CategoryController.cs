﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2WooxTravel.Context;
using Project2WooxTravel.Entities;

namespace Project2WooxTravel.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        TravelContext context = new TravelContext();
        [Authorize]
        public ActionResult CategoryList()
        {
            var values = context.Categories.ToList();
            return View(values);
        }
        public ActionResult UpdateCategory(int id)
        {
            var value = context.Categories.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateCategory(Category category)
        {
            var value = context.Categories.Find(category.CategoryId);

            if (value != null)
            {
                value.CategoryName = category.CategoryName;
                value.CategoryStatus = category.CategoryStatus;
                context.SaveChanges();
            }

            return RedirectToAction("CategoryList", "Category", "Admin");
        }
        public ActionResult InsertCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult InsertCategory(Category category)
        {
            context.Categories.Add(category);
            context.SaveChanges();
            return RedirectToAction("CategoryList", "Category", "Admin");
        }
        public ActionResult DeleteCategory(int id)
        {
            var value = context.Categories.Find(id);
            context.Categories.Remove(value);
            context.SaveChanges();
            return RedirectToAction("CategoryList", "Category", "Admin");

        }
    }
}