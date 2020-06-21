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
        public void SetContext(CarContext context)
        {
            this._CarContext = context;
        }

        // Thực hiện di chuyển vị trí của Xe
        public abstract void Move();

        // Set image chô mỗi state
        public abstract void SetImage();

        // Chuyển sang state khác
        public abstract void StateTransit();
    }
}
