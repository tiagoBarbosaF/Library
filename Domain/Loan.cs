using System;
using System.Collections.Generic;

namespace Domain
{
  public class Loan
  {
    public Guid LoanId { get; set; }
    public string User { get; set; }
    public Book Book { get; set; }
    public DateTime Borrowed { get; set; }
    public DateTime Returned { get; set; }
  }
}