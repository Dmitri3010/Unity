
using UnityEngine;

public class TankMove : MonoBehaviour {
    [SerializeField]
    private float speed = 20f;
    [SerializeField]
    private float lookspeed = 30f;
    [SerializeField]
    private AudioSource shootaudio;
    [SerializeField]

    private AudioClip move_audio;
    public GameObject bullet, startstvol, turret, gun, exploid, player, spawn;
    float angleroot, angleheight, bullet_speed, _bullet, _speed, h =10, k;
    private float turret_speed = 10f;
    
    void Start()
    {
        shootaudio = GetComponent<AudioSource>();
    }

    void RotateTurret()
    {
        angleroot = Time.deltaTime * Input.GetAxis("Mouse X")*turret_speed;
        angleheight = Time.deltaTime * Input.GetAxis("Mouse Y") * turret_speed;

        turret.transform.Rotate(0, angleroot, 0);
        gun.transform.Rotate(angleheight, 0, 0);



    }

         
    void Update()
    {
        float xMov = Input.GetAxisRaw("Horizontal");
        float yMov = Input.GetAxisRaw("Vertical");

        transform.Translate(-Vector3.forward * yMov * Time.deltaTime*speed);
        transform.Rotate(Vector3.up * xMov *lookspeed* Time.deltaTime, Space.World);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            shootaudio.Play();
            Vector3 spawnpoint = startstvol.transform.position;
            Quaternion spawnroot = startstvol.transform.rotation;
            GameObject fire_bullet = Instantiate(bullet, spawnpoint, spawnroot) as GameObject;
            Rigidbody run = fire_bullet.GetComponent<Rigidbody>();
            run.AddForce(-fire_bullet.transform.forward * 100, ForceMode.Impulse);
            

        }

        RotateTurret();

        if(Input.GetKeyDown(KeyCode.W) )
        {
            GetComponent<AudioSource>().PlayOneShot(move_audio);

        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            GetComponent<AudioSource>().Stop();
        }


    }
    public void ApplyParams()
    {
        speed = _speed;
        bullet_speed = _bullet;
    }
    public void hide()
    {
        h = -140;
    }
    public void show()
    {
        h = 10;
    }
    void OnGUI()
    {
        GUI.BeginGroup(new Rect(10, h, 250, 220));
        GUI.Box(new Rect(0, 0, 200, 270), "Параметры танка");
        GUI.Label(new Rect(15, 30, 200, 30), "Скорость танка  " + _speed + "  ");
        _speed = GUI.HorizontalSlider(new Rect(15, 50, 170, 30), _speed, 0.0f, 10.0f);
        GUI.Label(new Rect(15, 80, 200, 30), "Скорость снаряда  " + _bullet + "    ");
        _bullet = GUI.HorizontalSlider(new Rect(15, 100, 170, 30), _bullet, 0.0f, 100.0f);
        if (GUI.Button(new Rect(15, 130, 170, 20), "ок"))
        {
            ApplyParams();
        }
        if (GUI.Button(new Rect(15, 150, 170, 20), "Скрыть"))
        {
            hide();
        }
        if (GUI.Button(new Rect(15, 170, 170, 20), "Показать"))
        {
            show();
        }
        GUI.EndGroup();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "turretbullet")
        {
            k = k + 1;
            if (k == 6)
            {
                Instantiate(exploid, GetComponent<Rigidbody>().position, GetComponent<Rigidbody>().rotation);

                
                player.transform.position = spawn.transform.position;
                enterTank.enter = false;
                player.SetActive(true);
                gameObject.SetActive(false);
                transform.GetComponentInParent<TankMove>().enabled = false;enterTank.enter = false;
                this.enabled = false;
                Destroy(other.gameObject);
                Destroy(gameObject);
                Destroy_exploid();
                Destroy(GameObject.Find("bullet(Clone)"), 0f);
                k = 0;
            }
        }
    }

    private void Destroy_exploid()
    {
        Destroy(GameObject.Find("Pyroclastic Puff(Clone)"), 1f);

    }
}
