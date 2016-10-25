using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacTok {
	class Board : ICloneable {
		public enum State {
			None,
			X,
			O,

			SAME
		}

		public State[,] board = new State[3, 3];
		public State turn = State.X;

		public bool IsEnd() {
			return GetWinner() != State.None;
		}

		public State GetWinner() {
			// 가로
			if (board[0, 0] != State.None && board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0]) {
				return board[0, 0];
			}
			else if (board[0, 1] != State.None && board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1]) {
				return board[0, 1];
			}
			else if (board[0, 2] != State.None && board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2]) {
				return board[0, 2];
			}
			// 세로
			else if (board[0, 0] != State.None && board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2]) {
				return board[0, 0];
			}
			else if (board[1, 0] != State.None && board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2]) {
				return board[1, 0];
			}
			else if (board[2, 0] != State.None && board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2]) {
				return board[2, 0];
			}
			// 대각선
			else if (board[0, 0] != State.None && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2]) {
				return board[0, 0];
			}
			else if (board[2, 0] != State.None && board[2, 0] == board[1, 1] && board[1, 1] == board[0, 2]) {
				return board[2, 0];
			}
			else {
				for (int i = 0; i < 3; i++)
					for (int j = 0; j < 3; j++)
						if (board[i, j] == State.None)
							return State.None;

				return State.SAME;
			}
		}

		public void Clear() {
			for (int i = 0; i < 3; i++)
				for (int j = 0; j < 3; j++)
					board[i, j] = State.None;

			turn = State.X;
		}

		public bool InvalidMove(int x, int y) {
			return board[x, y] != State.None;
		}

		public void Play(int x, int y) {
			if (InvalidMove(x, y))
				return;

			if (turn == State.X) {
				turn = State.O;
				board[x, y] = State.X;
			}
			else if (turn == State.O) {
				turn = State.X;
				board[x, y] = State.O;
			}
		}

		public object Clone() {
			Board board = new Board();

			board.board = this.board.Clone() as Board.State[,];
			board.turn = this.turn;

			return board;
		}
	}
}
