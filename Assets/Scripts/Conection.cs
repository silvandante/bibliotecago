using UnityEngine;
using System;
using System.IO;
using System.Collections;
using System.Data;
using System.Text;
using Mono.Data.SqliteClient;
using System.Collections.Generic;

public class Conection : MonoBehaviour {
	private string connection;
	private IDbConnection dbcon;
	private IDbCommand dbcmd;
	private IDataReader reader;
	private StringBuilder builder;

	public void OpenDB(string p)
	{
        string filepath = Application.dataPath + "/StreamingAssets/" + "/" + p;
        //string filepath = Application.persistentDataPath + "/" + p;

        if (!File.Exists(filepath))
		{
			WWW loadDB = new WWW("jar:file://" + Application.dataPath + "!/assets/" + p);
			while(!loadDB.isDone) {}
			File.WriteAllBytes(filepath, loadDB.bytes);
		}

		connection = "URI=file:" + filepath;
		Debug.Log("Stablishing connection to: " + connection);
		dbcon = new SqliteConnection(connection);
		dbcon.Open();
	}


	public void CloseDB(){
		reader.Close(); 
  	 	reader = null;
   		dbcmd.Dispose();
   		dbcmd = null;
   		dbcon.Close();
   		dbcon = null;
	}


	public List<string> getAllAreas(){
        List<string> nome_areas = new List<string>(); ;

        string consulta;
		consulta = "SELECT * FROM areas ";	
		dbcmd = dbcon.CreateCommand();
		dbcmd.CommandText = consulta;
		reader = dbcmd.ExecuteReader();


		while(reader.Read()){
            nome_areas.Add(reader.GetString(1));
            Debug.Log("nome_area:"+reader.GetString(1));
		}

        return nome_areas;
        
	}

    public List<int> GetRouteByArea(int are_id)
    {
        List<int> route_area = new List<int>(); ;

        string consulta;
        consulta = "SELECT * FROM areas WHERE are_id = "+ are_id;
        dbcmd = dbcon.CreateCommand();
        dbcmd.CommandText = consulta;
        reader = dbcmd.ExecuteReader();


        while (reader.Read()) {

            if (reader.GetString(2) != null || reader.GetString(2) != "")
                route_area.Add(int.Parse(reader.GetString(2)));

            if (reader.GetString(3) != null || reader.GetString(3) != "")
                route_area.Add(int.Parse(reader.GetString(3)));

            if (reader.GetString(4) != null || reader.GetString(4) != "")
                route_area.Add(int.Parse(reader.GetString(4)));
        }

        return route_area;

    }

}