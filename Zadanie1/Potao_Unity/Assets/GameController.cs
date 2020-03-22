using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject DisPlatform1;
    public GameObject DisPlatform2;

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        if (DisPlatform1.activeSelf == false)
        {
            StartCoroutine(Enable(1));
        }
        if (DisPlatform2.activeSelf == false)
        {
            StartCoroutine(Enable(2));
        }
    }

    IEnumerator Enable(int number) 
    {
        yield return new WaitForSeconds(3);
        if(number == 1)
        DisPlatform1.SetActive(true);

        if (number == 2)
        DisPlatform2.SetActive(true);
    }
}
