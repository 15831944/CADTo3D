﻿using devDept.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdaLibTrials.BuildingElements
{
    class RectFooting
    {
        private double width;
        private double length;
        private Point3D centerPt;
        private Point3D ptLengthDir;

        public RectFooting(double _width, double _length, Point3D _cntrPt, Point3D _ptLngthDir)
        {
            width = _width;
            length = _length;
            centerPt = _cntrPt;
            ptLengthDir = _ptLngthDir;
        }

        public Point3D PtLengthDir
        {
            get { return ptLengthDir; }
            set { ptLengthDir = value; }
        }


        public Point3D CenterPt
        {
            get { return centerPt; }
            private set { centerPt = value; }
        }

        public double Length
        {
            get { return length; }
            private set { length = value; }
        }

        public double Width
        {
            get { return width; }
            private set { width = value; }
        }
    }
}
