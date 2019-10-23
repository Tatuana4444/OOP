using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace AllPeople
{
    [Serializable]
    public class Fireman : Worker
    {
        public override void Draw(Form fm, int x, int y, bool isWork=true)
        {
            this.isWork = isWork;
            width = 100;
            path = Path.GetFullPath("..\\..\\..\\..\\picture\\пожарный.jpg");
            Drawwing(fm, x, y);
            Str = "Я пожарный.";
        }
    }
}

