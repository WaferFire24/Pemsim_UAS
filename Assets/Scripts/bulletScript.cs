using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InfinityCode.RealWorldTerrain;

public class bulletScript : MonoBehaviour
{
    public float vAwal, a, g, arah;
    [HideInInspector] float t = 0;
    [HideInInspector] float timeScale = 1f;
    [SerializeField] GameObject delThis;
    public GameObject trace;
    private Vector3 posAwal;
    
    void Start() {
        posAwal = delThis.transform.position;
    }
    
    void Update()
    {
        t += Time.deltaTime * timeScale;
        transform.position = posBullet(vAwal, t, a, g, arah);
        if (transform.position.y < 13520.31f){
            Debug.Log("Bullet out of VOID");
            Destroy(delThis);
        }
        Instantiate(trace, transform.position, transform.rotation);
    }
    
    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Land"){
            Debug.Log("Bullet landed");
            Destroy(delThis);
        }else if (other.tag == "Enemy"){
            Debug.Log("Enemy Down!");
            Destroy(delThis);
        }
    }
    
    Vector3 posBullet(float _v, float _t, float _a, float _g, float _ar)
    {
        return new Vector3(
            posAwal.x + calcX(_v, _t, _ar),
            calcY(_v, _t, _a, _g) + posAwal.y ,
            calcZ(_v, _t, _ar) + posAwal.z
        );
    }

    float calcX(float _v, float _t, float _a)
    {
        return _v * _t * Mathf.Sin(_a * Mathf.PI /180);
    }

    float calcZ(float _v, float _t, float _a)
    {
        return _v * _t * Mathf.Cos(_a * Mathf.PI / 180);
    }

    float calcY(float _v, float _t, float _a, float _g)
    {
        return _v * _t * Mathf.Sin(_a * Mathf.PI / 180) - (0.5f * _g * Mathf.Pow(_t, 2));
    }

    /*
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

    public static Vector3 toWorldPos(double _long, double _lat, RealWorldTerrainContainer _container){
        Vector3 pos = Vector3.zero;

        _container.GetWorldPosition(_long, _lat, out pos);

        return pos;
    }

    public static Vector2 toGeoPos(Vector3 _v3, RealWorldTerrainContainer _container){
        Vector2 pos = Vector2.zero;
        _container.GetCoordinatesByWorldPosition(_v3, out pos);

        return pos;
    }
    */
}