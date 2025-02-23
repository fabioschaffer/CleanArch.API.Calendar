using System.Globalization;

namespace Domain.Interfaces;

public interface ICalendarRepository {

    Task<Calendar> Create(Calendar calendar);

}