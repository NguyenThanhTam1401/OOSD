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
            this._Car.StateString = "Normal State";
        }

        public override void Move()
        {
            SetImage();
            GetStateString();
            if (this._Car._Up)
                this._Car.TransitionTo(new MoveUp());

            else if (this._Car._Down)
                this._Car.TransitionTo(new MoveDown());

            else if (this._Car._Right)
                this._Car.TransitionTo(new MoveRight());

            else if (this._Car._Left)
                this._Car.TransitionTo(new MoveLeft());
        }

        public override void SetImage()
        {
            this._Car.Image = Game_Dua_Xe.Properties.Resources.police;
        }
    }
}
