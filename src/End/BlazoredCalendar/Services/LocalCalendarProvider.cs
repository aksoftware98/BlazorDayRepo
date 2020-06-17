using BlazoredCalendar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazoredCalendar.Services
{
    public class LocalCalendarProvider : ICalendarEventsProvider
    {

        private readonly static List<CalendarEvent> _events = new List<CalendarEvent>();


        public async Task AddEventAsync(CalendarEvent calendarEvent)
        {
            await Task.Delay(0);
            _events.Add(calendarEvent);
        }

        public async Task<IEnumerable<CalendarEvent>> GetEventsInMonthAsync(int year, int month)
        {
            await Task.Delay(0);
            DateTime startDate = new DateTime(year, month, 1);
            DateTime endDate = new DateTime(year, month, DateTime.DaysInMonth(year, month));
            return _events.Where(e => e.StartDate >= startDate && e.EndDate <= endDate); 
        }
    }
}
