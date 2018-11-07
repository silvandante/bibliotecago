using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class SelectArea : MonoBehaviour {

    Text caminhoText = null;

    private List<GameObject> markers = new List<GameObject>();
    public Dropdown ddArea;
    public DontDestroyMarkers markers_;
    private List<int> route = new List<int>();
    // Use this for initialization

    private void Start()
    {
        GetMarkers();

        caminhoText = GameObject.FindGameObjectWithTag("caminhoText").GetComponent<Text>();

    }

    private void GetMarkers()
    {
        markers = markers_.returnListOfMarkers();
    }
	
	// Update is called once per frame
	public void SelectThisArea () {

        route = new List<int>();

        SqliteDatabase sqlDB = new SqliteDatabase("bibliotecago_v01.db");
        string query = "SELECT * FROM areas WHERE are_id="+(ddArea.value+1);
        DataTable data = sqlDB.ExecuteQuery(query);
      
        foreach (DataRow dr in data.Rows)
        {
            int route_number = (int)dr["are_marker_01"];
            route.Add(route_number);

            int route_number_ = (int)dr["are_marker_02"];
            route.Add(route_number_);

            int route_number__ = (int)dr["are_marker_03"];
            route.Add(route_number__);
        }

        for (int i = 0; i < route.Count; i++)
        {
            Debug.Log("route[" + i + "]:" + route[i]);
            markers[i].GetComponent<Directions>().InsertDirection(route[i]);
        }

        string query_ = "SELECT * FROM areas WHERE are_id="+(ddArea.value+1);
        DataTable data_ = sqlDB.ExecuteQuery(query_);
        string area = "";
        foreach (DataRow dr in data_.Rows)
        {
            name = (string)dr["are_name"];
        }
        caminhoText.text = "Caminhando para "+area;
        


    }

    public void SelectThisLivro()
    {

        route = new List<int>();

        SqliteDatabase sqlDB = new SqliteDatabase("bibliotecago_v01.db");
        string query = "SELECT * FROM livros WHERE liv_name = '" + (ddArea.options[ddArea.value].text)+"'";
        DataTable data = sqlDB.ExecuteQuery(query);

        foreach (DataRow dr in data.Rows)
        {
            int route_number = (int)dr["liv_marker_01"];
            route.Add(route_number);

            int route_number_ = (int)dr["liv_marker_02"];
            route.Add(route_number_);

            int route_number__ = (int)dr["liv_marker_03"];
            route.Add(route_number__);
        }

        for (int i = 0; i < route.Count; i++)
        {
            Debug.Log("route[" + i + "]:" + route[i]);
            markers[i].GetComponent<Directions>().InsertDirection(route[i]);
        }

        string query_ = "SELECT * FROM livros WHERE liv_name = '" + (ddArea.options[ddArea.value].text) + "'";
        DataTable data_ = sqlDB.ExecuteQuery(query_);
        string name = "";
        foreach (DataRow dr in data_.Rows)
        {
            name = (string)dr["liv_name"];
        }
        caminhoText.text = "Caminhando para " + name;



    }


    public void SelectThisSubArea()
    {

        route = new List<int>();

        SqliteDatabase sqlDB = new SqliteDatabase("bibliotecago_v01.db");
        string query = "SELECT * FROM pequenas_areas WHERE peq_id=" + (ddArea.value + 1);
        DataTable data = sqlDB.ExecuteQuery(query);
        
        foreach (DataRow dr in data.Rows)
        {
            if (dr["peq_marker_01"] != null)
            {
                int route_number = (int)dr["peq_marker_01"];
                route.Add(route_number);
            }

            if (dr["peq_marker_02"] != null)
            {
                int route_number_ = (int)dr["peq_marker_02"];
                route.Add(route_number_);
            }

            if (dr["peq_marker_03"] != null)
            {
                int route_number__ = (int)dr["peq_marker_03"];
                route.Add(route_number__);
            }
        }

        for (int i = 0; i < route.Count; i++)
        {
            Debug.Log("route[" + i + "]:" + route[i]);
            markers[i].GetComponent<Directions>().InsertDirection(route[i]);

        }
        


    }
    
}
