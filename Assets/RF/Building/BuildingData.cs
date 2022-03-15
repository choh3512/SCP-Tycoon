using System;
using UnityEngine;

namespace RF.Building
{
    public enum BuildingType
    {
        None,
        Room,
        Elevator,
    }
    
    [CreateAssetMenu(menuName =  "ScriptableObject/Building", order = 0)]
    public class BuildingData:ScriptableObject
    {
        public string title = "";
        public string desc = "";

        public BuildingType buildingType;
        
        public int price = 0;
        public float spawnTime = 0F;

        public Vector2 cellSize;

        public string viewPrefabDir = "";
    }
}
