using System;
using RF.CustomDebug;
using Sirenix.OdinInspector;
using UnityEngine;

namespace RF.Main
{
    public class Main : MonoBehaviour
    {
        #region 싱글톤
        private static Main _instance;

        public static Main Instance
        {
            get { return _instance; }
            set { _instance = value; }
        }
        #endregion
        
        #region 유니티 기본 내장 함수
        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }

            if (DebugData.IsDebugMain)
            {
                Debug.Log("AWAKE : 메인 시스템 로드");  
            }
        }

        private void Start()
        {
            if (DebugData.IsDebugMain)
            {
                Debug.Log("START : 메인 시스템 로드");  
            }           
        }

        private void Update()
        {
            
        }
        #endregion
        
        #region 데이터 로드
        private GameData _gameData = new GameData();

        public GameData GameData
        {
            get { return _gameData; }
            set { _gameData = value; }
        }
        #endregion
    }
}
