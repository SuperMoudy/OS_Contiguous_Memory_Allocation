using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2_MemAllocation
{
    public partial class Memory : Form
    {
        //private Memory_Allocation Memory_Allocation;
        //public delegate void back_to_allocation();

        SortedList<int, Memory_Element> Final_Layout;
        int final_mem_size;

        public Memory(int final_size, SortedList<int,Memory_Element> Layout)
        {
            InitializeComponent();
            Final_Layout = Layout;
            final_mem_size = final_size;
            panel1.Paint += new PaintEventHandler(panel1_Paint);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Width = 100 * Final_Layout.Count;
            panel1.AutoScroll = true;
            int x = 0;
            int y = 0;
            int x2 = 15; //was 25
            int y2 = 10;
            for(int i = 0; i < final_mem_size; i++)
            {
                string drawString = Final_Layout.ElementAt(i).Value.name + "\n"
                    + "base: " + Final_Layout.ElementAt(i).Value.starting_address + "\n"
                    + "size: " + Final_Layout.ElementAt(i).Value.size +"\n"
                    + "type: " + Final_Layout.ElementAt(i).Value.type;
                    
                //string drawString = process.getName();
                Console.WriteLine(drawString);
                System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 10);
                System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
                System.Drawing.Graphics graphics = panel1.CreateGraphics();
                System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(x, y, 100, 100);
                graphics.DrawString(drawString, drawFont, drawBrush, x2, y2);
                x = x + 100;
                x2 = x2 + 100;
                graphics.DrawRectangle(System.Drawing.Pens.Black, rectangle);
            }


        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
