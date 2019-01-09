using System;
using Syncfusion.SfCalendar.XForms;
using Xamarin.Forms;

namespace CalendarTheme
{
    public class CalendarViewModel
    {
        public CalendarEventCollection CalendarInlineEvents { get; set; } = new CalendarEventCollection();

        public CalendarViewModel()
        {
            for (int i = 0; i < 10; i++)
            {
                CalendarInlineEvent events = new CalendarInlineEvent();
                events.StartTime = DateTime.Now.Date.AddHours(10).AddDays(i);
                events.EndTime = DateTime.Now.Date.AddHours(12).AddDays(i);
                events.Subject = events.StartTime.ToString();
                events.Color = Color.Red;
                CalendarInlineEvents.Add(events);
            }
        }
    }
}
