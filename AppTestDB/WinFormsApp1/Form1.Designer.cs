namespace GetDataBD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            databaseTablesListGridView = new DataGridView();
            ColumnInformationGridView = new DataGridView();
            btnDatabaseTablesList = new Button();
            btnSaveDoc = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            dbLogin = new TextBox();
            dbName = new TextBox();
            btnBDConnect = new Button();
            ((System.ComponentModel.ISupportInitialize)databaseTablesListGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ColumnInformationGridView).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // databaseTablesListGridView
            // 
            databaseTablesListGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            databaseTablesListGridView.Location = new Point(17, 33);
            databaseTablesListGridView.Name = "databaseTablesListGridView";
            databaseTablesListGridView.RowTemplate.Height = 25;
            databaseTablesListGridView.Size = new Size(234, 328);
            databaseTablesListGridView.TabIndex = 0;
            // 
            // ColumnInformationGridView
            // 
            ColumnInformationGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ColumnInformationGridView.Location = new Point(255, 33);
            ColumnInformationGridView.Name = "ColumnInformationGridView";
            ColumnInformationGridView.RowTemplate.Height = 25;
            ColumnInformationGridView.Size = new Size(525, 328);
            ColumnInformationGridView.TabIndex = 1;
            // 
            // btnDatabaseTablesList
            // 
            btnDatabaseTablesList.Location = new Point(17, 378);
            btnDatabaseTablesList.Name = "btnDatabaseTablesList";
            btnDatabaseTablesList.Size = new Size(234, 35);
            btnDatabaseTablesList.TabIndex = 2;
            btnDatabaseTablesList.Text = "Загрузить список таблиц базы данных";
            btnDatabaseTablesList.UseVisualStyleBackColor = true;
            btnDatabaseTablesList.Click += btnDatabaseTablesList_Click;
            // 
            // btnSaveDoc
            // 
            btnSaveDoc.Location = new Point(542, 378);
            btnSaveDoc.Name = "btnSaveDoc";
            btnSaveDoc.Size = new Size(238, 35);
            btnSaveDoc.TabIndex = 3;
            btnSaveDoc.Text = "Сохранить данные в документе Word";
            btnSaveDoc.UseVisualStyleBackColor = true;
            btnSaveDoc.Click += btnSaveDoc_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnSaveDoc);
            groupBox1.Controls.Add(btnDatabaseTablesList);
            groupBox1.Controls.Add(ColumnInformationGridView);
            groupBox1.Controls.Add(databaseTablesListGridView);
            groupBox1.Location = new Point(8, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(796, 430);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(255, 15);
            label2.Name = "label2";
            label2.Size = new Size(145, 15);
            label2.TabIndex = 5;
            label2.Text = "Информация о столбцах";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 15);
            label1.Name = "label1";
            label1.Size = new Size(164, 15);
            label1.TabIndex = 4;
            label1.Text = "Список таблиц базы данных";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(dbLogin);
            groupBox2.Controls.Add(dbName);
            groupBox2.Controls.Add(btnBDConnect);
            groupBox2.Location = new Point(8, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(796, 69);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Connect BD";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(461, 19);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 8;
            label5.Text = "Пароль";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(255, 19);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 7;
            label4.Text = "Имя пользователя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 19);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 6;
            label3.Text = "Имя базы данных";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(461, 40);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 3;
            // 
            // dbLogin
            // 
            dbLogin.Location = new Point(255, 40);
            dbLogin.Name = "dbLogin";
            dbLogin.Size = new Size(200, 23);
            dbLogin.TabIndex = 2;
            // 
            // dbName
            // 
            dbName.Location = new Point(17, 40);
            dbName.Name = "dbName";
            dbName.Size = new Size(200, 23);
            dbName.TabIndex = 1;
            // 
            // btnBDConnect
            // 
            btnBDConnect.Location = new Point(667, 39);
            btnBDConnect.Name = "btnBDConnect";
            btnBDConnect.Size = new Size(113, 23);
            btnBDConnect.TabIndex = 0;
            btnBDConnect.Text = "Connect BD";
            btnBDConnect.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 505);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Тестовое задание";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)databaseTablesListGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)ColumnInformationGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView databaseTablesListGridView;
        private DataGridView ColumnInformationGridView;
        private Button btnDatabaseTablesList;
        private Button btnSaveDoc;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnBDConnect;
        private TextBox textBox1;
        private TextBox dbLogin;
        private TextBox dbName;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}