using System;
using UnityEngine;

namespace RF.UI.Manager
{
    public class UI_Manager : MonoBehaviour
    {
        #region 싱글톤

        public static UI_Manager instance;
        #endregion
        
        #region 유니티 기본 내장 함수
        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }

        private void Start()
        {
            
        }

        private void Update()
        {
            
        }
        #endregion
        
        #region 팝업
        public void CreatePopup(Transform parent, string popupName)
        {
            GameObject popupObj = Instantiate(Resources.Load("Prefabs/UI/" + popupName) as GameObject, parent);
            popupObj.transform.SetParent(parent);
        }
        #endregion
    }
}
