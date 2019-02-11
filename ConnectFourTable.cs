/*
 * Programmer: Aaron Voymas
 * Date: 2015 May 4
 * This class allows a connect four table to be instantiated and populated with "checkers."
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFourFormApp
{
    public class ConnectFourTable
    {
        private char[,] c4Table; // An Array to hold the player pieces
        private int turn; // Stores current player's turn
        private int currentCol; // Currently selected column to place the piece
        private char playerChip; // The value of the current player's chip: R or B

        public char[,] C4Table
        {
            get
            {
                return c4Table;
            }
            set
            {
                c4Table = value;
            }
        }

        public int Turn
        {
            get
            {
                return turn;
            }
            set
            {
                turn = value;
            }
        }

        public int CurrentCol
        {
            get
            {
                return currentCol;
            }
            set
            {
                currentCol = value;
            }
        }

        public char PlayerChip
        {
            get
            {
                return playerChip;
            }
            set
            {
                playerChip = value;
            }
        }

        /* Constructor initializes a standard connect 4 table of 6 rows and 7 columns
         * and then populates the table with blank spaces. The first player's turn is
         * the argument sent into the Constructor.
        */
        public ConnectFourTable(int num)
        {
            c4Table = new char[6, 7];
            resetTable();
            turn = num;
        }

        // This method resets the table by populating the Array with blanks characters.
        public void resetTable()
        {
            for (int row = 0; row < 6; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    c4Table[row, col] = ' ';
                }
            }
        }

        // This method places a player piece in the given column, and integer.
        public void placeChecker(int col)
        {
            char checker = ' '; // Initially sets to a blank piece
            switch (turn) // Assigns the player's piece to the checker
            {
                case 0: checker = 'R';
                    break;
                case 1: checker = 'B';
                    break;
            }

            // Iterates through the column and places the piece at the lowest open spot.
            for (int row = 0; row < c4Table.GetLength(0); row++)
            {
                if (c4Table[row, col] == 'R' || c4Table[row, col] == 'B')
                {
                    if (row == 0 && col == 0) // Kicks out of the method if the column is full.
                    {
                        turn--;
                        return;
                    }
                    c4Table[(row - 1), col] = checker; // Places piece above the last piece
                    return;
                }
                else if(row == c4Table.GetLength(0) - 1)
                {
                    c4Table[row, col] = checker; // Places the piece at the bottom of the column
                    return;
                }
            }
        }

        /*
         * Check the table for a win in a single row.
        */
        public bool checkWinH()
        {
            int count = 1; // Initializes to 1 due to counting method
            char coin = ' '; // Current piece value; initially a blank
            bool win = false; // Win flag for determining if the player won

            // Iterates through the table row by row
            for (int i = 0; i < c4Table.GetLength(0); i++)
            {
                for (int j = 0; j < c4Table.GetLength(1); j++)
                {
                    if (coin != c4Table[i, j]) // Resets the counter if a different piece is found
                    {
                        coin = c4Table[i, j];
                        count = 1;
                    }
                    else
                    {
                        count++;

                        // Checks to see if the count is four if and only if it is a player piece
                        if ((coin == 'R' || coin == 'B') && count == 4)
                        {
                            win = true;
                            return win;
                        }
                        else
                        {
                            win = false;
                        }
                    }
                }
                count = 1;
            }
            // This return only occurs when four consecutive player pieces are not found
            return win; 
        }

        /*
         * This method works the same as the checkWinH method but iterates column by column
        */
        public bool checkWinV()
        {
            int count = 1;
            char coin = ' ';
            bool win = false;

            for (int i = 0; i < c4Table.GetLength(1); i++)
            {
                for (int j = 0; j < c4Table.GetLength(0); j++)
                {
                    if (coin != c4Table[j, i])
                    {
                        coin = c4Table[j, i];
                        count = 1;
                    }
                    else
                    {
                        count++;

                        if ((coin == 'R' || coin == 'B') && count == 4)
                        {
                            win = true;
                            return win;
                        }
                        else
                        {
                            win = false;
                        }
                    }
                }
                count = 1;
            }
            return win;
        }

        /*
         * This method checks the table for a player win diagonally down and to the right
        */
        public bool checkWinDR()
        {
            int count = 1;
            char coin = ' ';
            bool win = false;

            int i = 0, j = 0; // These two variables are to place holders to check diagonally

            // Check the tables starting from the top left corner
            for (int m = 0; m < c4Table.GetLength(0); m++)
            {
                for (int n = 0; n < c4Table.GetLength(1); n++)
                {
                    i = m;
                    j = n;

                    // Loops diagonally down and to the right to check for a win
                    while (i < c4Table.GetLength(0) && j < c4Table.GetLength(1))
                    {
                        if (coin != c4Table[i, j])
                        {
                            coin = c4Table[i, j];
                            count = 1;
                        }
                        else
                        {
                            count++;

                            if ((coin == 'R' || coin == 'B') && count == 4)
                            {
                                win = true;
                                return win;
                            }
                            else
                            {
                                win = false;
                            }
                        }

                        i++;
                        j++;
                    }
                }
                count = 1;
            }
            return win;
        }

        /*
         * This method works like checkWinDR but checks from the bottom left corner of the
         * table, up and to the right.
        */
        public bool checkWinUR()
        {
            int count = 1;
            char coin = ' ';
            bool win = false;

            int i = 0, j = 0;

            for (int m = c4Table.GetLength(0) - 1; m >= 0; m--)
            {
                for (int n = 0; n < c4Table.GetLength(1); n++)
                {
                    i = m;
                    j = n;

                    while (i >= 0 && j < c4Table.GetLength(0))
                    {
                        if (coin != c4Table[i, j])
                        {
                            coin = c4Table[i, j];
                            count = 1;
                        }
                        else
                        {
                            count++;

                            if ((coin == 'R' || coin == 'B') && count == 4)
                            {
                                win = true;
                                return win;
                            }
                            else
                            {
                                win = false;
                            }
                        }

                        i--;
                        j++;
                    }
                }
                count = 1;
            }
            return win;
        }
    }
}
