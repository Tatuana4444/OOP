using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllPeople;
using System.Windows.Forms;

namespace lab2
{

    class Find 
    {
        public string FindPeople(Lib lib)
        {
            int kol = 0;
            string Str = "";
            IPeopleIterator iterator = lib.CreateNumerator();
            while (iterator.HasNext())
            {
                People people = iterator.Next();
                if (people.isWork)
                {
                    kol++;
                    Str += people.GetType().ToString()+"("+people.x+", "+ people.y + ")" + ", ";
                }
            }
            if (kol == 0)
                return "Работающте люди не найдены";
            else
                return "Найдено "+kol.ToString()+" работащих(-ий) людей(человек): "+Str.Substring(0, Str.Length - 2);

        }
    }
    interface IPeopleIterator
    {
        bool HasNext();
        People Next();
    }
    interface IPeopleNumerable
    {
        IPeopleIterator CreateNumerator();
        int Count { get; }
        People this[int index] { get; }
    }
    class Lib: IPeopleNumerable
    {
        private People[] peopleList;
        public Lib(People[] arr)
        {
            peopleList = arr;
        }
        public int Count
        {
            get { return peopleList.Length; }
        }
        public People this[int index]
        {
            get { return peopleList[index]; }
        }
        public IPeopleIterator CreateNumerator()
        {
            return new LibNumerator(this);
        }
    }
    class LibNumerator: IPeopleIterator
    {
        IPeopleNumerable aggregate;
        public int index = 0;
        public LibNumerator(IPeopleNumerable aggr)
        {
            aggregate = aggr;
        }
        public bool HasNext()
        {
            return index < aggregate.Count;
        }
        public People Next()
        {
            return aggregate[index++];
        }
    }
}
