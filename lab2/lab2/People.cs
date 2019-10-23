using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace AllPeople
{
    [Serializable]
    public class People
    {
        public int x;
        public int y;
        [NonSerialized] public Form fm;
        protected int width = 200;
        internal string Str = "Мы все люди";
        public bool isWork, isInfo;
        public string path;

        [NonSerialized]public PictureBox p;
        [NonSerialized] public Label label, label2;
        public People()
        {
            path = Path.GetFullPath("..\\..\\..\\..\\picture\\Все.png");
        }
        public virtual void Draw(Form fm, int x, int y, bool isWork)
        {
            this.isWork = isWork;
            width = 200;
            Drawwing(fm, x, y);

        }
        public virtual void MyDispose()
        {
            p.Dispose();
            if (label!=null)
                label.Dispose();
            if (label2 != null)
                label2.Dispose();
        }
        protected void Drawwing(Form fm, int x, int y)
        {
            this.x = x;
            this.y = y;
            this.fm = fm;
            p = new PictureBox();
            p.Image = Image.FromFile(path);
            p.Location = new Point(x, y);
            p.Width = width;
            p.Height = 150;
            p.SizeMode = PictureBoxSizeMode.StretchImage;
            p.Parent = fm;
        }


        public virtual void ShowInfo()
        {
            label = new Label();
            label2 = new Label();
            label.Width = 200;
            label.Text = Str;
            label.Location = new Point(x, y - 20);
            label.Parent = fm;
            label.BringToFront();
        }
    }
    [Serializable]
    public class Adult : People
    {
        public Adult()
        {
            path = Path.GetFullPath("..\\..\\..\\..\\picture\\Совершеннолетнии.png");
        }
        public override void Draw(Form fm, int x, int y, bool isWork)
        {
            this.isWork = isWork;
            width = 200;
            Drawwing(fm, x, y);
            Str = "Мы взрослые люди";
        }


    }
    [Serializable]
    public class Kids : People
    {
        public Kids()
        {
            path = Path.GetFullPath("..\\..\\..\\..\\picture\\НЕСовершеннолетнии.png");

        }
        public override void Draw(Form fm, int x, int y, bool isWork)
        {
            this.isWork = isWork;
            width = 150;
            Drawwing(fm, x, y);
            Str = "Мы дети";
        }

    }
    [Serializable]
    public class Worker : Adult
    {
        public Worker()
        {
            path = Path.GetFullPath("..\\..\\..\\..\\picture\\НЕРаботающие.png");
        }
        public override void Draw(Form fm, int x, int y, bool isWork)
        {
            this.isWork = isWork;
            width = 200;
            this.isWork = isWork;
            if (isWork)
                path = Path.GetFullPath("..\\..\\..\\..\\picture\\Работающие.png");
            Drawwing(fm, x, y);
            if (isWork)
                Str = "Мы работаем круглыми сутками";
            else
                Str = "А мы не работаем";
        }

    }

    [Serializable]
    public class Builder : Worker
    {
        public Builder()
        {
            path = Path.GetFullPath("..\\..\\..\\..\\picture\\рабочий.png");
        }
        public override void Draw(Form fm, int x, int y, bool isWork)
        {
            this.isWork = isWork;
            width = 100;
            Drawwing(fm, x, y);
            Str = "Я строитель.";
        }

    }
    [Serializable]
    public class Artist : Worker
    {
        public Artist()
        {
            path = Path.GetFullPath("..\\..\\..\\..\\picture\\художник.png");
        }
        public override void Draw(Form fm, int x, int y, bool isWork)
        {
            this.isWork = isWork;
            width = 100;
            Drawwing(fm, x, y);
            Str = "Я художник.";
        }
    }
    [Serializable]
    public class Boss : Worker
    {
        public Boss()
        {
            path = Path.GetFullPath("..\\..\\..\\..\\picture\\предприниматель.png");
        }
        public override void Draw(Form fm, int x, int y, bool isWork)
        {
            this.isWork = isWork;
            width = 100;
            Drawwing(fm, x, y);
            Str = "Я предприниматель.";
        }
        public override void ShowInfo()
        {

            base.ShowInfo();
            label2 = new Label();
            label2.Width = 200;
            label2.ForeColor = Color.Blue;
            label2.Text = "У меня своя компания";
            label2.Location = new Point(x, y + 150);
            label2.Parent = fm;
        }
    }

    [Serializable]
    public class Student : Worker
    {
        public Student()
        {
            path = Path.GetFullPath("..\\..\\..\\..\\picture\\студент.png");
        }
        public override void Draw(Form fm, int x, int y, bool isWork)
        {
            this.isWork = isWork;
            width = 100;
            Drawwing(fm, x, y);
            Str = "Я студент.";
        }

    }
    [Serializable]
    public class Old : Worker
    {
        public Old()
        {
            path = Path.GetFullPath("..\\..\\..\\..\\picture\\пенсионер.png");
        }
        public override void Draw(Form fm, int x, int y, bool isWork)
        {
            this.isWork = isWork;
            width = 100;
            Drawwing(fm, x, y);
            Str = "Я пенсионер.";
        }
    }
    [Serializable]
    public class Invalid : Worker
    {
        public Invalid()
        {
            path = Path.GetFullPath("..\\..\\..\\..\\picture\\ивалид.png");
        }
        public override void Draw(Form fm, int x, int y, bool isWork)
        {
            this.isWork = isWork;
            width = 120;
            Drawwing(fm, x, y);
            Str = "Я ивалид.";
        }
    }
    [Serializable]
    public class Shool : Kids
    {
        public Shool()
        {
            path = Path.GetFullPath("..\\..\\..\\..\\picture\\школьник.png");
        }
        public override void Draw(Form fm, int x, int y, bool isWork)
        {
            this.isWork = isWork;
            width = 100;
            Drawwing(fm, x, y);
            Str = "Я школьница.";
        }
    }
    [Serializable]
    public class Kindergarden : Kids
    {
        public Kindergarden()
        {
            path = Path.GetFullPath("..\\..\\..\\..\\picture\\детсад.png");
        }
        public override void Draw(Form fm, int x, int y, bool isWork)
        {
            this.isWork = isWork;
            width = 100;
            Drawwing(fm, x, y);
            Str = "Я хочу в детский садик";
        }

    }
    [Serializable]
    public class Baby : Kids
    {
        public Baby()
        {
            path = Path.GetFullPath("..\\..\\..\\..\\picture\\малыш.png");
        }
        public override void Draw(Form fm, int x, int y, bool isWork)
        {
            this.isWork = isWork;
            width = 100;
            Drawwing(fm, x, y);
            Str = "Я еще совсем маленькая(-ий).";
        }

    }
}
