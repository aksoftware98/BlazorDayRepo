using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazoredCalendar.Models
{
    public class CalendarDay
    {
        public int Id { get; set; }
        public int DayNumber { get; set; }
        public DateTime Date { get; set; }
        public bool IsEmpty { get; set; }

        public virtual List<CalendarEvent> Events { get; set; }
    }
}
