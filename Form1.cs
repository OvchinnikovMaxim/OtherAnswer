using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace otherSol
{
    public partial class Mainform : Form
    {
        List<string> tag = new List<string>();

        Anywhere anywhere = new Anywhere();
                
        public Mainform()
        {
            InitializeComponent();
        }

        private void btn_new_question_Click(object sender, EventArgs e)
        {
            New_question new_Question = new New_question();
            new_Question.Show();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit();
            edit.Show();
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

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                string query = String.Empty;

                if (text_query.Text != String.Empty)
                {
                    query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; " +
                        "SELECT a.name FROM service.dbo._faq_questions q " +
                        "JOIN service.dbo._faq_app a ON a.id = q.app " +
                        "WHERE q.question LIKE '%" + text_query.Text + "%' GROUP BY a.name ";        
                }
                else
                    MessageBox.Show("не добавлено содержимое для поиска");
                
                anywhere.adapter = new SqlDataAdapter(query, anywhere.connection);
                anywhere.data = new DataSet();
                anywhere.adapter.Fill(anywhere.data);

                string res = String.Empty;

                for (int i = 0; i < anywhere.data.Tables[0].Rows.Count; i++)
                {
                    if (i == 0)
                        res = anywhere.data.Tables[0].Rows[i][0].ToString();
                    else
                        res += ", " + anywhere.data.Tables[0].Rows[i][0].ToString();                    
                }
                rich_app_exist.Text = res;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
            checkedList_tags.Items.Clear();
            list_questions.Items.Clear();

            string tags = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;" +
                "SELECT DISTINCT t.name FROM service.dbo._faq_questions q " +
                "JOIN service.dbo._faq_questions_tags qt ON q.id = qt.question_id " +
                "JOIN service.dbo._faq_tags t ON qt.tag_id = t.id " +
                "WHERE qt.del=0 and q.app = (SELECT id FROM service.dbo._faq_app WHERE name = '" + combo_app.SelectedItem.ToString() + "') ORDER BY name";

            string questons = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;" +
                "SELECT DISTINCT q.question FROM service.dbo._faq_questions q " +
                "JOIN service.dbo._faq_questions_tags qt ON q.id = qt.question_id " +
                "JOIN service.dbo._faq_tags t ON qt.tag_id = t.id WHERE q.app = (SELECT id FROM service.dbo._faq_app WHERE name = '" + combo_app.SelectedItem.ToString() + "')";

            anywhere.adap_dat(tags); 

            for (int i = 0; i < anywhere.data.Tables[0].Rows.Count; i++)
                checkedList_tags.Items.Add(anywhere.data.Tables[0].Rows[i][0].ToString());

            anywhere.adap_dat(questons);

            for (int i = 0; i < anywhere.data.Tables[0].Rows.Count; i++)
                list_questions.Items.Add(anywhere.data.Tables[0].Rows[i][0].ToString());
        }

        private void btn_filtr_tags_Click(object sender, EventArgs e)
        {
            string questons = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;" +
                "SELECT DISTINCT q.question FROM service.dbo._faq_questions q " +
                "JOIN service.dbo._faq_questions_tags qt ON q.id = qt.question_id " +
                "JOIN service.dbo._faq_tags t ON qt.tag_id = t.id WHERE q.app = (SELECT id FROM service.dbo._faq_app WHERE name = '" + combo_app.SelectedItem.ToString() + "')";
            
            List<int> tagID = new List<int>();

            tag.Clear();

            for (int i = 0; i < checkedList_tags.CheckedItems.Count; i++)
                tag.Add(checkedList_tags.CheckedItems[i].ToString());   
               
            list_questions.Items.Clear();

            foreach (var t in tag)
            {
                string tags = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; " +
                    "SELECT id FROM service.dbo._faq_tags  WHERE name = ";
                tags += "'" + t + "'";

                try
                {
                    SqlCommand sql_tagID = new SqlCommand(tags, anywhere.connection);

                    if (Convert.ToInt32(sql_tagID.ExecuteScalar()) == 0)
                        tagID.Add(Convert.ToInt32(sql_tagID.ExecuteScalar()) + 1);
                    else
                        tagID.Add(Convert.ToInt32(sql_tagID.ExecuteScalar()));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (tagID.Count != 0)
                questons += " and t.id in (" + String.Join(", ", tagID.ToArray()) + ")";

            anywhere.adap_dat(questons);            

            for (int i = 0; i < anywhere.data.Tables[0].Rows.Count; i++)
                list_questions.Items.Add(anywhere.data.Tables[0].Rows[i][0].ToString());
        }

        private void list_questions_SelectedIndexChanged(object sender, EventArgs e)
        {
            string answer = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; " +
                        "SELECT answer FROM service.dbo._faq_questions WHERE question = '" + list_questions.SelectedItem.ToString() + "'";

            string check = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; " +
                        "SELECT checking FROM service.dbo._faq_questions WHERE question = '" + list_questions.SelectedItem.ToString() + "'";
            try
            {
                richText_answer.Text = new SqlCommand(answer, anywhere.connection).ExecuteScalar().ToString();
                richText_check.Text = new SqlCommand(check, anywhere.connection).ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
