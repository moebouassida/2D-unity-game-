using UnityEngine;

public class PickUpCoin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            Inventory.instance.AddCoins(1);
            Destroy(gameObject);
        }    
    }
   
}
