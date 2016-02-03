﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using WizardFormLib;

namespace Ntua_Privacy_Solution
{
    public partial class spage2 : WizardFormLib.WizardPage
    {
        public spage2(WizardFormBase parent)
                    : base(parent)
        {
            InitPage();
        }
        public spage2(WizardFormBase parent, WizardPageType pageType)
                    : base(parent, pageType)
        {
            InitPage();
        }

        public void InitPage()
        {
            InitializeComponent();
            base.Size = this.Size;
            this.ParentWizardForm.DiscoverPagePanelSize(this.Size);
            base.Title = "Εργαστήριο Συστημάτων Αποφάσεων και Διοίκησης";
            base.Subtitle = "Κατηγορία: Προστασία Αποκάλυψης Παρουσίας στον Πίνακα";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "δ-Presence sq2.pdf");
            Process P = new Process
            {
                StartInfo = { FileName = "AcroRd32.exe", Arguments = path }
            };
            P.Start();
        }
    }
}
