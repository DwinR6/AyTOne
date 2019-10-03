using System;
using System.Collections.Generic;
using System.Text;

namespace AyTOne.Services
{
    public interface ISoldier
    {
        string DeServicio(bool Estado);
        void ObtenerMision(string TipoOficial);

    }
}
