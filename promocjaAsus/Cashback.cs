using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using promocjaAsus;


namespace promocjaAsus
{
    class Cashback
    {
        public Dictionary<Mobo, CbValues> values = new Dictionary<Mobo, CbValues>();
        public decimal getCashbackValue(Mobo moboName, CPU cpuName)
        {
            return values[moboName].getCbValue(cpuName);
        }
        public Cashback()
        {
            values.Add(Mobo.MAXIMUS_VIII_EXTREME, new CbValues(Mobo.MAXIMUS_VIII_EXTREME, 680,  630,  760,  630));
            values.Add(Mobo.MAXIMUS_VIII_HERO_ALPHA, new CbValues(Mobo.MAXIMUS_VIII_HERO_ALPHA, 590,  550,  680,  550));
            values.Add(Mobo.MAXIMUS_VIII_HERO, new CbValues(Mobo.MAXIMUS_VIII_HERO, 590,  550,  680,  550));
            values.Add(Mobo.MAXIMUS_VIII_RANGER, new CbValues(Mobo.MAXIMUS_VIII_RANGER, 550,  510,  630,  510));
            values.Add(Mobo.MAXIMUS_VIII_GENE, new CbValues(Mobo.MAXIMUS_VIII_GENE, 510,  460,  590,  460));
            values.Add(Mobo.MAXIMUS_VIII_IMPACT, new CbValues(Mobo.MAXIMUS_VIII_IMPACT, 590,  550,  680,  550));
            values.Add(Mobo.Z170_DELUXE, new CbValues(Mobo.Z170_DELUXE,  590,  550,  680,  550));
            values.Add(Mobo.Z170I_PRO_GAMING, new CbValues(Mobo.Z170I_PRO_GAMING, 510,  460,  590,  460));
            values.Add(Mobo.Z170_PRO_GAMING_AURA, new CbValues(Mobo.Z170_PRO_GAMING_AURA ,  460,  420,  550,  420));
            values.Add(Mobo.Z170_PRO_GAMING, new CbValues(Mobo.Z170_PRO_GAMING ,460,  420,  550,  420));
            values.Add(Mobo.Z170_A, new CbValues(Mobo.Z170_A,  420,  380,  510,  380));
            values.Add(Mobo.Z170_E, new CbValues(Mobo.Z170_E ,380,  340,  460,  340));
            values.Add(Mobo.Z170M_E_D3, new CbValues(Mobo.Z170M_E_D3, 380,  340,  460,  340));
            values.Add(Mobo.Z170_WS, new CbValues(Mobo.Z170_WS, 380,  340,  460,  340));
            values.Add(Mobo.MAXIMUS_IX_EXTREME, new CbValues(Mobo.MAXIMUS_IX_EXTREME, 590, 550, 680, 550));
            values.Add(Mobo.MAXIMUS_IX_FORMULA, new CbValues(Mobo.MAXIMUS_IX_FORMULA, 510,    460,    590,    460));
            values.Add(Mobo.MAXIMUS_IX_CODE, new CbValues(Mobo.MAXIMUS_IX_CODE, 460,    420,    550,    420));
            values.Add(Mobo.MAXIMUS_IX_APEX, new CbValues(Mobo.MAXIMUS_IX_APEX, 460,    420,    550,    420));
            values.Add(Mobo.MAXIMUS_IX_HERO, new CbValues(Mobo.MAXIMUS_IX_HERO, 460,    420,    550,    420));
            values.Add(Mobo.TUF_Z270_MARK_1, new CbValues(Mobo.TUF_Z270_MARK_1, 460,    420,    550,    420));
            values.Add(Mobo.STRIX_Z270E_GAMING, new CbValues(Mobo.STRIX_Z270E_GAMING, 420,    380,    510,    380));
            values.Add(Mobo.STRIX_Z270G_GAMING, new CbValues(Mobo.STRIX_Z270G_GAMING,  420,    380,    510,    380));
            values.Add(Mobo.STRIX_Z270F_GAMING, new CbValues(Mobo.STRIX_Z270F_GAMING, 420,    380,    510,    380));
            values.Add(Mobo.STRIX_Z270H_GAMING, new CbValues(Mobo.STRIX_Z270H_GAMING, 380,    340,    460,    340));
            values.Add(Mobo.STRIX_Z270I_GAMING, new CbValues(Mobo.STRIX_Z270I_GAMING , 420,    380,    510,    380));
            values.Add(Mobo.PRIME_Z270_A, new CbValues(Mobo.PRIME_Z270_A,   380,    340,    460,    340));
            values.Add(Mobo.TUF_Z270_MARK_2, new CbValues(Mobo.TUF_Z270_MARK_2, 380,    340,    460,    340));
            values.Add(Mobo.PRIME_Z270_K, new CbValues(Mobo.PRIME_Z270_K,   360,    320,    440,    320));
            values.Add(Mobo.PRIME_Z270_P, new CbValues(Mobo.PRIME_Z270_P,  340,    300,    420,    300));
            values.Add(Mobo.PRIME_Z270M_PLUS, new CbValues(Mobo.PRIME_Z270M_PLUS ,  380,    340,    460,    340));
        }

    }
    class CbValues
    {
        Mobo name;
        decimal pi7_7700K, pi5_7600K, pi7_6700K, pi5_6600K;

        public CbValues(Mobo n, decimal p7700K, decimal p7600K, decimal p6700K, decimal p6600K )
        {
            name = n;
            pi7_7700K = p7700K;
            pi5_7600K = p7600K;
            pi7_6700K = p6700K;
            pi5_6600K = p6600K;
        }

        public decimal getCbValue(CPU cpuName)
        {
            switch(cpuName)
            {
                case CPU.i7_7700K:
                    return pi7_7700K;
                case CPU.i5_7600K:
                    return pi5_7600K;
                case CPU.i7_6700K:
                    return pi7_6700K;
                case CPU.i5_6600K:
                    return pi5_6600K;
            }
            return 0m;
        }
    }
}
