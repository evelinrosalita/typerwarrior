using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;



public class Gamevalue : MonoBehaviour {

    public Animator m_animator;
	public GameObject gameOverMenu;
	public GameObject gameWinMenu;

	public Text dmgeTxt;
	public Text hpTxt;
	public Text monTxt;
	public Text priceDmgeTxt;
	public Text priceHpTxt;
	public Text enemyhpTxt;
	public Text canvasHealthPointTxt;

	public Text showTxt;
	public InputField inputTxt;

	public string[] words = {

	};

	public int index = 0;

	public Slider PlayerHealthBar;
	public Slider EnemyHealthBar;
	public GameObject Slider;
	public Timer timer4second;
	public bool gameOver = false;
	public bool gameWin = false;
		
	float damage =5f;
	float health;
	float money;
	float priceDmg;
	float priceHp;
	float canvasHp;

	float enemydamage;
	float enemyhp;
	float currentMoney;
	float currentPlayerHealth, currentEnemyHealth;
	float currentdamage, currentStaticHealth;
	float currentPriceDamage, currentPriceHp;


	// Use this for initialization
	void Start () {

        //m_animator = GetComponent<Animator>();
			
		damage = 5f;
		damageTxt ();


		health = 15f;
		healthTxt ();

		money = 4f;
		moneyTxt ();

		priceDmg = 4f;
		priceDamageTxt ();

		priceHp = 2f;
		priceHealthTxt ();


		enemydamage = 2f;
		enemyhp = 40f;
		enemyhealthTXt ();

		canvasHp = health;
		canvasHpTxt ();


		currentPlayerHealth = health;
		currentEnemyHealth = enemyhp;
		currentMoney = money;
		currentdamage = damage;
		currentStaticHealth = health;
		currentPriceDamage = priceDmg;
		currentPriceHp = priceHp;

		showTxt.text = words [index];

		PlayerHealthBar.value = calculatePlayerHealth ();
		EnemyHealthBar.value = calculateEnemyHealth ();

		if (currentPlayerHealth != 0 && currentEnemyHealth != 0)
		{
			GameLoop ();
		}

       
    }
	
	// Update is called once per frame
	void Update () {


		damageTxt ();
		healthTxt();
		canvasHpTxt ();
		enemyhealthTXt ();
		moneyTxt ();
		priceDamageTxt ();
		priceHealthTxt ();


		PlayerHealthBar.value = calculatePlayerHealth (); // slider
		EnemyHealthBar.value = calculateEnemyHealth (); // slider


        if (currentEnemyHealth <= 0)
        {
            die();
			GameWin ();
        }
			
        else if (currentPlayerHealth <= 0)
        {
            m_animator.SetTrigger("dead");
            Debug.Log("You is dead");
			GameOver ();
        }

    }

	public void clicked1 (){

		if (currentMoney >= currentPriceDamage) {
			currentMoney = currentMoney - currentPriceDamage;
			currentPriceDamage = currentPriceDamage + 2f;
			currentdamage = currentdamage + 1f;
		}

		moneyTxt ();
		priceDamageTxt ();
		damageTxt ();
	}

	public void clicked2 (){

		if (currentMoney >= currentPriceHp) {
			currentMoney = currentMoney - currentPriceHp;
			currentPriceHp = currentPriceHp + 2;
			currentStaticHealth = currentStaticHealth + 2f;
		}

		moneyTxt ();
		priceHealthTxt ();
		damageTxt ();

	}

	public float calculatePlayerHealth()
	{
		return currentPlayerHealth / health;
	
	}

	public float calculateEnemyHealth()
	{
		return currentEnemyHealth / enemyhp;
	}
		

	void damageTxt()
	{
		dmgeTxt.text = currentdamage.ToString ();
	}

	void healthTxt()
	{
		hpTxt.text = currentPlayerHealth.ToString ();
	}

	void moneyTxt()
	{
		monTxt.text = currentMoney.ToString ();
	}

	void priceDamageTxt()
	{
		priceDmgeTxt.text = currentPriceDamage.ToString ();
	}

	void priceHealthTxt()
	{
		priceHpTxt.text = currentPriceHp.ToString ();
	}

	void enemyhealthTXt(){
		enemyhpTxt.text = currentEnemyHealth.ToString ();
	}

	//public int calculateMoney(){

	//	monTxt.text = currentMoney.ToString ();
	//}

	void canvasHpTxt()
	{
		canvasHealthPointTxt.text = currentStaticHealth.ToString ();
	}


    public void check()
    {


        if (inputTxt.text == words[index])
        {

            index = Random.Range(0, words.Length);
            showTxt.text = words[index];
            inputTxt.text = "";

            m_animator.SetTrigger("attack");


            currentEnemyHealth = currentEnemyHealth - damage;
            EnemyHealthBar.value = calculateEnemyHealth();

			if (currentEnemyHealth <= 0)
			{
				currentMoney = currentMoney + 4;
			}

            m_animator.SetTrigger("afterattack");
            Debug.Log("currentEnemy: " + currentEnemyHealth);
            Debug.Log("currentPlayer: " + currentPlayerHealth);
            
        }
			

    }


      
	void die()
	{
        
        currentEnemyHealth = 0;
		Debug.Log ("Enemy is dead");
	}



	public void GameLoop(){

			timer4second = new Timer (damageTimer, null, 0, 3000);
              
	}

	private void damageTimer(object o)
	{
		if (currentEnemyHealth != 0 && currentPlayerHealth !=0) {
			currentPlayerHealth = currentPlayerHealth - 1;
		}
  
	}

	public void GameOver()
	{
			gameOver = false;
			gameOverMenu.SetActive(true);

	}


	public void GameWin()
	{	
		gameWin = false;
		gameWinMenu.SetActive(true);
	}
		
}
