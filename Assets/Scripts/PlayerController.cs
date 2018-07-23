using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public Rigidbody rb;
    public float speed = 5f;
    private int count;
    public Text countText;
    public Text winText;

    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        UpdateText();
        winText.text = "";
    }

    private void UpdateText()
    {
        countText.text = "Count: " + count.ToString();
        if(count >= 12)
        {
            winText.text = "You Win!";
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        // If we hit a pick up
        if(collider.gameObject.CompareTag("Pick Up"))
        {
            collider.gameObject.SetActive(false);
            count++;
            UpdateText();
        }
    }

    // Update called before physics calculations
    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal") * speed;
        float moveVertical = Input.GetAxis("Vertical") * speed;
        Vector3 force = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(force);
    }
}
