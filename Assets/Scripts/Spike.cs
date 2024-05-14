using UnityEngine;
using UnityEngine.UI;



public class Spike : MonoBehaviour
{
    public int nextEngel = 0;
    public SpikeGenerator spikeGenerator;
    void Update()
    {
        transform.Translate(Vector2.left * spikeGenerator.currentSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Next"))
        {
            spikeGenerator.GenerateNextSpikeWithGap();
            
        }

        /*if (collision.gameObject.CompareTag("Finish"))
        {
            Destroy(this.gameObject);
            
        }*/

        /*if (collision.gameObject.CompareTag("Player"))
        {
            print("temas var spikeda");
            Destroy(this.gameObject);
        }
        if (collision.gameObject.CompareTag("Attack"))
        {
            print("attack triggerlandi kardsm");
            Destroy(this.gameObject);
        }*/
    }
}
