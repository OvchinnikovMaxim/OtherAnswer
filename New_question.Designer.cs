
namespace otherSol
{
    partial class New_question
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_connect = new System.Windows.Forms.Panel();
            this.btn_connect = new System.Windows.Forms.Button();
            this.label_connect_table = new System.Windows.Forms.Label();
            this.panel_app = new System.Windows.Forms.Panel();
            this.panel_new_app = new System.Windows.Forms.Panel();
            this.text_new_app = new System.Windows.Forms.TextBox();
            this.btn_new_app = new System.Windows.Forms.Button();
            this.check_new_app = new System.Windows.Forms.CheckBox();
            this.list_app = new System.Windows.Forms.ListBox();
            this.panel_tags = new System.Windows.Forms.Panel();
            this.check_new_tag = new System.Windows.Forms.CheckBox();
            this.panel_new_tag = new System.Windows.Forms.Panel();
            this.text_new_tag = new System.Windows.Forms.TextBox();
            this.btn_new_tag = new System.Windows.Forms.Button();
            this.list_tags = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label_question = new System.Windows.Forms.Label();
            this.label_answer = new System.Windows.Forms.Label();
            this.label_check = new System.Windows.Forms.Label();
            this.btn_new_question = new System.Windows.Forms.Button();
            this.richText_answer = new System.Windows.Forms.RichTextBox();
            this.richText_check = new System.Windows.Forms.RichTextBox();
            this.text_question = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rich_checkAppTags = new System.Windows.Forms.RichTextBox();
            this.btn_check_app = new System.Windows.Forms.Button();
            this.tool_add = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_connect.SuspendLayout();
            this.panel_app.SuspendLayout();
            this.panel_new_app.SuspendLayout();
            this.panel_tags.SuspendLayout();
            this.panel_new_tag.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 217F));
            this.tableLayoutPanel1.Controls.Add(this.panel_connect, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_app, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_tags, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(924, 502);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel_connect
            // 
            this.panel_connect.Controls.Add(this.btn_connect);
            this.panel_connect.Controls.Add(this.label_connect_table);
            this.panel_connect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_connect.Location = new System.Drawing.Point(710, 3);
            this.panel_connect.Name = "panel_connect";
            this.panel_connect.Size = new System.Drawing.Size(211, 64);
            this.panel_connect.TabIndex = 0;
            // 
            // btn_connect
            // 
            this.btn_connect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_connect.Location = new System.Drawing.Point(0, 30);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(211, 34);
            this.btn_connect.TabIndex = 8;
            this.btn_connect.Text = "Подключение";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // label_connect_table
            // 
            this.label_connect_table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_connect_table.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_connect_table.ForeColor = System.Drawing.Color.Red;
            this.label_connect_table.Location = new System.Drawing.Point(3, 0);
            this.label_connect_table.Name = "label_connect_table";
            this.label_connect_table.Size = new System.Drawing.Size(203, 27);
            this.label_connect_table.TabIndex = 7;
            this.label_connect_table.Text = "service.dbo._faq_questions";
            this.label_connect_table.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_app
            // 
            this.panel_app.Controls.Add(this.panel_new_app);
            this.panel_app.Controls.Add(this.check_new_app);
            this.panel_app.Controls.Add(this.list_app);
            this.panel_app.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_app.Location = new System.Drawing.Point(3, 3);
            this.panel_app.Name = "panel_app";
            this.panel_app.Size = new System.Drawing.Size(701, 64);
            this.panel_app.TabIndex = 1;
            // 
            // panel_new_app
            // 
            this.panel_new_app.Controls.Add(this.text_new_app);
            this.panel_new_app.Controls.Add(this.btn_new_app);
            this.panel_new_app.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_new_app.Enabled = false;
            this.panel_new_app.Location = new System.Drawing.Point(449, 0);
            this.panel_new_app.Name = "panel_new_app";
            this.panel_new_app.Size = new System.Drawing.Size(252, 64);
            this.panel_new_app.TabIndex = 4;
            // 
            // text_new_app
            // 
            this.text_new_app.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_new_app.Location = new System.Drawing.Point(96, 11);
            this.text_new_app.Name = "text_new_app";
            this.text_new_app.Size = new System.Drawing.Size(153, 29);
            this.text_new_app.TabIndex = 3;
            // 
            // btn_new_app
            // 
            this.btn_new_app.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_new_app.Location = new System.Drawing.Point(3, 3);
            this.btn_new_app.Name = "btn_new_app";
            this.btn_new_app.Size = new System.Drawing.Size(87, 51);
            this.btn_new_app.TabIndex = 2;
            this.btn_new_app.Text = "Новая программа";
            this.btn_new_app.UseVisualStyleBackColor = true;
            this.btn_new_app.Click += new System.EventHandler(this.btn_new_app_Click);
            // 
            // check_new_app
            // 
            this.check_new_app.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.check_new_app.AutoSize = true;
            this.check_new_app.Location = new System.Drawing.Point(428, 3);
            this.check_new_app.Name = "check_new_app";
            this.check_new_app.Size = new System.Drawing.Size(15, 14);
            this.check_new_app.TabIndex = 1;
            this.check_new_app.UseVisualStyleBackColor = true;
            this.check_new_app.CheckedChanged += new System.EventHandler(this.check_new_app_CheckedChanged);
            // 
            // list_app
            // 
            this.list_app.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_app.FormattingEnabled = true;
            this.list_app.HorizontalScrollbar = true;
            this.list_app.Location = new System.Drawing.Point(3, 3);
            this.list_app.MultiColumn = true;
            this.list_app.Name = "list_app";
            this.list_app.Size = new System.Drawing.Size(419, 56);
            this.list_app.TabIndex = 0;
            this.list_app.SelectedIndexChanged += new System.EventHandler(this.list_app_SelectedIndexChanged);
            // 
            // panel_tags
            // 
            this.panel_tags.Controls.Add(this.check_new_tag);
            this.panel_tags.Controls.Add(this.panel_new_tag);
            this.panel_tags.Controls.Add(this.list_tags);
            this.panel_tags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_tags.Location = new System.Drawing.Point(710, 73);
            this.panel_tags.Name = "panel_tags";
            this.panel_tags.Size = new System.Drawing.Size(211, 426);
            this.panel_tags.TabIndex = 2;
            // 
            // check_new_tag
            // 
            this.check_new_tag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.check_new_tag.AutoSize = true;
            this.check_new_tag.Location = new System.Drawing.Point(3, 334);
            this.check_new_tag.Name = "check_new_tag";
            this.check_new_tag.Size = new System.Drawing.Size(15, 14);
            this.check_new_tag.TabIndex = 2;
            this.check_new_tag.UseVisualStyleBackColor = true;
            this.check_new_tag.CheckedChanged += new System.EventHandler(this.check_new_tag_CheckedChanged);
            // 
            // panel_new_tag
            // 
            this.panel_new_tag.Controls.Add(this.text_new_tag);
            this.panel_new_tag.Controls.Add(this.btn_new_tag);
            this.panel_new_tag.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_new_tag.Enabled = false;
            this.panel_new_tag.Location = new System.Drawing.Point(0, 354);
            this.panel_new_tag.Name = "panel_new_tag";
            this.panel_new_tag.Size = new System.Drawing.Size(211, 72);
            this.panel_new_tag.TabIndex = 1;
            // 
            // text_new_tag
            // 
            this.text_new_tag.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.text_new_tag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_new_tag.Location = new System.Drawing.Point(0, 43);
            this.text_new_tag.Name = "text_new_tag";
            this.text_new_tag.Size = new System.Drawing.Size(211, 29);
            this.text_new_tag.TabIndex = 1;
            // 
            // btn_new_tag
            // 
            this.btn_new_tag.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_new_tag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_new_tag.Location = new System.Drawing.Point(0, 0);
            this.btn_new_tag.Name = "btn_new_tag";
            this.btn_new_tag.Size = new System.Drawing.Size(211, 43);
            this.btn_new_tag.TabIndex = 0;
            this.btn_new_tag.Text = "Новый тэг";
            this.btn_new_tag.UseVisualStyleBackColor = true;
            this.btn_new_tag.Click += new System.EventHandler(this.btn_new_tag_Click);
            // 
            // list_tags
            // 
            this.list_tags.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_tags.FormattingEnabled = true;
            this.list_tags.Location = new System.Drawing.Point(0, 3);
            this.list_tags.Name = "list_tags";
            this.list_tags.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.list_tags.Size = new System.Drawing.Size(211, 329);
            this.list_tags.TabIndex = 0;
            this.list_tags.SelectedIndexChanged += new System.EventHandler(this.list_tags_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel2.Controls.Add(this.label_question, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label_answer, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label_check, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn_new_question, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.richText_answer, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.richText_check, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.text_question, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 73);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(701, 426);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // label_question
            // 
            this.label_question.AutoSize = true;
            this.label_question.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_question.Location = new System.Drawing.Point(3, 0);
            this.label_question.Name = "label_question";
            this.label_question.Size = new System.Drawing.Size(99, 30);
            this.label_question.TabIndex = 15;
            this.label_question.Text = "Вопрос";
            this.label_question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_answer
            // 
            this.label_answer.AutoSize = true;
            this.label_answer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_answer.Location = new System.Drawing.Point(3, 30);
            this.label_answer.Name = "label_answer";
            this.label_answer.Size = new System.Drawing.Size(99, 103);
            this.label_answer.TabIndex = 16;
            this.label_answer.Text = "Ответ";
            this.label_answer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_check
            // 
            this.label_check.AutoSize = true;
            this.label_check.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_check.Location = new System.Drawing.Point(3, 133);
            this.label_check.Name = "label_check";
            this.label_check.Size = new System.Drawing.Size(99, 242);
            this.label_check.TabIndex = 17;
            this.label_check.Text = "Проверка";
            this.label_check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_new_question
            // 
            this.btn_new_question.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_new_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_new_question.Location = new System.Drawing.Point(3, 378);
            this.btn_new_question.Name = "btn_new_question";
            this.btn_new_question.Size = new System.Drawing.Size(99, 45);
            this.btn_new_question.TabIndex = 18;
            this.btn_new_question.Text = "Добавить вопрос";
            this.btn_new_question.UseVisualStyleBackColor = true;
            this.btn_new_question.Click += new System.EventHandler(this.btn_new_question_Click);
            // 
            // richText_answer
            // 
            this.richText_answer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richText_answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richText_answer.Location = new System.Drawing.Point(108, 33);
            this.richText_answer.Name = "richText_answer";
            this.richText_answer.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richText_answer.Size = new System.Drawing.Size(590, 97);
            this.richText_answer.TabIndex = 19;
            this.richText_answer.Text = "";
            // 
            // richText_check
            // 
            this.richText_check.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richText_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richText_check.Location = new System.Drawing.Point(108, 136);
            this.richText_check.Name = "richText_check";
            this.richText_check.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richText_check.Size = new System.Drawing.Size(590, 236);
            this.richText_check.TabIndex = 20;
            this.richText_check.Text = "";
            // 
            // text_question
            // 
            this.text_question.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_question.Location = new System.Drawing.Point(108, 3);
            this.text_question.Name = "text_question";
            this.text_question.Size = new System.Drawing.Size(590, 26);
            this.text_question.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rich_checkAppTags);
            this.panel1.Controls.Add(this.btn_check_app);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(108, 378);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 45);
            this.panel1.TabIndex = 22;
            // 
            // rich_checkAppTags
            // 
            this.rich_checkAppTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rich_checkAppTags.Location = new System.Drawing.Point(165, 0);
            this.rich_checkAppTags.Name = "rich_checkAppTags";
            this.rich_checkAppTags.ReadOnly = true;
            this.rich_checkAppTags.Size = new System.Drawing.Size(425, 45);
            this.rich_checkAppTags.TabIndex = 2;
            this.rich_checkAppTags.Text = "";
            // 
            // btn_check_app
            // 
            this.btn_check_app.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_check_app.Location = new System.Drawing.Point(0, 0);
            this.btn_check_app.Name = "btn_check_app";
            this.btn_check_app.Size = new System.Drawing.Size(165, 45);
            this.btn_check_app.TabIndex = 1;
            this.btn_check_app.Text = "Проверка приложения и тэгов";
            this.btn_check_app.UseVisualStyleBackColor = true;
            this.btn_check_app.Click += new System.EventHandler(this.btn_check_app_Click);
            // 
            // New_question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 502);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "New_question";
            this.Text = "Новый вопрос";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel_connect.ResumeLayout(false);
            this.panel_app.ResumeLayout(false);
            this.panel_app.PerformLayout();
            this.panel_new_app.ResumeLayout(false);
            this.panel_new_app.PerformLayout();
            this.panel_tags.ResumeLayout(false);
            this.panel_tags.PerformLayout();
            this.panel_new_tag.ResumeLayout(false);
            this.panel_new_tag.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel_connect;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label label_connect_table;
        private System.Windows.Forms.Panel panel_app;
        private System.Windows.Forms.TextBox text_new_app;
        private System.Windows.Forms.Button btn_new_app;
        private System.Windows.Forms.CheckBox check_new_app;
        private System.Windows.Forms.ListBox list_app;
        private System.Windows.Forms.Panel panel_tags;
        private System.Windows.Forms.Panel panel_new_app;
        private System.Windows.Forms.Panel panel_new_tag;
        private System.Windows.Forms.ListBox list_tags;
        private System.Windows.Forms.CheckBox check_new_tag;
        private System.Windows.Forms.TextBox text_new_tag;
        private System.Windows.Forms.Button btn_new_tag;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label_question;
        private System.Windows.Forms.Label label_answer;
        private System.Windows.Forms.Label label_check;
        private System.Windows.Forms.Button btn_new_question;
        private System.Windows.Forms.RichTextBox richText_answer;
        private System.Windows.Forms.RichTextBox richText_check;
        private System.Windows.Forms.TextBox text_question;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_check_app;
        private System.Windows.Forms.RichTextBox rich_checkAppTags;
        private System.Windows.Forms.ToolTip tool_add;
    }
}