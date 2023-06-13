using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HuegoVentas
{
    public static class FormsHelper
    {
        public static void MsgError(Exception ex)
        {
            MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
