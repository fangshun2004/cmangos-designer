﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Db
{
    public class GameObjectDto
    {
        public int Guid { get; set; }
        public int Id { get; set; }
        public int Map { get; set; }
        public int SpawnMask { get; set; }
        public int PhaseMask { get; set; }
        public float PositionX { get; set; }
        public float PositionY { get; set; }
        public float PositionZ { get; set; }
        public float Orientation { get; set; }
        public float Rotation0 { get; set; }
        public float Rotation1 { get; set; }
        public float Rotation2 { get; set; }
        public float Rotation3 { get; set; }
        public int SpawnTimeSecsMin { get; set; }
        public int SpawnTimeSecsMax { get; set; }
        public int AnimProgress { get; set; }
        public int State { get; set; }

        public string GenerateSQL(bool phaseMask)
        {
            string output = "(" + Guid + "," + Id + "," + Map + "," + SpawnMask + (phaseMask ? ("," + PhaseMask) : "") + "," + PositionX.ToString(CultureInfo.InvariantCulture) + "," + PositionY.ToString(CultureInfo.InvariantCulture) + "," + PositionZ.ToString(CultureInfo.InvariantCulture) + "," + Orientation.ToString(CultureInfo.InvariantCulture) + "," + Rotation0.ToString(CultureInfo.InvariantCulture) + "," + Rotation1.ToString(CultureInfo.InvariantCulture) + "," + Rotation2.ToString(CultureInfo.InvariantCulture) + "," + Rotation3.ToString(CultureInfo.InvariantCulture) + "," + SpawnTimeSecsMin + "," + SpawnTimeSecsMax + "," + AnimProgress + "," + State + ")";
            return output;
        }
    }

    public class GameObjectParser
    {
        public string Guid { get; set; }
        public int Id { get; set; }
        public uint Map { get; set; }
        public int SpawnMask { get; set; }
        public int PhaseMask { get; set; }
        public string PositionX { get; set; } = string.Empty;
        public string PositionY { get; set; } = string.Empty;
        public string PositionZ { get; set; } = string.Empty;
        public string Orientation { get; set; } = string.Empty;
        public string Rotation0 { get; set; } = string.Empty;
        public string Rotation1 { get; set; } = string.Empty;
        public string Rotation2 { get; set; } = string.Empty;
        public string Rotation3 { get; set; } = string.Empty;
        public int SpawnTimeSecsMin { get; set; }
        public int SpawnTimeSecsMax { get; set; }

        public string GenerateSQL(bool phaseMask)
        {
            string output = "(" + Guid + "," + Id + "," + Map + "," + SpawnMask + (phaseMask ? ("," + PhaseMask) : "") + "," + PositionX.ToString(CultureInfo.InvariantCulture) + "," + PositionY.ToString(CultureInfo.InvariantCulture) + "," + PositionZ.ToString(CultureInfo.InvariantCulture) + "," + Orientation.ToString(CultureInfo.InvariantCulture) + "," + Rotation0.ToString(CultureInfo.InvariantCulture) + "," + Rotation1.ToString(CultureInfo.InvariantCulture) + "," + Rotation2.ToString(CultureInfo.InvariantCulture) + "," + Rotation3.ToString(CultureInfo.InvariantCulture) + "," + SpawnTimeSecsMin + "," + SpawnTimeSecsMax + ")";
            return output;
        }
    }
}
