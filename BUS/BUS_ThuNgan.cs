using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ThuNgan
    {
        DAO_ThuNgan dao = new DAO_ThuNgan();
        public string getTenThuNgan(string maTN)
        {
            return dao.getTenThuNgan(maTN);
        }
    }
}
