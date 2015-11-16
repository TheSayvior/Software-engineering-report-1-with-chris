using UnityEngine;
using System.Linq;

public class MoreGameObjects : MonoBehaviour {

    public int CreateAmount = 10;
    int counter = 0;

    static System.Random random = new System.Random();

    void Awake()
    {
        for (int i = 0; i < CreateAmount; i++)
        {
            CreateChildren(null, 0);
        }
    }

    void CreateChildren(Transform trans, int nestingLevel)
    {

        for (int i = 0; i < CreateAmount; i++)
        {
            counter++;
            if (counter > 100000) return;
            float randomValue = Random.value;
            if (counter == 800)
            {
                GameObject player = (GameObject)Instantiate(Resources.Load("Player"));
                player.transform.parent = trans;
            }
            GameObject empty = (GameObject) Instantiate(Resources.Load("Empty"));
            empty.transform.parent = trans;
            empty.name = RandomString(10);

            if (randomValue < 0.2 && nestingLevel < 5)
            {
                CreateChildren(empty.transform, nestingLevel+1);
            }
        }
    }

    public static string RandomString(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        
        return new string(Enumerable.Repeat(chars, length)
          .Select(s => s[random.Next(s.Length)]).ToArray());
    }
}
