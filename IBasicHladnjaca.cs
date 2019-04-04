using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoceClass;

namespace IBasicHladnjacaInterface
{
    interface IBasicHladnjaca
    {
        double otkupiVoce(List<Voce> voce);
        List<Voce> pregledVoca();
    }
}
