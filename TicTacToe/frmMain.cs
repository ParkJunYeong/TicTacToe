using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacTok {
	partial class frmMain : Form {
		private Dictionary<Button, Point> boardMap = new Dictionary<Button, Point>();

		Board board = new Board();

		MCTSEngine engine = new MCTSEngine();

		public frmMain() {
			InitializeComponent();

			board.Clear();
			
			boardMap[this.btnLT] = new Point(0, 0);
			boardMap[this.btnT] = new Point(1, 0);
			boardMap[this.btnRT] = new Point(2, 0);

			boardMap[this.btnL] = new Point(0, 1);
			boardMap[this.btnM] = new Point(1, 1);
			boardMap[this.btnR] = new Point(2, 1);

			boardMap[this.btnLB] = new Point(0, 2);
			boardMap[this.btnB] = new Point(1, 2);
			boardMap[this.btnRB] = new Point(2, 2);
		}

		private void Buttons_Clicked(object sender, EventArgs e) {
			if (board.turn == Board.State.X) {
				return;
			}

			Button btn = sender as Button;

			Point pt = boardMap[btn];
			if (board.InvalidMove(pt.X, pt.Y)) {
				MessageBox.Show("올바른 착점이 아닙니다.", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			btn.Text = "O";
			btn.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));

			board.Play(pt.X, pt.Y);
			engine.UpdateMove(pt);
			
			if(board.IsEnd()) {
				if(board.GetWinner() == Board.State.O) {
					MessageBox.Show("O가 이겼습니다.", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else if(board.GetWinner() == Board.State.X) {
					MessageBox.Show("X가 이겼습니다.", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else {
					MessageBox.Show("비겼습니다.", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}

			Play();
		}

		void Play() {
			try {
				var pt = engine.GetMove(board);

				Button btn = boardMap.First((pr) => pr.Value.X == pt.X && pr.Value.Y == pt.Y).Key;

				btn.Text = "X";
				btn.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)192))));
				board.Play(pt.X, pt.Y);

				if (board.IsEnd()) {
					if (board.GetWinner() == Board.State.O) {
						MessageBox.Show("O가 이겼습니다.", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else if (board.GetWinner() == Board.State.X) {
						MessageBox.Show("X가 이겼습니다.", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else {
						MessageBox.Show("비겼습니다.", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}
			catch {
			}
		}

		private void 새로운게임NToolStripMenuItem_Click(object sender, EventArgs e) {
			board.Clear();

			foreach (var pr in boardMap) {
				pr.Key.BackColor = Color.White;
				pr.Key.Text = "";
			}

			Play();			
		}
	}
}
