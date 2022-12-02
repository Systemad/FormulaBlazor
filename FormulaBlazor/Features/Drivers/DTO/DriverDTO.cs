namespace FormulaBlazor.Features.Drivers.DTO;

public class DriverDto
{
    public string DriverId { get; set; }
    public string GivenName { get; set; }
    public string FamilyName { get; set; }
    public string PermanentNumber { get; set; }
    public string DateOfBirth { get; set; }
    public string Nationality { get; set; }
    public string Position { get; set; } // Use this to order descending
    public string Points { get; set; }
    public string Wins { get; set; }
    public string Constructor { get; set; }
    public string ImageUrl { get; set; }
}
