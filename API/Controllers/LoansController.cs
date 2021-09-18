using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
  public class LoansController : BaseApiController
  {
    private readonly DataContext _context;

    public LoansController(DataContext context)
    {
      _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<List<Loan>>> GetBooks()
    {
      return await _context.Loans.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Loan>> GetBook(Guid id)
    {
      return await _context.Loans.FindAsync(id);
    }
  }
}