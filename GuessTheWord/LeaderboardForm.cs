using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheWord
{
    public partial class LeaderboardForm : Form
    {
        private Form1 form1;
        public List<Player> players { get; set; }
        public LeaderboardForm(Form1 form)
        {
            InitializeComponent();
            this.form1 = form;
            this.players = form1.Players;
        }

        private void LeaderboardForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            form1.ReadData();
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Score", "Score");

            foreach (Player player in players)
            {
                dataGridView1.Rows.Add(player.Name, player.Score);   
            }
            sortByScore();
        }

        private void sortByScore()
        {
            dataGridView1.Sort(dataGridView1.Columns["Score"], ListSortDirection.Descending);
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string index = (e.RowIndex + 1).ToString();

            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dataGridView1.RowHeadersWidth - 4, e.RowBounds.Height);
            TextFormatFlags flags = TextFormatFlags.VerticalCenter | TextFormatFlags.Right;
            TextRenderer.DrawText(e.Graphics, index, dataGridView1.RowHeadersDefaultCellStyle.Font, rectangle, dataGridView1.RowHeadersDefaultCellStyle.ForeColor, flags);
        }

        private void LeaderboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataGridView1.DataSource = null;
        }
    }
}
