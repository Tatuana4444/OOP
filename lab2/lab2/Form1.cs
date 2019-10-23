using System;
using System.Windows.Forms;
using AllPeople;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Plug;

namespace lab2
{
    public partial class Form1 : Form
    {
        public static Type type;
        public static bool ShowInf, Work=false;
        public static int X, Y, n=0, Age;
        public static People[] arr;

        public Form1()
        {
            InitializeComponent();            
        }

        private void DeleteОбъектToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if ((ListObj.FocusedItem != null)&&(ListObj.FocusedItem.Index>-1))
            {
                int i = ListObj.FocusedItem.Index;
                arr[i].MyDispose();
                for (int j = i; j < n - 1; j++)
                    arr[j] = arr[j + 1];
                n--;
               // arr = null;
                Array.Resize(ref arr, n + 1);
                ListObj.Items.Remove(ListObj.FocusedItem);
                ListObj.FocusedItem = null;
            }
            else
                MessageBox.Show("Ошибка. Выберете элемемент, который хотите удалить");
            if (n > 2)
                FacadeToolStripMenuItem.Visible = true;
            else
                FacadeToolStripMenuItem.Visible = false;
        }

        private void CryptoSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Crypto straus = new Crypto();
            if (n > 0)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream fs = new FileStream(saveFileDialog.FileName.ToString(), FileMode.OpenOrCreate))
                    {
                        formatter.Serialize(fs, arr);
                        MessageBox.Show("Объект сериализован");
                    }
                }
            }
            else
                MessageBox.Show("Ошибка. Объектов для сериализации нет!");
        }

        private void CryptoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName.ToString();
                byte[] array;
                Crypto crypto = new Crypto();
                using (FileStream fstream = File.OpenRead(path))
                {
                    array = new byte[fstream.Length];
                    fstream.Read(array, 0, array.Length);
                    string textFromFile = System.Text.Encoding.Default.GetString(array);
                    array = crypto.Encrypt(textFromFile);
                }
                using (FileStream fstream = new FileStream(path.Insert(path.Length-4,"_"), FileMode.Create))
                {
                    fstream.Write(array, 0, array.Length);
                    fstream.Write(crypto.AesKey, 0, crypto.AesKey.Length); 
                    fstream.Write(crypto.AesIV, 0, crypto.AesIV.Length); 

                }
                MessageBox.Show("Шифрование завершено успешно");
            }
        }

        private void DeCryptoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName.ToString();
                Crypto crypto = new Crypto();
                byte[] array;
                
                using (FileStream fstream = File.OpenRead(path))
                {
                    array = new byte[fstream.Length];
                    fstream.Read(array, 0, array.Length);                    
                    array = System.Text.Encoding.Default.GetBytes(crypto.Decrypt(array));
                }
                using (FileStream fstream = new FileStream(path.Insert(path.Length - 4, "_"), FileMode.Create))
                {                    
                    fstream.Write(array, 0, array.Length);
                }

            }
            MessageBox.Show("Дешифрование завершено успешно");
        }

        private void CompressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Crypto crypto = new Crypto();
                crypto.CompressFile(openFileDialog.FileName);
                MessageBox.Show("Сжатие файла завершено успешно");
            }
            
        }

        private void ExtractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Gz files (*.gz)|*.gz";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Crypto crypto = new Crypto();
                crypto.ExtractFile(openFileDialog.FileName);
                MessageBox.Show("Извлечение файла завершено успешно");
            }
            openFileDialog.Filter = "Binary File(*.bin)| *.bin";
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
            
        }

        private void CompressDirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                Crypto crypto = new Crypto();
                crypto.CompressDirectory(folderBrowserDialog.SelectedPath);
                MessageBox.Show("Сжатие папки завершено успешно");
            }
        }

        private void extractDirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Zip files (*.zip)|*.zip";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Crypto crypto = new Crypto();
                crypto.ExtractDirectory(openFileDialog.FileName);
                MessageBox.Show("Извлечение папки завершено успешно");
            }
            openFileDialog.Filter = "Binary File(*.bin)| *.bin";
        }

        private void menuStrip1_Click(object sender, EventArgs e)
        {

        }

        private void ListObj_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (ListObj.FocusedItem != null)
            {
                int i = ListObj.FocusedItem.Index;
                if ((i>-1) &&((arr[i].GetType().ToString() == "AllPeople.Baby")|| (arr[i].GetType().ToString() == "lab2.AddAge")))
                    decoratorToolStripMenuItem.Visible = true;
                else
                    decoratorToolStripMenuItem.Visible = false;
            }
        }

        private void FacadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facade facade = new Facade(arr[0], arr[1], arr[2]);
            if ((arr[0].isInfo) && (arr[1].isInfo) && (arr[2].isInfo))
                facade.DeleteAllInfo();
            else
                facade.ShowAllInfo();

        }

        private void iteratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lib lib = new Lib(arr);
            Find find = new Find();
            MessageBox.Show(find.FindPeople(lib));
        }

        private void decoratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ListObj.FocusedItem != null)
            {
                FormAge newForm = new FormAge();
                newForm.ShowDialog();
                int i = ListObj.FocusedItem.Index;
                arr[i] = new AddAge(arr[i], Age);
                arr[i].Draw(this, arr[i].x, arr[i].y, arr[i].isWork);
                if (arr[i].isInfo)
                    arr[i].ShowInfo();
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ListObj.Items.Clear();
                while (n > 0)
                {
                    arr[n - 1].MyDispose();
                    n--;

                }
                Array.Resize(ref arr, 0);
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream(openFileDialog.FileName.ToString(), FileMode.OpenOrCreate))
                {
                    arr = (People[])formatter.Deserialize(fs);
                    n = arr.Length;
                    foreach (People p in arr)
                    {
                        p.Draw(this, p.x, p.y, p.isWork);
                        if (p.isInfo)
                            p.ShowInfo();
                        ListObj.Items.Add(p.GetType().ToString());
                    }
                }
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (n > 0)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream fs = new FileStream(saveFileDialog.FileName.ToString(), FileMode.OpenOrCreate))
                    {
                        formatter.Serialize(fs, arr);
                        MessageBox.Show("Объект сериализован");
                    }
                }
            }
            else
                MessageBox.Show("Ошибка. Объектов для сериализации нет!");
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.ShowDialog();
            if (type != null)
            {
                People obj = Activator.CreateInstance(type) as People;
                obj.Draw(this, X, Y, Work);
                obj.isInfo = ShowInf;
                if (ShowInf)
                    obj.ShowInfo();
                Array.Resize(ref arr, n + 1);
                arr[n] = obj;
                ListObj.Items.Add(type.ToString());
                n++;
            }
            if (n > 2)
                FacadeToolStripMenuItem.Visible = true;
            else
                FacadeToolStripMenuItem.Visible = false;
        }
    }

    
}
