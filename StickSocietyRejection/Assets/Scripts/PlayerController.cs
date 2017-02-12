using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
    int walkSpeed = 5;
    int jumpSpeed = 200;
    double start;
    bool safe = false;
    bool onGround = true;

	// Use this for initialization
	void Start () {
        start = Time.time;
    }
	
	// Update is called once per frame
	void Update () {
        // Kill player if too far off left or bottom side of screen
        if ((Camera.main.WorldToViewportPoint(transform.position).x <= 0.2) ||
            (Camera.main.WorldToViewportPoint(transform.position).y <= -0.2)) {
            DeathIsUponUs();
        }

        if ((Time.time >= start + 60.0) && (!safe)) {
            DeathIsUponUs();
        }

        if (Time.time > (start + 21.0))
        {
            // Handle walking right
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(new Vector3(walkSpeed * Time.deltaTime, 0, 0));
                runWalkingAnimation();
            }
            // Handle walking left
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(new Vector3(-walkSpeed * Time.deltaTime, 0, 0));
                runWalkingAnimation();
            }
            // Handle jumping
            if (Input.GetKey(KeyCode.Space))
            {
                if (onGround) {
                    onGround = false;

                    transform.Translate(new Vector3(0, jumpSpeed * Time.deltaTime, 0));
                    runJumpingAnimation();
                }
                
            }
        }
    }

    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == "Scarf") {
            runWinProcess();
        }

        if (coll.gameObject.tag == "Poison") {
            DeathIsUponUs();
        }

        if (coll.gameObject.tag == "Ledge") {
            safe = true;
        }

        if (coll.gameObject.tag == "Ground")
        {
            onGround = true;
        }
    }

    void runWalkingAnimation() {
        //TODO: Fix line 20 (need to convert this to GameObject)
        //GameObject frontLegs = getChildGameObject(this,"FrontLeg");
        //frontLegrunJumpingAnimations.GetComponent<Animation>().Play("catWalking");
    }

    void runJumpingAnimation() {
        //TODO: Fix line 20 (need to convert this to GameObject)
        //GameObject frontLegs = getChildGameObject(this,"FrontLeg");
        //frontLegs.GetComponent<Animation>().Play("catWalking");
    }

    void runWinProcess() {

        // Go to win scene
        SceneManager.LoadScene(2);
    }

    void DeathIsUponUs() {
        SceneManager.LoadScene(3);
    }
}
