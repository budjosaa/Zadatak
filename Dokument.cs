using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DokumentClass
{
    class Dokument
    {
        private int jedinstvenBroj;
        public Dokument()
        {
            this.jedinstvenBroj = 0;
        }

        public void setJedinstveniBroj(int jedBroj)
        {
            this.jedinstvenBroj = jedBroj;
        }
    }
}
