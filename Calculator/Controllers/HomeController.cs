using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Calculator.Models;
using Microsoft.AspNetCore.Http;

namespace Calculator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(new Calculate());
        }

        [HttpPost]
        public IActionResult Index(Calculate calculator, string operation)
        {
            int result = 0;
            switch (operation)
            {
                case "add":
                    result = calculator.firstNum + calculator.secondNum;
                    break;
                case "sub":
                    result = calculator.firstNum - calculator.secondNum;
                    break;
            }

            calculator.total = result;

            return View(calculator);
        }

        [HttpPost]
        public IActionResult Calculator(string input)
        {
            string display = "";

            if(input != "=")
            {
                display = HttpContext.Session.GetString("display") + input;

            } else {

                for (int i = 0; i < display.Length; i++)
                {
                    switch (display[i])
                    {
                        case '/':
                            display = (int.Parse(display[i].ToString()) / int.Parse(display[i + 1].ToString())).ToString();
                            break;

                        case '*':
                            if (display[i + 1] != null)
                            {
                                display = (display[i] / display[i + 1]).ToString();

                            }

                            break;
                    }
                }
            }

            HttpContext.Session.SetString("display", display);

            ViewBag.Display = display;

            return View();
        }

        public ActionResult Calculate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Calculat(string firstNumber, string secondNumber, string Cal)
        {
            int a = Convert.ToInt32(firstNumber);
            int b = Convert.ToInt32(secondNumber);
            int c = 0;
            switch (Cal)
            {
                case "Add":
                    c = a + b;
                    break;
                case "Sub":
                    c = a - b;
                    break;
                case "Mul":
                    c = a * b;
                    break;
                case "Div":
                    c = a / b;
                    break;
            }
            ViewBag.Result = c;
            return View();
        }

        public void runOperation(string display) {
}

    }
}
