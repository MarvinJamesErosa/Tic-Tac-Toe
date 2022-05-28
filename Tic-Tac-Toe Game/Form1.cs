namespace Tic_Tac_Toe_Game
{
    public partial class gameScreen : Form
    {
        /* FOR X AND O BUTTON */
        int num;
        int mod;

        /* WIN SCENARIO // DRAW SCENARIO FIX */
        bool win = false;

        /* SCORE FUNCTION */
        int oscore = 0;
        int xscore = 0;

        /* FOR WIN SCENARIO */ /* 10 IS ARBITRARY VALUE // IT CAN BE ANY VALUE AS LONG AS IT IS NOT 1 OR 0 */ 
        int R1C1VAL = 10;
        int R1C2VAL = 10;
        int R1C3VAL = 10;
        int R2C1VAL = 10;
        int R2C2VAL = 10;
        int R2C3VAL = 10;
        int R3C1VAL = 10;
        int R3C2VAL = 10;
        int R3C3VAL = 10;

        /* COMPUTER MODE SWITCH */
        bool comp = false;

        public gameScreen()
        {
            InitializeComponent();
        }

        public void first()
        {
            if (comp & num == 1)
            {
                R2C2.PerformClick();
                gameSatus.Text = "Noice :)";
            }
        }

        public void algorithm()
        {
            mod = num % 2;

            if (comp & num >= 3 & mod != 0)
            {
                if (R1C1VAL == 10)
                {
                    R1C2.PerformClick();
                }
                else if (R1C2VAL == 10) 
                {
                    R1C2.PerformClick();
                }
                 else if (R1C3VAL == 10) 
                {
                    R1C3.PerformClick();
                }
                else if (R2C1VAL == 10)
                {
                    R2C1.PerformClick();
                }
                else if (R2C2VAL == 10)
                {
                    R2C2.PerformClick();
                }
                else if (R2C3VAL == 10)
                {
                    R2C3.PerformClick();
                }
                else if (R3C1VAL == 10)
                {
                    R3C1.PerformClick();
                }
                else if (R3C2VAL == 10)
                {
                    R3C2.PerformClick();
                }
                else if (R3C3VAL == 10)
                {
                    R3C3.PerformClick();
                }
            }

        }

        public void center()
        {
            if (comp & num == 1)
            {
                R1C2.PerformClick();
                gameSatus.Text = "Noice :)";
            }
        }

        private void R1C1_Click(object sender, EventArgs e)
        {
            /* FOR X AND O BUTTON */
            num = num + 1;
            mod = num % 2;

            if (mod == 0)
            {   /* FOR X AND O BUTTON */
                R1C1.Text = "X";
                /* FOR WIN SCENARIO */
                R1C1VAL = 1;
            }
            else
            {   /* FOR X AND O BUTTON*/
                R1C1.Text = "O";
                /* FOR WIN SCENARIO*/
                R1C1VAL = 0;
            }

            /* BUTTON DISABLE */
            R1C1.Enabled = false;

            /* COMPUTER MODE*/
            first();
            algorithm();
            
            /* O WIN SCENARIO */

                /*HORIZONTAL*/
            if (R1C1VAL == 0 & R1C2VAL == 0 & R1C3VAL == 0)
            {
                gameSatus.Text = "Player 1 Wins :)";

                /* GAME STATUS IDENTIFIER */
                win = true;

                /* SCORE FUNCTIONALITY */
                oscore = oscore + 1;
                scorePlayer1.Text = "Player O: " + oscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

                 /* VERTICAL */
            if (R1C1VAL == 0 & R2C1VAL == 0 & R3C1VAL == 0)
            {
                gameSatus.Text = "Player 1 Wins :)";

                /* GAME STATUS IDENTIFIER */
                win = true;

                /* SCORE FUNCTIONALITY */
                oscore = oscore + 1;
                scorePlayer1.Text = "Player O: " + oscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

                /* DIAGONAL */

            if (R1C1VAL == 0 & R2C2VAL == 0 & R3C3VAL == 0)
            {
                gameSatus.Text = "Player 1 Wins :)";

                /* GAME STATUS IDENTIFIER */
                win = true;

                /* SCORE FUNCTIONALITY */
                oscore = oscore + 1;
                scorePlayer1.Text = "Player O: " + oscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /* X WIN SCENARIO */

            /*HORIZONTAL*/
            if (R1C1VAL == 1 & R1C2VAL == 1 & R1C3VAL == 1)
            {
                gameSatus.Text = "Player 2 Wins :)";

                /* SCORE FUNCTIONALITY */
                xscore = xscore + 1;
                scorePlayer2.Text = "Player X: " + xscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /* VERTICAL */
            if (R1C1VAL == 1 & R2C1VAL == 1 & R3C1VAL == 1)
            {
                gameSatus.Text = "Player 2 Wins :)";

                /* SCORE FUNCTIONALITY */
                xscore = xscore + 1;
                scorePlayer2.Text = "Player X: " + xscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /* DIAGONAL */

            if (R1C1VAL == 1 & R2C2VAL == 1 & R3C3VAL == 1)
            {
                gameSatus.Text = "Player 2 Wins :)";

                /* SCORE FUNCTIONALITY */
                xscore = xscore + 1;
                scorePlayer2.Text = "Player X: " + xscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /*DRAW SCENARIO*/
            else if (num > 8 & win == false)
            {
                gameSatus.Text = "Nobody Wins :(";
            }
        }

        private void R1C2_Click(object sender, EventArgs e)
        {
            /* FOR X AND O BUTTON */
            num = num + 1;
            int mod = num % 2;

            if (mod == 0)
            {   /* FOR X AND O BUTTON */
                R1C2.Text = "X";
                /* FOR WIN SCENARIO */
                R1C2VAL = 1;
            }
            else
            {   /* FOR X AND O BUTTON*/
                R1C2.Text = "O";
                /* FOR WIN SCENARIO*/
                R1C2VAL = 0;
            }

            /* BUTTON DISABLE */
            R1C2.Enabled = false;

            /* COMPUTER MODE*/
            first();
            algorithm();

            /* O WIN SCENARIO */

            /* HORIZONTAL */
            if (R1C1VAL == 0 & R1C2VAL == 0 & R1C3VAL == 0)
            {
                gameSatus.Text = "Player 1 Wins :)";

                /* GAME STATUS IDENTIFIER */
                win = true;

                /* SCORE FUNCTIONALITY */
                oscore = oscore + 1;
                scorePlayer1.Text = "Player O: " + oscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C1.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

                 /* VERTICAL */
            if (R1C2VAL == 0 & R2C2VAL == 0 & R3C2VAL == 0)
            {
                gameSatus.Text = "Player 1 Wins :)";

                /* GAME STATUS IDENTIFIER */
                win = true;

                /* SCORE FUNCTIONALITY */
                oscore = oscore + 1;
                scorePlayer1.Text = "Player O: " + oscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C1.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /* X WIN SCENARIO */

            /* HORIZONTAL */
            if (R1C1VAL == 1 & R1C2VAL == 1 & R1C3VAL == 1)
            {
                gameSatus.Text = "Player 2 Wins :)";

                /* SCORE FUNCTIONALITY */
                xscore = xscore + 1;
                scorePlayer2.Text = "Player X: " + xscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C1.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /* VERTICAL */
            if (R1C2VAL == 1 & R2C2VAL == 1 & R3C2VAL == 1)
            {
                gameSatus.Text = "Player 2 Wins :)";

                /* SCORE FUNCTIONALITY */
                xscore = xscore + 1;
                scorePlayer2.Text = "Player X: " + xscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C1.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /*DRAW SCENARIO*/
            else if (num > 8 & win == false)
            {
                gameSatus.Text = "Nobody Wins :(";
            }
        }

        private void R1C3_Click(object sender, EventArgs e)
        {
            /* FOR X AND O BUTTON */
            num = num + 1;
            int mod = num % 2;

            if (mod == 0)
            {   /* FOR X AND O BUTTON */
                R1C3.Text = "X";
                /* FOR WIN SCENARIO */
                R1C3VAL = 1;
            }
            else
            {   /* FOR X AND O BUTTON*/
                R1C3.Text = "O";
                /* FOR WIN SCENARIO*/
                R1C3VAL = 0;
            }

            /* BUTTON DISABLE */
            R1C3.Enabled = false;

            /* COMPUTER MODE*/
            first();
            algorithm();

            /* O WIN SCENARIO */

            /*HORIZOTAL*/
            if (R1C1VAL == 0 & R1C2VAL == 0 & R1C3VAL == 0)
            {
                gameSatus.Text = "Player 1 Wins :)";

                /* GAME STATUS IDENTIFIER */
                win = true;

                /* SCORE FUNCTIONALITY */
                oscore = oscore + 1;
                scorePlayer1.Text = "Player O: " + oscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

                /* VERTICAL */
            if (R1C3VAL == 0 & R2C3VAL == 0 & R3C3VAL == 0)
            {
                gameSatus.Text = "Player 1 Wins :)";

                /* GAME STATUS IDENTIFIER */
                win = true;

                /* SCORE FUNCTIONALITY */
                oscore = oscore + 1;
                scorePlayer1.Text = "Player O: " + oscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /* DIAGONAL */
            if (R1C3VAL == 0 & R2C2VAL == 0 & R3C1VAL == 0)
            {
                gameSatus.Text = "Player 1 Wins :)";

                /* GAME STATUS IDENTIFIER */
                win = true;

                /* SCORE FUNCTIONALITY */
                oscore = oscore + 1;
                scorePlayer1.Text = "Player O: " + oscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /* X WIN SCENARIO */

            /* HORIZOTAL */
            if (R1C1VAL == 1 & R1C2VAL == 1 & R1C3VAL == 1)
            {
                gameSatus.Text = "Player 2 Wins :)";

                /* SCORE FUNCTIONALITY */
                xscore = xscore + 1;
                scorePlayer2.Text = "Player X: " + xscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /* VERTICAL */
            if (R1C3VAL == 1 & R2C3VAL == 1 & R3C3VAL == 1)
            {
                gameSatus.Text = "Player 2 Wins :)";

                /* SCORE FUNCTIONALITY */
                xscore = xscore + 1;
                scorePlayer2.Text = "Player X: " + xscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /* DIAGONAL */
            if (R1C3VAL == 1 & R2C2VAL == 1 & R3C1VAL == 1)
            {
                gameSatus.Text = "Player 2 Wins :)";

                /* SCORE FUNCTIONALITY */
                xscore = xscore + 1;
                scorePlayer2.Text = "Player X: " + xscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }
            /*DRAW SCENARIO*/
            else if (num > 8 & win == false)
            {
                gameSatus.Text = "Nobody Wins :(";
            }
        }

        private void R2C1_Click(object sender, EventArgs e)
        {
            /* FOR X AND O BUTTON */
            num = num + 1;
            int mod = num % 2;

            if (mod == 0)
            {   /* FOR X AND O BUTTON */
                R2C1.Text = "X";
                /* FOR WIN SCENARIO */
                R2C1VAL = 1;
            }
            else
            {   /* FOR X AND O BUTTON*/
                R2C1.Text = "O";
                /* FOR WIN SCENARIO*/
                R2C1VAL = 0;
            }

            /* BUTTON DISABLE */
            R2C1.Enabled = false;

            /* COMPUTER MODE*/
            first();
            algorithm();

            /* O WIN SCENARIO */

            /* HORIZOTAL */
            if (R2C1VAL == 0 & R2C2VAL == 0 & R2C3VAL == 0)
            {
                gameSatus.Text = "Player 1 Wins :)";

                /* GAME STATUS IDENTIFIER */
                win = true;

                /* SCORE FUNCTIONALITY */
                oscore = oscore + 1;
                scorePlayer1.Text = "Player O: " + oscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /* VERTICAL */
            if (R1C1VAL == 0 & R2C1VAL == 0 & R3C1VAL == 0)
            {
                gameSatus.Text = "Player 1 Wins :)";

                /* GAME STATUS IDENTIFIER */
                win = true;

                /* SCORE FUNCTIONALITY */
                oscore = oscore + 1;
                scorePlayer1.Text = "Player O: " + oscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /* X WIN SCENARIO */

            /* HORIZOTAL */
            if (R2C1VAL == 1 & R2C2VAL == 1 & R2C3VAL == 1)
            {
                gameSatus.Text = "Player 2 Wins :)";

                /* SCORE FUNCTIONALITY */
                xscore = xscore + 1;
                scorePlayer2.Text = "Player X: " + xscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /* VERTICAL */
            if (R1C1VAL == 1 & R2C1VAL == 1 & R3C1VAL == 1)
            {
                gameSatus.Text = "Player 2 Wins :)";

                /* SCORE FUNCTIONALITY */
                xscore = xscore + 1;
                scorePlayer2.Text = "Player X: " + xscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }
            /*DRAW SCENARIO*/
            else if (num > 8 & win == false)
            {
                gameSatus.Text = "Nobody Wins :(";
            }
        }

        private void R2C2_Click(object sender, EventArgs e)
        {
            /* FOR X AND O BUTTON */
            num = num + 1;
            int mod = num % 2;

            if (mod == 0)
            {   /* FOR X AND O BUTTON */
                R2C2.Text = "X";
                /* FOR WIN SCENARIO */
                R2C2VAL = 1;
            }
            else
            {   /* FOR X AND O BUTTON*/
                R2C2.Text = "O";
                /* FOR WIN SCENARIO*/
                R2C2VAL = 0;
            }

            /* BUTTON DISABLE */
            R2C2.Enabled = false;

            /* COMPUTER MODE*/
            center();
            algorithm();

            /* O WIN SCENARIO */

            /*HORIZONTAL*/
            if (R2C1VAL == 0 & R2C2VAL == 0 & R2C3VAL == 0)
            {
                gameSatus.Text = "Player 1 Wins :)";

                /* GAME STATUS IDENTIFIER */
                win = true;

                /* SCORE FUNCTIONALITY */
                oscore = oscore + 1;
                scorePlayer1.Text = "Player O: " + oscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }
                /* VERTICAL */
            if (R1C2VAL == 0 & R2C2VAL == 0 & R3C2VAL == 0)
            {
                gameSatus.Text = "Player 1 Wins :)";

                /* GAME STATUS IDENTIFIER */
                win = true;

                /* SCORE FUNCTIONALITY */
                oscore = oscore + 1;
                scorePlayer1.Text = "Player O: " + oscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

              /* DIAGONAL DESCENDING */
            
            if (R1C1VAL == 0 & R2C2VAL == 0 & R3C3VAL == 0)
            {
                gameSatus.Text = "Player 1 Wins :)";

                /* GAME STATUS IDENTIFIER */
                win = true;

                /* SCORE FUNCTIONALITY */
                oscore = oscore + 1;
                scorePlayer1.Text = "Player O: " + oscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C2.Enabled = false;
            }

             /* DIAGONAL ASCENDING */

            if (R1C3VAL == 0 & R2C2VAL == 0 & R3C1VAL == 0)
            {
                gameSatus.Text = "Player 1 Wins :)";

                /* GAME STATUS IDENTIFIER */
                win = true;

                /* SCORE FUNCTIONALITY */
                oscore = oscore + 1;
                scorePlayer1.Text = "Player O: " + oscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /* X WIN SCENARIO */

            /*HORIZONTAL*/
            if (R2C1VAL == 1 & R2C2VAL == 1 & R2C3VAL == 1)
            {
                gameSatus.Text = "Player 2 Wins :)";

                /* SCORE FUNCTIONALITY */
                xscore = xscore + 1;
                scorePlayer2.Text = "Player X: " + xscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }
            /* VERTICAL */
            if (R1C2VAL == 1 & R2C2VAL == 1 & R3C2VAL == 1)
            {
                gameSatus.Text = "Player 2 Wins :)";

                /* SCORE FUNCTIONALITY */
                xscore = xscore + 1;
                scorePlayer2.Text = "Player X: " + xscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /* DIAGONAL DESCENDING */

            if (R1C1VAL == 1 & R2C2VAL == 1 & R3C3VAL == 1)
            {
                gameSatus.Text = "Player 2 Wins :)";

                /* SCORE FUNCTIONALITY */
                xscore = xscore + 1;
                scorePlayer2.Text = "Player X: " + xscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C2.Enabled = false;
            }

            /* DIAGONAL ASCENDING */

            if (R1C3VAL == 1 & R2C2VAL == 1 & R3C1VAL == 1)
            {
                gameSatus.Text = "Player 2 Wins :)";

                /* SCORE FUNCTIONALITY */
                xscore = xscore + 1;
                scorePlayer2.Text = "Player X: " + xscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /*DRAW SCENARIO*/
            else if (num > 8 & win == false)
            {
               gameSatus.Text = "Nobody Wins :(";
                
            }
        }

        private void R2C3_Click(object sender, EventArgs e)
        {
            /* FOR X AND O BUTTON */
            num = num + 1;
            int mod = num % 2;

            if (mod == 0)
            {   /* FOR X AND O BUTTON */
                R2C3.Text = "X";
                /* FOR WIN SCENARIO */
                R2C3VAL = 1;
            }
            else
            {   /* FOR X AND O BUTTON*/
                R2C3.Text = "O";
                /* FOR WIN SCENARIO*/
                R2C3VAL = 0;
            }

            /* BUTTON DISABLE */
            R2C3.Enabled = false;

            /* COMPUTER MODE*/
            first();
            algorithm();

            /* O WIN SCENARIO */

            /* HORIZONTAL */
            if (R2C1VAL == 0 & R2C2VAL == 0 & R2C3VAL == 0)
            {
                gameSatus.Text = "Player 1 Wins :)";

                /* GAME STATUS IDENTIFIER */
                win = true;

                /* SCORE FUNCTIONALITY */
                oscore = oscore + 1;
                scorePlayer1.Text = "Player O: " + oscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }
                
                /* VERTICAL */
            if (R1C3VAL == 0 & R2C3VAL == 0 & R3C3VAL == 0)
            {
                gameSatus.Text = "Player 1 Wins :)";

                /* GAME STATUS IDENTIFIER */
                win = true;

                /* SCORE FUNCTIONALITY */
                oscore = oscore + 1;
                scorePlayer1.Text = "Player O: " + oscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /* X WIN SCENARIO */

            /* HORIZONTAL */
            if (R2C1VAL == 1 & R2C2VAL == 1 & R2C3VAL == 1)
            {
                gameSatus.Text = "Player 2 Wins :)";

                /* SCORE FUNCTIONALITY */
                xscore = xscore + 1;
                scorePlayer2.Text = "Player X: " + xscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /* VERTICAL */
            if (R1C3VAL == 1 & R2C3VAL == 1 & R3C3VAL == 1)
            {
                gameSatus.Text = "Player 2 Wins :)";

                /* SCORE FUNCTIONALITY */
                xscore = xscore + 1;
                scorePlayer2.Text = "Player X: " + xscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /*DRAW SCENARIO*/
            else if (num > 8 & win == false )
            {
                gameSatus.Text = "Nobody Wins :(";
            }
        }

        private void R3C1_Click(object sender, EventArgs e)
        {
            /* FOR X AND O BUTTON */
            num = num + 1;
            int mod = num % 2;

            if (mod == 0)
            {   /* FOR X AND O BUTTON */
                R3C1.Text = "X";
                /* FOR WIN SCENARIO */
                R3C1VAL = 1;
            }
            else
            {   /* FOR X AND O BUTTON*/
                R3C1.Text = "O";
                /* FOR WIN SCENARIO*/
                R3C1VAL = 0;
            }

            /* BUTTON DISABLE */
            R3C1.Enabled = false;

            /* COMPUTER MODE*/
            first();
            algorithm();

            /* O WIN SCENARIO */

            /* HORIZONTAL */
            if (R3C1VAL == 0 & R3C2VAL == 0 & R3C3VAL == 0)
            {
                gameSatus.Text = "Player 1 Wins :)";

                /* GAME STATUS IDENTIFIER */
                win = true;

                /* SCORE FUNCTIONALITY */
                oscore = oscore + 1;
                scorePlayer1.Text = "Player O: " + oscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

                /* VERTICAL */
            if (R1C1VAL == 0 & R2C1VAL == 0 & R3C1VAL == 0)
            {
                gameSatus.Text = "Player 1 Wins :)";

                /* GAME STATUS IDENTIFIER */
                win = true;

                /* SCORE FUNCTIONALITY */
                oscore = oscore + 1;
                scorePlayer1.Text = "Player O: " + oscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /* DIAGONAL */
            if (R1C3VAL == 0 & R2C2VAL == 0 & R3C1VAL == 0)
            {
                gameSatus.Text = "Player 1 Wins :)";

                /* GAME STATUS IDENTIFIER */
                win = true;

                /* SCORE FUNCTIONALITY */
                oscore = oscore + 1;
                scorePlayer1.Text = "Player O: " + oscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /* X WIN SCENARIO */

            /* HORIZONTAL */
            if (R3C1VAL == 1 & R3C2VAL == 1 & R3C3VAL == 1)
            {
                gameSatus.Text = "Player 2 Wins :)";

                /* SCORE FUNCTIONALITY */
                xscore = xscore + 1;
                scorePlayer2.Text = "Player X: " + xscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /* VERTICAL */
            if (R1C1VAL == 1 & R2C1VAL == 1 & R3C1VAL == 1)
            {
                gameSatus.Text = "Player 2 Wins :)";

                /* SCORE FUNCTIONALITY */
                xscore = xscore + 1;
                scorePlayer2.Text = "Player X: " + xscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /* DIAGONAL */
            if (R1C3VAL == 1 & R2C2VAL == 1 & R3C1VAL == 1)
            {
                gameSatus.Text = "Player 2 Wins :)";

                /* SCORE FUNCTIONALITY */
                xscore = xscore + 1;
                scorePlayer2.Text = "Player X: " + xscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /*DRAW SCENARIO*/
            else if (num > 8 & win == false)
            {
                gameSatus.Text = "Nobody Wins :(";
            }
        }

        private void R3C2_Click(object sender, EventArgs e)
        {
            /* FOR X AND O BUTTON */
            num = num + 1;
            int mod = num % 2;

            if (mod == 0)
            {   /* FOR X AND O BUTTON */
                R3C2.Text = "X";
                /* FOR WIN SCENARIO */
                R3C2VAL = 1;
            }
            else
            {   /* FOR X AND O BUTTON*/
                R3C2.Text = "O";
                /* FOR WIN SCENARIO*/
                R3C2VAL = 0;
            }

            /* BUTTON DISABLE */
            R3C2.Enabled = false;

            /* COMPUTER MODE*/
            first();
            algorithm();

            /* O WIN SCENARIO */

            /* HORIZONTAL */
            if (R3C1VAL == 0 & R3C2VAL == 0 & R3C3VAL == 0)
            {
                gameSatus.Text = "Player 1 Wins :)";

                /* GAME STATUS IDENTIFIER */
                win = true;

                /* SCORE FUNCTIONALITY */
                oscore = oscore + 1;
                scorePlayer1.Text = "Player O: " + oscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C3.Enabled = false;
            }

            /* VERTICAL */
            if (R1C2VAL == 0 & R2C2VAL == 0 & R3C2VAL == 0)
            {
                gameSatus.Text = "Player 1 Wins :)";

                /* GAME STATUS IDENTIFIER */
                win = true;

                /* SCORE FUNCTIONALITY */
                oscore = oscore + 1;
                scorePlayer1.Text = "Player O: " + oscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C3.Enabled = false;
            }

            /* X WIN SCENARIO */

            /* HORIZONTAL */
            if (R3C1VAL == 1 & R3C2VAL == 1 & R3C3VAL == 1)
            {
                gameSatus.Text = "Player 2 Wins :)";

                /* SCORE FUNCTIONALITY */
                xscore = xscore + 1;
                scorePlayer2.Text = "Player X: " + xscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C3.Enabled = false;
            }

            /* VERTICAL */
            if (R1C2VAL == 1 & R2C2VAL == 1 & R3C2VAL == 1)
            {
                gameSatus.Text = "Player 2 Wins :)";

                /* SCORE FUNCTIONALITY */
                xscore = xscore + 1;
                scorePlayer2.Text = "Player X: " + xscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C3.Enabled = false;
            }

            /*DRAW SCENARIO*/
            else if (num > 8 & win == false)
            {
                gameSatus.Text = "Nobody Wins :(";
            }
        }

        private void R3C3_Click(object sender, EventArgs e)
        {
            /* FOR X AND O BUTTON */
            num = num + 1;
            int mod = num % 2;

            if (mod == 0)
            {   /* FOR X AND O BUTTON */
                R3C3.Text = "X";
                /* FOR WIN SCENARIO */
                R3C3VAL = 1;
            }
            else
            {   /* FOR X AND O BUTTON*/
                R3C3.Text = "O";
                /* FOR WIN SCENARIO*/
                R3C3VAL = 0;
            }

            /* BUTTON DISABLE */
            R3C3.Enabled = false;

            /* COMPUTER MODE*/
            first();
            algorithm();

            /* O WIN SCENARIO */

            /* HORIZONTAL */
            if (R3C1VAL == 0 & R3C2VAL == 0 & R3C3VAL == 0)
            {
                gameSatus.Text = "Player 1 Wins :)";

                /* GAME STATUS IDENTIFIER */
                win = true;

                /* SCORE FUNCTIONALITY */
                oscore = oscore + 1;
                scorePlayer1.Text = "Player O: " + oscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
            }

            /* VERTICAL */
            if (R1C3VAL == 0 & R2C3VAL == 0 & R3C3VAL == 0)
            {
                gameSatus.Text = "Player 1 Wins :)";

                /* GAME STATUS IDENTIFIER */
                win = true;

                /* SCORE FUNCTIONALITY */
                oscore = oscore + 1;
                scorePlayer1.Text = "Player O: " + oscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }


            /* DIAGONAL */
            if (R1C1VAL == 0 & R2C2VAL == 0 & R3C3VAL == 0)
            {
                gameSatus.Text = "Player 1 Wins :)";

                /* GAME STATUS IDENTIFIER */
                win = true;

                /* SCORE FUNCTIONALITY */
                oscore = oscore + 1;
                scorePlayer1.Text = "Player O: " + oscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
            }

            /* X WIN SCENARIO */

            /* HORIZONTAL */
            if (R3C1VAL == 1 & R3C2VAL == 1 & R3C3VAL == 1)
            {
                gameSatus.Text = "Player 2 Wins :)";

                /* SCORE FUNCTIONALITY */
                xscore = xscore + 1;
                scorePlayer2.Text = "Player X: " + xscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
            }

            /* VERTICAL */
            if (R1C3VAL == 1 & R2C3VAL == 1 & R3C3VAL == 1)
            {
                gameSatus.Text = "Player 2 Wins :)";

                /* SCORE FUNCTIONALITY */
                xscore = xscore + 1;
                scorePlayer2.Text = "Player X: " + xscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }


            /* DIAGONAL */
            if (R1C1VAL == 1 & R2C2VAL == 1 & R3C3VAL == 1)
            {
                gameSatus.Text = "Player 2 Wins :)";

                /* SCORE FUNCTIONALITY */
                xscore = xscore + 1;
                scorePlayer2.Text = "Player X: " + xscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
            }

            /*DRAW SCENARIO*/
            else if (num > 8 & win == false)
            {
                gameSatus.Text = "Nobody Wins :(";
            }
        }

        private void resetBTN_Click(object sender, EventArgs e)
        {
            num = 0;
            mod = 0;
            win = false;

            /* ENABLE ALL BUTTONS */
            R1C1.Enabled = true;
            R1C2.Enabled = true;
            R1C3.Enabled = true;
            R2C1.Enabled = true;
            R2C2.Enabled = true;
            R2C3.Enabled = true;
            R3C1.Enabled = true;
            R3C2.Enabled = true;
            R3C3.Enabled = true;

            /* CLEAR ALL BUTTON*/
            R1C1.Text = "";
            R1C2.Text = "";
            R1C3.Text = "";
            R2C1.Text = "";
            R2C2.Text = "";
            R2C3.Text = "";
            R3C1.Text = "";
            R3C2.Text = "";
            R3C3.Text = "";

            /* RESET VALUE FOR WIN DETERMINER */
             R1C1VAL = 10;
             R1C2VAL = 10;
             R1C3VAL = 10;
             R2C1VAL = 10;
             R2C2VAL = 10;
             R2C3VAL = 10;
             R3C1VAL = 10;
             R3C2VAL = 10;
             R3C3VAL = 10;

            /* CLEAR GAME STATUS */
            gameSatus.Text = "Start Game";

            comp = false;
        }

        private void computerMode_Click(object sender, EventArgs e)
        {
            comp = true;
            gameSatus.Text = "You Go First ;)";
        }
    }
}