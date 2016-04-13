using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biz
{
    public class Test
    {
        public delegate void FireHandler(String txt);
        public FireHandler handler;

        //method deep down
        //metods already doesn't return a value
        //want to fire many actions, methods, at same time
        //solve the issue of circular reference
        //async method calls
        public void Read(bool value)
        {
            if(!value)
           //ask the delegate to publish; alert subscribers
            handler("Error");

        }
        public void Level3(bool value)
        {

            Read(value);

        }
        public void Level1(bool value)
        {

            Level2(value);

        }
        public void Level2(bool value)
        {

            Level3(value);

        }

       
    }
}
