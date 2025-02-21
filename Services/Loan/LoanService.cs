using Core.Domain;

namespace Services.Loan;

public class LoanService
{
    public List<Core.Domain.Loan> Loans { get; set; }

    public List<Core.Domain.Loan> GetLoans( string email = "" )
    {
        var loans = string.IsNullOrEmpty( value: email )
            ? Loans
            : Loans.Where( predicate: l => l.Email == email )
            .ToList() ?? new List<Core.Domain.Loan>();

        return loans;
    }

    public void Add( Core.Domain.Loan loan )
    {
        if ( Loans.Exists( match: l => l.Id == loan.Id && l.Email == loan.Email ) )
        {

        }

        Loans.Add( item: loan );
    }

    public void Modify( Core.Domain.Loan loan )
    {
        if ( !Loans.Exists( match: l => l.Id == loan.Id && l.Email == loan.Email ) )
        {

        }

        var loanItem = Loans
            .Where( predicate: l => l.Id == loan.Id && l.Email == loan.Email )
            .FirstOrDefault() ?? new Core.Domain.Loan();

        loanItem.Status = loan.Status;
    }
}