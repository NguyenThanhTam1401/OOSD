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
        protected CarContext _CarContext;
        public void SetCar(CarContext car)
        {
            this._CarContext = car;
        }

        public abstract void Move();
        public abstract void SetImage();
        public abstract void GetStateString();
    }
}
