using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Window
    {
        protected int top;
        protected int left;

        //constructor takes two integers to fix location on the console
        public Window(int top, int left)
        {
            this.top = top;
            this.left = left;
        }
        //simulaters drawing the window
        public virtual void DrawWindow()
        {
            Console.WriteLine("Window: drawing Window at {0}, {1}", top,left );
        }
        //these members are protected and thus visible
        //to derived class methods. We will examine this later in the chapter

        
    }
}
