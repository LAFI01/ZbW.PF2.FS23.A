﻿using Einheit13.CounterExample;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Einheit13
{
    public partial class StartView : Form
    {
        public StartView()
        {
            InitializeComponent();
        }

  

        private void OnClickBtnStaticExample(object sender, EventArgs e)
        {
            var view = new CounterView();
            view.Show();
        }
    }
}