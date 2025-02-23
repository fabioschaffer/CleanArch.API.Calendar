using Domain.Entities;
using System.Globalization;

namespace Domain.Interfaces;

public interface ICalendarRepository {

    Task<CalendarEntity> Create(CalendarEntity calendar);

}