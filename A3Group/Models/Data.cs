using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using A3Group.Models;

namespace A3Group.Models
{

	public class HomeMaster
	{
		public IQueryable<A3Group_Sliders> sli { get; set; }
		public IQueryable<A3Group_About> abo { get; set; }
		public IQueryable<A3Group_Differences> diff { get; set; }
		public IQueryable<A3Group_Features> fea { get; set; }
		public IQueryable<A3Group_Services> ser { get; set; }
		public IQueryable<A3Group_Prices> pri { get; set; }
		public List<A3Group_Partner> part { get; set; }
        public List<A3Group_Blog> blog { get; set; }
        public A3Group_Information info { get; set; }
        public List<A3Group_Member> mem { get; set; }
        public A3Group_Team team { get; set; }
        public List<A3Group_Project> pro { get; set; }
        public A3Group_Quotes quotes { get; set; }
        public A3Group_Works work { get; set; }
        public A3Group_Contact con { get; set; }
        public List<A3Group_Customer> cus { get; set; }
    }

}