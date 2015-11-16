using UnityEngine;
using System.Collections;

public class FindObjectOfTypeScript : MonoBehaviour {

    public int TimesToRun;
    
	void Update () {
        for (int i = 0; i < TimesToRun; i++)
        {
            Player Player = GameObject.FindObjectOfType<Player>();
        }
    }
}
