using FormulaBlazor.Features.Drivers.Models;

namespace FormulaBlazor.Features.Drivers.DTO;

public static class DriverMapping
{
    public static DriverDto MapToDriverDto(this DriverStanding driver)
    {
        var newDriver = new DriverDto
        {
            DriverId = driver.Driver.DriverId,
            GivenName = driver.Driver.GivenName,
            FamilyName = driver.Driver.FamilyName,
            PermanentNumber = driver.Driver.PermanentNumber,
            DateOfBirth = driver.Driver.DateOfBirth,
            Nationality = driver.Driver.Nationality,
            Position = driver.Position,
            Points = driver.Points,
            Wins = driver.Wins,
            Constructor = driver.Constructors[0].Name
        };
        return newDriver;
    }
}
