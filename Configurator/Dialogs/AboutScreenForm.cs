﻿/* Copyright (c) 2023, Oracle and/or its affiliates.

 This program is free software; you can redistribute it and/or modify
 it under the terms of the GNU General Public License as published by
 the Free Software Foundation; version 2 of the License.

 This program is distributed in the hope that it will be useful,
 but WITHOUT ANY WARRANTY; without even the implied warranty of
 MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 GNU General Public License for more details.

 You should have received a copy of the GNU General Public License
 along with this program; if not, write to the Free Software
 Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA 02110-1301  USA */

using MySql.Configurator.Core.Classes;
using MySql.Configurator.Core.Enums;
using System;
using System.Windows.Forms;

namespace MySql.Configurator.Dialogs
{
  public partial class AboutScreenForm : Form
  {
    public AboutScreenForm(Version version, LicenseType license)
    {
      InitializeComponent();
      VersionLicenseLabel.Text = $"Version {version.Major}.{version.Minor}.{version.Build} ({license.ToString()})";
    }

    protected override void OnLoad(EventArgs e)
    {
      Utilities.NormalizeFont(this);
      base.OnLoad(e);
    }

    private void AboutScreenForm_Deactivate(object sender, EventArgs e)
    {
      Close();
    }
  }
}