using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Dua_Xe
{
    public class NormalState:MoveState
    {
        public override void Move()
        {
            //Set image của context
            SetImage();

            StateTransit();
        }

        public override void SetImage()
        {
            this._CarContext.Image = Game_Dua_Xe.Properties.Resources.police;
        }

        //Phương thức chuyển trạng thái
        private void StateTransit()
        {
            if (this._CarContext._Up)
                this._CarContext.TransitionTo(new MoveUp());

            else if (this._CarContext._Down)
                this._CarContext.TransitionTo(new MoveDown());

            else if (this._CarContext._Right)
                this._CarContext.TransitionTo(new MoveRight());

            else if (this._CarContext._Left)
                this._CarContext.TransitionTo(new MoveLeft());
        }

    }
}
