using System;
using System.Collections.Generic;

namespace Quest
{
    class CollectionQst
    {
        private Qst[] _quests;
        private Int32 _numOfQuests;

        private void Sort()
        {
            Array.Sort(_quests, (x,y) => { return String.Compare(x.Name, y.Name, StringComparison.Ordinal); });
        }
        public Int32 NumOfQuests
        {
            get { return _numOfQuests; }
            set { _numOfQuests = value; }
        }

        public void Add(String name, String description, int minPlayers, int maxPlayers, int maxTime,
            int minPrice, int maxPrice, int difficultyLevel, int levelOfFear, int minAge, double rating,
            String nameOfTheOrganizer)
        {
            Qst[] nquests = new Qst[NumOfQuests + 1];
            for (int i = 0; i < NumOfQuests; i++)
            {
                nquests[i] = new Qst();
                nquests[i].Description = _quests[i].Description;
                nquests[i].DifficultyLevel = _quests[i].DifficultyLevel;
                nquests[i].LevelOfFear = _quests[i].LevelOfFear;
                nquests[i].MaxPlayers = _quests[i].MaxPlayers;
                nquests[i].MaxPrice = _quests[i].MaxPrice;
                nquests[i].MaxTime = _quests[i].MaxTime;
                nquests[i].MinAge = _quests[i].MinAge;
                nquests[i].MinPlayers = _quests[i].MinPlayers;
                nquests[i].MinPrice = _quests[i].MinPrice;
                nquests[i].Name = _quests[i].Name;
                nquests[i].NameOfTheOrganizer = _quests[i].NameOfTheOrganizer;
                nquests[i].Rating = _quests[i].Rating;
            }
            nquests[NumOfQuests] = new Qst();
            nquests[NumOfQuests].Description = description;
            nquests[NumOfQuests].DifficultyLevel = difficultyLevel;
            nquests[NumOfQuests].LevelOfFear = levelOfFear;
            nquests[NumOfQuests].MaxPlayers = maxPlayers;
            nquests[NumOfQuests].MaxPrice = maxPrice;
            nquests[NumOfQuests].MaxTime = maxTime;
            nquests[NumOfQuests].MinAge = minAge;
            nquests[NumOfQuests].MinPlayers = minPlayers;
            nquests[NumOfQuests].MinPrice = minPrice;
            nquests[NumOfQuests].Name = name;
            nquests[NumOfQuests].NameOfTheOrganizer = nameOfTheOrganizer;
            nquests[NumOfQuests].Rating = rating;
            _quests = nquests;
            NumOfQuests++;
            Sort();
        }

        public void Delete(Int32 index)
        {
            if (index > _quests.Length)
            {
                throw new IndexOutOfRangeException();
            }
            Qst[] nQsts = new Qst[NumOfQuests - 1];
            for (int i = 0,space = 0; i < NumOfQuests - 1; i++, space++)
            {
                nQsts[i] = new Qst();
                if (i == index)
                {
                    space++;
                }
                nQsts[i].Name = _quests[space].Name;
                nQsts[i].Description = _quests[space].Description;
                nQsts[i].DifficultyLevel = _quests[space].DifficultyLevel;
                nQsts[i].LevelOfFear = _quests[space].LevelOfFear;
                nQsts[i].MaxPlayers = _quests[space].MaxPlayers;
                nQsts[i].MaxPrice = _quests[space].MaxPrice;
                nQsts[i].MaxTime = _quests[space].MaxTime;
                nQsts[i].MinAge = _quests[space].MinAge;
                nQsts[i].MinPlayers = _quests[space].MinPlayers;
                nQsts[i].MinPrice = _quests[space].MinPrice;
                nQsts[i].NameOfTheOrganizer = _quests[space].NameOfTheOrganizer;
                nQsts[i].Rating = _quests[space].Rating;
            }
            NumOfQuests--;
            _quests = nQsts;
            Sort();
        }

        public void Delete(List<Int32> indexes)
        {
            foreach (var ind in indexes)
            {
                Delete(ind);
            }
        }

        public List<Int32> FindQ(String name)
        {
            List<Int32> res = new List<int>();
            for (int i = 0; i < _quests.Length; i++)
            {
                if (_quests[i].Name == name)
                {
                    res.Add(i);
                }
            }
            if (res.Count > 0)
            {
                return res;
            }
            throw new NotFoundException("Квесты с таким именем не найдены!");
        }

        public List<Int32> FindQRating(Int32 from, Int32 to)// поиск по рейтингу
        {
            List<Int32> res = new List<int>();
            for (int i = 0; i < _quests.Length; i++)
            {
                if (_quests[i].Rating >= from && _quests[i].Rating <= to)
                {
                    res.Add(i);
                }
            }
            if (res.Count > 0)
            {
                return res;
            }
            throw new NotFoundException("Квесты с таким рейтингом не найдены!");
        }
        public List<Int32> FindQDificult(Int32 from, Int32 to)
        {
            List<Int32> res = new List<int>();
            for (int i = 0; i < _quests.Length; i++)
            {
                if (_quests[i].DifficultyLevel >= from && _quests[i].DifficultyLevel <= to)
                {
                    res.Add(i);
                }
            }
            if (res.Count > 0)
            {
                return res;
            }
            throw new NotFoundException("Квесты с такой сложностью не найдены!");
        }

        public List<Int32> FindQPlayers(Int32 from, Int32 to)
        {
            List<Int32> res = new List<int>();
            for (int i = 0; i < _quests.Length; i++)
            {
                if (_quests[i].MinPlayers >= from && _quests[i].MaxPlayers <= to)
                {
                    res.Add(i);
                }
            }
            if (res.Count > 0)
            {
                return res;
            }
            throw new NotFoundException("Квесты с таким кол-вом игроков не найдены!");
        }

        public List<Int32> FindQPrice(Int32 from, Int32 to)
        {
            List<Int32> res = new List<int>();
            for (int i = 0; i < _quests.Length; i++)
            {
                if (_quests[i].MinPrice >= from && _quests[i].MaxPrice <= to)
                {
                    res.Add(i);
                }
            }
            if (res.Count > 0)
            {
                return res;
            }
            throw new NotFoundException("Квесты с такой ценой не найдены!");
        }

        public void Print(Int32 index)//печать по одному индексу
        {
            if (index > _quests.Length)
            {
                throw new IndexOutOfRangeException();
            }
            Console.WriteLine(_quests[index].ToString());
        }

        public void Print(List<Int32> indexes)//печать по массиву индексов
        {
            foreach (var ind in indexes)
            {
                Print(ind);
                Console.WriteLine();
            }
        }

        public void Print()//печать всех квестов
        {
            foreach (var el in _quests)
            {
                Console.WriteLine(el.ToString());
                Console.WriteLine();
            }
        }

        public Qst this[int i]
        {
            get { return _quests[i]; }
            set { _quests[i] = value; }
        }

    }
}
