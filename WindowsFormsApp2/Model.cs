using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class Model : Listener
    {
        List<Listener> listeners;
        List<string> liststring = new List<string>();
        int num1, num2;
        char op;
        public string result { get; set; }
        string res = String.Empty;
        public Model()
        {
            listeners = new List<Listener>();
        }
        public void update(string s)
        {
           
            num1 = s[0] - '0' ;
            op = s[1];
            num2 = s[2] - '0';
            switch (op)
            {
                case '+':
                    res = (num1 + num2).ToString();
                    break;
                case '-':
                    res = (num1 - num2).ToString();
                    break;
                case '*':
                    res = (num1 * num2).ToString();
                    break;
                case '/':
                    res = (num1 / num2).ToString();
                    break;
            }
            result = s + "= " + res;
        }
        
    }

}
