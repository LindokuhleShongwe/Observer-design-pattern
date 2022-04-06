/*
 Shongwe Lindokuhle
 2018275921
 CSIS 2664
 Project 8
 Due 20 11 2020
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2018275921_Project_8
{
    public partial class Colors : Form
    {
        private static List<IObserver> lstObservers = new List<IObserver>();
        public Colors()
        {
            InitializeComponent();
        }

        private void btnSpawnObserver_Click(object sender, EventArgs e)
        {
            Observer observer = new Observer();
            observer.Show();
        }
        public static void Subscribe(IObserver observer)
        {
            lstObservers.Add(observer);
        } //Subscribe
        public static void UnSubscribe(IObserver observer)
        {
            lstObservers.Remove(observer);
        } //UnSubscribe

        private void OnChange(string color)
        {
           
            foreach (IObserver observer in lstObservers)
                observer.Update(color);
        } //Notify
        private void btnRedColor_Click(object sender, EventArgs e)
        {
            OnChange("Red");
        }

        private void btnGreenColor_Click(object sender, EventArgs e)
        {
            OnChange("Green");
        }

        private void btnBlueColor_Click(object sender, EventArgs e)
        {
            OnChange("Blue");
        }

        private void Publisher_Load(object sender, EventArgs e)
        {

        }
    }
}
