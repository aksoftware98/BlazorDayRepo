using BlazoredCalendar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazoredCalendar.Services
{
    public interface ICalendarEventsProvider
    {

        Task<IEnumerable<CalendarEvent>> GetEventsInMonthAsync(int year, int month);

        Task AddEventAsync(CalendarEvent calendarEvent);
    }


}
