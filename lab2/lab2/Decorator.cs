using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllPeople;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace lab2
{
    [Serializable]
    abstract class PeopleDecorator: People
    {
        protected People people;
        public PeopleDecorator(People people) {
            this.people = people;
        }
    }
    [Serializable]
    class AddAge : PeopleDecorator
    {
        int Age;
        [NonSerialized] Label AgeLabel;
        public AddAge(People people, int Age) : base(people) {
            x = people.x;
            y = people.y;
            fm = people.fm;
            label = people.label;
            label2 = people.label2;
            isWork = people.isWork;
            isInfo = people.isInfo;
            Str = people.Str;
            this.Age = Age;
            ShowAge();
            if (Age == 0)
                path = Path.GetFullPath("..\\..\\..\\..\\picture\\новорожденный.jpg");
            else
                 if (Age == 1)
                path = Path.GetFullPath("..\\..\\..\\..\\picture\\1год.jpg");
                else
                    if (Age == 2)
                path = Path.GetFullPath("..\\..\\..\\..\\picture\\2года.jpg");
                    else
                path = Path.GetFullPath("..\\..\\..\\..\\picture\\малыш.png");

            people.MyDispose();
        }
        public override void MyDispose()
        {
            base.MyDispose();
            if (AgeLabel!=null)
                AgeLabel.Dispose();
        }
        private void ShowAge()
        {

            AgeLabel = new Label();
            AgeLabel.Width = 200;
            AgeLabel.Text ="Мне "+ Age.ToString();
            AgeLabel.Location = new Point(people.x, people.y - 40);
            AgeLabel.Parent = people.fm;
        }

    }

}
