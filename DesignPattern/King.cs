using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class King
    {
        public string name;

        private static King unserKoenig;

        public static King getInstance()
        {
            if (unserKoenig == null)
            {
                unserKoenig = new King();
            }
            return unserKoenig;
        }
        public King()
        {

        }
        public void setName(string koenig)
        {
            name = koenig;
        }
        public string AngriffsBefehl()
        {
            return name + " befiehlt: Wir greifen an!";
        }
        public string RueckzugsBefehl()
        {
            return name + " befiehlt: Wir ziehen uns zu!";
        }
    }
}
