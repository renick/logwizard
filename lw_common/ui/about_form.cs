﻿/* 
 * Copyright (C) 2014-2015 John Torjo
 *
 * This file is part of LogWizard
 *
 * LogWizard is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * LogWizard is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 *
 * If you wish to use this code in a closed source application, please contact john.code@torjo.com 
 *
 * **** Get Latest version at https://github.com/jtorjo/logwizard **** 
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lw_common.ui {
    public partial class about_form : Form {
        public about_form(Form parent) {
            InitializeComponent();
            TopMost = parent.TopMost;
        }

        private void jt2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            try {
                Process.Start("mailto:john.code@torjo.com");
            } catch {}
        }

        private void jt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            try {
                Process.Start("mailto:john.code@torjo.com");
            } catch {}
        }


        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            try {
                Process.Start("https://github.com/jtorjo/logwizard/wiki");
            } catch {}
            
        }
    }
}
