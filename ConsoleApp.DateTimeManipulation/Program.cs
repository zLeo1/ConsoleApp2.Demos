using System.Globalization;

namespace ConsoleApp.DateTimeManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************- DateTime Manipulation -*******************");
            ////Empty DateTime Object
            //DateTime dateTime = new DateTime();//new DateTime Object created or instanced

            ////Create a DateTime from date and time
            //var dateTime1 = new DateTime(1980,3,25);
            //Console.WriteLine($"My DOB is:  {dateTime1}");

            //var exactDateTime1 = new DateTime(1980, 3, 25, 8, 25, 54,DateTimeKind.Local);
            //Console.WriteLine($"My exact DOB is:  {exactDateTime1}");

            //Create a DateTime from a current timeStamp
            DateTime now = DateTime.Now;
            //Console.WriteLine($"The current time: {now}");

            ////Create a DateTime from a string
            //Console.WriteLine($"What is your DOB?(MM/dd/yyyy): ");
            //string dob = Console.ReadLine();

            //var userDob = DateTime.Parse(dob);
            //Console.WriteLine($"The date is: {dob}");
            //Console.WriteLine($"Day of the Week: {userDob.DayOfWeek}");
            //Console.WriteLine($"Day of the Year: {userDob.DayOfYear}");
            //Console.WriteLine($"Time of Day: {userDob.TimeOfDay}");
            //Console.WriteLine($"Tick: {userDob.Ticks}");
            //Console.WriteLine($"Kind: {userDob.Kind}");

            ////Change Format DateTime
            //Console.WriteLine($"Formatted date: {userDob.ToString("dd-MM-yyyy")}");
            //Console.WriteLine($"Formatted date: {userDob.ToString("MMM-dd-yy")}");
            //Console.WriteLine($"Formatted date: {userDob.ToString("MMM-dd-yy")}");
            //Console.WriteLine($"Formatted date: {userDob:MMMM-dd-yy}");
            //Console.ReadLine();

            ////Add Additional time
            //Console.WriteLine("One hour from now is: " + now.AddHours(1));
            //Console.WriteLine("One day from now is: " + now.AddDays(1));
            //Console.WriteLine("One day from now is: " + now.AddDays(-1));


            //Ticks from DateTime

            Console.WriteLine("****************- DateTime Offset Manipulation -*******************");

            //UTC - Coordinated Universal Time
            var utcNow = DateTime.UtcNow;
            Console.WriteLine($"Now Date Time: {now}");
            Console.WriteLine($"UTC Now Date Time: {utcNow}");

            //DateTime Offset and Timezone Info
            var tz = TimeZoneInfo.Local.GetUtcOffset( utcNow );
            Console.WriteLine($"User TimeZone: {tz}");

            var dto = new DateTimeOffset(now, tz);
            Console.WriteLine($"User Time Zone with UTC offset: {dto}");
            Console.WriteLine($"UTC time of action: {dto.UtcDateTime}");

            var azTz = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
            var azDateTime = TimeZoneInfo.ConvertTimeFromUtc(dto.UtcDateTime, azTz);
            Console.WriteLine($"Action was completed in Arizona at: {azDateTime}");
            Console.WriteLine($"Arizona Time Zone: {azTz}");

            Console.WriteLine("****************- Date only and Time only Manipulation -*******************");

            //Date Only
            var dateOnly = new DateOnly(1980, 12, 25);
            var nextDay = dateOnly.AddDays(1);
            var previousDay = dateOnly.AddDays(-1);
            var decadeLater = dateOnly.AddYears(10);
            var lastMonth  = dateOnly.AddMonths(-1);

            Console.WriteLine($"The Date: {dateOnly}");
            Console.WriteLine($"The Next Day: {nextDay}");
            Console.WriteLine($"The previous Day: {previousDay}");
            Console.WriteLine($"The Decade later: {decadeLater}");
            Console.WriteLine($"The last month: {lastMonth}");

            var dateOnlyFromDateTime = DateOnly.FromDateTime(now);
            Console.WriteLine($"Date only from dateTime: {dateOnlyFromDateTime}");

            //Console.WriteLine($"What is your DOB(dd MMM yyyy): ");
            //var dobDateOnly = Console.ReadLine();
            //var theDateOnly = DateOnly.ParseExact(dobDateOnly, "dd MMM yyyy", CultureInfo.InvariantCulture);
            //Console.WriteLine($"The date only: {theDateOnly}");

            //Time Only
            var timeOnly = TimeOnly.FromDateTime(now);
            Console.WriteLine($"The time only: {timeOnly:hh:mm tt}");
        }
    }
}
