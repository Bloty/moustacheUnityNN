using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OpenCVForUnity.CoreModule;
using OpenCVForUnityExample;


public class ScriptPerso : MonoBehaviour
{   //var deplacement
    public FaceDetectionWebCamTextureExample DetectionVisage;
    private Vector2 rectOrigine;
    private Vector2 rectXlargeurYlongeur;
    private float largeur;
    private float longeur;
    public float decaleMoustache = 1.5f;

    //autre var
    public int life = 1;
    public float timeUpScale = 10;
    [SerializeField]public float time;
    

    void Start()
    {
        time = timeUpScale;      
    }

    // Update is called once per frame
    void Update()
    {
        deplacement();
        upScaleAndLive();
        perdu();
       
    }

    private void deplacement()
    {
        rectOrigine = new Vector2(DetectionVisage.visagePosOrigine.x, DetectionVisage.visagePosOrigine.y);
        rectXlargeurYlongeur = new Vector2(DetectionVisage.visagePosLongLarg.x, DetectionVisage.visagePosLongLarg.y);

        largeur = rectXlargeurYlongeur.x - rectOrigine.x;
        longeur = rectXlargeurYlongeur.y - rectOrigine.y;


        transform.position = new Vector3(rectOrigine.x + largeur / 2, -rectOrigine.y - longeur / decaleMoustache, 0);
    }

    private void upScaleAndLive()
    {
        time -= Time.deltaTime;

        if (time < 0)
        {
            transform.localScale = new Vector3(transform.localScale.x + 1, transform.localScale.y + 1, 1);
            time = timeUpScale;
            life++;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Ennemi"))
        {
            life--;
            transform.localScale = new Vector3(transform.localScale.x - 1, transform.localScale.y - 1, 1);
        }
    }

    private void perdu()
    {
        if(life <= 0)
        {
            transform.localScale = new Vector3(0,0,0);
        }
    }
}
