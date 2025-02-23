using BookSalesSystem2._0.BookFolder;
using BookSalesSystem2._0.UserFolder;
using System.ComponentModel;

namespace BookSalesSystem2._0
{
    partial class BookControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            addBookButton = new Button();
            dataGridView1 = new DataGridView();
            Title = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            Genre = new DataGridViewTextBoxColumn();
            ISBN = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            editButton = new DataGridViewButtonColumn();
            deleteButton = new DataGridViewButtonColumn();
            bookBindingSource = new BindingSource(components);
            bookSalesSystemContextBindingSource = new BindingSource(components);
            userBindingSource = new BindingSource(components);
            searchBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((ISupportInitialize)dataGridView1).BeginInit();
            ((ISupportInitialize)bookBindingSource).BeginInit();
            ((ISupportInitialize)bookSalesSystemContextBindingSource).BeginInit();
            ((ISupportInitialize)userBindingSource).BeginInit();
            SuspendLayout();
            // 
            // addBookButton
            // 
            addBookButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addBookButton.AutoSize = true;
            addBookButton.BackColor = Color.FromArgb(101, 39, 253);
            addBookButton.Cursor = Cursors.Hand;
            addBookButton.FlatAppearance.BorderSize = 0;
            addBookButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 13, 182);
            addBookButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 16, 230);
            addBookButton.FlatStyle = FlatStyle.Flat;
            addBookButton.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addBookButton.ForeColor = Color.White;
            addBookButton.Location = new Point(558, 625);
            addBookButton.Margin = new Padding(3, 4, 3, 4);
            addBookButton.Name = "addBookButton";
            addBookButton.Size = new Size(277, 42);
            addBookButton.TabIndex = 7;
            addBookButton.Text = "Додати нову книгу";
            addBookButton.UseVisualStyleBackColor = false;
            addBookButton.Click += addBookButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(57, 40, 179);
            dataGridViewCellStyle1.Font = new Font("Palatino Linotype", 11.2F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Title, Author, Genre, ISBN, Price, Stock, editButton, deleteButton });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Palatino Linotype", 10F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = SystemColors.HotTrack;
            dataGridView1.Location = new Point(15, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(831, 518);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Title
            // 
            Title.DataPropertyName = "Title";
            Title.FillWeight = 155.381851F;
            Title.HeaderText = "Назва";
            Title.MinimumWidth = 10;
            Title.Name = "Title";
            Title.ReadOnly = true;
            // 
            // Author
            // 
            Author.DataPropertyName = "Author";
            Author.FillWeight = 136.844971F;
            Author.HeaderText = "Автор";
            Author.MinimumWidth = 6;
            Author.Name = "Author";
            Author.ReadOnly = true;
            // 
            // Genre
            // 
            Genre.DataPropertyName = "Genre";
            Genre.FillWeight = 98.94682F;
            Genre.HeaderText = "Жанр";
            Genre.MinimumWidth = 6;
            Genre.Name = "Genre";
            Genre.ReadOnly = true;
            // 
            // ISBN
            // 
            ISBN.DataPropertyName = "ISBN";
            ISBN.FillWeight = 68.8868942F;
            ISBN.HeaderText = "ISBN";
            ISBN.MinimumWidth = 6;
            ISBN.Name = "ISBN";
            ISBN.ReadOnly = true;
            // 
            // Price
            // 
            Price.DataPropertyName = "Price";
            Price.FillWeight = 93.14266F;
            Price.HeaderText = "Ціна";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // Stock
            // 
            Stock.DataPropertyName = "Stock";
            Stock.FillWeight = 84.8241348F;
            Stock.HeaderText = "Кількість";
            Stock.MinimumWidth = 6;
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            // 
            // editButton
            // 
            editButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(79, 240, 83);
            dataGridViewCellStyle2.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold | FontStyle.Italic);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(53, 176, 55);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            editButton.DefaultCellStyle = dataGridViewCellStyle2;
            editButton.FillWeight = 85.5615F;
            editButton.HeaderText = "";
            editButton.MinimumWidth = 6;
            editButton.Name = "editButton";
            editButton.ReadOnly = true;
            editButton.Resizable = DataGridViewTriState.False;
            editButton.Text = "✏ Редагувати";
            editButton.UseColumnTextForButtonValue = true;
            // 
            // deleteButton
            // 
            deleteButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(224, 72, 65);
            dataGridViewCellStyle3.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(168, 48, 43);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            deleteButton.DefaultCellStyle = dataGridViewCellStyle3;
            deleteButton.FillWeight = 76.41129F;
            deleteButton.HeaderText = "";
            deleteButton.MinimumWidth = 6;
            deleteButton.Name = "deleteButton";
            deleteButton.ReadOnly = true;
            deleteButton.Resizable = DataGridViewTriState.False;
            deleteButton.Text = "❌ Видалити";
            deleteButton.UseColumnTextForButtonValue = true;
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(Book);
            // 
            // bookSalesSystemContextBindingSource
            // 
            bookSalesSystemContextBindingSource.DataSource = typeof(BookSalesSystemContext);
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(User);
            // 
            // searchBox
            // 
            searchBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchBox.Font = new Font("Times New Roman", 12F);
            searchBox.Location = new Point(287, 23);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(396, 30);
            searchBox.TabIndex = 10;
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(169, 33);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 11;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(185, 26);
            label2.Name = "label2";
            label2.Size = new Size(82, 27);
            label2.TabIndex = 14;
            label2.Text = "Пошук:";
            // 
            // BookControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(searchBox);
            Controls.Add(dataGridView1);
            Controls.Add(addBookButton);
            Name = "BookControl";
            Size = new Size(858, 692);
            ((ISupportInitialize)dataGridView1).EndInit();
            ((ISupportInitialize)bookBindingSource).EndInit();
            ((ISupportInitialize)bookSalesSystemContextBindingSource).EndInit();
            ((ISupportInitialize)userBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button addBookButton;
        private DataGridView dataGridView1;
        private BindingSource bookSalesSystemContextBindingSource;
        private BindingSource userBindingSource;
        private BindingSource bookBindingSource;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn Genre;
        private DataGridViewTextBoxColumn ISBN;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewButtonColumn editButton;
        private DataGridViewButtonColumn deleteButton;
        private TextBox searchBox;
        private Label label1;
        private Label label2;
    }
}
