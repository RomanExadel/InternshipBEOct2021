﻿using DAL.Entities;
using Shared.SearchModels;
using System.Linq;

namespace BL.SearchModels
{
	public class CandidateSearchModel : OrderedSearchModel<Candidate>
	{
		public string FirstName { get; set; }

		public string LastName { get; set; }

		protected override IQueryable<Candidate> Ordering(IQueryable<Candidate> query)
		{
			switch (Predicate)
			{
				case nameof(FirstName):
					{
						return Order(query, x => x.FirstName);
					};

				case nameof(LastName):
					{
						return Order(query, x => x.LastName);
					}

				default:
					return Order(query, x => x.LastName);
			}
		}

		public override IQueryable<Candidate> Filter(IQueryable<Candidate> query)
		{
			if (!string.IsNullOrEmpty(FirstName)) query = query.Where(x => x.FirstName == FirstName);
			if (!string.IsNullOrEmpty(LastName)) query = query.Where(x => x.LastName == LastName);
			return base.Filter(query);
		}

		public SearchResult<Candidate> Find(IQueryable<Candidate> query)
		{
			var view = Filter(query);
			return new SearchResult<Candidate>
			{
				Body = Ordering(view).Skip(Skip).Take(Take),
				FullCount = query.Count(),
				Count = view.Count()
			};
		}
	}
}