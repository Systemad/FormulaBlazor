using FormulaBlazor.Features.Drivers.Models;

namespace FormulaBlazor.Features.Drivers.DTO;

public static class DriverStandingMapper
{
    public static DriverStandingDto MapToDriverList(this StandingsList standing)
    {
        var newDriverStanding = new DriverStandingDto
        {
            Round = standing.Round,
            Season = standing.Season
        };

        var standings = standing.DriverStandings
            .Select(
                driver =>
                    new DriverDto
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
                        Constructor = driver.Constructors[0].Name,
                        ImageUrl = driver.Driver.Url
                    }
            )
            //.OrderByDescending(d => d.Points)
            .ToList();
        //var orderByDescending = standing.DriverStandings.OrderByDescending(d => d.Points);
        newDriverStanding.DriverStanding = standings;

        return newDriverStanding;
    }
}
