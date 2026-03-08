
using UnityEngine;

public class DungeonGenerator : MonoBehaviour
{
    public int width = 30;
    public int height = 30;

    public GameObject floorPrefab;
    public GameObject wallPrefab;

    void Start()
    {
        Generate();
    }

    void Generate()
    {
        for(int x=0; x<width; x++)
        {
            for(int z=0; z<height; z++)
            {
                Instantiate(floorPrefab, new Vector3(x,0,z), Quaternion.identity);

                if(Random.value > 0.8f)
                {
                    Instantiate(wallPrefab, new Vector3(x,1,z), Quaternion.identity);
                }
            }
        }
    }
}
