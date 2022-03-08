using UnityEngine;

namespace RF.Player
{
    public class PlayerData
    {
        #region 초기화 
        public void Initialize()
        {
            SetLevel(PlayerPrefs.GetInt("level", 1));
            SetExp(PlayerPrefs.GetInt("exp", 0));
            
        }
        #endregion
        
        #region 레벨

        private int _level = 0;

        public void SetLevel(int num)
        {
            _level = num;
        }
        
        public int GetLevel()
        {
            return _level;
        }

        #endregion
        
        #region 경험치

        private int _exp = 0;

        public void SetExp(int num)
        {
            _exp = num;
        }

        public int GetExp()
        {
            return _exp;
        }

        #endregion
    }
}
