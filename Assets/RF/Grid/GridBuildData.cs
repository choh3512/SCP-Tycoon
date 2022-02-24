using System;

namespace RF.Grid
{
    public class GridBuildData
    {
        public DateTime spawnTime;
        
        public bool IsBuild()
        {
            return spawnTime <= DateTime.Now;
        }
    }
}
