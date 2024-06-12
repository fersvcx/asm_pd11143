using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.IO;
using System.Threading;
using System;
using UnityEngine.SocialPlatforms.Impl;
using System.Text;

public class ASM_MN : Singleton<ASM_MN>
{
    public List<Region> listRegion = new List<Region>();
    public List<Players> listPlayer = new List<Players>();

    private void Start()
    {
        createRegion();
    }

    public void createRegion()
    {
        listRegion.Add(new Region(0, "VN"));
        listRegion.Add(new Region(1, "VN1"));
        listRegion.Add(new Region(2, "VN2"));
        listRegion.Add(new Region(3, "JS"));
        listRegion.Add(new Region(4, "VS"));
    }

    public string calculate_rank(int score)
    {
        Console.OutputEncoding = Encoding.UTF8;
        if (score < 100)
        {

            return "Đồng";
        }
        else if (score < 500)
        {
           return "Bạc";
        }
        else if (score < 1000)
        {
            return "Vàng";
        }
        else if (score > 1000)
        {
            return "Kim cương";
        }
        return null;
    }

    public void YC1()
    {
        // sinh viên viết tiếp code ở đây
        string name = ScoreKeeper.Instance.GetUserName();
        int id = ScoreKeeper.Instance.GetID();
        int idR = ScoreKeeper.Instance.GetIDregion();

        int score = ScoreKeeper.Instance.GetScore();

        string regionName = "";

        if(idR == 0)
        {
            regionName = "Vn";
        }else if(idR == 1)
        {
            regionName = "Vn1";
        }


        Players player1 = new Players(id, "Nam", 1111, new Region(2, "VN2"));
        listPlayer.Add(player1);
        Players player2 = new Players(id, "Huy", 1111, new Region(3, "JS"));
        listPlayer.Add(player2);

        Region playerRegion1 = new Region(idR, regionName);
        Players player3 = new Players(id, name, score,playerRegion1);
        listPlayer.Add(player3);
    }
    public void YC2()
    {

        // sinh viên viết tiếp code ở đây
        foreach (Players player in listPlayer)
        {
            Debug.Log("Player Name: " + player.Name + "- Score:" + player.Score + " - " + player.PlayerRegion + player.PlayerRegion.Name + "Rank:" + calculate_rank(player.Score));

        }
    }
    public void YC3()
    {
        // sinh viên viết tiếp code ở đây
    }
    public void YC4()
    {
        // sinh viên viết tiếp code ở đây
    }
    public void YC5()
    {
        // sinh viên viết tiếp code ở đây
    }
    public void YC6()
    {
        // sinh viên viết tiếp code ở đây
    }
    public void YC7()
    {
        // sinh viên viết tiếp code ở đây
    }
    void CalculateAndSaveAverageScoreByRegion()
    {
        // sinh viên viết tiếp code ở đây
    }

}

[SerializeField]
public class Region
{
    public int ID;
    public string Name;
    public Region(int ID, string Name)
    {
        this.ID = ID;
        this.Name = Name;
    }
}

[SerializeField]
public class Players
{
    // sinh viên viết tiếp code ở đây
    public int Id { get; set; }
    public string Name { get; set; }

    public int Score {  get; set; }
    public Region PlayerRegion {  get; set; }
    ScoreKeeper sc;
    public Players(int id, string name, int score, Region region)
    {
        Id = id;
        Name = name;
        Score = score;
        PlayerRegion = region;
    }
}