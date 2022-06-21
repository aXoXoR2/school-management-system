
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Domain.Entities;
using SchoolManagementSystem.Domain.Services;
using SchoolManagementSystem.API.Dtos;
using AutoMapper;

namespace SchoolManagementSystem.API.Controllers.CrudEntities;

public class ExpensesController : CrudControlller<Expense, ExpenseDto>
{

    public ExpensesController(IExpenseService service, IMapper mapper) : base(service, mapper)
    {
    }
}
