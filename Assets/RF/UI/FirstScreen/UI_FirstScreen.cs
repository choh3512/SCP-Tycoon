using System.Collections;
using RF.UI.FirstScreen;
using Sirenix.OdinInspector;
using UnityEngine;

namespace RF.UI
{
    public class UI_FirstScreen : UI_Base
    {
        #region MVP
  
        [Title("MVP")]
        public UI_FirstScreen_Model ui_Model;
        public UI_FirstScreen_View ui_View;      
        #endregion
        
        #region UI 오버라이드 함수
        public override void Initialize()
        {
            ui_Model = new UI_FirstScreen_Model();
            ui_Model.Initialize();
            //CustomDebug.DebugManager.Instance.Log(this, "Initialize");
            
            ui_View.SetTitle_Alpha(1);
            ui_View.SetCopyright_Alpha(1);

            StartCoroutine("Tip_Change");
        }

        public override void Setup()
        {
            //CustomDebug.DebugManager.Instance.Log(this, "Setup");
        }

        public override void Hide(bool isHide)
        {
            //CustomDebug.DebugManager.Instance.Log(this, "Hide " + isHide);
        }

        public override void Think()
        {
            //CustomDebug.DebugManager.Instance.Log(this, "Think");
        }

        public override void Remove()
        {
            //CustomDebug.DebugManager.Instance.Log(this, "Remove");
        }

        public override void OnRemove()
        {
            //CustomDebug.DebugManager.Instance.Log(this, "OnRemove");
        }
        #endregion
        
        #region 프레젠트

        private int tip_Index = 0;
        IEnumerator Tip_Change()
        {
            while (true)
            {
                if (ui_View.GetLoading_Tip_Active())
                {
                    if (tip_Index >= ui_Model.tip_Texts.Count)
                    {
                        tip_Index = 0;
                    }

                    ui_View.SetLoading_Tip_Alpha(0F);
                    
                    yield return new WaitForSeconds(1F);
                    
                    ui_View.SetLoading_Tip(ui_Model.tip_Texts["tip_" + (tip_Index+1)]);
                    ui_View.SetLoading_Tip_Alpha(1F);
                    tip_Index++;
                }
                yield return new WaitForSeconds(5F);
            }
        }
        #endregion
    }
}
