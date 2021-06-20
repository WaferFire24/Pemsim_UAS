using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InfinityCode.RealWorldTerrain;


public class PhysicsManagerScript : MonoBehaviour
{
    private Transform a;

    void Start() {
        a = GameObject.Find("Flak37").transform;
    }

    public void dapatSudut(string _markas){
        Transform b = GameObject.Find(_markas).transform;
        
        float dist = Vector3.Distance(a.position, b.position);
        
        Debug.Log("jarak ke musuh "+dist);
        
        double temp = hitungSudut(dist, 240f);
        Debug.Log("Kecepatan Awal Standar : 240m/s");
        Debug.Log("Sudut elevasi yang dibutuhkan: "+temp);
    }

    double hitungSudut(float _jarak, float _v){
        //Debug.Log("Jarak "+_jarak+", VAwal "+_v);
        return (Mathf.Asin(_jarak * 10 / (Mathf.Pow(_v, 2)))* Mathf.Rad2Deg) / 2;
    }

    float calcYMax(float _v, float _a, float _g)
    {
        return (Mathf.Pow(_v,2) * Mathf.Pow(Mathf.Sin(_a * Mathf.PI / 180),2)) / (2 * _g);
    }

    float calcXMax(float _v, float _a, float _g)
    {
        return (Mathf.Pow(_v, 2) * Mathf.Sin(2 * _a * Mathf.PI / 180)) / _g;
    }

    float tTipun(float _v, float _a, float _g)
    {
        return (_v * Mathf.Sin(_a * Mathf.PI / 180)) / _g;
    }

    public Vector3 toWorldPos(double _long, double _lat, RealWorldTerrainContainer _container){
        Vector3 pos = Vector3.zero;

        _container.GetWorldPosition(_long, _lat, out pos);

        return pos;
    }

    public Vector2 toGeoPos(Vector3 _v3, RealWorldTerrainContainer _container){
        Vector2 pos = Vector2.zero;
        _container.GetCoordinatesByWorldPosition(_v3, out pos);

        return pos;
    }
}
