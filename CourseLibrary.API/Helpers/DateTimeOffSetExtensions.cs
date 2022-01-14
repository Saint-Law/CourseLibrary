using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseLibrary.API.Helpers
{
    public static class DateTimeOffSetExtensions
    {
        public static int GetCurrentAge(this DateTimeOffset dateTimeOffSet)
        {
            var currentDate = DateTime.UtcNow;
            int age = currentDate.Year - dateTimeOffSet.Year;

            if (currentDate < dateTimeOffSet.AddYears(age))
            {
                age--;
            }

            return age;
        }
    }
}
