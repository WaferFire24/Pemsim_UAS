using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiringCalScript : MonoBehaviour
{
    [SerializeField] GameObject bulletnya;
    private GameObject selongsong, setbul;
    private Transform bulOUT;

    void Start()
    {
        selongsong = GameObject.FindWithTag("Player");
        bulOUT = selongsong.transform.Find("calOut").transform;
    }

    public void btnFireTriggered(){
        Instantiate(bulletnya, bulOUT.position, bulOUT.rotation);

        setbul = GameObject.FindWithTag("Bullet");
        setbul.GetComponent<bulletScript>().vAwal = 5f;
        setbul.GetComponent<bulletScript>().g = 10f;
        setbul.GetComponent<bulletScript>().a = 35f;
        setbul.GetComponent<bulletScript>().enabled = true;
        setbul.GetComponent<Rigidbody>().useGravity = true;
    }
}
