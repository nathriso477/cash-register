using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
namespace cash_register
{
    public partial class resetbutton : Form
    {   //prices of products
        const double BAYONET = 2.49;
        const double KARAMBIT = 1.89;
        //sets up variables
        double tax = 0.13;
        double taxa;
        double subtotal;
        double total;
        double bayonetq;
        double karambitq;
        double change;
        double tendered;
        


        public resetbutton()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            try
            {
                //adds variables together with tax
                bayonetq = Convert.ToInt32(bayonet.Text);
                karambitq = Convert.ToInt32(karambit.Text);
                subtotal = karambitq * KARAMBIT + bayonetq * BAYONET;
                subtotalLabel.Text = "Subtotal = " + subtotal.ToString("C");
                taxa = subtotal * tax;
                Taxlabel.Text = "Tax = " + taxa.ToString("C");
                total = subtotal + taxa;
                totallabel.Text = "Total = " + total.ToString("C");
            }




            catch
            {
                //outputs when nothing is put in text boxes
                output.Text = "you need to pay for that";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void change_Click(object sender, EventArgs e)
        {
            //calculates change from amount put in
            tendered = Convert.ToInt32(changebox.Text);
            change = tendered - total;
            changelabel.Text = "Change = " + change.ToString("C");



        }

        private void receipt_Click(object sender, EventArgs e)
        {
            //plays a sound
            SoundPlayer player = new SoundPlayer(Properties.Resources.ching);
            player.Play();

            Graphics formgraphics = this.CreateGraphics();
            //sets different brushes
            SolidBrush drawBrush = new SolidBrush(Color.White);
            SolidBrush receiptBrush = new SolidBrush(Color.Black);
            SolidBrush ordernumber = new SolidBrush(Color.Black);
            SolidBrush datebrush = new SolidBrush(Color.Black);

            //sets different fonts
            Font titleFont = new Font("Consolas", 18, FontStyle.Bold);
            Font bodyFont = new Font("Consolas", 8);
            Font dateFont = new Font("Consolas", 8);



            // draws a rectangle
            formgraphics.FillRectangle(drawBrush, 500, 100, 300, 350);
            // fills rectangle with text
            formgraphics.DrawString("Steam Marketplace", titleFont, receiptBrush, 540, 110);
            Thread.Sleep(500);
            formgraphics.DrawString("Purchase number 3", bodyFont, ordernumber, 510, 140);
            Thread.Sleep(500);
            formgraphics.DrawString("Date: October 18 2016", dateFont, datebrush, 510, 150);
            Thread.Sleep(500);
            formgraphics.DrawString("Subtotal....................$" + subtotal, dateFont, datebrush, 510, 170);
            Thread.Sleep(500);
            formgraphics.DrawString("Tax.........................$" + tax, dateFont, datebrush, 510, 180);
            Thread.Sleep(500);
            formgraphics.DrawString("Total.......................$" + total, dateFont, datebrush, 510, 190);
            Thread.Sleep(500);
            formgraphics.DrawString("Tendered....................$" + tendered, dateFont, datebrush, 510, 200);
            Thread.Sleep(500);
            formgraphics.DrawString("Change......................$" + change, dateFont, datebrush, 510, 210);
            Thread.Sleep(500);
            formgraphics.DrawString("Have a nice day :) ", bodyFont, ordernumber, 600, 300);





        }

        private void reset_Click(object sender, EventArgs e)
           


        {   //sets everything back to normal
            Graphics formgraphics = this.CreateGraphics(); 
            SolidBrush drawBrush = new SolidBrush(Color.White);
            bayonet.Clear();
            karambit.Clear();
            changebox.Clear();
            subtotalLabel.Text = "subtotal";
            Taxlabel.Text = "Tax";
            totallabel.Text = "Total";
            changelabel.Text = "Change";

            Refresh();

        }




    }
}