using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
    public string url = "https://jsonplaceholder.typicode.com/posts";

    IEnumerator Start()
    {
        WWW www = new WWW(url);
        yield return www;

        if (www.text == null)
        {
            Debug.Log("WWW Ok!: " + www.text);
        }
        else
        {
            Debug.Log("WWW Error: " + www.error);
        }

    }
}