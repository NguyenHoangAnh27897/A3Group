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
	}

}