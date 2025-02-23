using Domain.Entities;
using Domain.Interfaces;
using Infra.Data.Context;

namespace Infra.Data.Repositories;
public class CalendarRepository : ICalendarRepository {


    private ApplicationDbContext _calendarContext;
    public CalendarRepository(ApplicationDbContext context) {
        _calendarContext = context;
    }

    public async Task<CalendarEntity> Create(CalendarEntity calendar) {
        _calendarContext.Add(calendar);
        await _calendarContext.SaveChangesAsync();
        return calendar;
    }
}