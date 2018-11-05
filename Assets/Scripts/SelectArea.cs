using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class SelectArea : MonoBehaviour {

    Conection db = null;



    private List<GameObject> markers = new List<GameObject>();
    public Dropdown ddArea;
    public DontDestroyMarkers markers_;
    private List<int> route = new List<int>();
	// Use this for initialization

    private void GetMarkers()
    {
        markers = markers_.returnListOfMarkers();
    }
	
	// Update is called once per frame
	public void SelectThisArea () {

        GetMarkers();

        db = GetComponent<Conection>();

        db.OpenDB("bibliotecago_v01.db");
      
        route = db.GetRouteByArea((ddArea.value+1));
        
        for (int i = 0; i < route.Count; i++)
        {
            Debug.Log("route[" + i + "]:" + route[i]);
            markers[i].GetComponent<Directions>().InsertDirection(route[i]);
        }

        db.CloseDB();


    }
}
