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
        public override void GetStateString()
        {
            this._CarContext.StateString = "Normal State";
        }

        public override void Move()
        {
            SetImage();
            GetStateString();
            if (this._CarContext._Up)
                this._CarContext.TransitionTo(new MoveUp());

            else if (this._CarContext._Down)
                this._CarContext.TransitionTo(new MoveDown());

            else if (this._CarContext._Right)
                this._CarContext.TransitionTo(new MoveRight());

            else if (this._CarContext._Left)
                this._CarContext.TransitionTo(new MoveLeft());
        }

        public override void SetImage()
        {
            this._CarContext.Image = Game_Dua_Xe.Properties.Resources.police;
        }
    }
}
