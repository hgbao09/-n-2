using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCK
{
    public partial class FormHoaDon : System.Windows.Forms.Form
    {
        public FormHoaDon()
        {
            InitializeComponent();
        }

        public void them_dshd(List<HangHoa> dshh)
        {
            
            foreach (HangHoa hh in dshh)
            {
                BillComponent billComponent = new BillComponent(this);
                billComponent.hh = hh;
                billComponent.SetProductInfo(hh);
                dshd_flp.Controls.Add(billComponent);

            }
           
        }
    }
}
