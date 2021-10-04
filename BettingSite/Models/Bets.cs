using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace BettingSite.Models {
  public class Bets {
    public Guid Id { get; set; }
    public decimal Amount { get; set; }
    public DateTime? CreatedDate { get; set; }
    public DateTime? LastUpdatedBet { get; set; }

  }

  public class BetsItemValidator : AbstractValidator<Bets> {
    public BetsItemValidator() {
      RuleFor(b => b.Amount).GreaterThan(0).WithMessage("Amount should be greater than 0");
    }
  }
}