using UnityEngine;

public class SpikeGenerator : MonoBehaviour
{
    public GameObject spike;

    public float minSpeed;
    public float maxSpeed;
    public float currentSpeed;
    public float speedMultiplier;
    public float aralik = 4;
    void Awake()
    {
        currentSpeed = minSpeed;
        generateSpike();
    }


    public void GenerateNextSpikeWithGap()
    {
        Invoke("generateSpike", aralik); //9 kalp gelir can basar ama 5 saniyede bir falan
    }
    public void generateSpike()
    {
        GameObject SpikeIns = Instantiate(spike, transform.position, transform.rotation);

        SpikeIns.GetComponent<Spike>().spikeGenerator = this;

    }
    void Update()
    {
        if(currentSpeed < maxSpeed)
        {
            currentSpeed += speedMultiplier;
        }
    }
}
