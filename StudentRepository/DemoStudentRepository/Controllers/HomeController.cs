using DemoStudentRepository.Models;
using Library.DomainData.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DemoStudentRepository.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            var L_Sttudent = await _unitOfWork.Students.GetAllSutdent();
            //var L_Classes = await _unitOfWork.Classes.GetAll();
            List<ModelStudent> L_Data = new List<ModelStudent>();
            foreach(var item in L_Sttudent)
            {               
                var S_Data = new ModelStudent()
                {
                    IdClass = item.IDClassStudent,
                    IdStudent = item.IDStudent,
                    Name = item.NameStudent,
                    //NameClass = L_Sttudent.FirstOrDefault(x=>x.IDClass == x.T_Class.IDClass).n
                };
                L_Data.Add(S_Data);
            }
            return View(L_Data);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
