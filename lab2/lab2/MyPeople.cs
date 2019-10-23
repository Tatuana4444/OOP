using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyPeople
{
    public class People
    {
        protected int x;
        protected int y;
        protected Form fm;
        protected int width = 200;
        protected string Str = "Мы все люди";
        public bool isWork;
        PictureBox p;
        public Label label, label2;
        public virtual void Draw(Form fm, int x, int y, bool isWork)
        {
            width = 200;
            string Path = "C:\\2курс2сем\\ООТПиСП\\Лаба1\\picture\\Все.png";
            Drawwing(fm, x, y, Path);

        }
        public void MyDispose()
        {
            p.Dispose();
            label.Dispose();
            label2.Dispose();
        }
        protected void Drawwing(Form fm, int x, int y, string Path)
        {
            this.x = x;
            this.y = y;
            this.fm = fm;
            p = new PictureBox();
            p.Image = Image.FromFile(Path);
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

    public class Adult : People
    {
        public override void Draw(Form fm, int x, int y, bool isWork)
        {
            width = 200;
            string Path = "C:\\2курс2сем\\ООТПиСП\\Лаба1\\picture\\Совершеннолетнии.png";
            Drawwing(fm, x, y, Path);
            Str = "Мы взрослые люди";
        }


    }
    public class Kids : People
    {
        public override void Draw(Form fm, int x, int y, bool isWork)
        {
            width = 150;
            string Path = "C:\\2курс2сем\\ООТПиСП\\Лаба1\\picture\\НЕСовершеннолетнии.png";
            Drawwing(fm, x, y, Path);
            Str = "Мы дети";
        }

    }
    public class Worker : Adult
    {
        public override void Draw(Form fm, int x, int y, bool isWork)
        {
            width = 200;
            this.isWork = isWork;
            string Path;
            if (isWork)
                Path = "C:\\2курс2сем\\ООТПиСП\\Лаба1\\picture\\Работающие.png";
            else
                Path = "C:\\2курс2сем\\ООТПиСП\\Лаба1\\picture\\НЕРаботающие.png";
            Drawwing(fm, x, y, Path);
            if (isWork)
                Str = "Мы работаем круглыми сутками";
            else
                Str = "А мы не работаем";
        }

    }


    public class Bilder : Worker
    {
        public override void Draw(Form fm, int x, int y, bool isWork)
        {
            width = 100;

            string Path = "C:\\2курс2сем\\ООТПиСП\\Лаба1\\picture\\рабочий.png";
            Drawwing(fm, x, y, Path);
            Str = "Я строитель.";
        }

    }

    public class Artist : Worker
    {
        public override void Draw(Form fm, int x, int y, bool isWork)
        {
            width = 100;

            string Path = "C:\\2курс2сем\\ООТПиСП\\Лаба1\\picture\\художник.png";
            Drawwing(fm, x, y, Path);
            Str = "Я художник.";
        }
    }

    public class Boss : Worker
    {
        public override void Draw(Form fm, int x, int y, bool isWork)
        {
            width = 100;

            string Path = "C:\\2курс2сем\\ООТПиСП\\Лаба1\\picture\\предприниматель.png";
            Drawwing(fm, x, y, Path);
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


    public class Student : Worker
    {
        public override void Draw(Form fm, int x, int y, bool isWork)
        {
            width = 100;

            string Path = "C:\\2курс2сем\\ООТПиСП\\Лаба1\\picture\\студент.png";
            Drawwing(fm, x, y, Path);
            Str = "Я студент.";
        }

    }

    public class Old : Worker
    {
        public override void Draw(Form fm, int x, int y, bool isWork)
        {
            width = 100;
            string Path = "C:\\2курс2сем\\ООТПиСП\\Лаба1\\picture\\пенсионер.png";
            Drawwing(fm, x, y, Path);
            Str = "Я пенсионер.";
        }
    }

    public class Invalid : Worker
    {
        public override void Draw(Form fm, int x, int y, bool isWork)
        {
            width = 120;
            string Path = "C:\\2курс2сем\\ООТПиСП\\Лаба1\\picture\\ивалид.png";
            Drawwing(fm, x, y, Path);
            Str = "Я ивалид.";
        }
    }

    public class Shool : Kids
    {
        public override void Draw(Form fm, int x, int y, bool isWork)
        {
            width = 100;
            string Path = "C:\\2курс2сем\\ООТПиСП\\Лаба1\\picture\\школьник.png";
            Drawwing(fm, x, y, Path);
            Str = "Я школьница.";
        }
    }
    public class Kindergarden : Kids
    {
        public override void Draw(Form fm, int x, int y, bool isWork)
        {
            width = 100;
            string Path = "C:\\2курс2сем\\ООТПиСП\\Лаба1\\picture\\детсад.png";
            Drawwing(fm, x, y, Path);
            Str = "Я хочу в детский садик";
        }

    }
    public class Baby : Kids
    {
        public override void Draw(Form fm, int x, int y, bool isWork)
        {
            width = 100;

            string Path = "C:\\2курс2сем\\ООТПиСП\\Лаба1\\picture\\малыш.png";
            Drawwing(fm, x, y, Path);
            Str = "Я еще совсем маленькая.";
        }

    }

}

