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
            this._CarContext.StateString = "Move Down";
        }

        public override void Move()
        {
            if (this._CarContext.Bottom < 420)
                this._CarContext.Top += this._CarContext.Speed;
            if (this._CarContext.isOver)
                return;
            SetImage();
            GetStateString();

            if (this._CarContext._Up)
                this._CarContext.TransitionTo(new MoveUp());

            else if (this._CarContext._Right)
                this._CarContext.TransitionTo(new MoveRight());

            else if (this._CarContext._Left)
                this._CarContext.TransitionTo(new MoveLeft());

        }

        public override void SetImage()
        {
            if (this._CarContext._Left)
                this._CarContext.Image = Game_Dua_Xe.Properties.Resources.policeLeft;
            else if (this._CarContext._Right)
                this._CarContext.Image = Game_Dua_Xe.Properties.Resources.policeRight;
            else
                this._CarContext.Image = Game_Dua_Xe.Properties.Resources.police;
        }
    }
}
