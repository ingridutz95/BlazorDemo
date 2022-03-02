using BlazorWebApp.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebApp.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        public List<EmployeeModel> EmployeeModels { get; set; }

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<WeatherForecast> Get()
        {
            var rng = new Random();
            var forecasts = Enumerable.Range(1, 10).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();

            return forecasts.ToList();
        }

        [HttpGet("employees/{department}")]
        public IReadOnlyCollection<EmployeeModel> GetEmployeesDepartments(string department)
        {
            var listEmployees = this.GetAllEmployees();
            var employeesToGet = listEmployees.Where(x => x.Department == department).ToList();
            return employeesToGet;
        }

        private List<EmployeeModel> GetAllEmployees()
        {
            var listEmployees = new List<EmployeeModel>();
            listEmployees.AddRange(
                new EmployeeModel[]
                {
                        new EmployeeModel
                        {
                            Name = "Allan",
                            Title = "analyst",
                            Department = "finance",
                            EmploymentDate = DateTime.Now,
                            Salary = 53000
                        },
                        new EmployeeModel
                        {
                            Name = "Niki",
                            Title = "analyst",
                            Department = "QA",
                            EmploymentDate = DateTime.Now,
                            Salary = 55000
                        },
                        new EmployeeModel
                        {
                            Name = "Mike",
                            Title = "analyst",
                            Department = "QA",
                            EmploymentDate = DateTime.Now,
                            Salary = 56000
                        },
                        new EmployeeModel
                        {
                            Name = "Hank",
                            Title = "analyst",
                            Department = "finance",
                            EmploymentDate = DateTime.Now,
                            Salary = 54000
                        },
                        new EmployeeModel
                        {
                            Name = "Mela",
                            Title = "analyst",
                            Department = "QA",
                            EmploymentDate = DateTime.Now,
                            Salary = 56000
                        },
                        new EmployeeModel
                        {
                            Name = "Theo",
                            Title = "analyst",
                            Department = "finance",
                            EmploymentDate = DateTime.Now,
                            Salary = 54000
                        },
                });
            return listEmployees.ToList();
        }
    }
}
