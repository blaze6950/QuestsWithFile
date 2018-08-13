namespace Quest
{
    interface IRepository
    {
        void ReadQuest();
        void WriteQuest(Qst quest);
        void ReadListOfQuests();
        void WriteListOfQuests(CollectionQst collectionQst);
    }
}
