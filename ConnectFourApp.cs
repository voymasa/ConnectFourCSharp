/*
 * Programmer: Aaron Voymas
 * Date: 2015 May 7
 * This program runs a form to play Connect Four
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectFourFormApp
{
    public partial class ConnectFourApp : Form
    {
        ConnectFourTable table;

        public ConnectFourApp()
        {
            InitializeComponent();
        }

        private void ConnectFourApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Thank you for playing");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Random num = new Random();

            int player = num.Next(1, 10) % 2;
            table = new ConnectFourTable(player);

            updateTable();
            displayPlayer(table.Turn);

            setVisibility(true);
        }

        public void updateTable()
        {
            assignLabel(lbl00, table, 0, 0);
            assignLabel(lbl01, table, 0, 1);
            assignLabel(lbl02, table, 0, 2);
            assignLabel(lbl03, table, 0, 3);
            assignLabel(lbl04, table, 0, 4);
            assignLabel(lbl05, table, 0, 5);
            assignLabel(lbl06, table, 0, 6);
            assignLabel(lbl10, table, 1, 0);
            assignLabel(lbl11, table, 1, 1);
            assignLabel(lbl12, table, 1, 2);
            assignLabel(lbl13, table, 1, 3);
            assignLabel(lbl14, table, 1, 4);
            assignLabel(lbl15, table, 1, 5);
            assignLabel(lbl16, table, 1, 6);
            assignLabel(lbl20, table, 2, 0);
            assignLabel(lbl21, table, 2, 1);
            assignLabel(lbl22, table, 2, 2);
            assignLabel(lbl23, table, 2, 3);
            assignLabel(lbl24, table, 2, 4);
            assignLabel(lbl25, table, 2, 5);
            assignLabel(lbl26, table, 2, 6);
            assignLabel(lbl30, table, 3, 0);
            assignLabel(lbl31, table, 3, 1);
            assignLabel(lbl32, table, 3, 2);
            assignLabel(lbl33, table, 3, 3);
            assignLabel(lbl34, table, 3, 4);
            assignLabel(lbl35, table, 3, 5);
            assignLabel(lbl36, table, 3, 6);
            assignLabel(lbl40, table, 4, 0);
            assignLabel(lbl41, table, 4, 1);
            assignLabel(lbl42, table, 4, 2);
            assignLabel(lbl43, table, 4, 3);
            assignLabel(lbl44, table, 4, 4);
            assignLabel(lbl45, table, 4, 5);
            assignLabel(lbl46, table, 4, 6);
            assignLabel(lbl50, table, 5, 0);
            assignLabel(lbl51, table, 5, 1);
            assignLabel(lbl52, table, 5, 2);
            assignLabel(lbl53, table, 5, 3);
            assignLabel(lbl54, table, 5, 4);
            assignLabel(lbl55, table, 5, 5);
            assignLabel(lbl56, table, 5, 6);
        }

        public void assignLabel(Label label, ConnectFourTable gameTable, int x, int y)
        {
            label.BackColor = findColor(gameTable.C4Table[x, y]);
            label.ForeColor = Color.White;
            label.Text = gameTable.C4Table[x, y].ToString();
        }

        public Color findColor(char color)
        {
            Color checker = Color.White;
            switch (color)
            {
                case 'R': checker = Color.Red;
                    break;
                case 'B': checker = Color.Black;
                    break;
            }
            return checker;
        }

        public void setVisibility(bool visible)
        {
            btnPlace.Visible = visible;
            btnReset.Visible = visible;
            btnStart.Visible = !visible;
            lblPlayer.Visible = visible;
            txtBxPlayer.Visible = visible;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            table.resetTable();
            setVisibility(false);
            updateTable();
        }

        private void btnPlace_Click(object sender, EventArgs e)
        {
            int cTurn = table.Turn;
            int colNum;
            if (int.TryParse(txtBxColNum.Text, out colNum) == false ||
                int.Parse(txtBxColNum.Text) < 1 || int.Parse(txtBxColNum.Text) > 7)
            {
                txtBxColNum.Focus();
                txtBxColNum.Clear();
            }
            else
                table.CurrentCol = int.Parse(txtBxColNum.Text) - 1;
            
            table.placeChecker(table.CurrentCol);
            updateTable();
            
			if (table.CheckForWinRight())
            {
                MessageBox.Show(txtBxPlayer.Text + " has won!");
                table.resetTable();
                setVisibility(false);
                updateTable();
            }
			else if (table.CheckForWinDown())
            {
                MessageBox.Show(txtBxPlayer.Text + " has won!");
                table.resetTable();
                setVisibility(false);
                updateTable();
            }
			else if (table.CheckForWinDownRight())
            {
                MessageBox.Show(txtBxPlayer.Text + " has won!");
                table.resetTable();
                setVisibility(false);
                updateTable();
            }
			else if (table.CheckForWinUpRight())
            {
                MessageBox.Show(txtBxPlayer.Text + " has won!");
                table.resetTable();
                setVisibility(false);
                updateTable();
            }

            table.Turn = ++table.Turn % 2;
            displayPlayer(cTurn);
            if (cTurn == table.Turn)
                MessageBox.Show("Invalid move. Try again!");
        }

        public void displayPlayer(int pTurn)
        {
            if (pTurn == 0)
                txtBxPlayer.Text = "Player 1";
            else if (pTurn == 1)
                txtBxPlayer.Text = "Player 2";
        }

        private void rdBtnCol1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rdBtnCol2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rdBtnCol3_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rdBtnCol4_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rdBtnCol5_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rdBtnCol6_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rdBtnCol7_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rdBtnCol1_Click(object sender, EventArgs e)
        {
        }

        private void rdBtnCol2_Click(object sender, EventArgs e)
        {
        }

        private void rdBtnCol3_Click(object sender, EventArgs e)
        {
        }

        private void rdBtnCol4_Click(object sender, EventArgs e)
        {
        }

        private void rdBtnCol5_Click(object sender, EventArgs e)
        {
        }

        private void rdBtnCol6_Click(object sender, EventArgs e)
        {
        }

        private void rdBtnCol7_Click(object sender, EventArgs e)
        {
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programmer: Aaron Voymas\ncirca May 2015\n\nThe" +
                            "goal of this game is to place four\nconsecutive pieces in a" +
                            "row, column, or diagonal.");
        }
    }
}
