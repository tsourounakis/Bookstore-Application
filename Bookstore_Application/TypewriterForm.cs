using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore_Application
{
    public partial class TypewriterForm : Form
    {
        DBConnection dbconn = new DBConnection("localhost", "bookstore_schema", "root", "root");
        DataTable dt;

        string email;
        string name;
        string surname;

        public TypewriterForm(string email, string name, string surname)
        {
            InitializeComponent();

            this.email = email;
            this.name = name;
            this.surname = surname;

            emailTypewriterLabel.Text = email + " Typewriter";

            dt = dbconn.Select("SELECT DISTINCT(title) FROM books;");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                searchTitleComboBox.Items.Add(dt.Rows[i][0].ToString());
            }

            dt = dbconn.Select("SELECT DISTINCT(author) FROM books;");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                searchAuthorComboBox.Items.Add(dt.Rows[i][0].ToString());
            }

            dt = dbconn.Select("SELECT DISTINCT(edition) FROM books;");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                searchEditionComboBox.Items.Add(dt.Rows[i][0].ToString());
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchTitleButton_Click(object sender, EventArgs e)
        {
            if (!check_Inputes())
                return;

            dt = dbconn.Select("SELECT critics FROM bookstore_schema.books WHERE title = '" + searchTitleComboBox.Text + "' AND author = '" + searchAuthorComboBox.Text + "' AND edition = '" + searchEditionComboBox.Text + "';");

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No such item found!", "No item found", MessageBoxButtons.OK);
                return;
            }

            if (!dt.Rows[0][0].ToString().Equals(string.Empty))
            {
                criticsRichTextBox.Text = dt.Rows[0][0].ToString();
                confirmButton.Enabled = false;
                clearButton.Visible = true;
            }               
            else
            {
                confirmButton.Enabled = true;
                clearButton.Visible = false;
            }
        }

        private bool check_Inputes()
        {
            if (searchTitleComboBox.Text.Equals(string.Empty))
            {
                searchTitleErrorLabel.Visible = true;
            }
            else
            {
                searchTitleErrorLabel.Visible = false;
            }

            if (searchAuthorComboBox.Text.Equals(string.Empty))
            {
                searchAuthorErrorLabel.Visible = true;
            }
            else
            {
                searchAuthorErrorLabel.Visible = false;
            }

            if (searchEditionComboBox.Text.Equals(string.Empty))
            {
                searchEditionErrorLabel.Visible = true;
            }
            else
            {
                searchEditionErrorLabel.Visible = false;
            }

            if (searchTitleErrorLabel.Visible || searchAuthorErrorLabel.Visible || searchEditionErrorLabel.Visible)
            {
                return false;
            }

            return true;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (!check_Inputes())
                return;

            dt = dbconn.Select("SELECT critics, id FROM bookstore_schema.books WHERE title = '" + searchTitleComboBox.Text + "' AND author = '" + searchAuthorComboBox.Text + "' AND edition = '" + searchEditionComboBox.Text + "';");

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Critic cannot be added, item no found!", "No item found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!criticsRichTextBox.Text.Equals(string.Empty))
            {
                string critics = dt.Rows[0][0].ToString() + "\n\n\n" + name + " " + surname + " said:\n\n" + criticsRichTextBox.Text;

                dbconn.ExecuteNonQuery("UPDATE bookstore_schema.books SET critics = '" + critics + "' WHERE title = '" + searchTitleComboBox.Text + "' AND author = '" + searchAuthorComboBox.Text + "' AND edition = '" + searchEditionComboBox.Text + "';");

                if (ratingNumericUpDown.Value > 0)
                {
                    dbconn.ExecuteNonQuery("UPDATE bookstore_schema.books_extra_info SET rating_sum = rating_sum + " + Convert.ToInt32(ratingNumericUpDown.Value) + ", rating_num = rating_num + 1 WHERE id = " + int.Parse(dt.Rows[0][1].ToString()) + ";");
                }

                MessageBox.Show("Critic added for this item.", "Critic Approved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            else
            {
                MessageBox.Show("No critic added for this item!", "Critic Disapproved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            criticsRichTextBox.Text = string.Empty;
            confirmButton.Enabled = true;
            clearButton.Visible = false;
        }
    }
}
