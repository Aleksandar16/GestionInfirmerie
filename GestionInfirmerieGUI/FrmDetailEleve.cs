﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using GestionInfirmerieBLL;
using GestionInfirmerieBO;

namespace GestionInfirmerieGUI
{
    public partial class FrmDetailEleve : Form
    {
        public FrmDetailEleve()
        {
            InitializeComponent();
            GestionEleve.SetchaineConnexion(ConfigurationManager.ConnectionStrings["GestionInfirmerie"]);
            List<Eleve> adherents = GestionEleve.GetEleve();
        }
    }
}
