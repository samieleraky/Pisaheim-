using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pisaheim;
using System.Threading.Tasks;

namespace Pisaheim
{
    //Merchandise is an abstract class, which means it cannot be instantiated directly. It can only be used as a base class for other classes. 
    public abstract class Merchandise
    {
        public string _itemId;

        //public Merchandise(string itemId)
        //{
        //    _itemId = itemId;
        //}

        public override string ToString()
        {
            return $"ItemId: {_itemId}";
        }
    }
}
