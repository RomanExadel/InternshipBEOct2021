using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Models.Authorization
{
	public class AuthOptions
	{
		public const string Issuer = "ExadelAuthServer";

		public const string Audience = "ExadelTeam";

		public const int LifeTime = 20000;

		private const string _Key = "732a81a384ca610d4bd9d13baf3feb10";

		public static SymmetricSecurityKey GetSymmetricSecurityKey()
		{
			return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_Key));
		}
	}
}
