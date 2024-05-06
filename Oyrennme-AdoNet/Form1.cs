using System.Data.SqlClient;

namespace Oyrennme_AdoNet
{
    public partial class Form1 : Form
    {
        const string connectionString = "Server = LAPTOP-PVUROI38\\SQLEXPRESS; Database=MSPLATFORMST; Trusted_Connection=True;";
        public Form1()
        {

            InitializeComponent();

            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Surname", "Surname");
            dataGridView1.Columns.Add("Gender", "Gender");

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            GetDatas();

        }
        void ResetTable()
        {
            dataGridView1.Rows.Clear();
        }
        public void GetDatas()
        {
            ResetTable();
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            using SqlCommand command = new SqlCommand("SELECT * FROM Users", conn);
            SqlDataReader datas = command.ExecuteReader();


            while (datas.Read())
            {
                dataGridView1.Rows.Add(datas[0], datas[1], datas[2], datas[3]);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = nameInput.Text;
            string soyad = surnameInput.Text;
            string cins = Qadın.Checked ? "Qadın" : "Kişi";
            InsertDatas(ad, soyad, Qadın.Checked ? 2 : 1);
            //dataGridView1.Rows.Add(dataGridView1.RowCount + 1, ad, soyad, cins);
            nameInput.Text = "";
            surnameInput.Text = "";
            GetDatas();


        }

        bool InsertDatas(string name, string surname, int genderId)
        {
            if (name.Length < 3 || surname.Length < 3 || genderId < 1 || genderId > 2)
            {
                MessageBox.Show("Gonderdiyiniz deyer uygun deyil.");
            }
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            using SqlCommand command = new SqlCommand($"INSERT INTO Users VALUES (N'{name}', N'{surname}', {genderId})", conn);

            int count = command.ExecuteNonQuery();
            while (count > 0)
            {
                return true;
            }
            return false;

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var data = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
            string id = (data.Cells[0].Value.ToString());
            Delete(id);
            GetDatas();
        }
        void Delete(string id)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            using SqlCommand command = new SqlCommand($"DELETE Users WHERE Id= {id}", conn);
            var result = command.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Silindi");
            }
            else 
            {
                MessageBox.Show("Gozlenilmez xeta ba verdi.");
            }
        }
    }
}
