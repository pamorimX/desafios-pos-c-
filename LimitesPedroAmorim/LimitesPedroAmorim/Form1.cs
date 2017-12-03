using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LimitesPedroAmorim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Acrescenta à propriedade Text de cada label os valores mínimos e máximos dos respectivos tipos
            lblTipoByte.Text += string.Format(" Mínimo {0} - Máximo {1}", byte.MinValue, byte.MaxValue);
            lblTipoSbyte.Text += string.Format(" Mínimo {0} - Máximo {1}", sbyte.MinValue, sbyte.MaxValue);
            lblTipoShort.Text += string.Format(" Mínimo {0} - Máximo {1}", short.MinValue, short.MaxValue);
            lblTipoUshort.Text += string.Format(" Mínimo {0} - Máximo {1}", ushort.MinValue, ushort.MaxValue);
            lblTipoInt.Text += string.Format(" Mínimo {0} - Máximo {1}", int.MinValue, int.MaxValue);
            lblTipoUint.Text += string.Format(" Mínimo {0} - Máximo {1}", uint.MinValue, uint.MaxValue);
            lblTipoLong.Text += string.Format(" Mínimo {0} - Máximo {1}", long.MinValue, long.MaxValue);
            lblTipoUlong.Text += string.Format(" Mínimo {0} - Máximo {1}", ulong.MinValue, ulong.MaxValue);
            lblTipoFloat.Text += string.Format(" Mínimo {0} - Máximo {1}", float.MinValue, float.MaxValue);
            lblTipoDouble.Text += string.Format(" Mínimo {0} - Máximo {1}", double.MinValue, double.MaxValue);
            lblTipoDecimal.Text += string.Format(" Mínimo {0} - Máximo {1}", decimal.MinValue, decimal.MaxValue);

        }
    }
}
