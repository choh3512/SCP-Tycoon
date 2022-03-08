using System;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace RF.Grid
{
    public class GridManager : MonoBehaviour
    {
        #region 유니티 기본 내장 함수

        private void Awake()
        {
            CreateGridMap();
            SelectGridMap(0);
            
            GenerateLines();
        }

        public void OnDrawGizmos()
        {
            if (selData != null)
            {
                for (int x = 0; x < selData.mapData.Length / 2; x++)
                {
                    //indices.Add(x);
                    for (int y = 0; y < selData.mapData.Length / 2; y++)
                    {
                        Gizmos.DrawWireCube(new Vector3(x*4, y*4), new Vector3(4,4));
                    }
                }                
            }
        }

        #endregion
    
        #region 그리드 맵

        [Title("그리드 맵")] 
        [SerializeField] private MeshRenderer meshRenderer;
        [SerializeField] private MeshFilter meshFilter;
        //[SerializeField] private LineRenderer lineRenderer;
        
        private List<GridMapData> gridMaps = new List<GridMapData>();

        private GridMapData selData;

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

        public GridMapData SelectGridMap(int num)
        {
            selData = gridMaps[num];

            return selData;
        }

        private void GenerateLines()
        {
            
            /*Mesh mesh = new Mesh();
            
            mesh.Clear();
            
            List<Vector3> verticles = new List<Vector3>();
            int[] tris = new int[6];
            List<int> indices = new List<int>();
            
            if (selData != null)
            {
                for (int x = 0; x < selData.mapData.Length / 2; x++)
                {
                    //indices.Add(x);
                    for (int y = 0; y < selData.mapData.Length / 2; y++)
                    {
                        verticles.Add(new Vector3(x * 4, y * 4));
                        verticles.Add(new Vector3(x * 4, y * 4 + 4));

                    }
                }                
            }

            int triIndex = 0;
            for (int i = 0; i < 2; i++)
            {
                tris[0] = 0;
                tris[1] = tris[4] = 1;
                tris[2] = tris[3] = 2;
                tris[5] = 3;
            }

            mesh.SetVertices(verticles);
            //mesh.SetTriangles(tris, 0);
            mesh.SetIndices(indices, MeshTopology.Lines, 0);

            mesh.RecalculateNormals();

            meshFilter.mesh = mesh;*/
        }
        #endregion
    }

    public class GridMapData
    {
        public GridData[,] mapData;

        public void Initialize()
        {
            mapData = new GridData[10, 10];

            for (int x = 0; x < mapData.Length/10; x++)
            {
                for (int y = 0; y < mapData.Length / 10; y++)
                {
                    Debug.Log("x : " + mapData.Length/10);
                    mapData[x, y] = new GridData {x = x, y = y};
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
