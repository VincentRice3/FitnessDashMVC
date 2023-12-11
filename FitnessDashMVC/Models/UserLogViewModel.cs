using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FitnessDashMVC.Models
{
    public class UserLogViewModel
    {
        public DateTime Date { get; set; }

        public int Steps { get; set; }

        public double Weight { get; set; }  

        public int Protein { get; set; }

        public int Fat { get; set;}

        public int Carbohydrates { get; set; }

        public int TotalCals { get; set; }

        public bool WorkoutTrue { get; set; }

        public string? DailyReflection { get; set; }

        public int ReturnTotalCals(int protein, int fat, int carb)
        {
            return (protein * 4) + (fat * 9) + (carb * 4);
        }

        public string CorrectDay(DateTime date)
        {
            return date.DayOfWeek.ToString();
        }

        public string MakeID(string date, int length)

        {


            string result = string.Empty;
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            int charactersLength = characters.Length;
            int counter = 0;
            Random rnd = new Random();
            while(counter < length)
            {
                result += characters[Convert.ToInt32(Math.Floor(rnd.NextDouble() * charactersLength))];
                counter++;
            }

            return date + result;
        }



        public static List<UserLogViewModel> SortByDate(List<UserLogViewModel> list)
        {
            list.Sort((a, b) => a.Date.CompareTo(b.Date));
            return list;
        }
    }
}
