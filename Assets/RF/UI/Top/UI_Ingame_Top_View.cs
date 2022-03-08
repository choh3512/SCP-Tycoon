using RF.UI.Base;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace RF.UI.Top
{
    public class UI_Ingame_Top_View : UI_View_Base
    {
        #region 플레이어 데이터 표기
        [Title("플레이어 데이터")] 
        [SerializeField] private TMP_Text level_Text;
        [SerializeField] private TMP_Text exp_Text;
        [SerializeField] private TMP_Text scpCount_Text;

        [SerializeField] private Image exp_Bar;

        public void SetLevel(int lvl)
        {
            level_Text.text = lvl.ToString();
        }

        public void SetEXP(int exp)
        {
            exp_Text.text = exp + "/" + "0";
        }

        public void SetSCPCount(int count)
        {
            scpCount_Text.text = count + "/" + "0";
        }    
        #endregion
    }
}
