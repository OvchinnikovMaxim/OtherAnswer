
namespace otherSol
{
    partial class Edit
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_connect = new System.Windows.Forms.Panel();
            this.btn_connect = new System.Windows.Forms.Button();
            this.label_connect_table = new System.Windows.Forms.Label();
            this.table_app = new System.Windows.Forms.TableLayoutPanel();
            this.btn_edit_app = new System.Windows.Forms.Button();
            this.panel_app_name = new System.Windows.Forms.Panel();
            this.text_app_name = new System.Windows.Forms.TextBox();
            this.label_app_name = new System.Windows.Forms.Label();
            this.panel_edit_caption = new System.Windows.Forms.Panel();
            this.text_edit_caption = new System.Windows.Forms.TextBox();
            this.label_edit_caption = new System.Windows.Forms.Label();
            this.panel_sp = new System.Windows.Forms.Panel();
            this.label_sp = new System.Windows.Forms.Label();
            this.combo_app = new System.Windows.Forms.ComboBox();
            this.table_edit_question = new System.Windows.Forms.TableLayoutPanel();
            this.rich_edit_check = new System.Windows.Forms.RichTextBox();
            this.rich_edit_answer = new System.Windows.Forms.RichTextBox();
            this.text_edit_question = new System.Windows.Forms.TextBox();
            this.list_questions = new System.Windows.Forms.ListBox();
            this.label_sp_question = new System.Windows.Forms.Label();
            this.label_edit_ques = new System.Windows.Forms.Label();
            this.label_edit_answer = new System.Windows.Forms.Label();
            this.label_edit_check = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_edit_question = new System.Windows.Forms.Button();
            this.panel_edit_tags = new System.Windows.Forms.Panel();
            this.label_tags = new System.Windows.Forms.Label();
            this.panel_edit_app = new System.Windows.Forms.Panel();
            this.label_app = new System.Windows.Forms.Label();
            this.list_edit_app = new System.Windows.Forms.ListBox();
            this.list_edit_tags = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_connect.SuspendLayout();
            this.table_app.SuspendLayout();
            this.panel_app_name.SuspendLayout();
            this.panel_edit_caption.SuspendLayout();
            this.panel_sp.SuspendLayout();
            this.table_edit_question.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel_edit_tags.SuspendLayout();
            this.panel_edit_app.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 217F));
            this.tableLayoutPanel1.Controls.Add(this.panel_connect, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.table_app, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.table_edit_question, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.94828F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.05173F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(886, 464);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel_connect
            // 
            this.panel_connect.Controls.Add(this.btn_connect);
            this.panel_connect.Controls.Add(this.label_connect_table);
            this.panel_connect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_connect.Location = new System.Drawing.Point(672, 3);
            this.panel_connect.Name = "panel_connect";
            this.panel_connect.Size = new System.Drawing.Size(211, 68);
            this.panel_connect.TabIndex = 0;
            // 
            // btn_connect
            // 
            this.btn_connect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_connect.Location = new System.Drawing.Point(0, 34);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(211, 34);
            this.btn_connect.TabIndex = 9;
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
            this.label_connect_table.Location = new System.Drawing.Point(3, 6);
            this.label_connect_table.Name = "label_connect_table";
            this.label_connect_table.Size = new System.Drawing.Size(205, 25);
            this.label_connect_table.TabIndex = 8;
            this.label_connect_table.Text = "service.dbo._faq_questions";
            this.label_connect_table.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // table_app
            // 
            this.table_app.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.table_app.ColumnCount = 4;
            this.table_app.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.table_app.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.table_app.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.table_app.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.table_app.Controls.Add(this.btn_edit_app, 3, 0);
            this.table_app.Controls.Add(this.panel_app_name, 1, 0);
            this.table_app.Controls.Add(this.panel_edit_caption, 2, 0);
            this.table_app.Controls.Add(this.panel_sp, 0, 0);
            this.table_app.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_app.Location = new System.Drawing.Point(3, 3);
            this.table_app.Name = "table_app";
            this.table_app.RowCount = 1;
            this.table_app.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_app.Size = new System.Drawing.Size(663, 68);
            this.table_app.TabIndex = 1;
            // 
            // btn_edit_app
            // 
            this.btn_edit_app.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_edit_app.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_edit_app.Location = new System.Drawing.Point(542, 4);
            this.btn_edit_app.Name = "btn_edit_app";
            this.btn_edit_app.Size = new System.Drawing.Size(117, 60);
            this.btn_edit_app.TabIndex = 0;
            this.btn_edit_app.Text = "Изменить";
            this.btn_edit_app.UseVisualStyleBackColor = true;
            this.btn_edit_app.Click += new System.EventHandler(this.btn_edit_app_Click);
            // 
            // panel_app_name
            // 
            this.panel_app_name.Controls.Add(this.text_app_name);
            this.panel_app_name.Controls.Add(this.label_app_name);
            this.panel_app_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_app_name.Location = new System.Drawing.Point(125, 4);
            this.panel_app_name.Name = "panel_app_name";
            this.panel_app_name.Size = new System.Drawing.Size(160, 60);
            this.panel_app_name.TabIndex = 2;
            // 
            // text_app_name
            // 
            this.text_app_name.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.text_app_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_app_name.Location = new System.Drawing.Point(0, 37);
            this.text_app_name.Name = "text_app_name";
            this.text_app_name.Size = new System.Drawing.Size(160, 23);
            this.text_app_name.TabIndex = 1;
            // 
            // label_app_name
            // 
            this.label_app_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_app_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_app_name.Location = new System.Drawing.Point(0, 0);
            this.label_app_name.Name = "label_app_name";
            this.label_app_name.Size = new System.Drawing.Size(160, 35);
            this.label_app_name.TabIndex = 0;
            this.label_app_name.Text = "Название приложения";
            this.label_app_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_edit_caption
            // 
            this.panel_edit_caption.Controls.Add(this.text_edit_caption);
            this.panel_edit_caption.Controls.Add(this.label_edit_caption);
            this.panel_edit_caption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_edit_caption.Location = new System.Drawing.Point(292, 4);
            this.panel_edit_caption.Name = "panel_edit_caption";
            this.panel_edit_caption.Size = new System.Drawing.Size(243, 60);
            this.panel_edit_caption.TabIndex = 3;
            // 
            // text_edit_caption
            // 
            this.text_edit_caption.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.text_edit_caption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_edit_caption.Location = new System.Drawing.Point(0, 37);
            this.text_edit_caption.Name = "text_edit_caption";
            this.text_edit_caption.Size = new System.Drawing.Size(243, 23);
            this.text_edit_caption.TabIndex = 1;
            // 
            // label_edit_caption
            // 
            this.label_edit_caption.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_edit_caption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_edit_caption.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_edit_caption.Location = new System.Drawing.Point(0, 0);
            this.label_edit_caption.Name = "label_edit_caption";
            this.label_edit_caption.Size = new System.Drawing.Size(243, 35);
            this.label_edit_caption.TabIndex = 0;
            this.label_edit_caption.Text = "Описание приложения";
            this.label_edit_caption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_sp
            // 
            this.panel_sp.Controls.Add(this.label_sp);
            this.panel_sp.Controls.Add(this.combo_app);
            this.panel_sp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_sp.Location = new System.Drawing.Point(4, 4);
            this.panel_sp.Name = "panel_sp";
            this.panel_sp.Size = new System.Drawing.Size(114, 60);
            this.panel_sp.TabIndex = 4;
            // 
            // label_sp
            // 
            this.label_sp.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_sp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_sp.Location = new System.Drawing.Point(0, 0);
            this.label_sp.Name = "label_sp";
            this.label_sp.Size = new System.Drawing.Size(114, 35);
            this.label_sp.TabIndex = 2;
            this.label_sp.Text = "Список приложений";
            this.label_sp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // combo_app
            // 
            this.combo_app.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.combo_app.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.combo_app.FormattingEnabled = true;
            this.combo_app.Location = new System.Drawing.Point(0, 36);
            this.combo_app.Name = "combo_app";
            this.combo_app.Size = new System.Drawing.Size(114, 24);
            this.combo_app.TabIndex = 1;
            this.combo_app.SelectionChangeCommitted += new System.EventHandler(this.combo_app_SelectionChangeCommitted);
            // 
            // table_edit_question
            // 
            this.table_edit_question.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.table_edit_question.ColumnCount = 2;
            this.table_edit_question.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.table_edit_question.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.table_edit_question.Controls.Add(this.rich_edit_check, 1, 3);
            this.table_edit_question.Controls.Add(this.rich_edit_answer, 1, 2);
            this.table_edit_question.Controls.Add(this.text_edit_question, 1, 1);
            this.table_edit_question.Controls.Add(this.list_questions, 1, 0);
            this.table_edit_question.Controls.Add(this.label_sp_question, 0, 0);
            this.table_edit_question.Controls.Add(this.label_edit_ques, 0, 1);
            this.table_edit_question.Controls.Add(this.label_edit_answer, 0, 2);
            this.table_edit_question.Controls.Add(this.label_edit_check, 0, 3);
            this.table_edit_question.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_edit_question.Location = new System.Drawing.Point(3, 77);
            this.table_edit_question.Name = "table_edit_question";
            this.table_edit_question.RowCount = 4;
            this.table_edit_question.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.table_edit_question.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.table_edit_question.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.table_edit_question.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.table_edit_question.Size = new System.Drawing.Size(663, 384);
            this.table_edit_question.TabIndex = 2;
            // 
            // rich_edit_check
            // 
            this.rich_edit_check.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rich_edit_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rich_edit_check.Location = new System.Drawing.Point(125, 209);
            this.rich_edit_check.Name = "rich_edit_check";
            this.rich_edit_check.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rich_edit_check.Size = new System.Drawing.Size(537, 171);
            this.rich_edit_check.TabIndex = 24;
            this.rich_edit_check.Text = "";
            // 
            // rich_edit_answer
            // 
            this.rich_edit_answer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rich_edit_answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rich_edit_answer.Location = new System.Drawing.Point(125, 133);
            this.rich_edit_answer.Name = "rich_edit_answer";
            this.rich_edit_answer.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rich_edit_answer.Size = new System.Drawing.Size(537, 69);
            this.rich_edit_answer.TabIndex = 23;
            this.rich_edit_answer.Text = "";
            // 
            // text_edit_question
            // 
            this.text_edit_question.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text_edit_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_edit_question.Location = new System.Drawing.Point(125, 100);
            this.text_edit_question.Name = "text_edit_question";
            this.text_edit_question.Size = new System.Drawing.Size(537, 26);
            this.text_edit_question.TabIndex = 22;
            // 
            // list_questions
            // 
            this.list_questions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_questions.FormattingEnabled = true;
            this.list_questions.HorizontalScrollbar = true;
            this.list_questions.Location = new System.Drawing.Point(125, 4);
            this.list_questions.Name = "list_questions";
            this.list_questions.Size = new System.Drawing.Size(537, 89);
            this.list_questions.TabIndex = 10;
            this.list_questions.SelectedIndexChanged += new System.EventHandler(this.list_questions_SelectedIndexChanged);
            // 
            // label_sp_question
            // 
            this.label_sp_question.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_sp_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_sp_question.Location = new System.Drawing.Point(4, 1);
            this.label_sp_question.Name = "label_sp_question";
            this.label_sp_question.Size = new System.Drawing.Size(114, 95);
            this.label_sp_question.TabIndex = 0;
            this.label_sp_question.Text = "Список вопросов";
            this.label_sp_question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_edit_ques
            // 
            this.label_edit_ques.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_edit_ques.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_edit_ques.Location = new System.Drawing.Point(4, 97);
            this.label_edit_ques.Name = "label_edit_ques";
            this.label_edit_ques.Size = new System.Drawing.Size(114, 32);
            this.label_edit_ques.TabIndex = 1;
            this.label_edit_ques.Text = "Редактировать вопрос";
            this.label_edit_ques.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_edit_answer
            // 
            this.label_edit_answer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_edit_answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_edit_answer.Location = new System.Drawing.Point(4, 130);
            this.label_edit_answer.Name = "label_edit_answer";
            this.label_edit_answer.Size = new System.Drawing.Size(114, 75);
            this.label_edit_answer.TabIndex = 2;
            this.label_edit_answer.Text = "Редактировать ответ";
            this.label_edit_answer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_edit_check
            // 
            this.label_edit_check.AutoSize = true;
            this.label_edit_check.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_edit_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_edit_check.Location = new System.Drawing.Point(4, 206);
            this.label_edit_check.Name = "label_edit_check";
            this.label_edit_check.Size = new System.Drawing.Size(114, 177);
            this.label_edit_check.TabIndex = 3;
            this.label_edit_check.Text = "Редактировать проверку";
            this.label_edit_check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btn_edit_question, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel_edit_tags, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel_edit_app, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(672, 77);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(211, 384);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // btn_edit_question
            // 
            this.btn_edit_question.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_edit_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_edit_question.Location = new System.Drawing.Point(4, 318);
            this.btn_edit_question.Name = "btn_edit_question";
            this.btn_edit_question.Size = new System.Drawing.Size(203, 62);
            this.btn_edit_question.TabIndex = 0;
            this.btn_edit_question.Text = "Сохранить изменения";
            this.btn_edit_question.UseVisualStyleBackColor = true;
            this.btn_edit_question.Click += new System.EventHandler(this.btn_edit_question_Click);
            // 
            // panel_edit_tags
            // 
            this.panel_edit_tags.Controls.Add(this.list_edit_tags);
            this.panel_edit_tags.Controls.Add(this.label_tags);
            this.panel_edit_tags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_edit_tags.Location = new System.Drawing.Point(4, 98);
            this.panel_edit_tags.Name = "panel_edit_tags";
            this.panel_edit_tags.Size = new System.Drawing.Size(203, 213);
            this.panel_edit_tags.TabIndex = 1;
            // 
            // label_tags
            // 
            this.label_tags.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_tags.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_tags.Location = new System.Drawing.Point(0, 0);
            this.label_tags.Name = "label_tags";
            this.label_tags.Size = new System.Drawing.Size(203, 27);
            this.label_tags.TabIndex = 0;
            this.label_tags.Text = "Теги";
            this.label_tags.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_edit_app
            // 
            this.panel_edit_app.Controls.Add(this.list_edit_app);
            this.panel_edit_app.Controls.Add(this.label_app);
            this.panel_edit_app.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_edit_app.Location = new System.Drawing.Point(4, 4);
            this.panel_edit_app.Name = "panel_edit_app";
            this.panel_edit_app.Size = new System.Drawing.Size(203, 87);
            this.panel_edit_app.TabIndex = 2;
            // 
            // label_app
            // 
            this.label_app.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_app.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_app.Location = new System.Drawing.Point(0, 0);
            this.label_app.Name = "label_app";
            this.label_app.Size = new System.Drawing.Size(203, 23);
            this.label_app.TabIndex = 0;
            this.label_app.Text = "Приложение";
            this.label_app.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // list_edit_app
            // 
            this.list_edit_app.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_edit_app.FormattingEnabled = true;
            this.list_edit_app.HorizontalScrollbar = true;
            this.list_edit_app.Location = new System.Drawing.Point(0, 23);
            this.list_edit_app.MultiColumn = true;
            this.list_edit_app.Name = "list_edit_app";
            this.list_edit_app.Size = new System.Drawing.Size(203, 64);
            this.list_edit_app.TabIndex = 1;
            // 
            // list_edit_tags
            // 
            this.list_edit_tags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_edit_tags.FormattingEnabled = true;
            this.list_edit_tags.Location = new System.Drawing.Point(0, 27);
            this.list_edit_tags.Name = "list_edit_tags";
            this.list_edit_tags.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.list_edit_tags.Size = new System.Drawing.Size(203, 186);
            this.list_edit_tags.TabIndex = 1;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 464);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Edit";
            this.Text = "Редактирование";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel_connect.ResumeLayout(false);
            this.table_app.ResumeLayout(false);
            this.panel_app_name.ResumeLayout(false);
            this.panel_app_name.PerformLayout();
            this.panel_edit_caption.ResumeLayout(false);
            this.panel_edit_caption.PerformLayout();
            this.panel_sp.ResumeLayout(false);
            this.table_edit_question.ResumeLayout(false);
            this.table_edit_question.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel_edit_tags.ResumeLayout(false);
            this.panel_edit_app.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel_connect;
        private System.Windows.Forms.Label label_connect_table;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.TableLayoutPanel table_app;
        private System.Windows.Forms.Button btn_edit_app;
        private System.Windows.Forms.ComboBox combo_app;
        private System.Windows.Forms.Panel panel_app_name;
        private System.Windows.Forms.TextBox text_app_name;
        private System.Windows.Forms.Label label_app_name;
        private System.Windows.Forms.Panel panel_edit_caption;
        private System.Windows.Forms.TextBox text_edit_caption;
        private System.Windows.Forms.Label label_edit_caption;
        private System.Windows.Forms.Panel panel_sp;
        private System.Windows.Forms.Label label_sp;
        private System.Windows.Forms.TableLayoutPanel table_edit_question;
        private System.Windows.Forms.Label label_sp_question;
        private System.Windows.Forms.Label label_edit_ques;
        private System.Windows.Forms.Label label_edit_answer;
        private System.Windows.Forms.Label label_edit_check;
        private System.Windows.Forms.ListBox list_questions;
        private System.Windows.Forms.TextBox text_edit_question;
        private System.Windows.Forms.RichTextBox rich_edit_answer;
        private System.Windows.Forms.RichTextBox rich_edit_check;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_edit_question;
        private System.Windows.Forms.Panel panel_edit_tags;
        private System.Windows.Forms.Label label_tags;
        private System.Windows.Forms.Panel panel_edit_app;
        private System.Windows.Forms.Label label_app;
        private System.Windows.Forms.ListBox list_edit_app;
        private System.Windows.Forms.ListBox list_edit_tags;
    }
}