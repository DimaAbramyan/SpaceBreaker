using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GiveRandomEnemyBuff : MonoBehaviour
{
    [SerializeField] int CountOfGettingBuff;
    List<Buff> m_BuffList;
    List<Enemy> ships;
    void Awake()
    {
        ships = GetComponentsInChildren<Enemy>().ToList<Enemy>();
        List<int> Cnt = CreateNumbOfBuffingEnemy(CountOfGettingBuff, ships);
        Debug.Log(ships.Count());
        for (int i = 0; i < ships.Count; i++)
        {
            {
                if (Cnt.Contains(i))
                ships[i].gameObject.AddComponent<IHaveBuff>();
            }
        }

        // Update is called once per frame
        void Update()
        {

        }

        List<int> CreateNumbOfBuffingEnemy(int cnt, List<Enemy> lnght)
        {
            List<int> res = new List<int>();
            while (cnt > 0) 
            {
                int RandomNumb = Random.Range(0, lnght.Count);
                if (lnght[RandomNumb].GetComponent<Enemy>().Buff != null && res.Contains(RandomNumb))
                    continue;
                res.Add(RandomNumb);
                cnt--;
            }
            return res;
        }
    }
}
