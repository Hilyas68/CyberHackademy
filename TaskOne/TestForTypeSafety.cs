using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne
{
    class TestForTypeSafety
    {
        public static void Main()
        {
            ArrayList list = new ArrayList()
            {
                1, "1", true, 4, 2, 6, 'a'
            };
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if(list[i] == typeof(int))
                {
                    sum += int.Parse(list[i].ToString());
                }
                
            }
               
        }
            
      }
}

