using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dotnet6_vuejs3.Controllers
{
    public class UsersController : Controller
    {

        [HttpGet("/getusers")]

        public IActionResult Index()
        {
            return Ok(new {message = "all users"});

        }
    }
}