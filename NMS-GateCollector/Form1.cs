using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMS_GateCollector
{
    public partial class Form1 : Form
    {
        List<Planet> planets = new List<Planet>(NMS_GateCollector.LoadPlanets());
        public Form1()
        {
            InitializeComponent();
            //PlanetList.AutoGenerateColumns = true;
            //PlanetList.DataSource = planets;
            SetupGrid();
        }

        private void SetupGrid()
        {
            PlanetList.AutoGenerateColumns = false;
            PlanetList.AllowUserToAddRows = false;
            PlanetList.DataSource = planets;

            DataGridViewTextBoxColumn Column1 = new DataGridViewTextBoxColumn
            {
                Name = "Galaxy",
                HeaderText = "Galaxy",
                DataPropertyName = "GalaxyName",
                Width = (PlanetList.Width / 4) - 15
            };
            PlanetList.Columns.Add(Column1);
            DataGridViewTextBoxColumn Column2 = new DataGridViewTextBoxColumn
            {
                Name = "Planet",
                HeaderText = "Custom Name",
                DataPropertyName = "Name",
                Width = (PlanetList.Width / 4) - 15
            };
            PlanetList.Columns.Add(Column2);
            DataGridViewTextBoxColumn Column3 = new DataGridViewTextBoxColumn
            {
                Name = "Discoverer",
                HeaderText = "Discovered By",
                DataPropertyName = "Discoverer",
                Width = (PlanetList.Width / 4) - 15
            };
            PlanetList.Columns.Add(Column3);
            DataGridViewTextBoxColumn Column4 = new DataGridViewTextBoxColumn
            {
                Name = "Gate",
                HeaderText = "Gate Address",
                DataPropertyName = "GateAddress",
                Width = (PlanetList.Width / 4) - 15
            };
            PlanetList.Columns.Add(Column4);
        }

        private void PlanetList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(PlanetList.Rows[e.RowIndex].Cells[3].Value.ToString());
            if(e.RowIndex >= 0)
            {
                SetGlyphs(e.RowIndex);
            }
        }

        private void SetGlyphs(int RowIndex)
        {

            pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject(string.Format("g{0}", PlanetList.Rows[RowIndex].Cells[3].Value.ToString()[0]));
            pictureBox2.Image = (Image)Properties.Resources.ResourceManager.GetObject(string.Format("g{0}", PlanetList.Rows[RowIndex].Cells[3].Value.ToString()[1]));
            pictureBox3.Image = (Image)Properties.Resources.ResourceManager.GetObject(string.Format("g{0}", PlanetList.Rows[RowIndex].Cells[3].Value.ToString()[2]));
            pictureBox4.Image = (Image)Properties.Resources.ResourceManager.GetObject(string.Format("g{0}", PlanetList.Rows[RowIndex].Cells[3].Value.ToString()[3]));
            pictureBox5.Image = (Image)Properties.Resources.ResourceManager.GetObject(string.Format("g{0}", PlanetList.Rows[RowIndex].Cells[3].Value.ToString()[4]));
            pictureBox6.Image = (Image)Properties.Resources.ResourceManager.GetObject(string.Format("g{0}", PlanetList.Rows[RowIndex].Cells[3].Value.ToString()[5]));
            pictureBox7.Image = (Image)Properties.Resources.ResourceManager.GetObject(string.Format("g{0}", PlanetList.Rows[RowIndex].Cells[3].Value.ToString()[6]));
            pictureBox8.Image = (Image)Properties.Resources.ResourceManager.GetObject(string.Format("g{0}", PlanetList.Rows[RowIndex].Cells[3].Value.ToString()[7]));
            pictureBox9.Image = (Image)Properties.Resources.ResourceManager.GetObject(string.Format("g{0}", PlanetList.Rows[RowIndex].Cells[3].Value.ToString()[8]));
            pictureBox10.Image = (Image)Properties.Resources.ResourceManager.GetObject(string.Format("g{0}", PlanetList.Rows[RowIndex].Cells[3].Value.ToString()[9]));
            pictureBox11.Image = (Image)Properties.Resources.ResourceManager.GetObject(string.Format("g{0}", PlanetList.Rows[RowIndex].Cells[3].Value.ToString()[10]));
            pictureBox12.Image = (Image)Properties.Resources.ResourceManager.GetObject(string.Format("g{0}", PlanetList.Rows[RowIndex].Cells[3].Value.ToString()[11]));
        }

    }
}
