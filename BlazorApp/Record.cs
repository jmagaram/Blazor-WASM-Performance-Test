using System;
using System.Linq;

namespace BlazorApp
{
    public class Record
    {
        static readonly Random _rnd = new Random();

        static readonly string _characters = "abcdefghijklmnopqrstuvwxyz0123456789 !$%@*()";

        public Record()
        {
            SetRandomValues();
        }

        private void SetRandomValues()
        {
            Important = _rnd.Next() % 2 == 1;
            Title = RandomString(30);
            Notes = RandomString(300);
            Year = _rnd.Next(1950, 2021);
            Modified = DateTime
                .Now
                .AddYears(_rnd.Next(-20, 1))
                .AddMonths(_rnd.Next(-11, 1))
                .AddDays(_rnd.Next(-30, 1))
                .AddMinutes(_rnd.Next(0, 24 * 60));
        }

        public bool Important { get; set; }

        public string Title { get; set; }

        public string Notes { get; set; }

        public int Year { get; set; }

        public DateTime Modified { get; set; }

        private char RandomCharacter() => _characters[_rnd.Next(0, _characters.Length)];

        private string RandomString(int maxLength)
        {
            int length = _rnd.Next(0, maxLength + 1);
            if (length == 0)
            {
                return "";
            }
            else
            {
                char[] letters =
                    Enumerable
                    .Range(1, length)
                    .Select(_ => RandomCharacter())
                    .ToArray();
                return new string(letters);
            }
        }
    }
}
