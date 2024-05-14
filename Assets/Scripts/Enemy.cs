using UnityEngine;
using UnityEngine.UI;



public class Enemy : MonoBehaviour
{
    public int nextEngel = 0;
    public EnemyGenerator enemyGenerator;
    void Update()
    {
        transform.Translate(Vector2.left * enemyGenerator.currentSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("NextEnemy"))
        {
            enemyGenerator.GenerateNextEnemyWithGap();
            
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
