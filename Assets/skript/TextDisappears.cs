using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextDisappears : MonoBehaviour
{

    public GameObject textObject;

    // Start is called before the first frame update
    void Start()
    {
        textObject.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        textObject.SetActive(true);
    }

    IEnumerator WaitFiveSeconds()
    {
        print("Start waiting");

        yield return new WaitForSeconds(5);

        print("5 seconds has passed");

        textObject.SetActive(false);
    }



}
