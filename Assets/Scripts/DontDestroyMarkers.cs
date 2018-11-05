using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyMarkers : MonoBehaviour {

    public List<GameObject> markers = new List<GameObject>();

    // Use this for initialization
    void Start () {
        for (int i = 0; i < markers.Count; i++)
        {
            DontDestroyOnLoad(markers[i]);
        }
    }

    void Awake()
    {
        for (int i = 0; i < markers.Count; i++)
        {
            DontDestroyOnLoad(markers[i]);
        }
    }

    public List<GameObject> returnListOfMarkers()
    {
        return markers;
    }
}
