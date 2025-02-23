using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service;
public class CalendarService : ICalendarService {

    private ICalendarRepository _calendarRepository;

    public CalendarService(ICalendarRepository categoryRepository) {
        _calendarRepository = categoryRepository;
    }

    public async Task Add(CalendarDTO calendarDto) {
        var categoryEntity = new CalendarEntity(calendarDto.Name);
        await _calendarRepository.Create(categoryEntity);
        calendarDto.Id = categoryEntity.Id;
    }
}