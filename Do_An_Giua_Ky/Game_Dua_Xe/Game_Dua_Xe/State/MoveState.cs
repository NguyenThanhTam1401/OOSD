using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Dua_Xe
{
    public abstract class MoveState
    {
        protected Car _Car;
        public void SetCar(Car car)
        {
            this._Car = car;
        }

        public abstract void Move();
        public abstract void SetImage();
        public abstract void GetStateString();
    }
}
