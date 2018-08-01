using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Patagames.Ocr;
using Patagames.Ocr.Enums;

namespace WindowsRecongnization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
                    }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var api = OcrApi.Create())
            {
                api.Init(Languages.Arabic);
                String Text = api.GetTextFromImage(@"C:\OCR\arabic-1.jpg");
                label1.Text = Text.ToString();
            }
        }
    }
}
