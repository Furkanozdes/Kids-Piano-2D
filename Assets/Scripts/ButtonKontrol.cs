using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ButtonKontrol : MonoBehaviour
{
    public GameObject do1,re,mi,fa,sol,la,si,do2;
    public GameObject Line, LineR, LineL;

    void Start()
    {
        do1.SetActive(true);
        re.SetActive(true);
        mi.SetActive(true);
        fa.SetActive(true);
        sol.SetActive(true);
        la.SetActive(true);
        si.SetActive(true);
        do2.SetActive(true);
        Line.SetActive(true);
        LineR.SetActive(true);
        LineL.SetActive(true);
    }
}
