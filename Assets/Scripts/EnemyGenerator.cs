using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject Enemy;

    public float minSpeed;
    public float maxSpeed;
    public float currentSpeed;
    public float speedMultiplier;
    public float aralik = 8;
    void Awake()
    {
        currentSpeed = minSpeed;

        Invoke("generateEnemy", 3);
    }
    

    public void GenerateNextEnemyWithGap()
    {
        //float random = Random.Range(aralik1, aralik2); // bazý engeller için bunu deðiþtiririz, 
        Invoke("generateEnemy", aralik); // kalp gelir can basar ama 5 saniyede bir falan
    }
    public void generateEnemy()
    {
        GameObject EnemyIns = Instantiate(Enemy, transform.position, transform.rotation);

        EnemyIns.GetComponent<Enemy>().enemyGenerator = this;

    }
    void Update()
    {
        if(currentSpeed < maxSpeed)
        {
            currentSpeed += speedMultiplier;
        }
    }
}
