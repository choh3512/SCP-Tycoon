using System;
using UnityEngine;

namespace RF.CustomDebug
{
    public class DebugManager : MonoBehaviour
    {
        #region 싱글톤

        private static DebugManager _instance;

        public static DebugManager Instance
        {
            set { _instance = value;}
            get { return _instance; }
        }
        #endregion
        
        #region 유니티 기본 내장 함수

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(this);
            }
            else
            {
                Destroy(this.gameObject);
            }

            if (DebugData.IsDebugDebugManager)
            {
                Debug.Log("AWAKE : 디버그 매니저 로드");
            }
        }

        private void Start()
        {
            if (DebugData.IsDebugDebugManager)
            {
                Debug.Log("START : 디버그 매니저 로드");
            }            
        }

        private void Update()
        {
            
        }
        #endregion
        
        #region 디버그

        public void Log<T>(T type, object obj)
        {
            Debug.Log("["+type.GetType().Name + "] : " + obj.ToString());
        }
        #endregion
    }
}
