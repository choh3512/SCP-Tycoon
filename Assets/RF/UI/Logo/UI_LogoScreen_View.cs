using RF.UI.Base;
using RF.UI.Loading;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;

namespace RF.UI.Logo
{
    public class UI_LogoScreen_View : UI_View_Base
    {
        #region 로고
        [Title("로고")]
        [SerializeField] private TMP_Text logo_Title_Text;
        [SerializeField] private TMP_Text logo_Copyright_Text;

        public void Logo_Fade(UI_LogoScreen logoScreen, UI_LoadingScreen loadingScreen)
        {
            logoScreen.Fade(logo_Title_Text, FadeType.IN, 3F, () =>
            {
                loadingScreen.gameObject.SetActive(true);
            });
            
            logoScreen.Fade(logo_Copyright_Text, FadeType.IN, 3F, () =>
            {
                loadingScreen.gameObject.SetActive(true);
            });
        }
        #endregion
    }
}
