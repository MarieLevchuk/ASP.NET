using System;

namespace Photographer
{
    public class Photographer
    {
        public string Name { get; set; }
        public ICamera Camera { get; set; }

        public Photographer (ICamera camera)
        {
            Camera = camera;
        }

        public void TakePhoto()
        {
            Camera.TakePhoto();
        }
        /*здесь ревлизован четвертый принцип SOLID - зависимость на абстракциях (с помощью
        интерейса ICamera*/
    }
}
