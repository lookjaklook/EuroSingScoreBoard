﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bas.EuroSing.ScoreBoard.Messages
{
    internal enum ResultsState
    {
        None = 0,
        SplashScreen,
        RevealCountry,
        FirstGroupOfPoints,
        EightPoints,
        TenPoints,
        TwelvePoints,
        RevealWinner
    }
}
