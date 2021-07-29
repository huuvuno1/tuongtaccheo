using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TuongTacCheo.Form1;

namespace TuongTacCheo
{
    class ToolUtils
    {
        public static List<Misson> GetListMisson(CheckBox follow, CheckBox likePage, CheckBox likePost)
        {
            List<Misson> missons = new List<Misson>();
            if (follow.Checked)
                missons.Add(Misson.FOLLOW);
            if (likePage.Checked)
                missons.Add(Misson.LIKE_PAGE);
            if (likePost.Checked)
                missons.Add(Misson.LIKE_POST);
            return missons;
        }
    }
}
