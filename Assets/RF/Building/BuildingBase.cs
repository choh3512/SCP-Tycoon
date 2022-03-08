using Sirenix.OdinInspector;
using UnityEngine;

namespace RF.Building
{
    public class BuildingBase : MonoBehaviour
    {
        [Title("건물 데이터")] 
        [SerializeField] private ScriptableObject buildingData;
    }
}
