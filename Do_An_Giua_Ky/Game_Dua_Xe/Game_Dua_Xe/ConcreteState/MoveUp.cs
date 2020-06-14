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
        private static MoveUp _instance;
        protected MoveUp()
        {

        }
        public static MoveUp Instance()
        {
            if (_instance == null)
            {
                _instance = new MoveUp();
            }
            return _instance;
        }

        public override void Move()
        {
            //không làm gì nếu đã kết thúc!
            if (this._CarContext.isOver)
                return;
            SetImage();
            Move_Up();

            StateTransit();
        }

        //Set image cho Xe
        public override void SetImage()
        {
            this._CarContext.Image = Game_Dua_Xe.Properties.Resources.police;
        }
        //Dời vị trí của Xe lên.
        private void Move_Up()
        {
            if (this._CarContext.Top > 15)
                this._CarContext.Top -= this._CarContext.Speed;
        }
        
        //Chuyển qua các sate khác
        private void StateTransit()
        {
            if (this._CarContext._Down)
                this._CarContext.TransitionTo(MoveDown.Instance());

            else if (this._CarContext._Right)
                this._CarContext.TransitionTo(MoveRight.Instance());

            else if (this._CarContext._Left)
                this._CarContext.TransitionTo(MoveLeft.Instance());
        }
    }
}
