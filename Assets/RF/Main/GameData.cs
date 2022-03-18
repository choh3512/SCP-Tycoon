using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using RF.Building;
using RF.Exploration;
using UnityEngine;

namespace RF.Main
{
    public class GameData
    {
        #region 게임 머니
        private int _money = 0;
        public int Money
        {
            get { return _money;}
            set { _money = value; }
        }
        #endregion
        
        #region 게임 캐쉬
        private int _cash = 0;
        public int Cash
        {
            get { return _cash; }
            set { _cash = value; }
        }
        #endregion
        
        #region 재료
        private List<int> _ingredients = new List<int>();
        public List<int> Ingredients
        {
            get { return _ingredients; }
            set { _ingredients = value; }
        }
        #endregion
        
        #region 건물 인벤토리
        private Dictionary<BuildingType, List<BuildingData>> _buildingInv = new Dictionary<BuildingType, List<BuildingData>>();

        public Dictionary<BuildingType, List<BuildingData>> BuildingInv
        {
            get
            {
                foreach (var tab in _buildingInv)
                {
                    CustomDebug.DebugManager.Instance.Log(this, "KEY : " + tab.Key + " \nValue : " + tab.Value + "\nNums : " + _buildingInv[tab.Key].Count);
                }
                
                return _buildingInv;
            }
        }
        #endregion
        
        #region 탐사 데이터
        private List<ExploreData> _exploreDatas = new List<ExploreData>();
        public List<ExploreData> ExploreDatas
        {
            get { return _exploreDatas; }
            set { _exploreDatas = value; }
        }
        #endregion
    }
}
