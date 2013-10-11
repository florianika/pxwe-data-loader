using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;




namespace PxDataLoader
{
    public partial class GenericSettings : Form
    {
        public GenericSettings()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
           
            
            connectionStringsSection.ConnectionStrings["PcAxisMetabaseEntities"].ConnectionString = txbMetabaseCn.Text;
            connectionStringsSection.ConnectionStrings["PcAxisDatabase"].ConnectionString = txbDatabaseCn.Text;
            config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");
            MessageBox.Show("Settings changed");
            this.Close();
          
        }

        private void GenericSettings_Load(object sender, EventArgs e)
        {
            txbMetabaseCn.Text = ConfigurationManager.ConnectionStrings["PcAxisMetabaseEntities"].ConnectionString;
            txbDatabaseCn.Text = ConfigurationManager.ConnectionStrings["PcAxisDatabase"].ConnectionString;
        }

        private void btnDbSetCnString_Click(object sender, EventArgs e)
        {
           
            String OldDatabaseCnString = ConfigurationManager.ConnectionStrings["PcAxisDatabase"].ConnectionString;
            String newDatabaseCnString;
          
            if (chbIntSecurityDb.Checked)
            {
                newDatabaseCnString = String.Format("Data Source={0}\\{1};Initial Catalog={2};Integrated Security=True", txbServerDb.Text, txbInstanceDb.Text, txbDatabaseDb.Text);
            }
            else
            {
                newDatabaseCnString = String.Format("Data Source={0}\\{1};Initial Catalog={2};User Id={3};Password={4}", txbServerDb.Text, txbInstanceDb.Text, txbDatabaseDb.Text, txbUsernameDb.Text, txbPasswordDb.Text);
            }
            txbDatabaseCn.Text = newDatabaseCnString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String oldMetabaseCnString = ConfigurationManager.ConnectionStrings["PcAxisMetabaseEntities"].ConnectionString;
            
            String newMetabaseCnStrign;
   
            if (chbIntsecMb.Checked)
            {
                newMetabaseCnStrign = oldMetabaseCnString.Substring(0, oldMetabaseCnString.IndexOf("Data Source")) + String.Format("Data Source={0}\\{1};Initial Catalog={2};Integrated Security=True;MultipleActiveResultSets=True\"", txbServerMb.Text, txbInstanceMb.Text, txbDatabaseMb.Text);
            }
            else
            {
                newMetabaseCnStrign = oldMetabaseCnString.Substring(0, oldMetabaseCnString.IndexOf("Data Source")) + String.Format("Data Source={0}\\{1};Initial Catalog={2};User Id={3};Password={4}MultipleActiveResultSets=True\"", txbServerMb.Text, txbInstanceMb.Text, txbDatabaseMb.Text, txbUsernameMb.Text, txbPasswordMb.Text);
            }

            txbMetabaseCn.Text = newMetabaseCnStrign;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}
