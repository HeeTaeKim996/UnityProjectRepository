using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_250121 : MonoBehaviour
{
    /// <summary>
    /// �� �ż���� ������ �����Դϴ�. summary ���̿� �����ϸ� �˴ϴ�. �ϴ��� param�� ������ �����մϴ�. �ϴ��� returns�� �ż����� ���ϰ��� �����մϴ�.
    /// </summary>
    /// <param name="a">ù��° ����</param> 
    /// <param name="b">�ι�° ����</param>
    /// <returns>�� ������ ��</returns>
    public float ExmapleForSummary(float a, float b)
    {
        
        #region Sample
        return a + b;
        #endregion  // #region - #endregion �� �����ϸ�, ���� �ڵ���� �ڵ� ������ �� �� �ִ�
    }

    public bool isJumpbable;
    public int money;
    public List<int> mooJiGae = new List<int> { 0, 1, 2, 3, 4, 5, 6 };

}
