using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Dua_Xe
{
    public class MoveRight:MoveState
    {
        public override void Move()
        {
            if (this._CarContext.isOver)
                return;
            SetImage();
            Move_Right();

            

            StateStransit();
        }

        private void Move_Right()
        {
            if (this._CarContext.Right < 280)
                this._CarContext.Left += this._CarContext.Speed;
        }
        private void StateStransit()
        {
            if (this._CarContext._Up)
                this._CarContext.TransitionTo(new MoveUp());
            else if (this._CarContext._Down)
                this._CarContext.TransitionTo(new MoveDown());
            else if (this._CarContext._Left)
                this._CarContext.TransitionTo(new MoveLeft());
        }
        public override void SetImage()
        {
            this._CarContext.Image = Game_Dua_Xe.Properties.Resources.policeRight;
        }

    }
}
