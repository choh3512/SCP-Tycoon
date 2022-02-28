using System;
using RF.UI.Base;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace RF.UI.Loading
{
    public class UI_LoadingScreen_View : UI_View_Base
    {
        #region 로딩
        [Title("로딩")] 
        [SerializeField] private Slider slider;
        [SerializeField] private TMP_Text tip_Text;

        public void SetProgress(float value)
        {
            slider.value = value;
        }

        public void SetTipText(string text)
        {
            tip_Text.text = text;
        }

        public void Tip_Fade_IN(UI_LoadingScreen loadingScreen, Action completedFunc)
        {
            loadingScreen.Fade(tip_Text, FadeType.IN, 3F, completedFunc);
        }
        
        public void Tip_Fade_OUT(UI_LoadingScreen loadingScreen, Action completedFunc)
        {
            loadingScreen.Fade(tip_Text, FadeType.OUT, 3F, completedFunc);
        }
        #endregion
    }
}
