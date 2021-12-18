using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_2
{
    public class Card
    {
        public string Header { get; set; }
        public string Content { get; set; }
        public Person Person { get; set; }
        public Buyukluk Buyukluk { get; set; }
        public State State { get; set; }

    }
    public enum State
    {
        ToDo = 1,
        InProgress,
        Done
    }
    public enum Buyukluk
    {
        XS = 1,
        S,
        M,
        L,
        XL
    }

}
