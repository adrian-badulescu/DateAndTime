using System;

namespace DotNet
{
    class Program : DateAndTime
    {
        IDateAndTime now { get; set; }
        static void Main(string[] args)
        {
            IDateAndTime now = new DateAndTime();
            Console.WriteLine(now.getDateAndTime());
        }
    }
}

class DateAndTime : IDateAndTime
{
    public DateTime dt = DateTime.Now;

    public DateTime getDateAndTime()
    {
        // Console.WriteLine(dt);
        return dt;
    }
}

interface IDateAndTime
{
    DateTime getDateAndTime();
}