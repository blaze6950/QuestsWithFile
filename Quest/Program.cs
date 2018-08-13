using System;

namespace Quest
{
    class Program
    {
        static void Main()
        {
            CollectionQst collection = new CollectionQst();
            collection.Add("First", "FJHfgjad qaedghakd fkagfk agdfkjgadkhfg kdaskfgkagfkjagsdfhgadsfas dfdjhagkfja!", 2, 4, 60, 300, 600, 4, 4, 12, 4.5, "ASdasd");
            collection.Add("Second", "VJKwjhfr wejkfgakjgrjkfh wqjhgrfwjhrgfwshjfg wjhgrkjgwkjgwjhg qwjhrgakjhr wj!", 3, 6, 120, 450, 900, 3, 2, 8, 4.9, "QWEqe");
            collection.Add("Third", "GHjhgsjh shjfgjshghgrjhw3 wukygiuwhjghw gusgjhgfr jfshhgjfgjwhgfjh fsgfhsjghd!", 4, 8, 45, 600, 1200, 3, 1, 6, 4.7, "Rytty");
            collection.Add("Fourth", "FGCDhgs fgsjhgflkjhsgjrkj sgjhfgjsgj sshjgfsjfg vsjgsfs  hjfghg fh  hfhfsjhfg!", 1, 3, 75, 150, 300, 1, 5, 14, 4.3, "Gjjk");
            collection.Add("Fifth", "JHgcdfgasfdg ahgfjwgshjfgjwd fgvjhkgk vxshgjsh glsgj juhjsdfhgsf gufhhsgruitgh!", 2, 4, 60, 300, 600, 2, 3, 12, 4.6, "Cbnm");
            collection.Add("Sixth", "MGHFhjgsfdkg asdfjhgw hjgfskgjh fgjkshghlhewugtoiqhgohfig wsihgjhsfjgfjh sfg!", 4, 8, 100, 600, 1200, 4, 5, 11, 4.2, "RTYU");
            collection.Add("Seventh", "GHfjdgf srgh wjkfkjgshfg hjsfg shfshg jkl fljhsgjfsg lksjfgjwhrgjhsjhsfgd!", 5, 10, 180, 750, 1500, 3, 2, 15, 4.1, "UPo");
            collection.Add("Eightth", "gbhsjdhgiulhfkjgshiu wlhg ihwslrfhg  ghf jdifgshjlgh slkjghslhg;sjfgiahg   !", 3, 6, 120, 450, 900, 2, 1, 8, 4.0, "JHLKh");
            collection.Add("Nineth", "GHRFuygwsvfruqy uyfegw ofuiahgljgfhdg algadfhyg asfgagfajhfgla ujfgajgfwsefgr!", 1, 3, 50, 150, 300, 1, 3, 7, 4.8, "Vbn");
            collection.Add("Tenth", "Fxkhgswdvdjfajhdgvj jhag vkdbfjgjqbfrlkj alnhfali ahl jghsjhfgbajgfbajhfghahkj!", 2, 4, 80, 300, 600, 5, 1, 6, 4.7, "ZXc");

            collection.Print();
            Console.WriteLine("===================================");
            collection.Print(collection.FindQ("First"));
            Console.WriteLine("===================================");
            //collection.Print(collection.FindQ("i"));
            Console.WriteLine("===================================");
            collection.Print(5);
            Console.WriteLine("===================================");
            collection.Print(collection.FindQDificult(3, 4));
            Console.WriteLine("===================================");
            collection.Delete(2);
            collection.Print();
            Console.WriteLine("===================================");
            Console.WriteLine(collection[1].Name);

            StreamReaderWriter srw = new StreamReaderWriter();
            srw.WriteQuest(collection[2]);
            srw.ReadQuest();
            Console.WriteLine("------------------------------------");
            srw.WriteListOfQuests(collection);
            srw.ReadListOfQuests();
            Console.WriteLine("------------------------------------");


            Console.WriteLine("------------------------------------");
            BinaryReaderWriter brw = new BinaryReaderWriter();
            brw.WriteQuest(collection[2]);
            brw.ReadQuest();
            Console.WriteLine("------------------------------------");
            brw.WriteListOfQuests(collection);
            brw.ReadListOfQuests();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("------------------------------------");
        }
    }
}
