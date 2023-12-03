using System.Text.RegularExpressions;

namespace day1_app
{
    class day1_1_app {         
        public static int Gib_answer()
        {
            List<int> calc = new();
            Regex r = new(@"\d", RegexOptions.Compiled);
            IEnumerable<string> dataset = File.ReadLines("./day1.input");
            foreach (string line in dataset){
                var x = r.Matches(line);
                calc.Add(Convert.ToInt32($"{x.First().Value}{x.Last().Value}"));
            }
            return calc.Sum();
        }
    }


    class day1_2_app {         
        public static int Gib_answer()
        {
            var replacement = new Dictionary<string, string>(){
                    {"one","1"},{"two","2"},
                    {"three","3"},{"four","4"},
                    {"five","5"},{"six","6"},
                    {"seven","7"},{"eight","8"},
                    {"nine","9"},{"zero","0"}
            };
            List<int> calc = new();
            Regex r = new(@"\d", RegexOptions.Compiled);
            IEnumerable<string> dataset = File.ReadLines("./day1.input");
            foreach (string line in dataset){
                string mutable_string = line;
                foreach (string key in replacement.Keys){
                    mutable_string = Regex.Replace(mutable_string,key,$"{key}{replacement[key]}{key}");
                }
                var x = r.Matches(mutable_string);
                calc.Add(Convert.ToInt32($"{x.First().Value}{x.Last().Value}"));
            }
            return calc.Sum();
        }
    }




    class Program
    {
        static void Main(string[] args){
            Console.WriteLine($"Day1_1: {day1_1_app.Gib_answer()}");
            Console.WriteLine($"Day1_2: {day1_2_app.Gib_answer()}");
            }
    }
}