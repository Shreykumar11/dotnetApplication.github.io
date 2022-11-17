using Microsoft.AspNetCore.Mvc;

namespace MyFirstWebApp.Controllers
{
    public class CalculatorController : Controller
    {
        public int num1 { get; set; }
        public int num2 { get; set; }

        [HttpGet]
        //public IActionResult Calci()
        //{
        //    return View();
        //}

        public int Add (int num1, int num2)
        { return num1 + num2; }

        public int Subtract (int num1, int num2) 
        { return num1 - num2; }

        public int Multiply (int num1, int num2) 
        { return num1 * num2; }

        public int Divide (int num1, int num2) 
        { return num1 / num2; }

        public void Main()
        {
            CalculatorController controller = new CalculatorController();
            controller.Add(7, 8);
            controller.Subtract(6, 9);
            controller.Multiply(7, 10);
            controller.Divide(70, 10);
        }
    }
}
