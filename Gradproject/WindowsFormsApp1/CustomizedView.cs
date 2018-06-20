using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class CustomizedView : UserControl {
        public List<Group> AllGroups;
        public List<Device> AllDevices;
        public CustomizedView() {
            InitializeComponent();
            groupList.ItemCheck += GroupList_ItemCheck;
        }

        private void GroupList_ItemCheck(object sender, ItemCheckEventArgs e) {
            //e.Index //Later
            if (groupList.GetItemChecked(e.Index)) {
                for(int i = 0; i < AllDevices.Count; i++) {
                    if (AllDevices[i].Group != null)
                        if (AllDevices[i].group_id == AllGroups[e.Index].group_id)
                            devicesList.SetItemChecked(i,false);
                }
            } else {
                for (int i = 0; i < AllDevices.Count; i++) {
                    if (AllDevices[i].Group != null)
                        if (AllDevices[i].group_id == AllGroups[e.Index].group_id)
                            devicesList.SetItemChecked(i, true);
                }
            }
        }
    }
}
