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
    public partial class Observer : Form , IObserver
    {
        public Observer()
        {
            InitializeComponent();
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
           
            Colors.Subscribe(this);
            btnSubscribe.Enabled = false;
            btnUnsubscribe.Enabled = true;

        }
        public  void Update(string color )
        {
            llstbxObserver.Items.Add(color + " " + "Button Clicked");
        } //Update
        private void Observer_Load(object sender, EventArgs e)
        {

        }

        private void btnUnsubscribe_Click(object sender, EventArgs e)
        {
            Colors.UnSubscribe(this);
            btnUnsubscribe.Enabled = false;
            btnSubscribe.Enabled = true;
        }

        private void Observer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Colors.UnSubscribe(this);
        }
    }
}
