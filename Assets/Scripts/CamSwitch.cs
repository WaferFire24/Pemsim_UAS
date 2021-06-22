using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
   public GameObject cam0;
   public GameObject cam1;
   public GameObject cam2;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Key0")){
            cam0.SetActive(true);
            cam1.SetActive(false);
            cam2.SetActive(false);
        }
        if(Input.GetButtonDown("Key1")){
            cam0.SetActive(false);
            cam1.SetActive(true);
            cam2.SetActive(false);
        }
        if(Input.GetButtonDown("Key2")){
            cam0.SetActive(false);
            cam1.SetActive(false);
            cam2.SetActive(true);
        }
    }
}
