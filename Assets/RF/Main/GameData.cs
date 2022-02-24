using System;
using System.Collections.Generic;
using JetBrains.Annotations;
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
        
        #region 생산 시간
        private List<DateTime> _createTimes = new List<DateTime>();
        public List<DateTime> CreateTimes
        {
            get { return _createTimes; }
            set { _createTimes = value; }
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
