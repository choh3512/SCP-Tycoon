using Sirenix.OdinInspector;
using UnityEngine;

namespace RF.UI.Explore
{
    public class UI_Explore : MonoBehaviour, IUI_Base
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
        
        #region 인터페이스
        public void Initialize()
        {
            ui_Model = new UI_Explore_Model();
            ui_Model.Initialize();
        }

        public void Setup()
        {
            
        }

        public void Think()
        {
            
        }

        public void Remove()
        {
           
        }

        public void OnRemove()
        {
            
        }
        #endregion
        
        #region MVP
        [Title("MVP")]
        [SerializeField] private UI_Explore_View ui_View;
        private UI_Explore_Model ui_Model;
        #endregion


    }
}
