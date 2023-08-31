using System.Data.SqlClient;
using System.Data;
using Xceed.Words.NET;
using Xceed.Document.NET;
using DataBaseLibrary;

namespace GetDataBD
{
    public partial class Form1 : Form
    {
        DataBaseLibrary.DataBase dataBase = new DataBaseLibrary.DataBase();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDatabaseTablesList_Click(object sender, EventArgs e)
        {
            databaseTablesListGridView.DataSource = dataBase.DatabaseTablesList();
            if (databaseTablesListGridView.DataSource is null)
            {
                MessageBox.Show($"Ошибка подключения к БД");
                return;
            }

            databaseTablesListGridView.CellClick += DataGridView1_CellClick!;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Убедитесь, что событие произошло на строке, а не за пределами таблицы
            {
                string? tableName = databaseTablesListGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                LoadColumnInformation(tableName!);
            }
        }

        private void LoadColumnInformation(string tableName)
        {
            ColumnInformationGridView.DataSource = dataBase.LoadColumnInformation(tableName);
        }

        private void btnSaveDoc_Click(object sender, EventArgs e)
        {
            // Запрос имени файла
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Word документы (*.doc)|*.doc";
            saveFileDialog.Title = "Сохранить данные в документе Word";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;

                using (DocX doc = DocX.Create(fileName))
                {
                    doc.InsertParagraph("Список таблиц базы данных:");
                    if (!AddDataGridViewToDocument(databaseTablesListGridView, doc))
                    {
                        return;
                    }

                    doc.InsertParagraph("Информация о столбцах:");
                    if (!AddDataGridViewToDocument(ColumnInformationGridView, doc))
                    {
                        return;
                    }

                    doc.Save();
                    MessageBox.Show("Документ успешно записан!");
                }
            }
        }
        private bool AddDataGridViewToDocument(DataGridView dataGridView, DocX doc)
        {
            try
            {

                // Добавление заголовков столбцов
                Table table = doc.AddTable(dataGridView.RowCount + 1, dataGridView.ColumnCount);
                for (int i = 0; i < dataGridView.ColumnCount; i++)
                {
                    table.Rows[0].Cells[i].Paragraphs.First().Append(dataGridView.Columns[i].HeaderText);
                }

                // Добавление данных из строк
                for (int i = 0; i < dataGridView.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView.ColumnCount; j++)
                    {
                        if (dataGridView.Rows[i].Cells[j].Value != null)
                        {
                            table.Rows[i + 1].Cells[j].Paragraphs.First().Append(dataGridView.Rows[i].Cells[j].Value.ToString());
                        }
                        else
                        {
                            table.Rows[i + 1].Cells[j].Paragraphs.First().Append("");
                        }
                    }
                }

                doc.InsertTable(table);
                doc.InsertParagraph();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Документ пустой!\nВыберите пожалуйста таблицу!\nОписание ошибки: {ex.Message}");
                return false;
            }
            return true;
        }

        private void btnConnectBD_Click(object sender, EventArgs e)
        {
            dataBase.serverName = "(local)";
            dataBase.nameDB = NameDB.Text;
            dataBase.loginDB = LoginDB.Text;
            dataBase.passwordDB = passwordDB.Text;

        }
    }
}