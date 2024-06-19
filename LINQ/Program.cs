using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<Games> NintendoGames = VideoGames();
            var gametitle = NintendoGames.OrderBy(x => x.NintendoGames.Length).ToList();
            gametitle.ForEach(x => Console.WriteLine(x.NintendoGames));

            


        }

            public static List<Games> VideoGames()
            { 
            
            List<Games> output = new List<Games>();
                output.Add(new Games { NintendoGames = "The Legend of Zelda" });
                output.Add(new Games { NintendoGames = "Donkey Kong" });
                output.Add(new Games { NintendoGames = "Metroid" });
                output.Add(new Games { NintendoGames = "Mario Brothers" });
                return output;


            }


        




       
    }




    
}
