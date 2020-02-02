using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShipPart : Interactable
{
    const float MAX_HEALTH = 100;
    public float health;

    public bool hasItem = false;

    public GameObject requiredItem;
    public GameObject requiredTool;
    public Sprite[] spriteList;
    
    // Start is called before the first frame update
    void Start()
    {
        health = MAX_HEALTH;
        // Debug.Log($"Required Item: {requiredItem}, Required Tool: {requiredTool}");
        gameObject.GetComponent<SpriteRenderer>().sprite = spriteList[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<ShipEventManager>().assignedPart)
        {
            if (FindObjectOfType<ShipEventManager>().assignedPart.name == gameObject.name)
            {
                requiredItem = FindObjectOfType<ShipEventManager>().assignedItem;
                requiredTool = FindObjectOfType<ShipEventManager>().assignedTool;
            }
        }

        if (health > 50)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = spriteList[0];
        }

        if (health <= 50)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = spriteList[1];
        }

        if (health <= 0)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = spriteList[2];
        }
    }

    override public void interact(PlayerInventory pi) {

        if (pi.item == requiredTool && hasItem && health > 0)
        {
            health = MAX_HEALTH;
        }
    }

    public void damage() {
        if (health <= 0) {
            return;
        }
        health -= 10;
        if (health <= 0) {
            LevelGlobal.broken++;
            if (LevelGlobal.broken >= 3) {
                LevelGlobal.LevelText = "Despite your best efforts, your ship was destroyed and you never made it to your concert";
                SceneManager.LoadSceneAsync("ending");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);

        if (requiredItem == collision.gameObject)
        {
            hasItem = true;
            collision.gameObject.SetActive(false);
            Debug.Log("Henlo BitchAss");
        }

    }

}
