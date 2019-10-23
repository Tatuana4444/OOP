namespace lab2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.обьектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьОбъектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CryptoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeCryptoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CompressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExtractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CompressDirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractDirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decoratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FacadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListObj = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.iteratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обьектToolStripMenuItem,
            this.удалитьОбъектToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.ToolsToolStripMenuItem,
            this.decoratorToolStripMenuItem,
            this.FacadeToolStripMenuItem,
            this.iteratorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1379, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Click += new System.EventHandler(this.menuStrip1_Click);
            // 
            // обьектToolStripMenuItem
            // 
            this.обьектToolStripMenuItem.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.обьектToolStripMenuItem.Name = "обьектToolStripMenuItem";
            this.обьектToolStripMenuItem.Size = new System.Drawing.Size(186, 32);
            this.обьектToolStripMenuItem.Text = "Добавить объект";
            this.обьектToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // удалитьОбъектToolStripMenuItem
            // 
            this.удалитьОбъектToolStripMenuItem.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.удалитьОбъектToolStripMenuItem.Name = "удалитьОбъектToolStripMenuItem";
            this.удалитьОбъектToolStripMenuItem.Size = new System.Drawing.Size(177, 32);
            this.удалитьОбъектToolStripMenuItem.Text = "Удалить объект";
            this.удалитьОбъектToolStripMenuItem.Click += new System.EventHandler(this.DeleteОбъектToolStripMenuItem_Click_1);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic);
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(123, 32);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic);
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(115, 32);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // ToolsToolStripMenuItem
            // 
            this.ToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CryptoToolStripMenuItem,
            this.DeCryptoToolStripMenuItem,
            this.CompressToolStripMenuItem,
            this.ExtractToolStripMenuItem,
            this.CompressDirToolStripMenuItem,
            this.extractDirToolStripMenuItem});
            this.ToolsToolStripMenuItem.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic);
            this.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem";
            this.ToolsToolStripMenuItem.Size = new System.Drawing.Size(82, 32);
            this.ToolsToolStripMenuItem.Text = "Опции";
            // 
            // CryptoToolStripMenuItem
            // 
            this.CryptoToolStripMenuItem.Name = "CryptoToolStripMenuItem";
            this.CryptoToolStripMenuItem.Size = new System.Drawing.Size(247, 32);
            this.CryptoToolStripMenuItem.Text = "Шифрование";
            this.CryptoToolStripMenuItem.Click += new System.EventHandler(this.CryptoToolStripMenuItem_Click);
            // 
            // DeCryptoToolStripMenuItem
            // 
            this.DeCryptoToolStripMenuItem.Name = "DeCryptoToolStripMenuItem";
            this.DeCryptoToolStripMenuItem.Size = new System.Drawing.Size(247, 32);
            this.DeCryptoToolStripMenuItem.Text = "Дешифрирование";
            this.DeCryptoToolStripMenuItem.Click += new System.EventHandler(this.DeCryptoToolStripMenuItem_Click);
            // 
            // CompressToolStripMenuItem
            // 
            this.CompressToolStripMenuItem.Name = "CompressToolStripMenuItem";
            this.CompressToolStripMenuItem.Size = new System.Drawing.Size(247, 32);
            this.CompressToolStripMenuItem.Text = "Сжать файл";
            this.CompressToolStripMenuItem.Click += new System.EventHandler(this.CompressToolStripMenuItem_Click);
            // 
            // ExtractToolStripMenuItem
            // 
            this.ExtractToolStripMenuItem.Name = "ExtractToolStripMenuItem";
            this.ExtractToolStripMenuItem.Size = new System.Drawing.Size(247, 32);
            this.ExtractToolStripMenuItem.Text = "Извлечь файл";
            this.ExtractToolStripMenuItem.Click += new System.EventHandler(this.ExtractToolStripMenuItem_Click);
            // 
            // CompressDirToolStripMenuItem
            // 
            this.CompressDirToolStripMenuItem.Name = "CompressDirToolStripMenuItem";
            this.CompressDirToolStripMenuItem.Size = new System.Drawing.Size(247, 32);
            this.CompressDirToolStripMenuItem.Text = "Сжать папку";
            this.CompressDirToolStripMenuItem.Click += new System.EventHandler(this.CompressDirToolStripMenuItem_Click);
            // 
            // extractDirToolStripMenuItem
            // 
            this.extractDirToolStripMenuItem.Name = "extractDirToolStripMenuItem";
            this.extractDirToolStripMenuItem.Size = new System.Drawing.Size(247, 32);
            this.extractDirToolStripMenuItem.Text = "Извлечь папку";
            this.extractDirToolStripMenuItem.Click += new System.EventHandler(this.extractDirToolStripMenuItem_Click);
            // 
            // decoratorToolStripMenuItem
            // 
            this.decoratorToolStripMenuItem.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic);
            this.decoratorToolStripMenuItem.Name = "decoratorToolStripMenuItem";
            this.decoratorToolStripMenuItem.Size = new System.Drawing.Size(127, 32);
            this.decoratorToolStripMenuItem.Text = "Декоратор";
            this.decoratorToolStripMenuItem.Visible = false;
            this.decoratorToolStripMenuItem.Click += new System.EventHandler(this.decoratorToolStripMenuItem_Click);
            // 
            // FacadeToolStripMenuItem
            // 
            this.FacadeToolStripMenuItem.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic);
            this.FacadeToolStripMenuItem.Name = "FacadeToolStripMenuItem";
            this.FacadeToolStripMenuItem.Size = new System.Drawing.Size(81, 32);
            this.FacadeToolStripMenuItem.Text = "Фасад";
            this.FacadeToolStripMenuItem.Visible = false;
            this.FacadeToolStripMenuItem.Click += new System.EventHandler(this.FacadeToolStripMenuItem_Click);
            // 
            // ListObj
            // 
            this.ListObj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListObj.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.ListObj.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListObj.FullRowSelect = true;
            this.ListObj.GridLines = true;
            this.ListObj.Location = new System.Drawing.Point(1158, 31);
            this.ListObj.Margin = new System.Windows.Forms.Padding(0);
            this.ListObj.Name = "ListObj";
            this.ListObj.Size = new System.Drawing.Size(236, 879);
            this.ListObj.TabIndex = 1;
            this.ListObj.UseCompatibleStateImageBehavior = false;
            this.ListObj.View = System.Windows.Forms.View.Details;
            this.ListObj.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListObj_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Объекты";
            this.columnHeader1.Width = 220;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Binary File (*.bin)|*.bin";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Binary File (*.bin)|*.bin";
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // iteratorToolStripMenuItem
            // 
            this.iteratorToolStripMenuItem.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic);
            this.iteratorToolStripMenuItem.Name = "iteratorToolStripMenuItem";
            this.iteratorToolStripMenuItem.Size = new System.Drawing.Size(120, 32);
            this.iteratorToolStripMenuItem.Text = "Итератор";
            this.iteratorToolStripMenuItem.Click += new System.EventHandler(this.iteratorToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 625);
            this.Controls.Add(this.ListObj);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №5 Бондарева Татьяна гр. 751001";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem обьектToolStripMenuItem;
        private System.Windows.Forms.ListView ListObj;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ToolStripMenuItem удалитьОбъектToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem ToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CryptoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeCryptoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CompressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExtractToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ToolStripMenuItem extractDirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CompressDirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decoratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FacadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iteratorToolStripMenuItem;
    }
}

