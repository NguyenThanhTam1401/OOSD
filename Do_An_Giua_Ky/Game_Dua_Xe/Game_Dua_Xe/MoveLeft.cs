using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Dua_Xe
{
    public class MoveLeft:MoveState
    {
        public override void GetStateString()
        {
            this._Car.StateString = "Move Left";
        }

        public override void Move()
        {
            if (this._Car.Left > 5)
                this._Car.Left -= this._Car.Speed;
            if (this._Car.isOver)
                return;
            SetImage();
            GetStateString();

            if (this._Car._Up)
                this._Car.TransitionTo(new MoveUp());

            else if (this._Car._Down)
                this._Car.TransitionTo(new MoveDown());

            else if (this._Car._Right)
                this._Car.TransitionTo(new MoveRight());

            //else this._Car.TransitionTo(new NormalState());

        }

        public override void SetImage()
        {
            this._Car.Image = Game_Dua_Xe.Properties.Resources.policeLeft;
        }
    }
}
