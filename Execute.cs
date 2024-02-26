using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grimorie
{
    public partial class Execute : Form
    {
        public Execute()
        {
            InitializeComponent();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (data.SelectedRows.Count < 1) 
                return;

            string program = data.SelectedRows[0].Cells[1].Value.ToString();
            string parameters = data.SelectedRows[0].Cells[2].Value.ToString();
            CommandLine.ExecuteCommandAsync(program, parameters);

            string doClose = data.SelectedRows[0].Cells[3].Value.ToString();

            if (doClose == "True")
                this.Close();
            //CommandLine.ExecuteCommandAsync("C:\\Program Files (x86)\\uvnc bvba\\UltraVNC\\vncviewer.exe", "-viewonly  -username SequorSystemsAdmin -password Security2022! 172.40.10.127");

        }
    }
}
