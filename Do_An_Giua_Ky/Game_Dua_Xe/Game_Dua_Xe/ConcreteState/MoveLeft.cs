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
        private static MoveLeft _instance;
        protected MoveLeft()
        {

        }
        public static MoveLeft Instance()
        {
            if (_instance == null)
            {
                _instance = new MoveLeft();
            }
            return _instance;
        }

        public override void Move()
        {
            if (this._CarContext.isOver)
                return;

            SetImage();

            Move_Left();

            StateTransit();
        }

        public override void StateTransit()
        {
            if (this._CarContext._Up)
                this._CarContext.TransitionTo(MoveUp.Instance());

            else if (this._CarContext._Down)
                this._CarContext.TransitionTo(MoveDown.Instance());

            else if (this._CarContext._Right)
                this._CarContext.TransitionTo(MoveRight.Instance());
        }
        private void Move_Left()
        {
            if (this._CarContext.Left > 5)
                this._CarContext.Left -= this._CarContext.Speed;
        }
        public override void SetImage()
        {
            this._CarContext.Image = Game_Dua_Xe.Properties.Resources.policeLeft;
        }
    }
}
