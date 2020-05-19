using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Dua_Xe
{
    public class MoveDown: MoveState
    {
        public override void GetStateString()
        {
            this._Car.StateString = "Move Down";
        }

        public override void Move()
        {
            if (this._Car.Bottom < 420)
                this._Car.Top += this._Car.Speed;
            if (this._Car.isOver)
                return;
            SetImage();
            GetStateString();

            if (this._Car._Up)
                this._Car.TransitionTo(new MoveUp());

            else if (this._Car._Right)
                this._Car.TransitionTo(new MoveRight());

            else if (this._Car._Left)
                this._Car.TransitionTo(new MoveLeft());

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
