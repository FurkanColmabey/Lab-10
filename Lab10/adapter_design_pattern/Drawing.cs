﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter_design_pattern
{
    class Drawing
    {
        List<Shape> shapes = null;
        public Drawing()
        {
            shapes = new List<Shape>();
        }
        public void addShape(Shape shape)
        {
            shapes.Add(shape);
        }
        public List<Shape> getShapes()
        {
            return shapes;
        }
        public void draw()
        {
            // shapes 'null değilse veya içerisinde 0 dan fazla eleman varsa tüm shapleri çizdir:
            if(shapes!=null)
            {

              foreach(Shape x in shapes)
                {
                    x.draw();
                }
            }
             
            
        }
      
    }
}
