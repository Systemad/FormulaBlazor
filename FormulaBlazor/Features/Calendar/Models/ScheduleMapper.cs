using System.Globalization;

namespace FormulaBlazor.Features.Calendar.Models;

public static class ScheduleMapper
{
    public static ScheduleDto MapScheduleDto(this RaceTable raceTable)
    {
        var raceList = new List<RaceDto>();
        var list = raceTable.Races;

        foreach (var race in list)
        {
            var raceDto = new RaceDto();

            raceDto.Round = race.Round;
            raceDto.Url = race.Url;
            raceDto.RaceName = race.RaceName;
            raceDto.CircuitName = race.Circuit.CircuitName;
            raceDto.Locality = race.Circuit.Location.Locality;
            raceDto.Country = race.Circuit.Location.Country;
            raceDto.Date = DateTime.Parse(
                race.Date + " " + race.Time,
                CultureInfo.InvariantCulture,
                DateTimeStyles.AdjustToUniversal
            );
            raceDto.FirstPractice = DateTime.Parse(
                race.FirstPractice.Date + " " + race.FirstPractice.Time,
                CultureInfo.InvariantCulture,
                DateTimeStyles.AdjustToUniversal
            );
            raceDto.SecondPractice = DateTime.Parse(
                race.SecondPractice.Date + " " + race.SecondPractice.Time,
                CultureInfo.InvariantCulture,
                DateTimeStyles.AdjustToUniversal
            );
            raceDto.Qualifying = DateTime.Parse(
                race.Qualifying.Date + " " + race.Qualifying.Time,
                CultureInfo.InvariantCulture,
                DateTimeStyles.AdjustToUniversal
            );

            if (race.Sprint is not null)
            {
                raceDto.Sprint = raceDto.Sprint = DateTime.Parse(
                    race.Sprint.Date + " " + race.Sprint.Time,
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.AdjustToUniversal
                );
                raceDto.ThirdPractice = null;
            }
            else
            {
                raceDto.ThirdPractice = DateTime.Parse(
                    race.ThirdPractice.Date + " " + race.ThirdPractice.Time,
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.AdjustToUniversal
                );
                raceDto.Sprint = null;
            }

            raceDto.IsDone = raceDto.Date < DateTime.UtcNow;
            // CHECK IF ITS NULL OR NOT, IF NULL JUST SET SPRINT TO NULL
            raceList.Add(raceDto);
        }

        var scheduleDto = new ScheduleDto { Season = raceTable.Season, Races = raceList };
        return scheduleDto;
    }
}
