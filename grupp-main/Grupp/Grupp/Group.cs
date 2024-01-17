using System;
using System.Collections.Generic;
using System.Linq;

namespace grupp
{
    public class Group
    {
        public List<Liik> Members { get; } = new List<Liik>();
        private readonly int _maxAmount;

        public Group(int maxAmount)
        {
            _maxAmount = maxAmount;
        }

        public bool AddMember(Liik member)
        {


            if (Members.Any(existingMember => existingMember.Name == member.Name)&& Members.Any(existingMember => existingMember.Age == member.Age)) return false;
            if (Members.Count >= _maxAmount) return false;
            Members.Add(member);
            return true;


        }


        public int GetMembersCount()
        {
            return Members.Count;
        }

        public bool HasMember(Liik member)
        {
            return Members.Contains(member);
        }

        public Liik GetYoungestLiik()
        {
            return Members.OrderBy(member => member.Age).First();
        }
        public Liik GetOldestLiik()
        {
            return Members.OrderBy(member => member.Age).Last();
        }
    }
}
