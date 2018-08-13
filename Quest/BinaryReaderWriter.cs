using System;
using System.IO;
using System.Text;

namespace Quest
{
    class BinaryReaderWriter : IRepository
    {
        public void ReadQuest()
        {
            using (FileStream stream = new FileStream("Quest.bin", FileMode.Open, FileAccess.ReadWrite, FileShare.None))
            {
                BinaryReader reader = new BinaryReader(stream, Encoding.Default);
                Console.WriteLine(reader.ReadString());
                reader.Dispose();
            }
        }

        public void WriteQuest(Qst quest)
        {
            using (FileStream stream = new FileStream("Quest.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None))
            {
                BinaryWriter writer = new BinaryWriter(stream, Encoding.Default);
                writer.Write(quest + "\n");
                writer.Dispose();
            }
        }

        public void ReadListOfQuests()
        {
            using (FileStream stream = new FileStream("listQuests.bin", FileMode.Open, FileAccess.ReadWrite, FileShare.None))
            {
                BinaryReader reader = new BinaryReader(stream, Encoding.Default);
                try
                {
                    while (true)
                    {
                        Console.WriteLine(reader.ReadString());
                    }
                }
                catch (EndOfStreamException)
                {
                    Console.WriteLine("Все квесты считаны!");
                }
                reader.Dispose();
            }
        }

        public void WriteListOfQuests(CollectionQst collectionQst)
        {
            using (FileStream stream = new FileStream("listQuests.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None))
            {
                BinaryWriter writer = new BinaryWriter(stream, Encoding.Default);
                for (int i = 0; i < collectionQst.NumOfQuests; i++)
                {
                    writer.Write(collectionQst[i] + "\n==================================\n");
                }
                writer.Dispose();
            }
        }
    }
}
