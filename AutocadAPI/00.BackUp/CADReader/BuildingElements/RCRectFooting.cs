﻿using CADReader.Base;
using devDept.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADReader.BuildingElements
{
   public class RCRectFooting: FootingBase
    {
       
        public override string Type { get; set; } = "RC";
         
        public RCRectFooting(double _width, double _length,double _thickness, Point3D _cntrPt, Point3D _ptLngthDir)
        {
            Width = _width;
            Length = _length;
            CenterPt = _cntrPt;
            PtLengthDir = _ptLngthDir;
            Thickness = _thickness;
        }
    }
}
