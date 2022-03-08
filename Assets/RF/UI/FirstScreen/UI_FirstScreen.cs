using System.Collections;
using RF.UI.Base;
using RF.UI.FirstScreen;
using RF.UI.Loading;
using RF.UI.Logo;
using Sirenix.OdinInspector;
using UniRx;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace RF.UI
{
    public class UI_FirstScreen : UI_Base
    {
        #region MVP
        [Title("MVP")]
        [SerializeField]private UI_FirstScreen_Model ui_Model;
        [SerializeField]private UI_FirstScreen_View ui_View;      
        #endregion
        
        
        #region UI 오버라이드 함수
        public override void Initialize()
        {
            ui_Model = new UI_FirstScreen_Model();
            ui_Model.Initialize();
            //CustomDebug.DebugManager.Instance.Log(this, "Initialize");
            
            logoScreen.gameObject.SetActive(true);
        }
        #endregion        
        
        #region 로고 
        [SerializeField]private UI_LogoScreen logoScreen;
        #endregion
        
        #region 로딩 
        [SerializeField]private UI_LoadingScreen loadingScreen;
        #endregion
    }
}
