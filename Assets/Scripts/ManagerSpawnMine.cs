using UnityEngine;


public class ManagerSpawnMine : MonoBehaviour
{
    public GameObject mineObject;
    public static int CountMineToGrind;
    public static int CountMine;

    private void Start()
    {
        CountMineToGrind = Random.Range(3, 5);
        CountMine = CountMineToGrind;
    }

    private void Update()
    {
        for (; CountMineToGrind > 0; CountMineToGrind--)
        {
            Vector3 pos = new Vector3(Random.Range(-12, 12), 0.5f, Random.Range(-12, 12));
            Instantiate(mineObject, pos, Quaternion.identity);
        }

        if (CountMine <= 0)
        {
            CountMineToGrind = Random.Range(3, 6);
            CountMine = CountMineToGrind;
        }

    }
}
