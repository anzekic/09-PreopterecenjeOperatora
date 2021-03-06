﻿using System;

namespace Vsite.CSharp
{
    // primjer preopterećivanja operatora za korisnički definiranu strukturu

    struct KompleksniBroj
    {
        public double RealniDio;
        public double ImaginarniDio;

        public KompleksniBroj(double realniDio, double imaginarniDio)
        {
            RealniDio = realniDio;
            ImaginarniDio = imaginarniDio;
        }

        public override string ToString()
        {
            if (ImaginarniDio == 0)
                return RealniDio.ToString();
            if (RealniDio == 0)
                return string.Format("{0}i", ImaginarniDio);
            if (ImaginarniDio < 0)
                return string.Format("{0} - {1}i", RealniDio, -ImaginarniDio);
            return string.Format("{0} + {1}i", RealniDio, ImaginarniDio);
        }

        public static KompleksniBroj operator +(KompleksniBroj br1, KompleksniBroj br2)
        {
            return new KompleksniBroj(br1.RealniDio + br2.RealniDio, br1.ImaginarniDio + br1.ImaginarniDio);
        }

        public static KompleksniBroj operator -(KompleksniBroj br1, KompleksniBroj br2)
        {
            return new KompleksniBroj(br1.RealniDio - br2.RealniDio, br1.ImaginarniDio - br1.ImaginarniDio);
        }

        public static KompleksniBroj operator -(KompleksniBroj br)
        {
            return new KompleksniBroj(-br.RealniDio, -br.ImaginarniDio);
        }

    }
}
