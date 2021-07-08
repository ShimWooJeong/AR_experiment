using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class burn : MonoBehaviour
{
    public GameObject yellowFire, orangeFire, redFire, purpleFire, greenFire, lightGreenFire;
    public GameObject match, fire;
    private void Start()
    {
        yellowFire = GameObject.Find("PFire").transform.FindChild("Magic fire pro yellow").gameObject;
        orangeFire = GameObject.Find("PFire").transform.FindChild("Magic fire pro orange").gameObject;
        redFire = GameObject.Find("PFire").transform.FindChild("Magic fire pro red").gameObject;
        purpleFire = GameObject.Find("PFire").transform.FindChild("Magic fire pro purple").gameObject;
        greenFire = GameObject.Find("PFire").transform.FindChild("Magic fire pro green").gameObject;
        lightGreenFire = GameObject.Find("PFire").transform.FindChild("Magic fire pro lightgreen").gameObject;

        match = GameObject.Find("Match");
        fire = GameObject.Find("PFire").transform.FindChild("fire").gameObject;
    }

    private void Update()
    {
       Vector3 vec = match.transform.localPosition;
       fire.gameObject.transform.position = vec + new Vector3((float)0.05,(float)0.15, (float)-0.5);
    }

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("�浹");
        string selectedReagent = "Natrium";//���Ƿ� �� ��. �վ����κ��� �ѵ��� ������ ��ȹ. 
        //StageManager = GameObject.Find("stagenum");
        //nowStage = StageManager.GetComponent<SceneChange>().stageNum;
        //switch (nowStage)  case 1: ~~                    !!!!!!!�̷������� �Ѱܹް� �� ����.

        switch (selectedReagent)
        {
            case "Natrium"://���
                yellowFire.SetActive(true);
                
                break;
            case "Calcium"://��Ȳ
                orangeFire.SetActive(true);
                
                break;
            case "Lithium"://����
                redFire.SetActive(true);
                
                break;
            case "Kalium"://����
                purpleFire.SetActive(true);

                break;
            case "Copper"://û��
                greenFire.SetActive(true);

                break;
            case "Barium"://����
                lightGreenFire.SetActive(true);

                break;
        }

    }

}
