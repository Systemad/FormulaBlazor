namespace FormulaBlazor.Features.Calendar.Models;

public class RaceDto
{
    public string Round { get; set; }
    public string Url { get; set; }
    public string RaceName { get; set; }
    public string CircuitName { get; set; }
    public string Locality { get; set; }
    public string Country { get; set; }
    public DateTime Date { get; set; }
    public DateTime FirstPractice { get; set; }
    public DateTime SecondPractice { get; set; }
    public DateTime? ThirdPractice { get; set; }
    public DateTime Qualifying { get; set; }
    public DateTime? Sprint { get; set; }
    public bool IsDone { get; set; }
}
