using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMSServer.DataAccessLayer;
using SMSServer.DataMapping;
using System.Configuration;

namespace SMSServer
{
    public partial class frmDestinations : Form
    {
        public delegate void DestinationsSelectedHandler(object sender, EventArgs e);
        public event DestinationsSelectedHandler DestinationsSelected;

        DestinationsManager _DestinationManager = new DestinationsManager();
        public frmDestinations()
        {
            InitializeComponent();
        }
        private void OnDestinationsSelected()
        {
            if (DestinationsSelected != null)
            {
                DestinationsSelected(this, new EventArgs());
            }
        }
        private void BindDestinationsCheckBoxList()
        {
            List<Destination> lstDestinations = _DestinationManager.GetAllDestinations();
            foreach (Destination dest in lstDestinations)
            {
                ListItem cbItem = new ListItem(dest.Name, dest.Id);
                if (Settings.Destinations.Contains(dest.Id))
                {
                    clbDestinations.Items.Add(cbItem, true);
                }
                else
                {
                    clbDestinations.Items.Add(cbItem,false );
                }
            }
        }

        private void frmDestinations_Load(object sender, EventArgs e)
        {
            BindDestinationsCheckBoxList();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string destinationsIds = string.Empty;
            List<int> lstDestinationsIds = new List<int>();
            foreach (ListItem item in clbDestinations.CheckedItems )
            {
                destinationsIds += (destinationsIds == string.Empty) ? item.Value.ToString() : "," + item.Value.ToString();
                lstDestinationsIds.Add(item.Value);
            }
            AppConfigHandler.WriteSetting("Destinations", destinationsIds);
            Settings.Destinations = lstDestinationsIds;
            OnDestinationsSelected();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
