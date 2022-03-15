using RF.UI.Base;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace RF.UI.Shop
{
    public class UI_Item_ShopItem_View : UI_View_Base
    {
        #region 아이템 설명 및 아이콘
        [Title("아이콘")]
        [SerializeField] private Image viewModel_Icon;

        [Title("제목")] 
        [SerializeField] private TMP_Text title_Text;
        
        [Title("설명")] 
        [SerializeField] private TMP_Text desc_Text;
        public void Set_Icon(Sprite image)
        {
            viewModel_Icon.sprite = image;
        }

        public void Set_Title(string text)
        {
            title_Text.text = text;
        }
        
        public void Set_Desc(string text)
        {
            desc_Text.text = text;
        }
        #endregion
    }
}
