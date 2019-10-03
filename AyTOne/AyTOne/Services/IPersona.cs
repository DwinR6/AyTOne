using System;
using System.Collections.Generic;
using System.Text;

namespace AyTOne.Services
{
    public interface IPersona
    {
        string Presentarse();
        void DarIformacionConfidencial(string TipoPersona);
    }
}
