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
        private static MoveDown _instance;
        protected MoveDown()
        {

        }
        public static MoveDown Instance()
        {
            if (_instance == null)
            {
                _instance = new MoveDown();
            }
            return _instance;
        }
        public override void Move()
        {
            if (this._CarContext.isOver)
                return;

            SetImage();

            Move_Down();

            StateTransit();

        }

        private void StateTransit()
        {
            if (this._CarContext._Up)
                this._CarContext.TransitionTo(MoveUp.Instance());

            else if (this._CarContext._Right)
                this._CarContext.TransitionTo(MoveRight.Instance());

            else if (this._CarContext._Left)
                this._CarContext.TransitionTo(MoveLeft.Instance());
        }
        private void Move_Down()
        {
            if (this._CarContext.Bottom < 420)
                this._CarContext.Top += this._CarContext.Speed;
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
