using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class burn : MonoBehaviour
{
    public GameObject yellowFire, orangeFire, redFire, purpleFire, greenFire, lightGreenFire;
    public GameObject StageManager;
    int nowStage;

    private void Start()
    {
        yellowFire = GameObject.Find("Magic fire pro yellow");
        orangeFire = GameObject.Find("Magic fire pro orange");
        redFire = GameObject.Find("Magic fire pro red");
        purpleFire = GameObject.Find("Magic fire pro purple");
        greenFire = GameObject.Find("Magic fire pro green");
        lightGreenFire = GameObject.Find("Magic fire pro lightGreen");
    }
    public void OnCollisionEnter(Collision collision)
    {


        StageManager = GameObject.Find("stagenum");
        nowStage = StageManager.GetComponent<SceneChange>().stageNum;

        switch (nowStage)
        {
            case 1://����
                purpleFire.SetActive(true);

                break;
            case 2://��Ȳ
                orangeFire.SetActive(true);

                break;
            case 3://����
                lightGreenFire.SetActive(true);

                break;
            case 4://����
                redFire.SetActive(true);

                break;
            case 5://���
                yellowFire.SetActive(true);
                
                break;
            case 6://û��
                greenFire.SetActive(true);

                break;
            
        }
        //1-Į��,2-Į��,3-�ٷ�,4-��Ƭ,5-��Ʈ��,6-����
    }

}
