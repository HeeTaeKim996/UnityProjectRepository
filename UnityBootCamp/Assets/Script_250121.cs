using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_250121 : MonoBehaviour
{
    /// <summary>
    /// 이 매서드는 서마리 예시입니다. summary 사이에 서술하면 됩니다. 하단의 param은 변수를 설명합니다. 하단의 returns는 매서드의 리턴값을 설명합니다.
    /// </summary>
    /// <param name="a">첫번째 변수</param> 
    /// <param name="b">두번째 변수</param>
    /// <returns>두 숫자의 합</returns>
    public float ExmapleForSummary(float a, float b)
    {
        
        #region Sample
        return a + b;
        #endregion  // #region - #endregion 로 지정하면, 사이 코드들은 코드 폴딩을 할 수 있다
    }

    public bool isJumpbable;
    public int money;
    public List<int> mooJiGae = new List<int> { 0, 1, 2, 3, 4, 5, 6 };

}
