using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Dua_Xe
{
    public class MoveUp:MoveState
    {
        public override void GetStateString()
        {
            this._Car.StateString = "Move Up";
        }

        public override void Move()
        {
            if (this._Car.Top > 15)
                this._Car.Top -= this._Car.Speed;
            if (this._Car.isOver)
                return;
            SetImage();
            GetStateString();
            //if (this._Car._Up)
            //    this._Car.TransitionTo(new MoveUp());

            if (this._Car._Down)
                this._Car.TransitionTo(new MoveDown());

            else if (this._Car._Right)
                this._Car.TransitionTo(new MoveRight());

            else if (this._Car._Left)
                this._Car.TransitionTo(new MoveLeft());

            //else this._Car.TransitionTo(new NormalState());
        }

        public override void SetImage()
        {
            if (this._Car._Left)
                this._Car.Image = Game_Dua_Xe.Properties.Resources.policeLeft;
            else if (this._Car._Right)
                this._Car.Image = Game_Dua_Xe.Properties.Resources.policeRight;
            else
                this._Car.Image = Game_Dua_Xe.Properties.Resources.police;
        }
    }
}
