using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacTok {
	class MCTSEngine {
		class TreeNode {
			public TreeNode(TreeNode parent, double prior) {
				Parent = parent;
				Visits = 0;
				Q = 0;
				U = prior;
				P = prior;
			}

			public TreeNode Parent {
				get;set;
			}

			public Dictionary<Point, TreeNode> Children {
				get;
				private set;
			} = new Dictionary<Point, TreeNode>();

			public int Visits {
				get;set;
			}

			public double Q {
				get;set;
			}

			public double U {
				get;set;
			}

			public double P {
				get;set;
			}

			public void Expand(Dictionary<Point, double> actions) {
				foreach (var pr in actions) {
					if (!Children.ContainsKey(pr.Key)) {
						Children[pr.Key] = new TreeNode(this, pr.Value);
					}
				}
			}

			public KeyValuePair<Point, TreeNode> Select() {
				return Children.Aggregate((l, r) => l.Value._GetValue() > r.Value._GetValue() ? l : r);
			}

			void _Update(double leaf_value, double c_puct) {
				Visits++;

				Q += (leaf_value - Q) / Visits;

				if (Parent != null)
					U = c_puct * P * Math.Sqrt(Parent.Visits) / (Visits + 1);
			}

			double _GetValue() {
				return Q + U;
			}

			public void Update(double leaf_value, double c_puct) {
				if (Parent != null)
					Parent.Update(leaf_value, c_puct);

				_Update(leaf_value, c_puct);
			} 
		}

		private double[,] Prior =
		{
			{ 0.5, 0.5, 0.5 },
			{ 0.5, 0.9, 0.5 },
			{ 0.5, 0.5, 0.5 }
		};

		TreeNode root = new TreeNode(null, 1.0);

		List<Point> _GetValidMove(Board board) {
			List<Point> ret = new List<Point>();

			for (int i = 0; i < 3; i++)
				for (int j = 0; j < 3; j++)
					if (!board.InvalidMove(i, j))
						ret.Add(new Point(i, j));

			return ret;
		}

		void _Playout(Board board) {
			TreeNode node = root;

			while (!board.IsEnd()) {
				if (node.Children.Count == 0) {
					var moves = _GetValidMove(board);

					if (moves.Count == 0)
						break;

					Dictionary<Point, double> actions = new Dictionary<Point, double>();

					foreach(var m in moves) {
						actions[m] = Prior[m.X, m.Y];
					}

					node.Expand(actions);
				}

				var acts = node.Select();
				board.Play(acts.Key.X, acts.Key.Y);
				node = acts.Value;

				int rollout = _Rollout(board);

				node.Update(rollout, 0.5);
			}
		}

		int _Rollout(Board board) {
			Board.State player = board.turn;

			while (!board.IsEnd()) {
				Random rand = new Random((int)DateTime.Now.Ticks);
				var moves = _GetValidMove(board);

				List<Point> pt = new List<Point>();
				double prior = double.MinValue;
				foreach (var m in moves) {
					if (Prior[m.X, m.Y] > prior) {
						pt.Clear();
						prior = Prior[m.X, m.Y];
						pt.Add(m);
					}
					else if(Prior[m.X, m.Y] == prior) {
						pt.Add(m);
					}
				}

				var move = pt[rand.Next(0, pt.Count)];

				board.Play(move.X, move.Y);
			}

			if (board.GetWinner() == Board.State.SAME) return 0;
			else if (board.GetWinner() == player) return -1;
			else return 1;
		}

		public Point GetMove(Board board) {
			for (int i = 0; i < 10000; i++) {
				Board cpy = board.Clone() as Board;

				_Playout(cpy);
			}

			return root.Children.Aggregate((l, r) => l.Value.Visits > r.Value.Visits ? l : r).Key;
		}

		public void UpdateMove(Point pt) {
			if (root.Children.ContainsKey(pt)) {
				root = root.Children[pt];
				root.Parent = null;
			}
			else {
				root = new TreeNode(null, 1.0);
			}
		}
	}
}
