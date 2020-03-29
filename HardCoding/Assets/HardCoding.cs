using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardCoding : MonoBehaviour
{
    
    void Start()
    {
        int a = 10;
        float b = 5;

        bool bool1 = true;
        bool bool2 = false;

        string nap1 = "Programuję w C#";
        string nap2 = "EPG";

        Debug.Log("a=" + a + " b=" + b + " bool1=" + bool1 + " bool2=" + bool2 + " nap1=" + nap1 + " nap2=" + nap2);

        PorownanieLiczb(a, b);
        PorownanieString(nap1, nap2);
        KoniunkcjaBool(bool1, bool2);
    }


    void Update()
    {
        
    }

    public void PorownanieLiczb(int a, float b)
    {
        if (a == b)
            Debug.Log("Tak");
        else
            Debug.Log("Nie");

        if (a != b)
            Debug.Log("Tak");
        else
            Debug.Log("Nie");

        if (a > b)
            Debug.Log("Tak");
        else
            Debug.Log("Nie");

        if (a >= b)
            Debug.Log("Tak");
        else
            Debug.Log("Nie");

        if (a < b)
            Debug.Log("Tak");
        else
            Debug.Log("Nie");

        if (a <= b)
            Debug.Log("Tak");
        else
            Debug.Log("Nie");
    }

    public void PorownanieString(string nap1, string nap2)
    {
        if (string.Equals(nap1, nap2))
            Debug.Log("Są takie same!");
        else
            Debug.Log("Różne");
    }

    public void KoniunkcjaBool(bool bool1, bool bool2)
    {
        if (bool1 && bool2)
            Debug.Log("bool1 && bool2 = " + "True");
        else
            Debug.Log("bool1 && bool2 = " + "False");

        ////////////////////////////////////////////////////////

        if (bool1 || bool2)
            Debug.Log("bool1 || bool2 = " + "True");
        else
            Debug.Log("bool1 || bool2 = " + "False");

        if (!bool1 || bool2)
            Debug.Log("!bool1 || bool2 = " + "True");
        else
            Debug.Log("!bool1 || bool2 = " + "False");

        if (!bool1 || !bool2)
            Debug.Log("!bool1 || !bool2 = " + "True");
        else
            Debug.Log("!bool1 || !bool2 = " + "False");

        if (bool1 || !bool2)
            Debug.Log("bool1 || !bool2 = " + "True");
        else
            Debug.Log("bool1 || !bool2 = " + "False");
    }
}
