using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTCG
{
    internal class Card
    {
        private readonly int _damage;
        public enum ElementType 
        { 
            Fire = 1,
            Water = 2,
            Normal = 3 
        }
        public Card() { }
        public virtual int Play() { return _damage; }
    }
}


// Readonly: public int Anything { set; init; }
// https://dotnettutorials.net/lesson/factory-design-pattern-csharp/