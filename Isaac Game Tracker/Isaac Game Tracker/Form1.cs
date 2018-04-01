using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IGGnis_Game_Tracker
{
    public partial class Form1 : Form
    {
        BindingList<Game> games = new BindingList<Game> ();
        static String[] characters = { "Isaac", "Magdalene", "Cain", "Judas", "???", "Eve", "Samson", "Azazel", "Lazarus", "Eden", "The Lost", "Lilith", "Keeper", "Apollyon" };

        int[] wins = new int[characters.Length];
        int[] streaks = new int[characters.Length + 1];
        int[] longeststreaks = new int[characters.Length + 1];

        int victories = 0;
        int defeats = 0;
        int longeststreak = 0;
        int currentstreak = 0;

        int numberofgames = 10000;

        public class Game
        {
            public String Character { get; set; }
            public Boolean WonRun { get; set; }

            public Game(String character, Boolean victory)
            {
                this.Character = character;
                this.WonRun = victory;
            }
        }

        public Form1()
        {
            InitializeComponent();

            victories = 0;
            defeats = 0;
            currentstreak = 0;
            longeststreak = 0;

            LoadGames();
            UpdateLabels();
            CalculateStats();

            cmb_Character.DataSource = characters;
            dgv_Record.DataSource = games;
        }

        private void btn_Victory_Click(object sender, EventArgs e)
        {
            Game thisGame = new IGGnis_Game_Tracker.Form1.Game(cmb_Character.SelectedValue.ToString(), true);
            AddGame(thisGame, true);
        }

        private void btn_Defeat_Click(object sender, EventArgs e)
        {
            Game thisGame = new IGGnis_Game_Tracker.Form1.Game(cmb_Character.SelectedValue.ToString(), false);
            AddGame(thisGame, true);
        }

        private void CalculateStats ()
        {

            for (int x = 0; x < characters.Length; ++ x)
            {
                wins[x] = 0;
                streaks[x] = 0;
                longeststreaks[x] = 0;
            }

            streaks[characters.Length] = 0;
            longeststreaks[characters.Length] = 0;

            for (int g = games.Count - 1; g >= 0; --g)
            {
                string characterName = games[g].Character;
                int characterNumber = Array.IndexOf(characters, characterName);

                if (games[g].WonRun)
                {
                    streaks[characterNumber] ++;
                    streaks[characters.Length] ++;
                    wins[characterNumber]++;
                }
                else
                {
                    if (streaks[characters.Length] > longeststreaks[characters.Length])
                    {
                        longeststreaks[characters.Length] = streaks[characters.Length];
                    }

                    if (streaks [characterNumber] > longeststreaks[characterNumber])
                    {
                        longeststreaks[characterNumber] = streaks[characterNumber];
                    }

                    streaks[characters.Length] = 0;
                    streaks[characterNumber] = 0;
                }
            }

            for (int c = 0; c <= characters.Length; ++ c)
            {
                if (streaks [c] > longeststreaks [c])
                {
                    longeststreaks[c] = streaks[c];
                }
            }

            int max = wins.Max();
            int min = wins.Min();

            if (min == 0 && max != 0)
            {
                min = wins.OrderByDescending(x => x).Distinct().Reverse().Skip(1).First();
            }

            lbl_MostWinsText.Text = String.Format("{0} - {1}", characters[Array.IndexOf(wins, max)], max);
            lbl_FewestWinsText.Text = String.Format("{0} - {1}", characters[Array.IndexOf(wins, min)], min);
            lbl_LongestStreakNumber.Text = longeststreak.ToString();
            lbl_CurrentStreakNumber.Text = currentstreak.ToString();
        }

        private void AddGame (Game g, bool save)
        {
            games.Insert(0, g);

            if (g.WonRun)
            {
                ++victories;
            }
            else
            {
                ++defeats;
            }

            while (games.Count > numberofgames)
            {
                if (games[numberofgames].WonRun)
                {
                    --victories;
                }
                else
                {
                    --defeats;
                }

                games.RemoveAt(numberofgames);
            }

            if (save)
            {
                CalculateStats();
                UpdateLabels();
                SaveGames();
            }
        }

        private void UpdateLabels ()
        {
            lbl_WinCount.Text = victories.ToString();
            lbl_LossCount.Text = defeats.ToString();
        }

        private void LoadGames()
        {
            while (games.Count > 0)
            {
                games.RemoveAt(0);
            }

            try
            {
                using (System.IO.StreamReader file = new System.IO.StreamReader(@".\games.txt"))
                {
                    String line;
                    while ((line = file.ReadLine()) != null)
                    {
                        string characterString;
                        int characterNumber;
                        Boolean b;

                        characterString = line.Split(';')[0];
                        Int32.TryParse(characterString, out characterNumber);
                        b = line.Split(';')[1] == "1";

                        if (characterNumber < 0 || characterNumber > characters.Length)
                        {

                        }
                        else
                        {
                            Game game = new IGGnis_Game_Tracker.Form1.Game(characters[characterNumber], b);
                            AddGame(game, false);
                        }
                    }
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                // No file was found.  Create an empty file.
                System.IO.StreamWriter fileWrite = new System.IO.StreamWriter(@".\games.txt");
                fileWrite.Flush();
                fileWrite.Close();
            }
        }

        private void SaveGames ()
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@".\games.txt", false))
                {
                    var chars = characters.ToArray<String>();

                    for (int i = games.Count - 1; i >= 0; -- i)
                    {
                        file.WriteLine(String.Format("{0};{1}", Array.IndexOf(chars, games[i].Character), (games[i].WonRun == true ? "1" : "0")));
                    }

                    file.Flush();
                    file.Close();
                }

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@".\wl.txt", false))
                {
                    file.WriteLine(String.Format("{0}-{1}", victories, defeats));
                    file.Flush();
                    file.Close();
                }

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@".\longest.txt", false))
                {
                    file.WriteLine(String.Format("{0}", longeststreaks[characters.Length]));
                    file.Flush();
                    file.Close();
                }

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@".\current.txt", false))
                {
                    file.WriteLine(String.Format("{0}", streaks[characters.Length]));
                    file.Flush();
                    file.Close();
                }

                for (int c = 0; c < characters.Length; ++c)
                {
                    string whichCharacter = characters[c].ToLower();
                    if (whichCharacter.Equals("???"))
                    {
                        whichCharacter = "blue baby";
                    }

                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(String.Format(@".\{0}_current.txt", whichCharacter)))
                    {
                        file.WriteLine(String.Format("{0}", streaks[c]));
                        file.Flush();
                        file.Close();
                    }

                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(String.Format(@".\{0}_longest.txt", whichCharacter)))
                    {
                        file.WriteLine(String.Format("{0}", longeststreaks[c]));
                        file.Flush();
                        file.Close();
                    }
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            while (games.Count > 0)
            {
                games.RemoveAt(0);
            }

            victories = 0;
            defeats = 0;
            longeststreak = 0;
            currentstreak = 0;

            SaveGames();
            UpdateLabels();
            CalculateStats();
        }
    }
}
