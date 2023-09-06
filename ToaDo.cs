using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class ToaDo
    {
        private string ten;

        public string Ten
        {
          get { return ten; }
          set { ten = value; }
        }
        private float x;

        public float X
        {
          get { return x; }
          set { x = value; }
        }

        private float y;

        public float Y
        {
            get { return y; }
            set { y = value; }
        }
        public ToaDo()
        {

        }
        public ToaDo(string ten,float x,float y)
        {
            this.ten = ten;
            this.x = x;
            this.y = y;
        }
    }
}
