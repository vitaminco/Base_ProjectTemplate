using App.Data.Entities;
using App.Data.Repositories;
using App.Share.Consts;
using App.Web.Common;
using App.Web.ViewModels.Role;
using App.Web.ViewModels.User;
using App.Web.WebConfig;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace App.Web.Controllers
{
    public class CategoryController : AppControllerBase
    {
        public CategoryController(IMapper mapper) : base(mapper)
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
