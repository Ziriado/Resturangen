using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Restaurant
{
    internal class Graphics
    {
        public void Draw<T>(string header, int fromLeft, int fromTop, List<T> anyList)
        {
            string[] graphics = new string[anyList.Count];
            for (int i = 0; i < anyList.Count; i++)
            {
                if (anyList[i] is Guest)
                {
                    graphics[i] = (anyList[i] as Guest).Name;
                }
                else if (anyList[i] is Waitress)
                {
                    graphics[i] = (anyList[i] as Waitress).Name;
                }
                else if (anyList[i] is Chef)
                {
                    graphics[i] = (anyList[i] as Chef).Name;
                }

            }              
            GUI.Window.Draw(header, fromLeft, fromTop, graphics);
            
        }
        //public void DrawWaitress<T>(string header, int fromLeft, int fromTop, List<T> anyList)
        //{
        //    string[] graphics = new string[anyList.Count];
        //    for (int i = 0; i < anyList.Count; i++)
        //    {
        //        graphics[i] = (anyList[i] as Waitress).Name;
        //    }
        //    GUI.Window.Draw(header, fromLeft, fromTop, graphics);
        //}
    }
}