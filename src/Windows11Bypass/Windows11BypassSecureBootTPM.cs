using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows11Bypass
{
    public partial class Windows11BypassSecureBootTPM : Form
    {
        public Windows11BypassSecureBootTPM()
        {
            InitializeComponent();
            if (MessageBox.Show("Do you want Bypass Windows 11 Secure Boot Check and TPM 2.0?", "Bypass Windows 11 Secure Boot Check and TPM 2.0", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                RegistryKey bypasstpmsecurebootramstoragecheck = Registry.LocalMachine.CreateSubKey(@"SYSTEM\Setup\LabConfig");
                bypasstpmsecurebootramstoragecheck.SetValue("BypassTPMCheck", "1", RegistryValueKind.DWord);
                bypasstpmsecurebootramstoragecheck.SetValue("BypassSecureBootCheck", "1", RegistryValueKind.DWord);
                bypasstpmsecurebootramstoragecheck.SetValue("BypassRAMCheck", "1", RegistryValueKind.DWord);
                bypasstpmsecurebootramstoragecheck.SetValue("BypassStorageCheck", "1", RegistryValueKind.DWord);
                RegistryKey BypassCPUCheckandTPMCheckINMoSetup = Registry.LocalMachine.CreateSubKey(@"SYSTEM\Setup\MoSetup");
                BypassCPUCheckandTPMCheckINMoSetup.SetValue("AllowUpgradesWithUnsupportedTPMOrCPU", "1", RegistryValueKind.DWord);
                MessageBox.Show("Done.");
            }
            Environment.Exit(0);
        }
    }
}
