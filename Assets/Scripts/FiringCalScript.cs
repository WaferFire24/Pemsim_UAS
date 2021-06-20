using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FiringCalScript : MonoBehaviour
{
    [SerializeField] GameObject bulletnya;
    private GameObject selongsong, setbul;
    private Transform bulOUT;
    private HUDManagerScript1 _hud;

    void Start()
    {
        selongsong = GameObject.FindWithTag("Player");
        bulOUT = selongsong.transform.Find("calOut").transform;
        _hud = GameObject.FindObjectOfType<HUDManagerScript1>();
    }

    public void btnFireTriggered(){
        Instantiate(bulletnya, bulOUT.position, bulOUT.rotation);

        setbul = GameObject.FindWithTag("Bullet");
        setbul.GetComponent<bulletScript>().vAwal = _hud.getVAwal();
        setbul.GetComponent<bulletScript>().g = _hud.getUrativity();
        setbul.GetComponent<bulletScript>().a = _hud.getSudut();
        setbul.GetComponent<bulletScript>().arah = _hud.getSudutPutar();
        setbul.GetComponent<bulletScript>().enabled = true;
        setbul.GetComponent<Rigidbody>().useGravity = true;
    }
}
