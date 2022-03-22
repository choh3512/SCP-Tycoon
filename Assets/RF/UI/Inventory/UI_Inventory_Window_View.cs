using RF.Building;
using RF.UI.Base;
using UnityEngine;

namespace RF.UI.Inventory
{
    public class UI_Inventory_Window_View : UI_View_Base
    {
        #region 인벤토리
        [SerializeField] private Transform content;
        [SerializeField] private GameObject itemPrefab;
        
        public void AddItem(BuildingData data)
        {
            GameObject item = Instantiate(itemPrefab);
            item.transform.SetParent(content);
        }
        #endregion
    }
}
