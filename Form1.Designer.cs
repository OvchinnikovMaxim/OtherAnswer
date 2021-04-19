
namespace otherSol
{
    partial class Mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.richText_answer = new System.Windows.Forms.RichTextBox();
            this.text_query = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.richText_check = new System.Windows.Forms.RichTextBox();
            this.label_connect_table = new System.Windows.Forms.Label();
            this.btn_connect = new System.Windows.Forms.Button();
            this.combo_app = new System.Windows.Forms.ComboBox();
            this.list_questions = new System.Windows.Forms.ListBox();
            this.label_app = new System.Windows.Forms.Label();
            this.label_tags = new System.Windows.Forms.Label();
            this.label_question = new System.Windows.Forms.Label();
            this.label_answer = new System.Windows.Forms.Label();
            this.label_check = new System.Windows.Forms.Label();
            this.btn_new_question = new System.Windows.Forms.Button();
            this.rich_app_exist = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkedList_tags = new System.Windows.Forms.CheckedListBox();
            this.btn_filtr_tegs = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_edit = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richText_answer
            // 
            this.richText_answer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richText_answer.Location = new System.Drawing.Point(112, 98);
            this.richText_answer.Name = "richText_answer";
            this.richText_answer.ReadOnly = true;
            this.richText_answer.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richText_answer.Size = new System.Drawing.Size(613, 89);
            this.richText_answer.TabIndex = 0;
            this.richText_answer.Text = "";
            // 
            // text_query
            // 
            this.text_query.Location = new System.Drawing.Point(32, 46);
            this.text_query.Name = "text_query";
            this.text_query.Size = new System.Drawing.Size(100, 20);
            this.text_query.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(32, 17);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(100, 23);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Поиск";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // richText_check
            // 
            this.richText_check.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richText_check.Location = new System.Drawing.Point(112, 193);
            this.richText_check.Name = "richText_check";
            this.richText_check.ReadOnly = true;
            this.richText_check.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richText_check.Size = new System.Drawing.Size(613, 186);
            this.richText_check.TabIndex = 3;
            this.richText_check.Text = "";
            // 
            // label_connect_table
            // 
            this.label_connect_table.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_connect_table.AutoSize = true;
            this.label_connect_table.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_connect_table.ForeColor = System.Drawing.Color.Red;
            this.label_connect_table.Location = new System.Drawing.Point(741, 19);
            this.label_connect_table.Name = "label_connect_table";
            this.label_connect_table.Size = new System.Drawing.Size(203, 20);
            this.label_connect_table.TabIndex = 4;
            this.label_connect_table.Text = "service.dbo._faq_questions";
            // 
            // btn_connect
            // 
            this.btn_connect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_connect.Location = new System.Drawing.Point(610, 12);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(125, 34);
            this.btn_connect.TabIndex = 6;
            this.btn_connect.Text = "Подключение";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // combo_app
            // 
            this.combo_app.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_app.FormattingEnabled = true;
            this.combo_app.Location = new System.Drawing.Point(3, 24);
            this.combo_app.Name = "combo_app";
            this.combo_app.Size = new System.Drawing.Size(194, 21);
            this.combo_app.TabIndex = 7;
            this.combo_app.SelectionChangeCommitted += new System.EventHandler(this.combo_app_SelectionChangeCommitted);
            // 
            // list_questions
            // 
            this.list_questions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_questions.FormattingEnabled = true;
            this.list_questions.HorizontalScrollbar = true;
            this.list_questions.Location = new System.Drawing.Point(112, 3);
            this.list_questions.Name = "list_questions";
            this.list_questions.Size = new System.Drawing.Size(613, 89);
            this.list_questions.TabIndex = 9;
            this.list_questions.SelectedIndexChanged += new System.EventHandler(this.list_questions_SelectedIndexChanged);
            // 
            // label_app
            // 
            this.label_app.Location = new System.Drawing.Point(3, 0);
            this.label_app.Name = "label_app";
            this.label_app.Size = new System.Drawing.Size(194, 21);
            this.label_app.TabIndex = 11;
            this.label_app.Text = "Программа";
            this.label_app.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_tags
            // 
            this.label_tags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_tags.Location = new System.Drawing.Point(3, 48);
            this.label_tags.Name = "label_tags";
            this.label_tags.Size = new System.Drawing.Size(194, 23);
            this.label_tags.TabIndex = 13;
            this.label_tags.Text = "Теги";
            this.label_tags.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_question
            // 
            this.label_question.AutoSize = true;
            this.label_question.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_question.Location = new System.Drawing.Point(3, 0);
            this.label_question.Name = "label_question";
            this.label_question.Size = new System.Drawing.Size(103, 95);
            this.label_question.TabIndex = 14;
            this.label_question.Text = "Вопросы";
            this.label_question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_answer
            // 
            this.label_answer.AutoSize = true;
            this.label_answer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_answer.Location = new System.Drawing.Point(3, 95);
            this.label_answer.Name = "label_answer";
            this.label_answer.Size = new System.Drawing.Size(103, 95);
            this.label_answer.TabIndex = 15;
            this.label_answer.Text = "Ответ";
            this.label_answer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_check
            // 
            this.label_check.AutoSize = true;
            this.label_check.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_check.Location = new System.Drawing.Point(3, 190);
            this.label_check.Name = "label_check";
            this.label_check.Size = new System.Drawing.Size(103, 192);
            this.label_check.TabIndex = 16;
            this.label_check.Text = "Проверка";
            this.label_check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_new_question
            // 
            this.btn_new_question.Location = new System.Drawing.Point(158, 12);
            this.btn_new_question.Name = "btn_new_question";
            this.btn_new_question.Size = new System.Drawing.Size(138, 49);
            this.btn_new_question.TabIndex = 17;
            this.btn_new_question.Text = "Добавить вопрос";
            this.btn_new_question.UseVisualStyleBackColor = true;
            this.btn_new_question.Click += new System.EventHandler(this.btn_new_question_Click);
            // 
            // rich_app_exist
            // 
            this.rich_app_exist.Location = new System.Drawing.Point(32, 72);
            this.rich_app_exist.Name = "rich_app_exist";
            this.rich_app_exist.ReadOnly = true;
            this.rich_app_exist.Size = new System.Drawing.Size(100, 44);
            this.rich_app_exist.TabIndex = 19;
            this.rich_app_exist.Text = "в каких приложениях есть";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.label_app);
            this.flowLayoutPanel1.Controls.Add(this.combo_app);
            this.flowLayoutPanel1.Controls.Add(this.label_tags);
            this.flowLayoutPanel1.Controls.Add(this.checkedList_tags);
            this.flowLayoutPanel1.Controls.Add(this.btn_filtr_tegs);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 122);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 316);
            this.flowLayoutPanel1.TabIndex = 22;
            // 
            // checkedList_tags
            // 
            this.checkedList_tags.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedList_tags.CheckOnClick = true;
            this.checkedList_tags.FormattingEnabled = true;
            this.checkedList_tags.Location = new System.Drawing.Point(3, 74);
            this.checkedList_tags.Name = "checkedList_tags";
            this.checkedList_tags.Size = new System.Drawing.Size(194, 199);
            this.checkedList_tags.TabIndex = 0;
            // 
            // btn_filtr_tegs
            // 
            this.btn_filtr_tegs.AutoSize = true;
            this.btn_filtr_tegs.Location = new System.Drawing.Point(3, 279);
            this.btn_filtr_tegs.Name = "btn_filtr_tegs";
            this.btn_filtr_tegs.Size = new System.Drawing.Size(194, 34);
            this.btn_filtr_tegs.TabIndex = 14;
            this.btn_filtr_tegs.Text = "Применить фильтр";
            this.btn_filtr_tegs.UseVisualStyleBackColor = true;
            this.btn_filtr_tegs.Click += new System.EventHandler(this.btn_filtr_tags_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.99312F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.00688F));
            this.tableLayoutPanel1.Controls.Add(this.label_question, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.richText_answer, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.richText_check, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_check, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.list_questions, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_answer, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(219, 67);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(728, 382);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(322, 12);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(116, 49);
            this.btn_edit.TabIndex = 24;
            this.btn_edit.Text = "Редактировать";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(949, 450);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.rich_app_exist);
            this.Controls.Add(this.btn_new_question);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.label_connect_table);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.text_query);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mainform";
            this.Text = "Вопрос - ответ";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richText_answer;
        private System.Windows.Forms.TextBox text_query;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.RichTextBox richText_check;
        private System.Windows.Forms.Label label_connect_table;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.ComboBox combo_app;
        private System.Windows.Forms.ListBox list_questions;
        private System.Windows.Forms.Label label_app;
        private System.Windows.Forms.Label label_tags;
        private System.Windows.Forms.Label label_question;
        private System.Windows.Forms.Label label_answer;
        private System.Windows.Forms.Label label_check;
        private System.Windows.Forms.Button btn_new_question;
        private System.Windows.Forms.RichTextBox rich_app_exist;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_filtr_tegs;
        private System.Windows.Forms.CheckedListBox checkedList_tags;
        private System.Windows.Forms.Button btn_edit;
    }
}

