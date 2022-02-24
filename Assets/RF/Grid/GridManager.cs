using System.Collections.Generic;
using UnityEngine;

namespace RF.Grid
{
    public class GridManager : MonoBehaviour
    {
        #region 그리드 맵
        private List<GridMapData> gridMaps = new List<GridMapData>();

        public List<GridMapData> GetGridMaps()
        {
            return gridMaps;
        }

        public GridMapData GetGridMap(int index)
        {
            return gridMaps[index];
        }

        public void CreateGridMap()
        {
            GridMapData map = new GridMapData();
            map.Initialize();
            
            gridMaps.Add(map);
        }
        #endregion
    }

    public class GridMapData
    {
        public GridData[,] mapData;

        public void Initialize()
        {
            mapData = new GridData[20, 20];

            for (int x = 0; x < mapData.Length/2; x++)
            {
                for (int y = 0; y < mapData.Length / 2; y++)
                {
                    mapData[x, y] = new GridData();
                    mapData[x, y].x = x;
                    mapData[x, y].y = y;
                }
            }
        }
    }

    public class GridData
    {
        public int x = 0, y = 0;
        public GridBuildData buildData = null;

        public bool CanBuild()
        {
            return buildData != null;
        }
    }
}
