using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;


[System.Serializable]
public class AgentData
{
    public string id;
    public int[] pos;
    public string type;
    public bool display;
}

public class FetchDataFromAPI : MonoBehaviour
{
    public GameObject prefabRescuerAgent;
    public GameObject prefabVictimAgent;

    private string apiUrl = "http://127.0.0.1:8585/step";

    void Start()
    {
        StartCoroutine(FetchDataFromPython());
    }

    IEnumerator FetchDataFromPython()
    {
        using (var request = UnityEngine.Networking.UnityWebRequest.Get(apiUrl))
        {
            yield return request.SendWebRequest();

            if (request.result != UnityEngine.Networking.UnityWebRequest.Result.Success)
            {
                Debug.Log("Failed to fetch data from API: " + request.error);
                yield break;
            }

            string jsonResponse = request.downloadHandler.text;
            
            // Parse the JSON response and store it in a C# HashMap
            AgentData[] data = JsonConvert.DeserializeObject<AgentData[]>(jsonResponse);
            
        }
    }
}
