using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplaceObjectOnClick : MonoBehaviour
{

    public GameObject objectToReplace;

    // Start is called before the first frame update
    void Start()
    {
        objectToReplace.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        objectToReplace.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
