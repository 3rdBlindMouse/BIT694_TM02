using System;

namespace SynonymsDatabaseActivity
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteWord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addSynonyms = new System.Windows.Forms.TextBox();
            this.addWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.updateSynonyms = new System.Windows.Forms.TextBox();
            this.updateWord = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.querySynonyms = new System.Windows.Forms.TextBox();
            this.queryWord = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.tableAdapterManager = new SynonymsDatabaseActivity.NewWordsDataSetTableAdapters.TableAdapterManager();
            this.wordsTableAdapter = new SynonymsDatabaseActivity.NewWordsDataSetTableAdapters.WordsTableAdapter();
            this.wordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newWordsDataSet = new SynonymsDatabaseActivity.NewWordsDataSet();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.wordsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.wordsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.selectedFolderFilesListbox = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.selectedFolderTextBox = new System.Windows.Forms.TextBox();
            this.SelectFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.searchTermsLabel = new System.Windows.Forms.Label();
            this.searchTermsTextBox = new System.Windows.Forms.TextBox();
            this.includeSynonymsCheckBox = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.searchTimeLabel = new System.Windows.Forms.Label();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.foldersFoundTextBox = new System.Windows.Forms.TextBox();
            this.subFoldersFoundLabel = new System.Windows.Forms.Label();
            this.filesFoundTextBox = new System.Windows.Forms.TextBox();
            this.filesFoundLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newWordsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordsBindingNavigator)).BeginInit();
            this.wordsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.deleteWord);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.removeButton);
            this.groupBox1.Location = new System.Drawing.Point(765, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delete Entry";
            // 
            // deleteWord
            // 
            this.deleteWord.Location = new System.Drawing.Point(88, 24);
            this.deleteWord.Name = "deleteWord";
            this.deleteWord.Size = new System.Drawing.Size(100, 20);
            this.deleteWord.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Word";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(67, 71);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(109, 23);
            this.removeButton.TabIndex = 0;
            this.removeButton.Text = "Remove Entry";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.addSynonyms);
            this.groupBox2.Controls.Add(this.addWord);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.addButton);
            this.groupBox2.Location = new System.Drawing.Point(765, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Entry";
            // 
            // addSynonyms
            // 
            this.addSynonyms.Location = new System.Drawing.Point(88, 42);
            this.addSynonyms.Name = "addSynonyms";
            this.addSynonyms.Size = new System.Drawing.Size(100, 20);
            this.addSynonyms.TabIndex = 4;
            // 
            // addWord
            // 
            this.addWord.Location = new System.Drawing.Point(88, 20);
            this.addWord.Name = "addWord";
            this.addWord.Size = new System.Drawing.Size(100, 20);
            this.addWord.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Synonyms";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Word";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(67, 77);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(109, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add Entry";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.updateSynonyms);
            this.groupBox3.Controls.Add(this.updateWord);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.updateButton);
            this.groupBox3.Location = new System.Drawing.Point(765, 222);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update Entry";
            // 
            // updateSynonyms
            // 
            this.updateSynonyms.Location = new System.Drawing.Point(80, 37);
            this.updateSynonyms.Name = "updateSynonyms";
            this.updateSynonyms.Size = new System.Drawing.Size(100, 20);
            this.updateSynonyms.TabIndex = 4;
            // 
            // updateWord
            // 
            this.updateWord.Location = new System.Drawing.Point(80, 12);
            this.updateWord.Name = "updateWord";
            this.updateWord.Size = new System.Drawing.Size(100, 20);
            this.updateWord.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Synonyms";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Word";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(67, 71);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(109, 23);
            this.updateButton.TabIndex = 0;
            this.updateButton.Text = "Update Entry";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox4.Controls.Add(this.querySynonyms);
            this.groupBox4.Controls.Add(this.queryWord);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.searchButton);
            this.groupBox4.Location = new System.Drawing.Point(765, 328);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 143);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Query";
            // 
            // querySynonyms
            // 
            this.querySynonyms.Location = new System.Drawing.Point(80, 37);
            this.querySynonyms.Multiline = true;
            this.querySynonyms.Name = "querySynonyms";
            this.querySynonyms.Size = new System.Drawing.Size(100, 72);
            this.querySynonyms.TabIndex = 4;
            // 
            // queryWord
            // 
            this.queryWord.Location = new System.Drawing.Point(80, 12);
            this.queryWord.Name = "queryWord";
            this.queryWord.Size = new System.Drawing.Size(100, 20);
            this.queryWord.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Synonyms";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Word";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(67, 115);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(109, 23);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = SynonymsDatabaseActivity.NewWordsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WordsTableAdapter = this.wordsTableAdapter;
            // 
            // wordsTableAdapter
            // 
            this.wordsTableAdapter.ClearBeforeFill = true;
            // 
            // wordsBindingSource
            // 
            this.wordsBindingSource.DataMember = "Words";
            this.wordsBindingSource.DataSource = this.newWordsDataSet;
            // 
            // newWordsDataSet
            // 
            this.newWordsDataSet.DataSetName = "NewWordsDataSet";
            this.newWordsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // wordsBindingNavigatorSaveItem
            // 
            this.wordsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.wordsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("wordsBindingNavigatorSaveItem.Image")));
            this.wordsBindingNavigatorSaveItem.Name = "wordsBindingNavigatorSaveItem";
            this.wordsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.wordsBindingNavigatorSaveItem.Text = "Save Data";
            this.wordsBindingNavigatorSaveItem.Click += new System.EventHandler(this.wordsBindingNavigatorSaveItem_Click);
            // 
            // wordsBindingNavigator
            // 
            this.wordsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.wordsBindingNavigator.BindingSource = this.wordsBindingSource;
            this.wordsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.wordsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.wordsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.wordsBindingNavigatorSaveItem});
            this.wordsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.wordsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.wordsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.wordsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.wordsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.wordsBindingNavigator.Name = "wordsBindingNavigator";
            this.wordsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.wordsBindingNavigator.Size = new System.Drawing.Size(1034, 25);
            this.wordsBindingNavigator.TabIndex = 0;
            this.wordsBindingNavigator.Text = "bindingNavigator1";
            // 
            // selectedFolderFilesListbox
            // 
            this.selectedFolderFilesListbox.FormattingEnabled = true;
            this.selectedFolderFilesListbox.Location = new System.Drawing.Point(0, 216);
            this.selectedFolderFilesListbox.Name = "selectedFolderFilesListbox";
            this.selectedFolderFilesListbox.Size = new System.Drawing.Size(523, 56);
            this.selectedFolderFilesListbox.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Selected Folder";
            // 
            // selectedFolderTextBox
            // 
            this.selectedFolderTextBox.Location = new System.Drawing.Point(0, 73);
            this.selectedFolderTextBox.Name = "selectedFolderTextBox";
            this.selectedFolderTextBox.Size = new System.Drawing.Size(323, 20);
            this.selectedFolderTextBox.TabIndex = 7;
            this.selectedFolderTextBox.TextChanged += new System.EventHandler(this.selectedFolderTextBox_TextChanged);
            // 
            // SelectFolder
            // 
            this.SelectFolder.Location = new System.Drawing.Point(440, 63);
            this.SelectFolder.Name = "SelectFolder";
            this.SelectFolder.Size = new System.Drawing.Size(86, 33);
            this.SelectFolder.TabIndex = 6;
            this.SelectFolder.Text = "Search Folders";
            this.SelectFolder.UseVisualStyleBackColor = true;
            this.SelectFolder.Click += new System.EventHandler(this.SelectFolder_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchTermsLabel
            // 
            this.searchTermsLabel.AutoSize = true;
            this.searchTermsLabel.Location = new System.Drawing.Point(0, 116);
            this.searchTermsLabel.Name = "searchTermsLabel";
            this.searchTermsLabel.Size = new System.Drawing.Size(73, 13);
            this.searchTermsLabel.TabIndex = 12;
            this.searchTermsLabel.Text = "Search Terms";
            // 
            // searchTermsTextBox
            // 
            this.searchTermsTextBox.Location = new System.Drawing.Point(90, 108);
            this.searchTermsTextBox.Name = "searchTermsTextBox";
            this.searchTermsTextBox.Size = new System.Drawing.Size(233, 20);
            this.searchTermsTextBox.TabIndex = 13;
            // 
            // includeSynonymsCheckBox
            // 
            this.includeSynonymsCheckBox.AutoSize = true;
            this.includeSynonymsCheckBox.Location = new System.Drawing.Point(348, 108);
            this.includeSynonymsCheckBox.Name = "includeSynonymsCheckBox";
            this.includeSynonymsCheckBox.Size = new System.Drawing.Size(112, 17);
            this.includeSynonymsCheckBox.TabIndex = 14;
            this.includeSynonymsCheckBox.Text = "Include Synonyms";
            this.includeSynonymsCheckBox.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(523, 39);
            this.button2.TabIndex = 15;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // searchTimeLabel
            // 
            this.searchTimeLabel.AutoSize = true;
            this.searchTimeLabel.Location = new System.Drawing.Point(3, 279);
            this.searchTimeLabel.Name = "searchTimeLabel";
            this.searchTimeLabel.Size = new System.Drawing.Size(67, 13);
            this.searchTimeLabel.TabIndex = 16;
            this.searchTimeLabel.Text = "Seacrh Time";
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(114, 278);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(100, 20);
            this.timeTextBox.TabIndex = 17;
            // 
            // foldersFoundTextBox
            // 
            this.foldersFoundTextBox.Location = new System.Drawing.Point(114, 306);
            this.foldersFoundTextBox.Name = "foldersFoundTextBox";
            this.foldersFoundTextBox.Size = new System.Drawing.Size(100, 20);
            this.foldersFoundTextBox.TabIndex = 19;
            // 
            // subFoldersFoundLabel
            // 
            this.subFoldersFoundLabel.AutoSize = true;
            this.subFoldersFoundLabel.Location = new System.Drawing.Point(3, 309);
            this.subFoldersFoundLabel.Name = "subFoldersFoundLabel";
            this.subFoldersFoundLabel.Size = new System.Drawing.Size(93, 13);
            this.subFoldersFoundLabel.TabIndex = 18;
            this.subFoldersFoundLabel.Text = "SubFolders Found";
            // 
            // filesFoundTextBox
            // 
            this.filesFoundTextBox.Location = new System.Drawing.Point(114, 337);
            this.filesFoundTextBox.Name = "filesFoundTextBox";
            this.filesFoundTextBox.Size = new System.Drawing.Size(100, 20);
            this.filesFoundTextBox.TabIndex = 21;
            // 
            // filesFoundLabel
            // 
            this.filesFoundLabel.AutoSize = true;
            this.filesFoundLabel.Location = new System.Drawing.Point(3, 340);
            this.filesFoundLabel.Name = "filesFoundLabel";
            this.filesFoundLabel.Size = new System.Drawing.Size(61, 13);
            this.filesFoundLabel.TabIndex = 20;
            this.filesFoundLabel.Text = "Files Found";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 483);
            this.Controls.Add(this.filesFoundTextBox);
            this.Controls.Add(this.filesFoundLabel);
            this.Controls.Add(this.foldersFoundTextBox);
            this.Controls.Add(this.subFoldersFoundLabel);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.searchTimeLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.includeSynonymsCheckBox);
            this.Controls.Add(this.searchTermsTextBox);
            this.Controls.Add(this.searchTermsLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.selectedFolderFilesListbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.selectedFolderTextBox);
            this.Controls.Add(this.SelectFolder);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.wordsBindingNavigator);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newWordsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordsBindingNavigator)).EndInit();
            this.wordsBindingNavigator.ResumeLayout(false);
            this.wordsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void selectedFolderTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox deleteWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox addSynonyms;
        private System.Windows.Forms.TextBox addWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox updateSynonyms;
        private System.Windows.Forms.TextBox updateWord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox queryWord;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox querySynonyms;
        private NewWordsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private NewWordsDataSetTableAdapters.WordsTableAdapter wordsTableAdapter;
        private System.Windows.Forms.BindingSource wordsBindingSource;
        private NewWordsDataSet newWordsDataSet;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton wordsBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator wordsBindingNavigator;
        private System.Windows.Forms.ListBox selectedFolderFilesListbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox selectedFolderTextBox;
        private System.Windows.Forms.Button SelectFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label searchTermsLabel;
        private System.Windows.Forms.TextBox searchTermsTextBox;
        private System.Windows.Forms.CheckBox includeSynonymsCheckBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label searchTimeLabel;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.TextBox foldersFoundTextBox;
        private System.Windows.Forms.Label subFoldersFoundLabel;
        private System.Windows.Forms.TextBox filesFoundTextBox;
        private System.Windows.Forms.Label filesFoundLabel;
    }
}

