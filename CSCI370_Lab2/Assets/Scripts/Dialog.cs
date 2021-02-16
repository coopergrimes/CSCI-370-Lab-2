using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog : MonoBehaviour
{

    int num = 0;
    string s = "";
    List<string> words = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        words.Add("In need to find my home before my owner returns and sees me out!");
        words.Add("This is not my home. I need to find my home.");
        words.Add("I do not belong here.");
        words.Add("I need to find my way back home.");
        words.Add("This is not my home either.");
        words.Add("I don't remember my home looking like this.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void getNextLine()
    {
        num %= words.Count;
        s = words[num];
        num += 1;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            getNextLine();
            GameManager.Instance.StartDialog(s);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.HideDialog();
        }
    }

}
