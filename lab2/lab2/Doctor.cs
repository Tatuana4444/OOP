using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace AllPeople
{
    [Serializable]
    public class Doctor : Worker
    {
        public Doctor()
        {
            path = Path.GetFullPath("..\\..\\..\\..\\picture\\доктор.jpg");
        }
        public override void Draw(Form fm, int x, int y, bool isWork)
        {
            width = 100;
            this.isWork = isWork;
            Drawwing(fm, x, y);
            Str = "Я доктор.";
        }
    }
}

