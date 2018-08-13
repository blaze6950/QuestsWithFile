using System;
using System.IO;

namespace Quest
{
    class StreamReaderWriter : IRepository
    {
        public void ReadQuest()
        {
            using (FileStream stream = new FileStream("Quest.txt", FileMode.Open, FileAccess.ReadWrite, FileShare.None))
            {
                StreamReader reader = new StreamReader(stream);
                Console.WriteLine(reader.ReadToEnd());
                reader.Dispose();
            }
        }

        public void WriteQuest(Qst quest)
        {
            using (FileStream stream = new FileStream("Quest.txt",FileMode.OpenOrCreate, FileAccess.ReadWrite,FileShare.None))
            {
                StreamWriter writer = new StreamWriter(stream);
                writer.AutoFlush = true;
                writer.WriteLine(quest.ToString());
                writer.Dispose();
            }
        }

        public void ReadListOfQuests()
        {
            using (FileStream stream = new FileStream("listQuests.txt", FileMode.Open, FileAccess.ReadWrite, FileShare.None))
            {
                StreamReader reader = new StreamReader(stream);
                Console.WriteLine(reader.ReadToEnd());
                reader.Dispose();
            }
        }

        public void WriteListOfQuests(CollectionQst collectionQst)
        {
            using (FileStream stream = new FileStream("listQuests.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None))
            {
                StreamWriter writer = new StreamWriter(stream);
                writer.AutoFlush = true;
                for (int i = 0; i < collectionQst.NumOfQuests; i++)
                {
                    writer.WriteLine(collectionQst[i] + "\n==================================");
                }
                writer.Dispose();
            }
        }
    }
}
