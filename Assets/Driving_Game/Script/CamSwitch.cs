using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    public GameObject cam1;
    public GameObject Title;
    public GameObject Play;
    public GameObject Res16;
    public GameObject Res9;
    public GameObject A;
    public GameObject B;

    public void Cam1_on()
    {
        cam1.SetActive(true);
        Title.SetActive(false);
        Play.SetActive(false);
        Res16.SetActive(false);
        Res9.SetActive(false);
        A.SetActive(true);
        B.SetActive(true);
    } 

}
