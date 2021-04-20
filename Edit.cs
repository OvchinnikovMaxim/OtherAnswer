using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace otherSol
{
    public partial class Edit : Form
    {
        Anywhere anywhere = new Anywhere();

        public Edit()
        {
            InitializeComponent();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            anywhere.connect(label_connect_table);

            if (anywhere.connection.State == ConnectionState.Open)
            {
                combo_app.Items.Clear();
                APP();
            }
        }

        #region edit app
        private void APP()
        {
            string query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; " +
                        "SELECT name FROM service.dbo._faq_app ORDER BY name";

            anywhere.adap_dat(query);

            for (int i = 0; i < anywhere.data.Tables[0].Rows.Count; i++)
                combo_app.Items.Add(anywhere.data.Tables[0].Rows[i][0].ToString());
        }

        private void combo_app_SelectionChangeCommitted(object sender, EventArgs e)
        {
            list_questions.Items.Clear();

            string app = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;" +
                "SELECT name, caption FROM service.dbo._faq_app WHERE name = '" + combo_app.SelectedItem.ToString() + "'";

            string questons = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;" +
                "SELECT DISTINCT q.question FROM service.dbo._faq_questions q " +
                "JOIN service.dbo._faq_questions_tags qt ON q.id = qt.question_id " +
                "JOIN service.dbo._faq_tags t ON qt.tag_id = t.id WHERE qt.del=0 and q.app = (SELECT id FROM service.dbo._faq_app WHERE name = '" + combo_app.SelectedItem.ToString() + "')" ;

            anywhere.adap_dat(app);

            text_app_name.Text = anywhere.data.Tables[0].Rows[0][0].ToString();
            text_edit_caption.Text = anywhere.data.Tables[0].Rows[0][1].ToString();

            anywhere.adap_dat(questons);

            for (int i = 0; i < anywhere.data.Tables[0].Rows.Count; i++)
                list_questions.Items.Add(anywhere.data.Tables[0].Rows[i][0].ToString());
        }

        private void btn_edit_app_Click(object sender, EventArgs e)
        {
            string app_name = text_app_name.Text;
            app_name.Replace("'", "`");
            app_name = app_name.ToLower();

            string app_caption = text_edit_caption.Text;
            app_caption.Replace("'", "`");

            string query = "UPDATE  service.dbo._faq_app  SET name='" + app_name + "', caption='" + app_caption + "' " +
                "WHERE id =(SELECT id FROM service.dbo._faq_app WHERE name = '" + combo_app.SelectedItem.ToString() + "')";

            try
            {
                SqlCommand sql_edit_app = new SqlCommand(query, anywhere.connection);
                sql_edit_app.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            combo_app.Items.Clear();
            APP();

            MessageBox.Show("Изменения внесены", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        private void list_questions_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; " +
                        "SELECT question, answer, checking FROM service.dbo._faq_questions WHERE question = '" + list_questions.SelectedItem.ToString() + "'";

            anywhere.adap_dat(query);

            text_edit_question.Text = anywhere.data.Tables[0].Rows[0][0].ToString();
            rich_edit_answer.Text = anywhere.data.Tables[0].Rows[0][1].ToString();
            rich_edit_check.Text = anywhere.data.Tables[0].Rows[0][2].ToString();

            string apps = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; " +
                        "SELECT name FROM service.dbo._faq_app";
            
            list_edit_app.Items.Clear();

            anywhere.adap_dat(apps);

            for (int i = 0; i < anywhere.data.Tables[0].Rows.Count; i++)
                list_edit_app.Items.Add(anywhere.data.Tables[0].Rows[i][0].ToString());

            string app = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;" +
                "SELECT name FROM service.dbo._faq_app a " +
                "JOIN service.dbo._faq_questions q ON a.id = q.app " +
                "WHERE q.question = '" + list_questions.SelectedItem.ToString() + "'";

            list_edit_app.SelectedItem = new SqlCommand(app, anywhere.connection).ExecuteScalar().ToString();

            list_edit_tags.Items.Clear();

            string tags_all = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; " +
                        "SELECT name FROM service.dbo._faq_tags ORDER BY name";

            anywhere.adap_dat(tags_all);

            for (int i = 0; i < anywhere.data.Tables[0].Rows.Count; i++)
                list_edit_tags.Items.Add(anywhere.data.Tables[0].Rows[i][0].ToString());

            string tags = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; " +
                "SELECT DISTINCT t.name FROM service.dbo._faq_questions q " +
                "JOIN service.dbo._faq_questions_tags qt ON q.id = qt.question_id " +
                "JOIN service.dbo._faq_tags t ON qt.tag_id = t.id " +
                "WHERE qt.del=0 and q.question = '" + list_questions.SelectedItem.ToString() + "'";

            anywhere.adap_dat(tags);

            for (int i = 0; i < anywhere.data.Tables[0].Rows.Count; i++)
                list_edit_tags.SelectedItem = anywhere.data.Tables[0].Rows[i][0].ToString();
        }

        private void btn_edit_question_Click(object sender, EventArgs e)
        {
            string question = text_edit_question.Text;
            question.Replace("'", "`");

            string answer = rich_edit_answer.Text;
            answer.Replace("'", "`");

            string t_check = rich_edit_check.Text;
            t_check.Replace("'", "`");

            string app_question = "SELECT id FROM service.dbo._faq_app WHERE name = '" + list_edit_app.SelectedItem.ToString() + "'";

            int app = (int)new SqlCommand(app_question, anywhere.connection).ExecuteScalar();

            string upd_ques = "UPDATE  service.dbo._faq_questions  SET " +
                "question='" + question + "', answer='" + answer + "', checking='" + t_check + "', app=" + app + "" +
                " WHERE question = '" + list_questions.SelectedItem.ToString() + "'";

            SqlCommand sql_edit_ques = new SqlCommand(upd_ques, anywhere.connection);
            sql_edit_ques.ExecuteNonQuery();

            string t_del = "update service.dbo._faq_questions_tags SET del=1 WHERE id in (" +
                        "SELECT qt.id FROM service.dbo._faq_questions q " +
                        "JOIN service.dbo._faq_questions_tags qt ON q.id = qt.question_id " +
                        "WHERE q.question = '" + list_questions.SelectedItem.ToString() + "')";
            SqlCommand sql_t_del = new SqlCommand(t_del, anywhere.connection);
            sql_t_del.ExecuteNonQuery();

            foreach (var i in list_edit_tags.SelectedItems)
            {
                string query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; " +
                        "SELECT id FROM service.dbo._faq_tags WHERE name='"+i.ToString()+"'";


                int tag = (int)new SqlCommand(query, anywhere.connection).ExecuteScalar();

                string ques_t = @"IF EXISTS(
SELECT qt.tag_id FROM service.dbo._faq_questions q
JOIN service.dbo._faq_questions_tags qt ON q.id = qt.question_id
JOIN service.dbo._faq_tags t ON qt.tag_id = t.id
WHERE t.name = '"+i.ToString()+"' and q.question = '" + question + "')"+
@"BEGIN
     SELECT qt.tag_id FROM service.dbo._faq_questions q
     JOIN service.dbo._faq_questions_tags qt ON q.id = qt.question_id
     JOIN service.dbo._faq_tags t ON qt.tag_id = t.id
     WHERE t.name = '"+i.ToString()+"' and q.question = '" + question + "'"+
@"END
ELSE
BEGIN
     SELECT 0 as tag_id
END";

                if (tag == (int)new SqlCommand(ques_t, anywhere.connection).ExecuteScalar())
                {
                    string t_name= "SELECT t.name FROM service.dbo._faq_questions q " +
                        "JOIN service.dbo._faq_questions_tags qt ON q.id = qt.question_id " +
                        "JOIN service.dbo._faq_tags t ON qt.tag_id = t.id " +
                        "WHERE t.name = '"+i.ToString()+"' and q.question = '" + question + "'";//list_questions.SelectedItem.ToString()
                    
                    string t_active = "update service.dbo._faq_questions_tags SET del=0 WHERE id in (" +
                        "SELECT qt.id FROM service.dbo._faq_questions q " +
                        "JOIN service.dbo._faq_questions_tags qt ON q.id = qt.question_id " +
                        "JOIN service.dbo._faq_tags t ON qt.tag_id = t.id " +
                        "WHERE t.name = '" + i.ToString() + "' and q.question = '" + question + "')";

                    SqlCommand sql_t_active = new SqlCommand(t_active, anywhere.connection);
                    sql_t_active.ExecuteNonQuery();                    
                }
                else
                {
                    string add_tag = "DECLARE @question_id INT;" +
                            "DECLARE @tag_id INT;" +
                            "SET @question_id = (SELECT id FROM service.dbo._faq_questions WHERE question = '" + question + "');" +
                            "SET @tag_id = (SELECT id FROM service.dbo._faq_tags WHERE name = '" + i.ToString() + "');" +
                            "INSERT INTO service.dbo._faq_questions_tags(question_id, tag_id, del) VALUES(@question_id, @tag_id, 0)";

                    SqlCommand AddTs = new SqlCommand(add_tag, anywhere.connection);
                    AddTs.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Изменения внесены", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
