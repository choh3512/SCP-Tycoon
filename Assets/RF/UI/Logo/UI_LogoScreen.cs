using RF.UI.Base;
using RF.UI.Loading;
using Sirenix.OdinInspector;
using UnityEngine;

namespace RF.UI.Logo
{
    public class UI_LogoScreen : UI_Base
    {
        #region UI 오버라이드
        public override void Initialize()
        {
            base.Initialize();

            ui_Model = new UI_LogoScreen_Model();
            ui_Model.Initialize();

            ui_View.Logo_Fade(this, loadingScreen);
        }

        public override void Setup()
        {
            base.Setup();
        }

        public override void Think()
        {
            base.Think();
        }

        public override void OnRemove()
        {
            base.OnRemove();
        }
        #endregion
        
        #region MVP
        [Title("MVP")]
        [SerializeField] private UI_LogoScreen_View ui_View;
        [SerializeField]private UI_LogoScreen_Model ui_Model;
        #endregion
        
        #region 로딩 스크린
        [SerializeField] private UI_LoadingScreen loadingScreen;
        #endregion
    }
}
