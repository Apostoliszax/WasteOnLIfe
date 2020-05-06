using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasteOnLIfe
{
    class Input
    {
        private readonly DateTime _dateOfBirth;
        public DateTime DateOfBirth { get; set; }
        public int DaysLived { get; set; }
        public int HoursLived { get; set; }
        public int DaysLeft { get; set; }
        public int DaysToCentury { get; set; }
        public int NextBirthday { get; set; }

        public Input(string input)
        {
            DateTime.TryParse(input, out _dateOfBirth);
            DateOfBirth = _dateOfBirth;
            DaysLived = (DateTime.Now - DateOfBirth).Days;
            HoursLived = (int)(DateTime.Now - DateOfBirth).TotalHours;
            DaysLeft = 29200 - DaysLived;
            DaysToCentury = 36500 - DaysLived;
            var nextBirthday = 365 - (DaysLived % 365);
            NextBirthday = nextBirthday; 
        }
    }
}
