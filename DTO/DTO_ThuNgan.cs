using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ThuNgan
    {
        private string maTN;
        private string tenTN;

        public string MATHUNGAN { get => maTN; set => maTN = value; }
        public string HOTEN { get => tenTN; set => tenTN = value; }

        public DTO_ThuNgan(string maTN, string tenTN)
        {
            this.maTN = maTN;
            this.tenTN = tenTN;
        }
    }
}
