using System.Windows.Forms;
using Fishy_Projek.Models;

namespace Fishy_Projek.Models
{
    public class Manager : User
    {
        public override void AturHakAksesMenu(Form formUtama)
        {
            FormUtama f = (FormUtama)formUtama;
            f.btnDashboard.Visible = true;
            f.btnStok.Visible = true;
            f.btnInputSuhu.Visible = true;
            f.btnPengiriman.Visible = true;
            f.btnLaporan.Visible = true;
            f.btnMaster.Visible = true;
        }
    }
}