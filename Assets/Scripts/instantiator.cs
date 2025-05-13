using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiator : MonoBehaviour

{

    public GameObject cuboPrefab;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(cuboPrefab);
    }

    public void InstanciarCubo()
    {
        Instantiate(cuboPrefab);
    }
}
