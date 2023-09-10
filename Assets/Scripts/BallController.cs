using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    public int force;
    Rigidbody2D rigid;
    private int count;
    public Text countText;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        Vector2 arah = new Vector2(0, -2).normalized;
        rigid.AddForce(arah * force);

        count = 0;
        countText.text = count.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "TepiBawah")
        {

        }
        if (coll.gameObject.name == "Player")
        {
            float sudut = (transform.position.x - coll.transform.position.x) * 5f;
            Vector2 arah = new Vector2(sudut, rigid.velocity.y).normalized;
            rigid.velocity = new Vector2(0, 0);
            rigid.AddForce(arah * force * 2);

            //Vector2 arah = transform.position - coll.transform.position;

            //rigid.AddForce(arah);
            // rigid.velocity = arah.normalized * 8;
        }
        if (coll.gameObject.CompareTag("Pick Up"))
        {
            coll.gameObject.SetActive(false);
            count = count + 5;
            SetCountText();
        }
        if (count >= 100)
        {
            Application.LoadLevel("Victory");
        }
        if (coll.gameObject.name == "TepiBawah")
        {
            Application.LoadLevel("GameOver");
        }
    }

    void SetCountText()
    {
        countText.text = count.ToString();
    }
}
