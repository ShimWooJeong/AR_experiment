using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selected_Reagent : MonoBehaviour
{
    public static string selectedReagent;

        private void Start()
    {
        selectedReagent = "Barium"; //���Ƿ� ������ ��. �þ༱�� Scene���κ��� �Ѿ�� ����.
    }

    /*
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    ������ �����Ͱ����� ���ؼ��� �̰� ����. �ٵ� ���� �ϴ� static���� �ؼ� ��ũ��Ʈ�������� �� ����.
    */

}
