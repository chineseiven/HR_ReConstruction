﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace HR_ReConstruction
{
    class Network_Data
    {
        public class Layer
        {
            public double[] Node;
            public double[][] Weight;
            public double[] Bia;
            public double[][] NextLayerNode; 
            //[0] To access NoSigmoidResult double[], [1] To access SigmoidResult double[];
            public double[] Common_Derivative;
            public double[][] De_Weight;
            public double[] De_Bia;
            public double[] De_Node;
        }

        public class InputPixInfo //could simplefity?
        {
            public double[] PixInfo;
            public double LableNumber;
        }

        public class NeuralNetwork
        {
            public Layer FirstLayer;
            public Layer SecondLayer;
            public Layer OutputLayer;
        }
    }
}
