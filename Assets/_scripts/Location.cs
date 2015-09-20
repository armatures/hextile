using System;

namespace Application
{
	public class Location : IEquatable<Location>
	{
		public readonly int Row;
		public readonly int Col;

		public Location (int row, int col)
		{
			this.Row = row;
			this.Col = col;
		}

		public string summary ()
		{
			return String.Format ("({0}, {1})", this.Row, this.Col);
		}


		//Equals overrides from "Guidelines for Overloading Equals() and Operator == (C# Programming Guide)"
		public override bool Equals (System.Object obj)
		{
			// If parameter is null return false.
			if (obj == null) {
				return false;
			}
			
			// If parameter cannot be cast to Location return false.
			Location p = obj as Location;
			if ((System.Object)p == null) {
				return false;
			}
			
			// Return true if the fields match:
			return (Row == p.Row) && (Col == p.Col);
		}
		
		public bool Equals (Location p)
		{
			// If parameter is null return false:
			if ((object)p == null) {
				return false;
			}
			
			// Return true if the fields match:
			return (Row == p.Row) && (Col == p.Col);
		}
		
		public override int GetHashCode ()
		{
			return Row ^ Col;
		}
	}
}

