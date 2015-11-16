using UnityEngine;

public class FindObjectWithCache : MonoBehaviour {

    public int TimesToRun;

    public Player _player;

    void Start()
    {
        _player = GameObject.Find("Player(Clone)").GetComponent<Player>();
    }

	void Update () {
        for(int i = 0; i < TimesToRun; i++)
        {
            Player Player = _player;
        }
	}
}
