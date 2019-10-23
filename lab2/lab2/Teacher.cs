using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace AllPeople
{
    [Serializable]
    public class Teacher : Worker
    {
        public Teacher()
        {
            path = Path.GetFullPath("..\\..\\..\\..\\picture\\учительница.jpg");
        }
        public override void Draw(Form fm, int x, int y, bool isWork=true)
        {
            width = 80;
            this.isWork = isWork;
            Drawwing(fm, x, y);
            Str = "Я учительница.";
        }
    }
}
