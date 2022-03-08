using RF.UI.Base;
using Sirenix.OdinInspector;
using UniRx;
using UnityEngine;
using UnityEngine.Events;

namespace RF.UI.MainMenu
{
    public class UI_MainMenu : UI_Base
    {
        #region UI 오버라이드 함수
        public override void Initialize()
        {
            Setup_Buttons();
        }
        #endregion
        
        #region 메인메뉴 버튼
        [Title("버튼")]
        [SerializeField] private UI_Custom_Button playButton;
        [SerializeField] private UI_Custom_Button collectionButton;
        [SerializeField] private UI_Custom_Button settingButton;
        [SerializeField] private UI_Custom_Button creditButton;
        [SerializeField] private UI_Custom_Button closeButton;

        private void Setup_Buttons()
        {
            playButton.onClick.AsObservable().Subscribe(unit =>
            {
                Play();
            });

            collectionButton.onClick.AsObservable().Subscribe(unit =>
            {
                Collection();
            });
            
            settingButton.onClick.AsObservable().Subscribe(unit =>
            {
                Setting();
            });
            
            creditButton.onClick.AsObservable().Subscribe(unit =>
            {
                Credit();
            });
            
            closeButton.onClick.AsObservable().Subscribe(unit =>
            {
                Close();
            });
        }

        private void Play()
        {
            
        }

        private void Collection()
        {
            
        }
        
        private void Setting()
        {
            
        }
        
        private void Credit()
        {
            
        }
        
        private void Close()
        {
            Application.Quit();
        }
        #endregion
    }
}
