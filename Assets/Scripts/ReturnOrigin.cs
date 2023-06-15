using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnOrigin : MonoBehaviour
{
    [SerializeField] GameObject _victim;
    public Vector3 safeZone;
    public Vector3 safeZone2;

    PersonAgent personAgentScript;

    void Start()
    {
        personAgentScript = GetComponent<PersonAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (personAgentScript.type == "victim")  
        {
            if (transform.position.x == safeZone.x && transform.position.y == safeZone.y && transform.position.z == safeZone.z)
            {
                _victim.SetActive(false);
            }
            else if(transform.position.x == safeZone2.x && transform.position.y == safeZone2.y && transform.position.z == safeZone2.z)
            {
                _victim.SetActive(false);
            }
        }
    }
}
