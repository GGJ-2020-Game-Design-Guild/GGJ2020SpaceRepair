using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShipPart : Interactable
{
    const float MAX_HEALTH = 100;
    public float health;

    public bool hasItem = false;

    public Item requiredItem;
    public Tool requiredTool;
    public Sprite[] spriteList;

    bool animBool = false;
    
    // Start is called before the first frame update
    void Start()
    {
        health = MAX_HEALTH;
        // Debug.Log($"Required Item: {requiredItem}, Required Tool: {requiredTool}");
        if (spriteList.Length > 0)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = spriteList[0];
        }
        InvokeRepeating("changeBool", 0, 2);
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

        if (spriteList.Length > 0)
        {
            if (health > 50)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = spriteList[0];
            }

            if (health <= 50)
            {
                if (spriteList.Length == 4)
                {
                    if (animBool)
                    {
                        gameObject.GetComponent<SpriteRenderer>().sprite = spriteList[1];
                    }
                    else
                    {
                        gameObject.GetComponent<SpriteRenderer>().sprite = spriteList[2];
                    }
                }
                else
                {
                    gameObject.GetComponent<SpriteRenderer>().sprite = spriteList[1];
                }
            }

            if (health <= 0)
            {
                if (spriteList.Length == 4)
                {
                    gameObject.GetComponent<SpriteRenderer>().sprite = spriteList[3];
                }
                else
                {
                    gameObject.GetComponent<SpriteRenderer>().sprite = spriteList[2];
                }
            }
        }
    }

    override public void interact(PlayerInventory pi) {

        if (pi.item.name.Equals(requiredTool.name) && hasItem && health > 0)
        {
            health = MAX_HEALTH;
            requiredTool = null;
            requiredItem = null;
        }
    }

    public void damage() {
        if (health <= 0) {
            return;
        }
        health -= Random.Range(40,60);
        if (health <= 0) {
            LevelGlobal.broken++;
            if (LevelGlobal.broken >= 3) {
                LevelGlobal.LevelText = "Despite your best efforts, your ship was destroyed and you never made it to your concert";
                SceneManager.LoadSceneAsync("ending");
            }
        }
        hasItem = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Got item at all");
        if (requiredItem && requiredItem.name.Equals(collision.GetComponent<Item>().name))
        {
            hasItem = true;
            collision.gameObject.SetActive(false);
        }

    }

    private void changeBool()
    {
        animBool = !animBool;
    }

}
