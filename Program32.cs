using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMyPro1
{
    class players
    {
        public int pl_id { get; set; }
        public string pl_name { get; set; }
        public string pl_game { get; set; }
        public string pl_country { get; set; }

    }

    class pl_lists
    {
        List<players> ls;
        public pl_lists(List<players> ls)
        {
            this.ls = ls;
        }
        public Dictionary<string, List<players>> g_list()
        {
            List<players> cricket_ls = new List<players>();
            List<players> football_ls = new List<players>();
            List<players> hockey_ls = new List<players>();

            Dictionary<string, List<players>> dlist = new Dictionary<string, List<players>>();

            foreach (players p in ls)
            {
                if (p.pl_game == "cricket")
                {
                    cricket_ls.Add(p);
                }
                else if (p.pl_game == "hockey")
                {
                    hockey_ls.Add(p);
                }
                else if (p.pl_game == "football")
                {
                    football_ls.Add(p);
                }
            }
            dlist.Add("Cricket", cricket_ls);
            dlist.Add("Hockey", hockey_ls);
            dlist.Add("Football", football_ls);

            return dlist;
        }

        public void c_list()
        {

        }
    }
    class Program32
    {
        static void Main(string[] args)
        {
            List<players> ls = new List<players>();
            //string choice = null;
            //do
            //{
            //    Console.WriteLine("enter player(d");
            //    int plid = int.Parse(Console.ReadLine());

            //    Console.WriteLine("enter player name");
            //    string plname = Console.ReadLine();

            //    Console.WriteLine("enter player Game");
            //    string plgame = Console.ReadLine();

            //    Console.WriteLine("enter player country");
            //    string country = Console.ReadLine();

            //    ls.Add(new players { pl_id = plid, pl_name = plname, pl_game = plname, pl_country = country });

            //    Console.WriteLine("Do you Want to Continue y/n");
            //    choice = Console.ReadLine();

            //} while (choice=="y");

            ls.Add(new players { pl_id = 1001, pl_name = "sanjay", pl_game = "cricket", pl_country = "India" });
            ls.Add(new players { pl_id = 1002, pl_name = "sam", pl_game = "cricket", pl_country = "India" });
            ls.Add(new players { pl_id = 1003, pl_name = "raul", pl_game = "hockey", pl_country = "france" });
            ls.Add(new players { pl_id = 1004, pl_name = "rajiv", pl_game = "hockey", pl_country = "france" });
            ls.Add(new players { pl_id = 1005, pl_name = "peter", pl_game = "football", pl_country = "germany" });
            ls.Add(new players { pl_id = 1006, pl_name = "david", pl_game = "football", pl_country = "germany" });
            ls.Add(new players { pl_id = 1007, pl_name = "john", pl_game = "cricket", pl_country = "India" });
            ls.Add(new players { pl_id = 1008, pl_name = "ramiz", pl_game = "football", pl_country = "germany" });
            ls.Add(new players { pl_id = 1009, pl_name = "pathan", pl_game = "cricket", pl_country = "India" });
            ls.Add(new players { pl_id = 1010, pl_name = "shenoy", pl_game = "football", pl_country = "germany" });
            ls.Add(new players { pl_id = 1011, pl_name = "kumar", pl_game = "hockey", pl_country = "france" });
            ls.Add(new players { pl_id = 1012, pl_name = "ganesh", pl_game = "hockey", pl_country = "france" });

            pl_lists pl = new pl_lists(ls);
            Dictionary<string, List<players>> dlist = pl.g_list();

            Console.WriteLine("Gamewise List");
            foreach (KeyValuePair<string, List<players>> p in dlist)
            {
                Console.WriteLine("game {0} list " + p.Key);
                {
                    foreach (players p1 in p.Value)
                    {
                        Console.WriteLine("pl_id = {0} pl_name ={1} pl_game = {2} pl_country = {3}", p1.pl_id, p1.pl_name, p1.pl_game, p1.pl_country);
                    }
                }
            }
        }
    }
}
