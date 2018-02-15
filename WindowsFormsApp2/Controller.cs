using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Controller
    {
        List<Listener> listeners;
        public Controller()
        {
            listeners = new List<Listener>();
        }
        public void getInput(string s)
        {
            listeners.ForEach(x => x.update(s));
        }

        public void subscribe(Listener listener)
        {
            listeners.Add(listener);
        }

    }
}

