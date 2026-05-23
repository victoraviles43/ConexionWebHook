using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Conexion.Domain.Util

{
	
		public class SnakeCaseNamingPolicy : JsonNamingPolicy
		{
			public override string ConvertName(string name)
			{
				if (string.IsNullOrEmpty(name))
					return name;

				var builder = new StringBuilder();
				for (int i = 0; i < name.Length; i++)
				{
					if (char.IsUpper(name[i]))
					{
						if (i > 0)
							builder.Append('_');

						builder.Append(char.ToLower(name[i]));
					}
					else
					{
						builder.Append(name[i]);
					}
				}

				return builder.ToString();
			}
		}
	}

