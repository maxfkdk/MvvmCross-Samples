﻿using System;

namespace FractalGen.Core.Services.Fractal
{
    public class InterestingPointGenerator : IInterestingPointGenerator
    {
        private readonly double[][] _boundaries = new[]
            {
                new[] {-2.1, -1.0, -1.3, 1.3},
                new[] {-1.8, 0.7, -1, 1},
                new[]
                    {
                        -1.30989899,
                        -1.19878788,
                        -0.40390572,
                        -0.26922559
                    },
                new[]
                    {
                        0.28689
                        , 0.28694
                        , 0.0142
                        , 0.0143
                    },
                new[]
                    {
                        0.382116699
                        , 0.402429199
                        , 0.261474609
                        , 0.283349609
                    },
                new[]
                    {
                        -5.0
                        , 2
                        , -4
                        , 4
                    },
                new[]
                    {
                        -1.291601
                        , -1.129101
                        , -0.4046875
                        , -0.2296875
                    },
                new[]
                    {
                        -1.195434570
                        , -1.175122070
                        , -0.31257324
                        , -0.29069824
                    },
                new[]
                    {
                        -1.185322952
                        , -1.184688186
                        , -0.3001724243
                        , -0.299488830
                    },
                new[]
                    {
                        -1.185040283
                        , -1.185000610
                        , -0.299955797
                        , -0.299913072
                    },
                new[]
                    {
                        0.100756835,
                        0.182006835,
                        0.616259765,
                        0.703759765,
                    },
                new[]
                    {
                        0.103216552,
                        0.113372802,
                        0.632409667,
                        0.643347167,
                    },
                new[]
                    {
                        0.10804672,
                        0.10931625,
                        0.634268188,
                        0.635635375
                    },
                new[]
                    {
                        -0.95976,
                        -0.44651,
                        -0.51724,
                        -0.13362,
                    },
                new[]
                    {
                        -0.89694,
                        -0.82880,
                        -0.28442,
                        -0.23349,
                    },
                new[]
                    {
                        -0.87306,
                        -0.86155,
                        -0.24684,
                        -0.23823,
                    },
                new[]
                    {
                        -0.86456,
                        -0.86198,
                        -0.24157,
                        -0.23965,
                    },
                new[]
                    {
                        -0.86431,
                        -0.86433,
                        -0.24140,
                        -0.24134,
                    },
                new[]
                    {
                        0.34366,
                        0.34781,
                        0.38979,
                        0.39289,
                    },
                new[]
                    {
                        -0.07969,
                        -0.07948,
                        0.86352,
                        0.86368,
                    },
                new[]
                    {
                        -0.084277,
                        -0.06760,
                        0.85675,
                        0.86922,
                    },
                new[]
                    {
                        0.13953,
                        0.20419,
                        -0.60390,
                        -0.55558,
                    },
                new[]
                    {
                        0.17786,
                        0.18578,
                        -0.58574,
                        -0.57982,
                    },
                new[]
                    {
                        0.18225,
                        0.18404,
                        -0.58257,
                        -0.58123,
                    },
            };

        private readonly Random _random = new Random();

        public Limits Generate()
        {
            var which = _random.Next(_boundaries.GetLength(0));
            var boundary = _boundaries[which];
            return new Limits
                {
                    XMin = boundary[0],
                    XMax = boundary[1],
                    YMin = boundary[2],
                    YMax = boundary[3]
                };
        }
    }
}