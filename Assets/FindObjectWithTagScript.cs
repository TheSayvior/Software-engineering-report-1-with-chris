using UnityEngine;
using System.Collections;

public class FindObjectWithTagScript : MonoBehaviour {

    public int TimesToRun;
    
	void Update () {
        for (int i = 0; i < TimesToRun; i++)
        {
            GameObject Player = GameObject.FindGameObjectWithTag("Player");//.GetComponent<Player>();
        }
    }
}
