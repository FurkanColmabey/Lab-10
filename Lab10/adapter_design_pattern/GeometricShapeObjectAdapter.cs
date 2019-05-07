using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter_design_pattern
{
    class GeometricShapeObjectAdapter : Shape
    {
        public GeometricShape sekiller;

        public GeometricShapeObjectAdapter(GeometricShape shape)
        {
            sekiller = shape;
        }
        public void draw( )
        {
            sekiller.drawShape();
        }        
            
    }
}
