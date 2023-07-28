using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collidercontroller : MonoBehaviour
{
    BoxControl boxControl;
    public static string tıklananNota;
    public static bool temasEtti=false;
    static GameObject temp;
    public int counterdestroy=0;
    BoxControl _box;

    void Start()
    {
        _box = FindObjectOfType<BoxControl>();
        
        //boxControl =GameObject.Find("GameManager").GetComponent<BoxControl>();
    }
    public void Tıklanan(string a)
    {
        tıklananNota = a;
        Debug.Log(tıklananNota);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ColliderSol")
        {
            temp = collision.gameObject;
            temasEtti = true;
            Time.timeScale = 0f;
        }
        else if (collision.gameObject.tag == "ColliderFa")
        {
            temp = collision.gameObject;
            temasEtti = true;
            Time.timeScale = 0f;
        }
        else if (collision.gameObject.tag == "ColliderMi")
        {
            temp = collision.gameObject;
            temasEtti = true;
            Time.timeScale = 0f;
        }
        else if (collision.gameObject.tag == "ColliderRe")
        {
            temp = collision.gameObject;
            temasEtti = true;
            Time.timeScale = 0f;
        }
        else if (collision.gameObject.tag == "ColliderLa")
        {
            temp = collision.gameObject;
            temasEtti = true;
            Time.timeScale = 0f;
        }
        else if (collision.gameObject.tag == "ColliderSi")
        {
            temp = collision.gameObject;
            temasEtti = true;
            Time.timeScale = 0f;
        }
        else if (collision.gameObject.tag == "ColliderDo1")
        {
            temp = collision.gameObject;
            temasEtti = true;
            Time.timeScale = 0f;
        }
        else if (collision.gameObject.tag == "ColliderDo2")
        {
            temp = collision.gameObject;
            temasEtti = true;
            Time.timeScale = 0f;
        }
        else
        {

        }
    }
     void Update()
    {
        if (temasEtti)
        {
            if (temp.name == tıklananNota)
            {
                
                Destroy(gameObject);
                counterdestroy++;
                _box.CounteronText(counterdestroy);
                /*BoxControl.CountonText()*/
                
                tıklananNota = "0";
                Time.timeScale = 1;
                temasEtti = false;
            }
        }
    }

}
