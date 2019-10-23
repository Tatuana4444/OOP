using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllPeople;

namespace lab2
{
    class Facade
    {
        People people1, people2, people3;
        public Facade(People p1, People p2, People p3)
        {
            people1 = p1;
            people2 = p2;
            people3 = p3;
        }
        private void ShowOneInfo(People p)
        {
            p.isInfo = true;
            if (p.label == null)
                p.ShowInfo();
            else
                p.label.Text = p.Str;
        }
        public void ShowAllInfo()
        {
            ShowOneInfo(people1);
            ShowOneInfo(people2);
            ShowOneInfo(people3);
        }
        private void DeleteOneInfp(People p)
        {
            p.isInfo = false;
            p.label.Text = "";
        }
        public void DeleteAllInfo()
        {
            DeleteOneInfp(people1);
            DeleteOneInfp(people2);
            DeleteOneInfp(people3);
        }
    }
}
