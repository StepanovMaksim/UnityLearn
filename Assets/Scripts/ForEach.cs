using UnityEngine;

public class ForEach : MonoBehaviour
{
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("Номер куба: " + i);

            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = new Vector3(i * 2, 0, 0);
        }
    }
}
/*GameObject[] cubes = new GameObject[3];

for (int i = 0; i < cubes.Length; i++)
{
    cubes[i] = GameObject.CreatePrimitive(PrimitiveType.Cube);
    cubes[i].transform.position = new Vector3(i * 2, 0, 0);
}

foreach (GameObject cube in cubes)
{
    cube.transform.localScale = Vector3.one * 1.5f;
}

int energy = 3;

while (energy > 0)
{
    Debug.Log("Осталось энергии: " + energy);
    energy--;
}*/