using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using InfinityCode.RealWorldTerrain;

public class HUDManagerScript : MonoBehaviour
{
    [SerializeField] Dropdown _dropTarget;
    [SerializeField] InputField _edtVAwal;
    [SerializeField] InputField _edtSudut;
    [SerializeField] InputField _edtLong;
    [SerializeField] InputField _edtLat;
    [SerializeField] Text _dropText;
    [SerializeField] Slider _slideSudut;
    private Vector3 currentEulerAngles, SliderY;
    [SerializeField] GameObject selongsong;
    [SerializeField] GameObject maincam;

    void Update() {
        dpOnChange(_dropTarget.value);
        _edtSudut.text = string.Format("{0:N2}",_slideSudut.value);
        selongsong.transform.localEulerAngles = new Vector3( _slideSudut.value, selongsong.transform.rotation.y, selongsong.transform.rotation.z);
    }

    public void dpOnChange(){
        int pilihan = _dropTarget.value;
        switch (pilihan)
        {
            case 1:
                selongsong.transform.localEulerAngles = new Vector3(selongsong.transform.rotation.x, -45.162f, selongsong.transform.rotation.z);
                Debug.Log("Target Musuh : Camp Musuh A");
                maincam.transform.localEulerAngles = new Vector3(0, 127.875f, 0);
                _edtLong.text = "105.351";
                _edtLat.text = "-6.76";
                break;

            case 2:
                Debug.Log("Target Musuh : Camp Musuh B");
                selongsong.transform.localEulerAngles = new Vector3(selongsong.transform.rotation.x, 0, selongsong.transform.rotation.z);
                maincam.transform.localEulerAngles = new Vector3(0, 172.922f, 0);
                _edtLong.text = "105.3691";
                _edtLat.text = "-6.754";
                break;

            default:
                Debug.Log("DEFAULT");
                break;
        }
    }

    public void dpOnChange(int valDD){
        switch (valDD)
        {
            case 1:
                selongsong.transform.localEulerAngles = new Vector3(selongsong.transform.rotation.x, -45.162f, selongsong.transform.rotation.z);
                Debug.Log("Target Musuh : Camp Musuh A");
                maincam.transform.localEulerAngles = new Vector3(0, 127.875f, 0);
                _edtLong.text = "105.351";
                _edtLat.text = "-6.76";
                break;

            case 2:
                Debug.Log("Target Musuh : Camp Musuh B");
                selongsong.transform.localEulerAngles = new Vector3(selongsong.transform.rotation.x, 0, selongsong.transform.rotation.z);
                maincam.transform.localEulerAngles = new Vector3(0, 172.922f, 0);
                _edtLong.text = "105.3691";
                _edtLat.text = "-6.754";
                break;

            default:
                Debug.Log("DEFAULT");
                break;
        }
    }

    public void fireOnClick(){
        //Debug.Log("Kecepatan Awal = " + _edtVAwal.text);
        //Debug.Log("Sudut Tembak = " + _edtSudut.text);
        //Debug.Log("Target Tembak = " + _dropText.text);
        //Debug.Log("Longitude = " + double.Parse(_edtLong.text));
        //Debug.Log("Latitude = " + double.Parse(_edtLat.text));

        ///Vector3 pos1 = PHYManagerScript.toWorldPos(double.Parse(_edtLong.text), double.Parse(_edtLat.text), GameObject.FindObjectOfType<RealWorldTerrainContainer>());
        ///Debug.Log("Longitude=" + double.Parse(_edtLong.text) + " Latitude=" + double.Parse(_edtLat.text));
        ///Debug.Log("RealWorld="+pos1);
    }

    public int getVAwal(){
        return int.Parse(_edtVAwal.text);
    }

    public int getSudut(){
        return int.Parse(_edtSudut.text);
    }

    public double getLong(){
        return double.Parse(_edtLong.text);
    }

    public double getLat(){
        return double.Parse(_edtLat.text);
    }    

    /*public int[] getVar(int _StartVel, int _teta, int _longitude, int _latitude){  
        int []outseries = int[4];  
        outseries[0] = int.Parse(_edtVAwal.text);
        outseries[1] = int.Parse(_edtSudut.text);
        outseries[2] = int.Parse(_edtLong.text);
        outseries[3] = int.Parse(_edtLat.text);
        return outseries;
    } */
}
