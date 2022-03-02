using BlazorWebApp.Shared;
using BlazorWebApp.Shared.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorWebApp.Client.Pages
{
    public partial class Index
    {
        private List<EmployeeModel> listEmployees;
        private List<ColumnDefinition> columnDefinition;
        protected override void OnInitialized()
        {
            base.OnInitialized();
            Initialize();
        }
        //protected override async Task OnInitializedAsync()
        //{
        //    base.OnInitialized();
        //    //Console.WriteLine("enter .razor.cs");
        //    //listEmployees = await Http.GetFromJsonAsync<List<EmployeeModel>>("WeatherForecast/employees");
        //    Initialize();
        //}

        private void Initialize()
        {
            if (columnDefinition == null)
            {
                columnDefinition = new List<ColumnDefinition>();
                columnDefinition.AddRange(
                    new ColumnDefinition[]
                    {
                    new ColumnDefinition {DataField = "Name", Caption = "Name"},
                    new ColumnDefinition {DataField = "Title", Caption = "Title"},
                    new ColumnDefinition {DataField = "Department", Caption = "Department"},
                    new ColumnDefinition {DataField = "EmploymentDate", Caption = "Employment Date", Format = "yyyy/MM/dd", DataType = DataType.Date},
                    new ColumnDefinition {DataField = "Salary", Caption = "Annual Salary", DataType = DataType.Currency, Alignment = Alignment.Right, Format = "c"},
                    }
               );
            }

            if (listEmployees == null)
            {
                listEmployees = new List<EmployeeModel>();
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
            }
        }
    }
}
