using System;
using System.Windows.Forms;

namespace Fishy_Projek.Models
{
    public abstract class User
    {
        public int IdUser { get; set; }
        public string Nama { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int IdRole { get; set; }

        public abstract void AturHakAksesMenu(Form formUtama);
    }
}