using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Xml.Serialization;

namespace LAB4
{
    public partial class Form1 : Form
    {
        public int index = 0;
        string NameEng;
        string namePol;

        public  Dictionary<string, string> dirictEng = new Dictionary<string, string>()
        {
                {"Food","Jedzienie"},
                {"Apple","Jabko"},
                {"Cigarettes","Papierosy"},
                {"Drink","Pić"},
                {"Table","Stół"},
                {"Pappier","Papież"},
                {"Mouse","Mysz"},
                {"Cat","Kot"},
                {"Dog","Pies"},
                {"Phone","Telefon"},
                {"Sky","Niebo"},
                {"Home","Dom"},
                {"Cap","Kubek"},
                {"Pen","Długopis"},
                {"Eazy","Lekko"}
        };

        public Dictionary<string, string> dirictPol = new Dictionary<string, string>()
        {
                {"Jedzienie","Food"},
                {"Jabko","Apple"},
                {"Papierosy","Cigarettes"},
                {"Pić","Drink"},
                {"Stół","Table"},
                {"Papież","Pappier"},
                {"Mysz","Mouse"},
                {"Kot","Cat"},
                {"Pies","Dog"},
                {"Telefon","Phone"},
                {"Niebo","Sky"},
                {"Dom","Home"},
                {"Kubek","Cap"},
                {"Długopis","Pen"},
                {"Lekko","Eazy"}
        };

        Dictionary<string, string> dirictAll;

        public static string FirstUpper(string str)
        {
            string[] s = str.Split(' ');

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Length > 1)
                    s[i] = s[i].Substring(0, 1).ToUpper() + s[i].Substring(1, s[i].Length - 1).ToLower();
                else s[i] = s[i].ToUpper();
            }
            return string.Join(" ", s);
        }

        void SortedList()
        {
            if (index == 0) 
            {
                var sortedDict = new SortedDictionary<string, string>(dirictEng);
                dirictAll = new Dictionary<string, string>();
                foreach (var kvp in sortedDict)
                {
                    dirictAll.Add(kvp.Key, kvp.Value);
                }
            } 
            if (index == 1)
            {
                var sortedDict = new SortedDictionary<string, string>(dirictPol);
                dirictAll = new Dictionary<string, string>();
                foreach (var kvp in sortedDict)
                {
                    dirictAll.Add(kvp.Key, kvp.Value);
                }
            }
        }


        void refresh()
        {

            SortedList();
            dataGridView1.DataSource = dirictAll.ToArray();

            if (index == 0){
                dataGridView1.Columns[0].HeaderText = "English";
                dataGridView1.Columns[1].HeaderText = "Poland";
            }
            if(index == 1)
            {
                dataGridView1.Columns[0].HeaderText = "Poland";
                dataGridView1.Columns[1].HeaderText = "English";
            }
        }

        void clear()
        {
            textPoland.Text = "";
            textEnglish.Text = "";
        }

        void AddWord()
        {
            dirictEng.Add(FirstUpper(textEnglish.Text), FirstUpper(textPoland.Text));
            dirictPol.Add(FirstUpper(textPoland.Text), FirstUpper(textEnglish.Text)); 

        }

        void SearchWord()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(FirstUpper(textBoxSearch.Text)))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
                if (textBoxSearch.Text == "")
                {
                    dataGridView1.Rows[i].Selected = false;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            refresh();

        }

        
        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            try{
                if (textEnglish.Text == "" || textPoland.Text == "")
                {
                    MessageBox.Show("Error!");
                }
                else
                {
                    NameEng = FirstUpper(textEnglish.Text);
                    namePol = FirstUpper(textPoland.Text);
                    AddWord();
                    refresh();
                    clear();
                    listHistory.Items.Insert(0, "You save a word in: " + DateTime.Now);
                }
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clear();
            listHistory.Items.Clear();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchWord();
        }

        private void buttonEnglish_Click(object sender, EventArgs e)
        {
            index = 0;
            buttonEnglish.BackColor = Color.Peru;
            buttonPoland.BackColor = Color.Transparent;
            refresh();
            listHistory.Items.Insert(0, "You change language in: " + DateTime.Now);
        }
        private void buttonPoland_Click(object sender, EventArgs e)
        {
            index = 1;
            buttonEnglish.BackColor = Color.Transparent;
            buttonPoland.BackColor = Color.Peru;
            refresh();
            listHistory.Items.Insert(0, "You change language in: " + DateTime.Now);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Owner = this;
            f.ShowDialog();
            refresh();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Owner = this;
            f.ShowDialog();
        }
    }
}