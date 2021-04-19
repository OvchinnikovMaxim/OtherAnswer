using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace otherSol
{
    public partial class New_question : Form
    {
        Anywhere anywhere = new Anywhere();

        string APPS, TAGS;

        public New_question()
        {
            InitializeComponent();

            tool_add.SetToolTip(btn_new_question, "Напишите вопрос, ответ и проверку(необязательно)." + '\n'
                        + "Выберите приложение" + '\n'
                        + "Выберите тэг (минимум 1).");
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            anywhere.connect(label_connect_table);

            if (anywhere.connection.State == ConnectionState.Open)
            {
                list_app.Items.Clear();
                list_tags.Items.Clear();
                APP();
                Tags();
            }
        }

        private void APP()
        {
            string query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; " +
                        "SELECT name FROM service.dbo._faq_app";

            anywhere.adap_dat(query);

            for (int i = 0; i < anywhere.data.Tables[0].Rows.Count; i++)
                list_app.Items.Add(anywhere.data.Tables[0].Rows[i][0].ToString());
        }

        private void Tags()
        {
            string query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; " +
                        "SELECT name FROM service.dbo._faq_tags";

            anywhere.adap_dat(query);

            for (int i = 0; i < anywhere.data.Tables[0].Rows.Count; i++)
                list_tags.Items.Add(anywhere.data.Tables[0].Rows[i][0].ToString());
        }

        private void check_new_app_CheckedChanged(object sender, EventArgs e)
        {
            panel_new_app.Enabled = panel_new_app.Enabled == false;
        }

        private void check_new_tag_CheckedChanged(object sender, EventArgs e)
        {
            panel_new_tag.Enabled = panel_new_tag.Enabled == false;
        }

        private void btn_new_app_Click(object sender, EventArgs e)
        {
            string new_app = text_new_app.Text;
            new_app.Replace("'", "`");
            new_app = new_app.ToLower();

            string query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; " +
                        "SELECT name FROM service.dbo._faq_app WHERE name ='" + new_app + "'";

            try
            {
                SqlCommand query_sql = new SqlCommand(query, anywhere.connection);

                if (new_app == (string)query_sql.ExecuteScalar())
                    MessageBox.Show("Такая программа уже есть", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    SqlCommand sql_new_app = new SqlCommand("INSERT INTO service.dbo._faq_app (name) VALUES ('" + new_app + "')", anywhere.connection);
                    sql_new_app.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            list_app.Items.Clear();
            APP();
        }

        private void btn_new_tag_Click(object sender, EventArgs e)
        {
            string new_tag = text_new_tag.Text;
            new_tag.Replace("'", "`");
            new_tag = new_tag.ToLower();

            string query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; " +
                        "SELECT name FROM service.dbo._faq_tags WHERE name ='" + new_tag + "'";

            try
            {
                SqlCommand query_sql = new SqlCommand(query, anywhere.connection);

                if (new_tag == (string)query_sql.ExecuteScalar())
                    MessageBox.Show("Такой тэг уже есть", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    SqlCommand sql_new_tag = new SqlCommand("INSERT INTO service.dbo._faq_tags (name) VALUES ('" + new_tag + "')", anywhere.connection);
                    sql_new_tag.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            list_tags.Items.Clear();
            Tags();
        }

        private void list_app_SelectedIndexChanged(object sender, EventArgs e)
        {
            APPS = list_app.SelectedItem.ToString();

            string query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; " +
                        "SELECT caption FROM service.dbo._faq_app WHERE name ='" + APPS + "'";
            try
            {
                SqlCommand query_sql = new SqlCommand(query, anywhere.connection);

                if (String.IsNullOrWhiteSpace(query_sql.ExecuteScalar().ToString()))
                    MessageBox.Show("Нет описания", "Описание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show((string)query_sql.ExecuteScalar(), "Описание");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void list_tags_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> ts = new List<string>();

            foreach (var item in list_tags.SelectedItems)
                ts.Add(item.ToString());

            TAGS = String.Join(", ", ts.ToArray());
        }

        private void btn_check_app_Click(object sender, EventArgs e)
        {
            rich_checkAppTags.Text = String.Format("Программа: {0}; Тэги: {1}.", APPS, TAGS);
        }

        private void btn_new_question_Click(object sender, EventArgs e)
        {
            string question = text_question.Text;
            question.Replace("'", "`");

            string answer = richText_answer.Text;
            answer.Replace("'", "`");

            string t_check = richText_check.Text;
            t_check.Replace("'", "`");

            string add_question = "INSERT INTO service.dbo._faq_questions (app, question, answer, checking) " +
                    "VALUES((SELECT id FROM service.dbo._faq_app WHERE name = '" + APPS + "'), " +
                    "'" + question + "', " +
                    "'" + answer + "', " +
                    "'" + t_check + "')";

            string query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; " +
                        "SELECT name FROM service.dbo._faq_questions WHERE name ='" + question + "'";

            try
            {
                SqlCommand query_sql = new SqlCommand(query, anywhere.connection);

                if (question == (string)query_sql.ExecuteScalar())
                    MessageBox.Show("Такой вопрос уже есть", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    try
                    {
                        var q = String.IsNullOrWhiteSpace(text_question.Text);
                        var a = String.IsNullOrWhiteSpace(richText_answer.Text);
                        var t = list_tags.SelectedItems.Count;

                        if (!q && !a && t != 0)
                        {
                            SqlCommand AddQues = new SqlCommand(add_question, anywhere.connection);
                            AddQues.ExecuteNonQuery();

                            foreach (var item in list_tags.SelectedItems)
                            {
                                string add_tag = "DECLARE @question_id INT;" +
                                    "DECLARE @tag_id INT;" +
                                    "SET @question_id = (SELECT id FROM service.dbo._faq_questions WHERE question = '" + text_question.Text + "');" +
                                    "SET @tag_id = (SELECT id FROM service.dbo._faq_tags WHERE name = '" + item.ToString() + "');" +
                                    "INSERT INTO service.dbo._faq_questions_tags(question_id, tag_id, del) VALUES(@question_id, @tag_id, 0)";

                                SqlCommand AddTs = new SqlCommand(add_tag, anywhere.connection);
                                AddTs.ExecuteNonQuery();
                            }

                            MessageBox.Show("Вопрос добавлен", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Вопрос не добавлен" + '\n'
                                + "Проверьте написан ли вопрос и ответ." + '\n'
                                + "Выбрано ли приложение" + '\n'
                                + "Выбран ли тэг (минимум 1).", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }      
        
    }

}
