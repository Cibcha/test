using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scriptcube : MonoBehaviour
{
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
      cube.transform.position = new Vector3(0f, 0f, 0f);
      cube.transform.rotarion = Quaternion.Euler(new Vector3(0f, 45f, 0f));
      cube.transform.localscale = new Vector3(2f, 2f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
  