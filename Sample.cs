﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSperity
{
    public partial class Sample : Form
    {
        public Sample()
        {
            InitializeComponent();
            guna2MessageDialog1.Parent = frmMain.Instance;
        }
    }
}
