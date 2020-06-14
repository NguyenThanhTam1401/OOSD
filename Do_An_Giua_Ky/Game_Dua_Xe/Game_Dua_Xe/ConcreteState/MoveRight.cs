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

        private static MoveRight _instance;
        protected MoveRight()
        {

        }
        public static MoveRight Instance()
        {
            if (_instance == null)
            {
                _instance = new MoveRight();
            }
            return _instance;
        }

        public override void Move()
        {
            if (this._CarContext.isOver)
                return;
            SetImage();
            Move_Right();



            StateTransit();
        }

        private void Move_Right()
        {
            if (this._CarContext.Right < 280)
                this._CarContext.Left += this._CarContext.Speed;
        }
        public override void StateTransit()
        {
            if (this._CarContext._Up)
                this._CarContext.TransitionTo(MoveUp.Instance());
            else if (this._CarContext._Down)
                this._CarContext.TransitionTo(MoveDown.Instance());
            else if (this._CarContext._Left)
                this._CarContext.TransitionTo(MoveLeft.Instance());
        }
        public override void SetImage()
        {
            this._CarContext.Image = Game_Dua_Xe.Properties.Resources.policeRight;
        }

    }
}
