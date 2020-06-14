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
        public void SetContext(CarContext car)
        {
            this._CarContext = car;
        }
        // Thực hiện di chuyển vị trí của Xe
        public abstract void Move();

        // Set image chô mỗi state
        public abstract void SetImage();

        // Chuyển sang state khác
        public abstract void StateTransit();
    }
}
