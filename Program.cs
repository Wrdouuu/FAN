using System.Reflection.Metadata;

namespace FAN
{
    public class FAN
    {
        //3 hằng được đặt tên là SLOW, MEDIUM, và FAST với giá trị 1, 2, và 3 để biểu thị tốc độ quạt.//
        const int SLOW = 1;
        const int MEDIUM = 2;
        const int FAST = 3;

        //Trường speed có kiểu số nguyên (private int) để xác định tốc độ quạt, mặc định là SLOW//

        private int speed = SLOW;

        //Trường on có kiểu private bool để xác định quạt đang bật hay tắt, mặc định là false (tắt).//

        private bool on = false;

        //Trường radius có kiểu private double để xác định bán kính quạt, giá trị mặc định là 5//

        private double radius = 5;

        //Trường color có kiểu dữ liệu private string để xác định màu quạt, mặc định là blue//
        private string color = "Blue";

        //Các getter và setter cho các thuộc tính//
         public int getSpeed()
        {
            return speed;
        }
        public void setSpeed(int _speed)
        {
            speed = _speed;
        }
        public bool getOn()
        {
            return on;
        }
        public void setOn(bool _on)
        {
            on = _on;
        }
        public double getRadius()
        {
            return radius;
        }
        public void setRadius(double _radius)
        {
            radius = _radius;
        }
        public string getColor()
        {
            return color;
        }
        public void setColor(string _color)
        {
            color = _color;
        }
        //Phương thức khởi tạo không tham số tạo đối tượng fan mặc định
        public FAN() { }
        public FAN(int _speed, bool _on, double _radius, string _color)
        {
            speed = _speed;
            on = _on;
            radius = _radius;
            color = _color;
        }
         //Phương thức ToString() trả về chuỗi chứa thông tin của quạt.
        //Nếu quạt đang ở trạng thái on, phương thức trả về speed, color,
        //và radius với chuỗi “fan is on”. Nếu quạt không ở trạng thái on,
        //phương thức trả về color, radius với chuỗi “fan is off”.
          public string ToString()
        {
            string info = "";
            if (on)
            {
                info = "fan is on, ” + speed + “, ” + color + “, ” + radius";
            }
            else
            {
                info = "fan is off, ” + color + “, ” + radius";
            }
            return info;
        }
    }
}
