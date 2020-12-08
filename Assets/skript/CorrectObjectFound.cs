using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CorrectObjectFound : MonoBehaviour
{

    public GameObject pointerLight;

    public GameObject textObject;


    // Start is called before the first frame update
    void Start()
    {
        pointerLight.SetActive(false);

        textObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        pointerLight.SetActive(true);

        textObject.SetActive(true);


    }


 
    

    //if you want to make text disappear after some time look at COROUTINES online
}
