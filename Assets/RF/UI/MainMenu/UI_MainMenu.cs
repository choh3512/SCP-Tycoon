using RF.UI.Base;
using RF.UI.Loading;
using Sirenix.OdinInspector;
using UniRx;
using UnityEngine;
using UnityEngine.Events;

namespace RF.UI.MainMenu
{
    public class UI_MainMenu : MonoBehaviour, IUI_Base
    {
        #region 유니티 기본 내장 함수

        private void Awake()
        {
            Initialize();
            Setup();
        }

        private void Update()
        {
            Think();
        }
        #endregion
        
        #region UI 오버라이드 함수
        public void Initialize()
        {
            Setup_Buttons();
        }

        public void Setup()
        {
            
        }

        public void Think()
        {
            
        }

        public void Remove()
        {
            OnRemove();
        }

        public void OnRemove()
        {
            
        }
        #endregion
        
        #region 게임 씬 로딩
        [Title("로딩")] 
        [SerializeField] private UI_LoadingScreen ui_LoadingScreen;
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
            gameObject.SetActive(false);
            ui_LoadingScreen.gameObject.SetActive(true);
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
