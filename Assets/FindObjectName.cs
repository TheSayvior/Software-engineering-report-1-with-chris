using UnityEngine;

public class FindObjectName : MonoBehaviour {

    public int TimesToRun;

	void Update () {
        for(int i = 0; i < TimesToRun; i++)
        {
            GameObject Player = GameObject.Find("Player(Clone)");//.GetComponent<Player>();
        }
	}
}
