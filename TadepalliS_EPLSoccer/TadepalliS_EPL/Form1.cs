/************************************************************
    PROGRAMME	:	BONUS English Premier League Predictor

    OUTLINE		:	This program reads a file called "teams.txt."
                    This program reads the name and the rating 
                    per team. The program then matches each team
                    with one another, and bases on the ratings, the
                    goals of each team is decided. The winner's gains
                    3 points, a tie results in both teams gainign 1 point
                    and a loss results in no change to the points. 
                    At the end, the teams with the 3 highest points are
                    outputted as first place, second place and third place.
                    if there is a tie in between the points of the top
                    3 teams, then whichever team has the highest number
                    of goals wins. (simulate the goals using the rating).
                    each match's details (match number, first team name, 
                    first team score for that game, second team name, 
                    second team score for that game, and match outcome) is
                    to be listed to a list view. An output file names
                    "stats.txt" should contain the stats for each team.
                    the stats include the team name, the team's rating, 
                    teams number of wins, ties, and losses, teams total
                    goals, and the teams total points for the season.                     


    PROGRAMMER	:	Saikrishna Tadepalli

    DATE		:	Friday Jan 17th 2020
************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TadepalliS_EPL
{
    // ranking is decided by sorting the teams for points, if there is a tie in points, whoever has the higher goals scored wins. 
    public partial class frmMain : Form
    {
        private int match = 0;
        private Team[] myTeams;
        private Random rand = new Random();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void GetData()
        {
            string[] lines = File.ReadAllLines("teams.txt");

            lines = lines.ToList().OrderBy(a => Guid.NewGuid()).ToList().ToArray();
            myTeams = new Team[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                string[] line = lines[i].Split('*');
                myTeams[i] = new Team(line[0], int.Parse(line[1]));
            }
        }

        private void SetMatches(Array myArray)
        {
            List<string> combinations = new List<string>();

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray.Length; j++)
                {
                    if (i == j || i > j)
                        continue;
                    else if (i < j)
                        combinations.Add(i.ToString() + j.ToString());
                }
            }

            combinations = combinations.Distinct().ToList();
            combinations = combinations.OrderBy(a => Guid.NewGuid()).ToList();

            for (int i = 0; i < combinations.Count; i++)
            {
                int first = int.Parse(combinations[i][0].ToString());
                int second = int.Parse(combinations[i][1].ToString());

                match += 1;
                Match(first, second, match);
            }
        }

        private void Match(int team1Index, int team2Index, int matchNum)
        {
            Team team1 = myTeams[team1Index];
            Team team2 = myTeams[team2Index];

            int team1Score = rand.Next(0, team1.rating * 10) / 20;
            int team2Score = rand.Next(0, team2.rating * 10) / 20;

            team1.goals += team1Score;
            team2.goals += team2Score;

            string outcome = "";

            if (team1Score == team2Score)
            {
                team1.matchTied();
                team2.matchTied();
                outcome = "Tie!";
            }
            else if (team1Score > team2Score)
            {
                team1.matchWon();
                team2.matchLost();
                outcome = team1.name + "!";
            }
            else
            {
                team1.matchLost();
                team2.matchWon();
                outcome = team2.name + "!";
            }

            string[] row = { team1.name,team1Score.ToString(), team2.name, team2Score.ToString(), outcome };
            lsvOut.Items.Add(matchNum.ToString("D2")).SubItems.AddRange(row);
        }

        private void Ranking()
        {
            Team[] organizedTeams = myTeams;
            organizedTeams = SortPoints(organizedTeams);

            Team[] top3 = { organizedTeams[0], organizedTeams[1], organizedTeams[2] };
            top3 = SortGoals(top3);

            lblFirstPlace.Text = "1st: " + top3[0].name;
            lblSecondPlace.Text = "2nd: " + top3[1].name;
            lblThirdPlace.Text = "3rd: " + top3[2].name;
        }

        private Team[] SortPoints(Team[] sort)
        {
            int i, j;
            int N = sort.Length;

            for (j = N - 1; j > 0; j--)
                for (i = 0; i < j; i++)
                    if (sort[i].points > sort[i + 1].points)
                        Exchange(sort, i, i + 1);

            Array.Reverse(sort);
            return sort;
        }
        private Team[] SortGoals(Team[] sort)
        {
            int i, j;
            int N = sort.Length;

            for (j = N - 1; j > 0; j--)
                for (i = 0; i < j; i++)
                    if (sort[i].points > sort[i + 1].points || sort[i].goals > sort[i + 1].goals)
                        Exchange(sort, i, i + 1);

            Array.Reverse(sort);
            return sort;
        }

        private void Exchange(Team[] teamArr,int m, int n)
        {
            Team temporary;

            temporary = teamArr[m];
            teamArr[m] = teamArr[n];
            teamArr[n] = temporary;
        }

        private void WriteStats()
        {
            StreamWriter SW = File.CreateText("stats.txt");

            SW.WriteLine("TeamName. Rating. Wins. Ties. Losses. Goals. Points.\n");

            for (int i = 0; i < myTeams.Length; i++)
            {
                SW.WriteLine((myTeams[i].name + " (Rating: " + myTeams[i].rating + "/10) Stats:").PadRight(50, ' ') + 
                    "Wins - " + ". " + myTeams[i].wins.ToString("D2") + ". Ties - " + myTeams[i].ties.ToString("D2") 
                    + ". Losses - " + myTeams[i].losses.ToString("D2") + ". Total Goals - " 
                    + myTeams[i].goals.ToString("D2") + ". Points - " + myTeams[i].points.ToString("D2"));
            }

            SW.Close();
        }

        private void btnPredict_Click(object sender, EventArgs e)
        {
            lsvOut.Items.Clear();
            match = 0;
            GetData();
            SetMatches(myTeams);
            Ranking();
            WriteStats();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
