using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Vector3 direction;
    public FloorSpawner floorSpawnerScript;
    public float speed;
    public static bool fell;
    public float addedSpeed;

    public GameObject inGameScreen, loseScreen;

    // Start is called before the first frame update
    void Start()
    {
        direction = Vector3.forward;
        fell = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= 0.5f)
        {
            fell = true;
            inGameScreen.SetActive(false);
            loseScreen.SetActive(true);
        }
        if (fell == true)
        {
            return;
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (direction.x == 0)
            {
                direction = Vector3.left;
            }
            else
            {
                direction = Vector3.forward;
            }

            speed += addedSpeed * Time.deltaTime;
        }
    }

    private void FixedUpdate()
    {
        Vector3 movement = direction * Time.deltaTime * speed;
        transform.position += movement;
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            Skor.skor++;
            collision.gameObject.AddComponent<Rigidbody>();
            floorSpawnerScript.floor_spawn();
            StartCoroutine(WipeFloor(collision.gameObject));
            DataManager.Instance.skor++;
        }
    }

    IEnumerator WipeFloor(GameObject DeleteFloor)
    {
        yield return new WaitForSeconds(3f);
        Destroy(DeleteFloor);
    }
}
