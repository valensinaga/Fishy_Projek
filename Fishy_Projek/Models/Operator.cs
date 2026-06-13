using System.Windows.Forms;
using Fishy_Projek.Models;

namespace Fishy_Projek.Models
{
    public class Operator : User
    {
        public override void AturHakAksesMenu(Form formUtama)
        {
            FormUtama f = (FormUtama)formUtama;
            f.btnDashboard.Visible = false;
            f.btnStok.Visible = true;
            f.btnInputSuhu.Visible = true;
            f.btnPengiriman.Visible = true;
            f.btnLaporan.Visible = false;
            f.btnMaster.Visible = false;
        }
    }
}