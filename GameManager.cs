
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int level = 1;

    void Start()
    {
        Debug.Log("Dungeon Arcanum 3D iniciado");
    }

    public void NextLevel()
    {
        level++;
        Debug.Log("Subiste al nivel " + level);
    }
}
