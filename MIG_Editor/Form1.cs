using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MIG_Editor.Objects;
using System.Xml.Serialization;
using System.IO;

namespace MIG_Editor
{
    public partial class Form1 : Form
    {
        Objects.Container cont;
        public Form1()
        {
            InitializeComponent();
            cont = new Objects.Container();
            cont.AddPower();
            cont.AddPower();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer ser = new XmlSerializer(typeof(Objects.Container));

            StreamWriter sw = new StreamWriter("myfile.xml");

            ser.Serialize(sw, cont);

            sw.Close();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer deser = new XmlSerializer(typeof(Objects.Container));

            FileStream fs = new FileStream("myfile.xml", FileMode.Open);

            cont = (Objects.Container)deser.Deserialize(fs);

            fs.Close();
        }
    }
}
