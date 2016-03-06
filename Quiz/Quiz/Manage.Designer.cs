namespace Quiz
{
    partial class Manage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage));
            this.quizDataSet = new Quiz.QuizDataSet();
            this.examineeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examineeTableAdapter = new Quiz.QuizDataSetTableAdapters.ExamineeTableAdapter();
            this.tableAdapterManager = new Quiz.QuizDataSetTableAdapters.TableAdapterManager();
            this.examineeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.examineeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.examineeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.quizBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quizTableAdapter = new Quiz.QuizDataSetTableAdapters.QuizTableAdapter();
            this.quizDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.questionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questionTableAdapter = new Quiz.QuizDataSetTableAdapters.QuestionTableAdapter();
            this.questionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.qptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qptionTableAdapter = new Quiz.QuizDataSetTableAdapters.QptionTableAdapter();
            this.qptionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examineeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examineeBindingNavigator)).BeginInit();
            this.examineeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examineeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qptionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // quizDataSet
            // 
            this.quizDataSet.DataSetName = "QuizDataSet";
            this.quizDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // examineeBindingSource
            // 
            this.examineeBindingSource.DataMember = "Examinee";
            this.examineeBindingSource.DataSource = this.quizDataSet;
            // 
            // examineeTableAdapter
            // 
            this.examineeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ExamineeTableAdapter = this.examineeTableAdapter;
            this.tableAdapterManager.QptionTableAdapter = this.qptionTableAdapter;
            this.tableAdapterManager.QuestionTableAdapter = this.questionTableAdapter;
            this.tableAdapterManager.QuizTableAdapter = this.quizTableAdapter;
            this.tableAdapterManager.UpdateOrder = Quiz.QuizDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // examineeBindingNavigator
            // 
            this.examineeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.examineeBindingNavigator.BindingSource = this.examineeBindingSource;
            this.examineeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.examineeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.examineeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.examineeBindingNavigatorSaveItem});
            this.examineeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.examineeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.examineeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.examineeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.examineeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.examineeBindingNavigator.Name = "examineeBindingNavigator";
            this.examineeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.examineeBindingNavigator.Size = new System.Drawing.Size(891, 25);
            this.examineeBindingNavigator.TabIndex = 0;
            this.examineeBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // examineeBindingNavigatorSaveItem
            // 
            this.examineeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.examineeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("examineeBindingNavigatorSaveItem.Image")));
            this.examineeBindingNavigatorSaveItem.Name = "examineeBindingNavigatorSaveItem";
            this.examineeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.examineeBindingNavigatorSaveItem.Text = "Save Data";
            this.examineeBindingNavigatorSaveItem.Click += new System.EventHandler(this.examineeBindingNavigatorSaveItem_Click);
            // 
            // examineeDataGridView
            // 
            this.examineeDataGridView.AutoGenerateColumns = false;
            this.examineeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.examineeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.examineeDataGridView.DataSource = this.examineeBindingSource;
            this.examineeDataGridView.Location = new System.Drawing.Point(12, 49);
            this.examineeDataGridView.Name = "examineeDataGridView";
            this.examineeDataGridView.Size = new System.Drawing.Size(259, 191);
            this.examineeDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Examinee";
            // 
            // quizBindingSource
            // 
            this.quizBindingSource.DataMember = "Quiz";
            this.quizBindingSource.DataSource = this.quizDataSet;
            // 
            // quizTableAdapter
            // 
            this.quizTableAdapter.ClearBeforeFill = true;
            // 
            // quizDataGridView
            // 
            this.quizDataGridView.AutoGenerateColumns = false;
            this.quizDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quizDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.quizDataGridView.DataSource = this.quizBindingSource;
            this.quizDataGridView.Location = new System.Drawing.Point(277, 49);
            this.quizDataGridView.Name = "quizDataGridView";
            this.quizDataGridView.Size = new System.Drawing.Size(586, 191);
            this.quizDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn3.HeaderText = "Id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Score";
            this.dataGridViewTextBoxColumn4.HeaderText = "Score";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn5.HeaderText = "Date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn6.HeaderText = "Name";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quiz";
            // 
            // questionBindingSource
            // 
            this.questionBindingSource.DataMember = "Question";
            this.questionBindingSource.DataSource = this.quizDataSet;
            // 
            // questionTableAdapter
            // 
            this.questionTableAdapter.ClearBeforeFill = true;
            // 
            // questionDataGridView
            // 
            this.questionDataGridView.AutoGenerateColumns = false;
            this.questionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.questionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.questionDataGridView.DataSource = this.questionBindingSource;
            this.questionDataGridView.Location = new System.Drawing.Point(12, 272);
            this.questionDataGridView.Name = "questionDataGridView";
            this.questionDataGridView.Size = new System.Drawing.Size(382, 191);
            this.questionDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn7.HeaderText = "Id";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Text";
            this.dataGridViewTextBoxColumn8.HeaderText = "Text";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "QuizId";
            this.dataGridViewTextBoxColumn9.HeaderText = "QuizId";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Question";
            // 
            // qptionBindingSource
            // 
            this.qptionBindingSource.DataMember = "Qption";
            this.qptionBindingSource.DataSource = this.quizDataSet;
            // 
            // qptionTableAdapter
            // 
            this.qptionTableAdapter.ClearBeforeFill = true;
            // 
            // qptionDataGridView
            // 
            this.qptionDataGridView.AutoGenerateColumns = false;
            this.qptionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qptionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn12});
            this.qptionDataGridView.DataSource = this.qptionBindingSource;
            this.qptionDataGridView.Location = new System.Drawing.Point(400, 272);
            this.qptionDataGridView.Name = "qptionDataGridView";
            this.qptionDataGridView.Size = new System.Drawing.Size(463, 191);
            this.qptionDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn10.HeaderText = "Id";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Text";
            this.dataGridViewTextBoxColumn11.HeaderText = "Text";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "CorrectAnswer";
            this.dataGridViewCheckBoxColumn1.HeaderText = "CorrectAnswer";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "QuestionId";
            this.dataGridViewTextBoxColumn12.HeaderText = "QuestionId";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Option";
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 544);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.qptionDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.questionDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quizDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.examineeDataGridView);
            this.Controls.Add(this.examineeBindingNavigator);
            this.Name = "Manage";
            this.Text = "Manage";
            this.Load += new System.EventHandler(this.Manage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quizDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examineeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examineeBindingNavigator)).EndInit();
            this.examineeBindingNavigator.ResumeLayout(false);
            this.examineeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examineeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qptionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QuizDataSet quizDataSet;
        private System.Windows.Forms.BindingSource examineeBindingSource;
        private QuizDataSetTableAdapters.ExamineeTableAdapter examineeTableAdapter;
        private QuizDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator examineeBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton examineeBindingNavigatorSaveItem;
        private QuizDataSetTableAdapters.QuizTableAdapter quizTableAdapter;
        private System.Windows.Forms.DataGridView examineeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource quizBindingSource;
        private QuizDataSetTableAdapters.QuestionTableAdapter questionTableAdapter;
        private System.Windows.Forms.DataGridView quizDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource questionBindingSource;
        private QuizDataSetTableAdapters.QptionTableAdapter qptionTableAdapter;
        private System.Windows.Forms.DataGridView questionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource qptionBindingSource;
        private System.Windows.Forms.DataGridView qptionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Label label4;
    }
}