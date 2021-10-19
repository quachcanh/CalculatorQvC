using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayTinhCalculator
{
    public class TinhToan
    {
        double giatri1, giatri2;

        // Hàm khỏi tạo
        public TinhToan()
        {

        }

        // Hàm khỏi tạo có tham số
        public TinhToan(double gt1, double gt2)
        {
            giatri1 = gt1;
            giatri2 = gt2;
        }

        //Hàm tính phép cộng
        public double PhepCong()
        {
            return (giatri1 + giatri2);
        }

        public double PhepTru()
        {
            return (giatri1 - giatri2);
        }

        public double PhepNhan()
        {
            return (giatri1 * giatri2);
        }

        public double PhepChia()
        {
            return (giatri1 / giatri2);
        }
    }
}
