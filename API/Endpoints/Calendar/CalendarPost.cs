using Application.DTOs;
using Application.Interfaces;

namespace API.Endpoints.Calendar;

public class CalendarPost {
    public static string Template => "/calendar";
    public static string[] Methods => [HttpMethod.Post.ToString()];
    public static Delegate Handle => Action;

    public static async Task<IResult> Action(CalendarDTO calendarDTO, ICalendarService calendarService) {
        // if (categoryRequest == null)
        //     return BadRequest("Invalid Data");

        await calendarService.Add(calendarDTO);

        return Results.Created($"/calendar/{calendarDTO.Id}", calendarDTO.Id);
    }
}