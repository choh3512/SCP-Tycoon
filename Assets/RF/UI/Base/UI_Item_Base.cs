using System;
using System.Collections;
using System.Collections.Generic;
using RF.UI;
using UnityEngine;

public class UI_Item_Base : MonoBehaviour, IUI_Base
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

    #endregion

    public void Initialize()
    {
        
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
}
