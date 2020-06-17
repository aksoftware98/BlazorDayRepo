using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazoredCalendar
{
    public class AppState
    {

        public event Action OnChange;

        public void AddEvent()
        {
            OnChange?.Invoke();
        }

    }
}
