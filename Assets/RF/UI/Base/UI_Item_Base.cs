using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Item_Base : MonoBehaviour
{
    #region 유니티 기본 내장 함수
    private void Awake()
    {
        Initialize();
    }

    private void Update()
    {
        Think();
    }

    private void OnDestroy()
    {
        OnRemove();
    }

    #endregion
    
    #region UI 가상 함수
    public virtual void Initialize()
    {
        
    }

    public virtual void Think()
    {
        
    }
    
    public virtual void OnRemove()
    {
        
    }
    #endregion
}
